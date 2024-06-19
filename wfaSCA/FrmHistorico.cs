using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bll;
using System.Data.OleDb;

namespace wfaSCA
{
    public partial class FrmHistorico : Form
    {
        private CamadaNegocios cn = new CamadaNegocios();
        StatusLabel Status;

        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            Status = new StatusLabel(STSlblStatus);
            LoadCmbCursos();
            LoadCmbDisciplina();
            LoadCmbMatricula();
            LoadDGV();
            //ConfigDGV();
        }

        #region Métodos
        private void LoadCmbCursos()
        {
            try
            {
                DataTable dt = cn.ObtemCursoComAlunos();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbCurso.Items.Add(dt.Rows[i]["cur_sgl"].ToString());
                }
            }
            catch(OleDbException err) 
            {
                MessageBox.Show($"Não foi possível carregar os cursos: {err.Message}", "Historico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception err)
            {
                MessageBox.Show($"Erro: {err.Message}", "Historico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCmbDisciplina()
        {
            try
            {
                DataTable dt = cn.ObtemDisciplinasComAlunos();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbDiscpCod.Items.Add(dt.Rows[i]["dis_sgl"].ToString());
                }
            }
            catch (OleDbException err)
            {
                MessageBox.Show($"Não foi possível carregar as disciplinas: {err.Message}", "Historico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Erro: {err.Message}", "Historico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCmbMatricula()
        {
            try
            {
                DataTable dt = cn.ObtemMatriculaDosAlunos();
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbMatr.Items.Add(dt.Rows[i]["mat_alu_cod"].ToString());
                }
            }
            catch (OleDbException err)
            {
                MessageBox.Show($"Não foi possível carregar as matriculas: {err.Message}", "Historico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Erro: {err.Message}", "Historico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDGV()
        {
            try
            {
                dgvHist.DataSource = cn.obtemHistorico();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Histórico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Histórico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigDGV()
        {
            dgvHist.Columns["Matricula"].Width = 70;
            dgvHist.Columns["Curso"].Width = 60;
            dgvHist.Columns["Disciplina"].Width = 70;
            dgvHist.Columns["P1"].Width = 50;
            dgvHist.Columns["P2"].Width = 50;
            dgvHist.Columns["Trab"].Width = 50;
            dgvHist.Columns["Média"].Width = 50;
            dgvHist.Columns["Conceito"].Width = 50;
            dgvHist.Columns["Faltas"].Width = 40;
            dgvHist.Columns["Nome"].Width = 180;
        }
        #endregion

        #region Evento KeyPress
        private void txtAluNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Valida.CheckChar(e.KeyChar, digit: false))
            {
                e.KeyChar = (char)0;
            }
        }

        private void txtDiscpNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Valida.CheckChar(e.KeyChar, digit: false))
            {
                e.KeyChar = (char)0;
            }
        }
        #endregion

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Status.Set("Realizando pesquisa...", StatusType.INFO);
                string aluno = txtAluNome.Text.Trim();
                string disciplina_sgl = (cmbDiscpCod.SelectedIndex == -1) ? "" : cmbDiscpCod.SelectedItem.ToString();
                string disciplina_nom = txtDiscpNome.Text.Trim();
                string mat = (cmbMatr.SelectedIndex == -1) ? "" : cmbMatr.SelectedItem.ToString().Trim();
                string curso = (cmbCurso.SelectedIndex == -1) ? "" : cmbCurso.SelectedItem.ToString().Trim();
                dgvHist.DataSource = cn.obtemHistorico(aluno, disciplina_nom, disciplina_sgl, curso, mat);
                Status.Set("Pesquisa realizada!", StatusType.OK);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Histórico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Histórico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            cmbCurso.SelectedIndex = -1;
            cmbDiscpCod.SelectedIndex = -1;
            cmbMatr.SelectedIndex = -1;
            txtAluNome.Text = "";
            txtDiscpNome.Text = "";
            txtAluNome.Focus();
            Status.Set("Tudo pronto", StatusType.INFO);
        }

        private void cmbDiscpCod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbDiscpCod.SelectedIndex != -1)
            {
                txtDiscpNome.Text = cn.ObtemNomeDisciplina(sigla: cmbDiscpCod.SelectedItem.ToString());
            }
        }
    }
}
