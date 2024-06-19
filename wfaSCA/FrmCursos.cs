using Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace wfaSCA
{
    public partial class FrmCursos : Form
    {
        public FrmCursos()
        {
            InitializeComponent();
        }

        private void FrmCursos_Load(object sender, EventArgs e)
        {
            LoadCursos();
            LoadSiglaDepto();
            ConfigCursos();
        }

        #region Métodos
        private enum Sts
        {
            OK,
            ERROR
        }
        private void LoadCursos()
        {
            CamadaNegocios cn = new CamadaNegocios();
            dgvCur.DataSource = cn.ObtemCrusos().Tables[0];
        }

        private void ConfigCursos()
        {
            dgvCur.Columns["cur_nom"].Width = 300;
            dgvCur.Columns["cur_sgl"].HeaderText = "Sigla";
            dgvCur.Columns["cur_nom"].HeaderText = "Nome";
            dgvCur.Columns["cur_dep_sgl"].HeaderText = "Depto";
        }

        private void LoadSiglaDepto()
        {
            CamadaNegocios cn = new CamadaNegocios();
            DataSet depto = cn.ObtemDeptos();
            DataTable tb = depto.Tables[0];
            
            for(int i = 0; i < tb.Rows.Count; i++)
            {
                cmbCurSglDepto.Items.Add(tb.Rows[i][0].ToString()) ;
            }
        }

        private void Status(string msg, Sts status)
        {
            STSlblCurStatus.Text = msg;
            switch (status)
            {
                case Sts.OK:
                    STSlblCurStatus.ForeColor = Color.Green;
                    break;
                case Sts.ERROR:
                    STSlblCurStatus.ForeColor = Color.Red;
                    break;
                default:
                    STSlblCurStatus.ForeColor = Color.Black;
                    break;
            }
        }

        private void CleanFields()
        {
            txtCurNome.Text = "";
            txtCurSigla.Text = "";
            cmbCurSglDepto.SelectedIndex = -1;
        }

        private void CleanSetError()
        {
            EPCursos.SetError(txtCurNome, "");
            EPCursos.SetError(txtCurSigla, "");
            EPCursos.SetError(cmbCurSglDepto, "");
        }
        #endregion

        #region ToolStripButtons
        private void TSbCurAdd_Click(object sender, EventArgs e)
        {
            CamadaNegocios cn = new CamadaNegocios();
            Curso curso;
            CleanSetError();
            try
            {
                curso = new Curso(txtCurNome.Text, txtCurSigla.Text, cmbCurSglDepto.Text);
                cn.AddCurso(curso);
                Status("Curso adicionado", Sts.OK);

                CleanFields();
                LoadCursos();
            }
            catch (InvalidSiglaException err)
            {
                EPCursos.SetError(txtCurSigla, err.Message);
            }
            catch (InvalidNameException err)
            {
                EPCursos.SetError(txtCurNome, err.Message);
            }
            catch (ArgumentException err)
            {
                EPCursos.SetError(cmbCurSglDepto, err.Message);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cadastro de Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status("Curso não pode ser adicionado", Sts.ERROR);
            }
        }

        private void TSbCurUpdate_Click(object sender, EventArgs e)
        {
            CamadaNegocios cn = new CamadaNegocios();
            Curso curso;
            CleanSetError();
            try
            {
                curso = new Curso(txtCurNome.Text, txtCurSigla.Text, cmbCurSglDepto.Text);

                cn.UpdateCurso(curso);
                Status("Curso atualizado", Sts.OK);

                CleanFields();
                LoadCursos();
            }
            catch (InvalidSiglaException err)
            {
                EPCursos.SetError(txtCurSigla, err.Message);
            }
            catch (InvalidNameException err)
            {
                EPCursos.SetError(txtCurNome, err.Message);
            }
            catch (ArgumentException)
            {
                EPCursos.SetError(cmbCurSglDepto, "Selecione um departamento");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cadastro de Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status("Curso não pode ser atualizado", Sts.ERROR);
            }
        }

        private void TSbCurDelete_Click(object sender, EventArgs e)
        {
            CamadaNegocios cn = new CamadaNegocios();
            Curso curso;
            CleanSetError();
            try
            {
                curso = new Curso(txtCurNome.Text, txtCurSigla.Text, cmbCurSglDepto.Text);
                var answer = MessageBox.Show($"Confirmar exclusão do curso {curso.Nome}?", "Cadastro de Cursos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    cn.DeleteCurso(curso);
                    LoadCursos();
                    CleanFields();
                    Status("Curso excluído", Sts.OK);
                }
            }
            catch (InvalidNameException err)
            {
                EPCursos.SetError(txtCurNome, err.Message);
            }
            catch (InvalidSiglaException err)
            {
                EPCursos.SetError(txtCurSigla, err.Message);
            }
            catch (ArgumentException err)
            {
                EPCursos.SetError(cmbCurSglDepto, err.Message);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cadastro de Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status("Curso não pode ser excluído", Sts.ERROR);
            }
        }

        private void TSbCurLimpar_Click(object sender, EventArgs e)
        {
            CleanFields();
            txtCurNome.Focus();
        }

        #endregion

        #region DataGridView
        private void dgvCur_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCurNome.Text = dgvCur.CurrentRow.Cells["cur_nom"].Value.ToString();
            txtCurSigla.Text = dgvCur.CurrentRow.Cells["cur_sgl"].Value.ToString();
            string depto_sgl = dgvCur.CurrentRow.Cells["cur_dep_sgl"].Value.ToString();
            cmbCurSglDepto.SelectedIndex = cmbCurSglDepto.Items.IndexOf(depto_sgl);
        }
        #endregion

        #region Fields Txt
        private void txtCurSigla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Valida.CheckChar(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            else
            {
                e.KeyChar = (char)0;
            }
        }
        #endregion

        #region Btn Pesquisar
        private void btnCurPesq_Click(object sender, EventArgs e)
        {
            CamadaNegocios cn = new CamadaNegocios();

            try
            {
                if (txtCurNome.Text != "")
                {
                    dgvCur.DataSource = cn.ObtemCursoPorNome(txtCurNome.Text).Tables[0];
                }
                else
                {
                    LoadCursos();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cadastro de Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
