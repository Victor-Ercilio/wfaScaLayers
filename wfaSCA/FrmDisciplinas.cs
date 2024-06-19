using Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSCA
{
    public partial class FrmDisciplinas : Form
    {
        private List<int> Codigos = new List<int>();
        private Disciplina old;
        public FrmDisciplinas()
        {
            InitializeComponent();
        }
        private void FrmDisciplinas_Load(object sender, EventArgs e)
        {
            loadDGV();
            configDGV();
            loadSiglaCurso();
            loadCodigos();
        }

        private enum Sts
        {
            OK,
            ERROR,
            INFO
        }

        #region Métodos
        private void loadDGV()
        {
            CamadaNegocios cn = new CamadaNegocios();
            dgvDisciplina.DataSource = cn.ObtemDisciplinas();
        }

        private void configDGV()
        {
            dgvDisciplina.Columns["dis_cod"].HeaderText = "Código";
            dgvDisciplina.Columns["dis_sgl"].HeaderText = "Sigla";
            dgvDisciplina.Columns["dis_nom"].HeaderText = "Nome";
            dgvDisciplina.Columns["dis_crg_hor"].HeaderText = "Carga horária";
            dgvDisciplina.Columns["dis_cur_sgl"].HeaderText = "Curso";
            
            dgvDisciplina.Columns["dis_cod"].Width = 60;
            dgvDisciplina.Columns["dis_sgl"].Width = 70;
            dgvDisciplina.Columns["dis_nom"].Width = 300;
            dgvDisciplina.Columns["dis_crg_hor"].Width = 60;
            dgvDisciplina.Columns["dis_cur_sgl"].Width = 70;
        }

        private void loadSiglaCurso()
        {
            CamadaNegocios cn = new CamadaNegocios();
            DataTable dt = cn.ObtemCrusos().Tables[0];
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                cmbConsCurso.Items.Add(dt.Rows[i][0].ToString());
                cmbCadCurso.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void loadCodigos()
        {
            CamadaNegocios cn = new CamadaNegocios();
            DataTable dt = cn.ObtemDisciplinas();
            Codigos.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Codigos.Add(Convert.ToInt32(dt.Rows[i][0].ToString()));
            }
        }

        private string getIntervalCodigos()
        {
            StringBuilder cods = new StringBuilder();

            if(Codigos.Count > 0)
                cods.Append($"{Codigos[0]}");

            for (int i = 1, last = Codigos[0], count = 0; i < Codigos.Count; i++)
            {
                bool TemCodigo = (i + 1) != Codigos.Count;
                bool DifValorUm = (Codigos[i] - last) == 1;
                if (DifValorUm)
                {
                    count++;
                }
                if( !DifValorUm || !TemCodigo)
                {
                    if(count > 1)
                    {
                        cods.Append(" - ");
                        if(TemCodigo || (!DifValorUm && !TemCodigo))
                            cods.Append($"{last}, ");
                    }
                    else if(count == 1)
                    {
                        if (TemCodigo)
                            cods.Append($", {last}, ");
                        else
                            cods.Append(", ");
                    }
                    else if(count == 0 || !TemCodigo)
                    {
                        cods.Append(", ");
                    }
                    count = 0;
                    cods.Append($"{Codigos[i]}");
                }

                last = Codigos[i];
            }
            return cods.ToString();
        }

        private bool checkCodigo(int codigo)
        {
            if(Codigos.Contains(codigo))
                return true;
            return false;
        }

        private void cleanSetError()
        {
            EPDiscp.SetError(numCadCod, "");
            EPDiscp.SetError(cmbCadCurso, "");
            EPDiscp.SetError(txtCadNome, "");
            EPDiscp.SetError(numCrgaHr, "");
            EPDiscp.SetError(txtCadSigla, "");
        }

        private void setStatus(string msg, Sts status)
        {
            switch(status)
            {
                case Sts.OK:
                    STSDiscpStatus.Text = msg;
                    STSDiscpStatus.ForeColor = Color.Green;
                    break;
                case Sts.ERROR:
                    STSDiscpStatus.Text = msg;
                    STSDiscpStatus.ForeColor = Color.Red;
                    break;
                case Sts.INFO:
                    STSDiscpStatus.Text = msg;
                    STSDiscpStatus.ForeColor = Color.Black;
                    break;
            }
        }

        #endregion

        #region ToolStrip 
        private void TSbtnAdd_Click(object sender, EventArgs e)
        {
            CamadaNegocios cn = new CamadaNegocios();
            if (checkCodigo(Convert.ToInt32(numCadCod.Value)))
            {
                setStatus($"Código {numCadCod.Value}: já cadastrado!", Sts.ERROR);
                EPDiscp.SetError(numCadCod, $"Código já cadastrado. Em uso: {getIntervalCodigos()}");
                return;
            }
            try
            {
                int index = cmbCadCurso.SelectedIndex;
                setStatus("Adicionando disciplina...", Sts.INFO);
                Disciplina dis = new Disciplina(Convert.ToInt32(numCadCod.Value), txtCadNome.Text, txtCadSigla.Text, Convert.ToInt32(numCrgaHr.Value), cmbCadCurso.Items[index].ToString());
                cn.AddDisciplina(dis);

                setStatus($"Disiplina {txtCadNome.Text} cadastrado", Sts.OK);
                loadDGV();
                loadCodigos();
            }
            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setStatus($"Disiplina já cadastrada", Sts.ERROR);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Cadastro Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setStatus($"Disiplina não cadastrada", Sts.ERROR);
            }
        }

        private void TSbtnUpdate_Click(object sender, EventArgs e)
        {
            CamadaNegocios cn = new CamadaNegocios();
            try
            {
                int index = cmbCadCurso.SelectedIndex;
                Disciplina dis = new Disciplina(Convert.ToInt32(numCadCod.Value), txtCadNome.Text, txtCadSigla.Text, Convert.ToInt32(numCrgaHr.Value), cmbCadCurso.Items[index].ToString());
                setStatus($"Atualizando disiciplina: {dis.Nome}...", Sts.INFO);
                cn.UpdateDisciplina(dis, old);

                setStatus($"Atualização realizada.", Sts.OK);
                loadDGV();
                loadCodigos();
            }
            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setStatus("Atualização não realizada", Sts.ERROR);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cadastro Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Error);
                setStatus("Atualização não realizada", Sts.ERROR);
            }
        }

        private void TSbtnClear_Click(object sender, EventArgs e)
        {
            txtCadNome.Text = "";
            txtCadSigla.Text = "";
            cmbCadCurso.SelectedIndex = -1;
            numCadCod.Value = 1;
            numCrgaHr.Value = 1;
            cleanSetError();
            setStatus("Limpeza realizada", Sts.INFO);
        }

        private void TSbtnDelete_Click(object sender, EventArgs e)
        {
            CamadaNegocios cn = new CamadaNegocios();
            try
            {
                Disciplina dis = new Disciplina(Convert.ToInt32(numCadCod.Value), txtCadNome.Text, txtCadSigla.Text, Convert.ToInt32(numCrgaHr.Value), cmbCadCurso.SelectedText);
                if (MessageBox.Show($"Deseja excluir {dis.Nome}?", "Excluir disciplina", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    setStatus($"Excluindo disciplina: Cod({dis.Codigo}) {dis.Nome}...", Sts.INFO);
                    cn.DeleteDisciplina(dis);
                    setStatus($"Exclusão realizada: Cod({dis.Codigo}) {dis.Nome}...", Sts.OK);
                    loadDGV();
                    loadCodigos();
                }
                else
                    setStatus($"Exclusão cancelada.", Sts.INFO);

            }
            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cadastro Disciplina", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region TabControl

        #region Aba Consulta
        private void btnPesq_Click(object sender, EventArgs e)
        {
            CamadaNegocios cn = new CamadaNegocios();
            int index = cmbConsCurso.SelectedIndex;
            string nomeCurso = (index >= 0) ? cmbConsCurso.Items[index].ToString() : "";
            Disciplina dis = new Disciplina(Convert.ToInt32(numConsCod.Value), nome: txtConsNome.Text, curso: nomeCurso);
            dgvDisciplina.DataSource = cn.ObtemDisciplina(dis);
        }
        private void dgvDisciplina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDisciplina.CurrentRow;

            // Passando os dados da linha clicada para os campos de cadastro
            txtCadNome.Text = row.Cells["dis_nom"].Value.ToString();
            txtCadSigla.Text = row.Cells["dis_sgl"].Value.ToString();
            int.TryParse(row.Cells["dis_cod"].Value.ToString(), out int codigo);
            int.TryParse(row.Cells["dis_crg_hor"].Value.ToString(), out int carga);
            numCadCod.Value = codigo;
            numCrgaHr.Value = carga;
            cmbCadCurso.SelectedIndex = cmbCadCurso.Items.IndexOf(row.Cells["dis_cur_sgl"].Value.ToString());

            // Guardando dados para possível atualização
            old = new Disciplina(codigo, txtCadNome.Text, txtCadSigla.Text, carga, cmbCadCurso.SelectedItem.ToString());

            // Mudando para aba cadastro
            tbcDiscp.SelectedIndex = 0;
        }

        #region Validando
        private void cmbConsCurso_Validating(object sender, CancelEventArgs e)
        {
            if(cmbConsCurso.SelectedIndex == -1 && !Valida.Sigla(cmbConsCurso.Text, 10, 0))
            {
                e.Cancel = true;
                EPDiscp.SetError(cmbConsCurso, "Selecione um dos cursos");
            }
        }

        private void txtConsNome_Validating(object sender, CancelEventArgs e)
        {
            if ( !Valida.Nome(txtConsNome.Text, 70, 0))
            {
                e.Cancel = true;
                EPDiscp.SetError(txtConsNome, "Digite apenas letras, espaços e pontuações");
            }
        }
        private void numConsCod_Validating(object sender, CancelEventArgs e)
        {
            if (numConsCod.Value != 0  && numConsCod.Value < 1)
            {
                numConsCod.Value = 0;
            }
        }

        #endregion

        #region Valido
        private void cmbConsCurso_Validated(object sender, EventArgs e)
        {
            EPDiscp.SetError(cmbConsCurso, "");
        }

        private void txtConsNome_Validated(object sender, EventArgs e)
        {
            EPDiscp.SetError(txtConsNome, "");
        }

        #endregion

        #endregion

        #region Aba Cadastro
        private void txtCadSigla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Valida.CheckChar(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            else
            {
                e.KeyChar = (char)0;
            }
        }

        #region Validando
        private void txtCadNome_Validating(object sender, CancelEventArgs e)
        {
            if ( !Valida.Nome(txtCadNome.Text, 70))
            {
                EPDiscp.SetError(txtCadNome, "Nome obrigatório. Máximo 70 caracteres.");
                e.Cancel = true;
            }
        }

        private void numCadCod_Validating(object sender, CancelEventArgs e)
        {
            int codigo = Convert.ToInt32(numCadCod.Value);
            if (codigo <= 0)
            {
                
                e.Cancel = true;
            }
            else if(codigo <= 0)
            {
                EPDiscp.SetError(numCadCod, "Código é obrigatório");
                e.Cancel = true;
            }
        }

        private void cmbCadCurso_Validating(object sender, CancelEventArgs e)
        {
            if(cmbCadCurso.SelectedIndex == -1)
            {
                EPDiscp.SetError(cmbCadCurso, "Selecione um curso");
                e.Cancel = true;
            }
        }

        private void txtCadSigla_Validating(object sender, CancelEventArgs e)
        {
            if(!Valida.Sigla(txtCadSigla.Text, 10))
            {
                EPDiscp.SetError(txtCadSigla, "Apenas letras, máximo 10.");
                e.Cancel = true;
            }
        }

        private void numCrgaHr_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(numCrgaHr.Value) <= 0)
            {
                EPDiscp.SetError(numCrgaHr, "Carga horária é obrigatória");
                e.Cancel = true;
            }
        }

        #endregion

        #region Valido
        private void txtCadNome_Validated(object sender, EventArgs e)
        {
            EPDiscp.SetError(txtCadNome, "");
        }

        private void numCadCod_Validated(object sender, EventArgs e)
        {
            EPDiscp.SetError(numCadCod, "");
        }

        private void cmbCadCurso_Validated(object sender, EventArgs e)
        {
            EPDiscp.SetError(cmbCadCurso, "");
        }

        private void txtCadSigla_Validated(object sender, EventArgs e)
        {
            EPDiscp.SetError(txtCadSigla, "");
        }

        private void numCrgaHr_Validated(object sender, EventArgs e)
        {
            EPDiscp.SetError(numCrgaHr, "");
        }

        #endregion

        #endregion

        private void tbcDiscp_Selected(object sender, TabControlEventArgs e)
        {
            if(e.TabPageIndex == 0)
            {
                TSbtnAdd.Enabled = true;
                TSbtnClear.Enabled = true;
                TSbtnDelete.Enabled = true;
                TSbtnUpdate.Enabled = true;
            }
            else if(e.TabPageIndex == 1)
            {
                TSbtnAdd.Enabled = false;
                TSbtnClear.Enabled = false;
                TSbtnDelete.Enabled = false;
                TSbtnUpdate.Enabled = false;
            }
        }


        #endregion

    }
}
