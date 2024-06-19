using Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSCA
{
    public partial class FrmConceito : Form
    {
        private StatusLabel Status;
        private DataTable Cursos;
        private DataTable DisciplDisp;
        private DataTable Discipl;
        private DataTable Matricl;
        private CamadaNegocios cn = new CamadaNegocios();
        public FrmConceito()
        {
            InitializeComponent();
        }
        private void FrmConceito_Load(object sender, EventArgs e)
        {
            LoadDgv();
            LoadCursos();
            Status = new StatusLabel(STSlblStatus);
        }

        #region Métodos

        private void LoadCursos()
        {
            try
            {
                Cursos = cn.ObtemCursoComAlunos();
                cmbCurso.Items.Clear();
                for (int i = 0; i < Cursos.Rows.Count; i++)
                {
                    if(!cmbCurso.Items.Contains(Cursos.Rows[i]["cur_sgl"].ToString()))
                        cmbCurso.Items.Add(Cursos.Rows[i]["cur_sgl"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cursos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMatrDoCurso(string curso)
        {
            try
            {
                Matricl = cn.ObtemAlunosDoCurso(curso);
                cmbMatr.Items.Clear();
                for (int i = 0; i < Matricl.Rows.Count; i++)
                {
                    cmbMatr.Items.Add(Matricl.Rows[i]["Matricula"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Matriculas do Curso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDisciplinas(string curso)
        {
            try
            {
                Discipl = cn.ObtemDisciplinasPorCurso(curso);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Matriculas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double? ConvertDouble(string valor)
        {
            if (valor == "")
            {
                return null;
            }
            else if (double.TryParse(valor, out double v))
            {
                return v;
            }
            else
            {
                return null;
            }
        }

        private char? ConvertChar(string valor)
        {
            if (valor == "")
            {
                return null;
            }
            else if (Char.TryParse(valor, out char v))
            {
                return v;
            }
            else
            {
                return null;
            }
        }

        private void LoadDisciplinasDisponiveis(string matricula)
        {
            try
            {
                DisciplDisp = cn.ObtemDisciplinasPorAluno(matricula);
                cmbDiscSigla.Items.Clear();
          
                for (int i = 0; i < DisciplDisp.Rows.Count; i++)
                {
                    if (DisciplDisp.Rows[i]["Matricula"].ToString() == matricula)
                    {
                        if (!cmbDiscSigla.Items.Contains(DisciplDisp.Rows[i]["Disciplina_Sigla"].ToString()))
                            cmbDiscSigla.Items.Add(DisciplDisp.Rows[i]["Disciplina_Sigla"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Matriculas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDgv()
        {
            try
            {
                dgvNotas.DataSource = cn.ObtemMatriculas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Matriculas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int IndexOfDisciplina(string sigla, bool cod = false)
        {
            if (Discipl != null)
            {
                if (!cod)
                {
                    for (int i = 0; i < Discipl.Rows.Count; i++)
                    {
                        if (Discipl.Rows[i]["Disciplina_Sigla"].ToString() == sigla)
                        {
                            return i;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < Discipl.Rows.Count; i++)
                    {
                        if (Discipl.Rows[i]["Disciplina_Cod"].ToString() == sigla)
                        {
                            return i;
                        }
                    }
                }
            }
            return 0;
        }

        private void CalcMedia()
        {
            bool temP1 = double.TryParse(txtP1.Text, out double p1);
            bool temP2 = double.TryParse(txtP2.Text, out double p2);
            bool temTrb = double.TryParse(txtMedTrab.Text, out double tb);
            if ( temP1 || temP2 || temTrb)
            {
                double media = Matricula.CalcMedia(p1, p2, tb);
                txtMedia.Text = media.ToString();
            }
        }

        private void EnableCamposNotas(bool value)
        {
            txtP1.Enabled = value;
            txtP2.Enabled = value;
            txtMedTrab.Enabled = value;
        }

        private void ObterAnoSem(out int ano, out int sem)
        {
            if(cmbAnoSem.SelectedIndex != -1)
            {
                string[] anosem = cmbAnoSem.SelectedItem.ToString().Split('/');
                ano = int.Parse(anosem[0]);
                sem = int.Parse(anosem[1]);
            }
            else
            {
                ano = 0;
                sem = 0;
            }
        }

        private void ResetNotas()
        {
            txtP1.Text = "";
            txtP2.Text = "";
            txtMedTrab.Text = "";
            txtMedia.Text = "";
            txtConc.Text = "";

            EnableCamposNotas(false);
        }
        private void ResetMatriculas()
        {
            cmbMatr.Items.Clear();
            cmbMatr.SelectedIndex = -1;
            cmbMatr.Text = "";
            txtMatr.Text = "";
            cmbMatr.Enabled = false;
        }
        private void ResetDisciplinas()
        {
            cmbDiscSigla.Items.Clear();
            cmbDiscSigla.SelectedIndex = -1;
            cmbDiscSigla.Text = "";
            txtDisc.Text = "";
            cmbDiscSigla.Enabled = false;
        }
        private void ResetAnoSemestre()
        {
            cmbAnoSem.Items.Clear();
            cmbAnoSem.SelectedIndex = -1;
            cmbAnoSem.Text = "";
            cmbAnoSem.Enabled = false;
        }
        private void ResetFaltas()
        {
            nroFaltas.Value = 0;
            nroFaltas.Enabled = false;
        }

        private bool IsNotAllSelected()
        {
            return (cmbCurso.SelectedIndex == -1 ||
                    cmbMatr.SelectedIndex == -1 ||
                    cmbDiscSigla.SelectedIndex == -1 ||
                    cmbAnoSem.SelectedIndex == -1);
        }
        #endregion

        #region ToolStrip
        private void TSbtnAdd_Click(object sender, EventArgs e)
        {
            if (IsNotAllSelected())
            {
                Status.Set("Faltam campos a serem selecionados", StatusType.INFO);
                return;
            }
            try
            {
                Matricula mat;
                
                int index = IndexOfDisciplina(cmbDiscSigla.SelectedItem.ToString(), true);
                ObterAnoSem(out int ano, out int sem);

                mat = new Matricula(ano, sem, cmbMatr.SelectedItem.ToString(), index, 
                    ConvertDouble(txtP1.Text), ConvertDouble(txtP2.Text), ConvertDouble(txtMedTrab.Text),
                    ConvertDouble(txtMedia.Text), ConvertChar(txtConc.Text), (int)nroFaltas.Value);
                Status.Set("Adicionando notas...", StatusType.INFO);
                cn.UpdateMatricula(mat);
                LoadDgv();
                Status.Set("Notas adicionadas com sucesso", StatusType.OK);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Não foi possível adicionar as notas" + ex.Message, "Cadastro de notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Cadastro de notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TSbtnUpdate_Click(object sender, EventArgs e)
        {
            if (IsNotAllSelected())
            {
                Status.Set("Faltam campos a serem selecionados", StatusType.INFO);
                return;
            }
            try
            {
                Matricula mat;

                ObterAnoSem(out int ano, out int sem);
                int index = cn.ObtemCodDisciplina(ano, sem, cmbMatr.SelectedItem.ToString(), cmbDiscSigla.SelectedItem.ToString());

                mat = new Matricula(ano, sem, cmbMatr.SelectedItem.ToString(), index,
                    ConvertDouble(txtP1.Text), ConvertDouble(txtP2.Text), ConvertDouble(txtMedTrab.Text),
                    ConvertDouble(txtMedia.Text), ConvertChar(txtConc.Text), (int)nroFaltas.Value) ;
                Status.Set("Atualizando notas...", StatusType.INFO);
                cn.UpdateMatricula(mat);
                LoadDgv();
                Status.Set("Notas atualizadas com sucesso", StatusType.OK);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Não foi possível excluir as notas" + ex.Message, "Cadastro de notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Cadastro de notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TSbtnLimpar_Click(object sender, EventArgs e)
        {
            if(TCNotas.SelectedIndex == 0)
            {
                cmbCurso.SelectedIndex = -1;
                txtCurso.Text = "";

                ResetMatriculas();
                ResetDisciplinas();
                ResetAnoSemestre();
                ResetFaltas();
                ResetNotas();
            }
            else
            {
                txtConsMatr.Text = "";
            }
            Status.Set("Limpeza realizada", StatusType.INFO);
        }

        private void TSbtnDelete_Click(object sender, EventArgs e)
        {
            if (IsNotAllSelected())
            {
                Status.Set("Faltam campos a serem selecionados", StatusType.INFO);
                return;
            }
            try
            {
                Matricula mat;
                if (MessageBox.Show("Confirmar exclusão das notas?", "Cadastro de Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ObterAnoSem(out int ano, out int sem);
                    int dis_cod = cn.ObtemCodigoDisciplina(cmbDiscSigla.SelectedItem.ToString());
                    mat = new Matricula(ano, sem, cmbMatr.SelectedItem.ToString(), dis_cod);
                    Status.Set("Apagando notas...", StatusType.INFO);
                    cn.UpdateMatricula(mat);
                    LoadDgv();
                    Status.Set("Notas apagadas com sucesso", StatusType.OK);
                } 
            }
            catch(OleDbException ex)
            {
                MessageBox.Show("Não foi possível excluir as notas" + ex.Message, "Cadastro de notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Cadastro de notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


        #region TabControl
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TCNotas.SelectedIndex == 0)
            {
                TSbtnAdd.Enabled = true;
                TSbtnDelete.Enabled = true;
                TSbtnUpdate.Enabled = true;
            }
            else
            {
                TSbtnAdd.Enabled = false;
                TSbtnDelete.Enabled = false;
                TSbtnUpdate.Enabled = false;
            }
        }

        #region PageConsulta

        private void btnPesq_Click(object sender, EventArgs e)
        {
            try
            {
                dgvNotas.DataSource = cn.ObtemMatricula(txtConsMatr.Text);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Matriculas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Matriculas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtConsMatr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.KeyChar = (char)0;
            }
        }

        #endregion

        #region PageCadastro
        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCurso.SelectedIndex != -1)
            {
                ResetMatriculas();
                ResetDisciplinas();
                ResetAnoSemestre();
                ResetFaltas();
                ResetNotas();
                cmbMatr.Items.Clear();
                cmbDiscSigla.Items.Clear();
                txtCurso.Text = Cursos.Rows[cmbCurso.SelectedIndex][1].ToString();
                cmbMatr.Enabled = true;
                LoadMatrDoCurso(cmbCurso.SelectedItem.ToString());
            }
        }

        private void cmbMatr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMatr.SelectedIndex != -1)
            {
                ResetDisciplinas();
                ResetAnoSemestre();
                ResetFaltas();
                ResetNotas();
                txtMatr.Text = Matricl.Rows[cmbMatr.SelectedIndex][1].ToString();
                cmbDiscSigla.Enabled = true;
                LoadDisciplinasDisponiveis(cmbMatr.SelectedItem.ToString());
            }
            else
            {
                cmbMatr.Enabled = false;
            }
        }

        private void cmbDiscSigla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiscSigla.SelectedIndex != -1)
            {
                try
                {

                    ResetAnoSemestre();
                    ResetFaltas();
                    ResetNotas();
                    LoadDisciplinas(cmbCurso.SelectedItem.ToString());

                    int cod = cn.ObtemCodigoDisciplina(cmbDiscSigla.SelectedItem.ToString());
                    txtDisc.Text = cn.ObtemNomeDisciplina(sigla:  cmbDiscSigla.SelectedItem.ToString());

                    DataTable alu = cn.ObtemMatricula(cmbMatr.SelectedItem.ToString(), disc_cod: cod);

                    // Carregar os Ano\Semestres da disciplina
                    cmbAnoSem.Items.Clear();
                    for(int i = 0; i < alu.Rows.Count; i++)
                    {
                        cmbAnoSem.Items.Add($"{alu.Rows[i]["Ano"]}/{alu.Rows[i]["Semestre"]}");
                    }
                    cmbAnoSem.Enabled = true;

                }
                catch(OleDbException ex)
                {
                    MessageBox.Show(ex.Message, "Cadastro de notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}", "Cadastro de notas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                cmbDiscSigla.Enabled = false;
            }
        }
        private void cmbAnoSem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetFaltas();
            ResetNotas();
            EnableCamposNotas(true);
            nroFaltas.Enabled = true;
            ObterAnoSem(out int ano, out int sem);
            //IndexOfDisciplina(cmbDiscSigla.SelectedItem.ToString(), true)
            int cod = cn.ObtemCodigoDisciplina(cmbDiscSigla.SelectedItem.ToString());
            DataTable alu = cn.ObtemMatricula(cmbMatr.SelectedItem.ToString(), ano, sem, cod);

            int.TryParse(alu.Rows[0]["Faltas"].ToString(), out int faltas);
            nroFaltas.Value = (decimal) faltas;
            txtP1.Text = alu.Rows[0]["P1"].ToString();
            txtP2.Text = alu.Rows[0]["P2"].ToString();
            txtMedTrab.Text = alu.Rows[0]["Trab"].ToString();
            CalcMedia();
        }
        private void txtMedia_TextChanged(object sender, EventArgs e)
        {
            if(double.TryParse(txtMedia.Text, out double nota))
            {
                if (nota < 0)
                {
                    nota = 0;
                    txtMedia.Text = nota.ToString();
                }
                else if(nota > 10.0)
                {
                    nota = 10;
                    txtMedia.Text = nota.ToString();
                }

                txtConc.Text = Matricula.EvalConceito(nota, (int)nroFaltas.Value);
            }
        }

        #region Validando
        private void txtP1_Validating(object sender, CancelEventArgs e)
        {
            if(double.TryParse(txtP1.Text, out double nota))
            {
                if (nota < 0) nota = 0.0;
                else if (nota > 10) nota = 10;
                txtP1.Text = nota.ToString();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txtP2_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(txtP2.Text, out double nota))
            {
                if (nota < 0) nota = 0.0;
                else if (nota > 10) nota = 10;
                txtP2.Text = nota.ToString();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txtMedTrab_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(txtMedTrab.Text, out double nota))
            {
                if (nota < 0) nota = 0.0;
                else if (nota > 10) nota = 10;
                txtMedTrab.Text = nota.ToString();
            }
            else
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Valido
        private void EventCalc(object sender, EventArgs e)
        {
            CalcMedia();
        }
        private void txtP1_Validated(object sender, EventArgs e)
        {
            CalcMedia();
        }

        private void txtP2_Validated(object sender, EventArgs e)
        {
            CalcMedia();
        }

        private void txtMedTrab_Validated(object sender, EventArgs e)
        {
            CalcMedia();
        }
        #endregion

        private void txtP1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && (e.KeyChar != ',' || e.KeyChar == ',' && ((TextBox)sender).Text.Contains(",")))
                e.KeyChar = (char)0;
        }
        private void nroFaltas_ValueChanged(object sender, EventArgs e)
        {
            if (nroFaltas.Value > 0)
            {
                if(double.TryParse(txtMedia.Text, out double med))
                {
                    txtConc.Text = Matricula.EvalConceito(med, (int)nroFaltas.Value);
                }
            }
        }
        #endregion

        #endregion

    }
}
