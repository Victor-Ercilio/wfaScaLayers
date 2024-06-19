using Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSCA
{
    public partial class FrmMatriculas : Form
    {
        private StatusLabel Status;
        private DataTable Cursos;
        private DataTable DisciplDisp;
        private DataTable Discipl;
        private DataTable Matricl;
        private CamadaNegocios cn = new CamadaNegocios();

        public FrmMatriculas()
        {
            InitializeComponent();
        }

        private void FrmMatriculas_Load(object sender, EventArgs e)
        {
            LoadDgv();
            LoadCursos();
            SetAnoSemestre();
            Status = new StatusLabel(STSlblStatus);
        }


        #region Métodos

        private void LoadCursos()
        {
            try
            {
                Cursos = cn.ObtemCursoComAlunos();
                List<string> list = new List<string>();
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
            if(valor == "")
            {
                return null;
            }
            else if(double.TryParse(valor, out double v))
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

        private void LoadDisciplinasDisponiveis(string matricula, string curso)
        {
            try
            {
                ObterAnoSemestre(out int ano, out int sem);
                DisciplDisp = cn.ObtemDisciplinasDisponiveis(ano, sem, matricula, curso);
                cmbDiscSigla.Items.Clear();
                List<string> list = new List<string>();
                for (int i = 0; i < DisciplDisp.Rows.Count; i++)
                {
                    if (DisciplDisp.Rows[i]["Matricula"].ToString() != matricula)
                    {
                        if(!cmbDiscSigla.Items.Contains(DisciplDisp.Rows[i]["Disciplina_Sigla"].ToString()))
                            cmbDiscSigla.Items.Add(DisciplDisp.Rows[i]["Disciplina_Sigla"].ToString());
                    }
                    else
                    {
                        list.Add(DisciplDisp.Rows[i]["Disciplina_Sigla"].ToString());
                    }
                }
                foreach(string s in list)
                {
                    cmbDiscSigla.Items.Remove(s);
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
                dgvMatr.DataSource = cn.ObtemMatriculas();
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

        private int IndexOfCurso(string matr)
        {
            if (Cursos != null)
            {
                for (int i = 0; i < Cursos.Rows.Count; i++)
                {
                    if (Cursos.Rows[i]["Matricula"].ToString() == matr)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }

        private void SetAnoSemestre()
        {
            int ano = DateTime.Today.Year;
            int semestre = (DateTime.Today.Month >= 6 ? 2 : 1);
            mskDisAnoSem.Text = $"{ano}{semestre}";
            mskDisAnoSem.ReadOnly = true;
        }


        private void ObterAnoSemestre(out int ano, out int sem)
        {
            if(mskDisAnoSem.Text != "")
            {
                string[] periodo = mskDisAnoSem.Text.Split('/');
                int.TryParse(periodo[0], out int anov);
                int.TryParse(periodo[1], out int semtr);
                ano = anov;
                sem = semtr;
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
            txtMed.Text = "";
            txtMedTb.Text = "";
            txtConc.Text = "";
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
            cmbDiscSigla.Enabled = false;
            txtDiscNome.Text = "";
        }
        private void ResetFaltas()
        {
            nroFaltas.Value = 0;
            nroFaltas.ReadOnly = true;
        }

        private bool IsNotAllSelected()
        {
            return (cmbCurso.SelectedIndex == -1 ||
                    cmbMatr.SelectedIndex == -1 ||
                    cmbDiscSigla.SelectedIndex == -1);
        }

        #endregion

        #region ToolStrip
        private void TSbtnAdd_Click(object sender, EventArgs e)
        {
            Matricula matr;

            if (IsNotAllSelected())
            {
                return;
            }
            try
            {
                ObterAnoSemestre(out int ano, out int sem);

                int dis_cod = cn.ObtemCodigoDisciplina(cmbDiscSigla.SelectedItem.ToString());

                int faltas = (int)nroFaltas.Value;
                
                matr = new Matricula(ano, sem, cmbMatr.SelectedItem.ToString(), dis_cod, faltas: faltas);
                cn.AddMatricula(matr);
                LoadDgv();
                LoadDisciplinasDisponiveis(cmbCurso.SelectedItem.ToString(), cmbCurso.SelectedItem.ToString());
                Status.Set($"Matricula cadastrado", StatusType.OK);
            }
            catch (OleDbException)
            {
                MessageBox.Show("Matrícula já cadastrada", "Cadastro de matriculas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Não foi possivel adicionar a matricula", StatusType.ERROR);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Cadastro de matriculas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Não foi possivel adicionar a matricula", StatusType.ERROR);
            }
        }

        private void TSbtnUpdate_Click(object sender, EventArgs e)
        {
            Matricula matr;
            if(IsNotAllSelected())
            {
                return;
            }

            try
            {
                ObterAnoSemestre(out int ano, out int sem);

                int dis_cod = cn.ObtemCodigoDisciplina(cmbDiscSigla.SelectedItem.ToString());

                int faltas = (int)nroFaltas.Value;

                matr = new Matricula(ano, sem, cmbMatr.SelectedItem.ToString(), dis_cod, ConvertDouble(txtP1.Text), ConvertDouble(txtP2.Text), ConvertDouble(txtMed.Text), ConvertDouble(txtMedTb.Text), ConvertChar(txtConc.Text) , faltas: faltas);

                cn.UpdateMatricula(matr);
                LoadDgv();
                Status.Set($"Matricula atualizada", StatusType.OK);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro de matriculas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Não foi possivel atualizar a matricula", StatusType.ERROR);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Cadastro de matriculas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Não foi possivel atualizar a matricula", StatusType.ERROR);
            }
        }

        private void TSbtnClear_Click(object sender, EventArgs e)
        {
            if(TCMatr.SelectedIndex == 0)
            {
                cmbCurso.SelectedIndex = -1;
                txtCurso.Text = "";

                ResetMatriculas();
                ResetDisciplinas();
                ResetFaltas();
                SetAnoSemestre();

                cmbCurso.Focus();
            }
            else
            {
                txtConsMatr.Text = "";
            }
        }

        private void TSbtnDelete_Click(object sender, EventArgs e)
        {
            if(IsNotAllSelected()) return;
            try
            {
                if(MessageBox.Show($"Deseja excluir a matricula {cmbMatr.SelectedItem.ToString()}?", "Cadatro de Matriculas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ObterAnoSemestre(out int ano, out int sem);

                    int dis_cod= cn.ObtemCodigoDisciplina(cmbDiscSigla.SelectedItem.ToString());
                
                    cn.DeleteMatricula(cmbMatr.SelectedItem.ToString(), ano, sem, dis_cod);
                
                    LoadDgv();
                    Status.Set($"Matricula excluida ", StatusType.OK);
                }
                else
                    Status.Set($"Exclusão cancelada ", StatusType.INFO);
            }
            catch(InvalidOperationMatriculaTemNotas ex)
            {
                MessageBox.Show(ex.Message, "Exclusão de matriculas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Não foi possivel excluir a matricula, notas cadastradas", StatusType.ERROR);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Exclusão de matriculas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Não foi possivel excluir a matricula ", StatusType.ERROR);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Exclusão de matriculas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Não foi possivel excluir a matricula ", StatusType.ERROR);
            }
        }

        #endregion

        #region Consultar
        private void btnPesq_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMatr.DataSource = cn.ObtemMatricula(txtConsMatr.Text);
            }
            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Matriculas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Matriculas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtConsMatr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.KeyChar = (char)0;
            }
        }
        private void dgvMatr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvMatr.CurrentRow;

            string discp = row.Cells["Disc_Sigla"].Value.ToString();
            int.TryParse(row.Cells["Disc_Cod"].Value.ToString(), out int dis_cod);
            string matr = row.Cells["Matricula"].Value.ToString();
            int.TryParse(row.Cells["Ano"].Value.ToString(), out int ano);
            int.TryParse(row.Cells["Semestre"].Value.ToString(), out int sem);

            cmbCurso.Items.Clear();
            cmbCurso.Items.Add(cn.ObtemCursoPorDisciplina(dis_cod));
            cmbCurso.SelectedIndex = 0;

            cmbMatr.Enabled = true;
            cmbMatr.SelectedItem = matr;

            
            cmbDiscSigla.Enabled = true;
            cmbDiscSigla.Items.Add(discp);
            cmbDiscSigla.SelectedItem = discp;


            mskDisAnoSem.Text = $"{ano}{sem}";

            decimal.TryParse(row.Cells["Faltas"].Value.ToString(), out decimal faltas);
            nroFaltas.Value = faltas;

            txtP1.Text = row.Cells["P1"].Value.ToString();
            txtP2.Text = row.Cells["P2"].Value.ToString();
            txtMedTb.Text = row.Cells["Trab"].Value.ToString();
            txtMed.Text = row.Cells["Media"].Value.ToString();
            txtConc.Text = row.Cells["Conceito"].Value.ToString();

            mskDisAnoSem.ReadOnly = false;
            nroFaltas.ReadOnly = false;

            TCMatr.SelectedIndex = 0;
        }
        #endregion

        #region Cadastrar
        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCurso.SelectedIndex != -1)
            {
                ResetMatriculas();
                ResetDisciplinas();
                ResetFaltas();
                ResetNotas();
                SetAnoSemestre();
                txtCurso.Text = cn.ObtemNomeCurso(cmbCurso.SelectedItem.ToString());
                cmbMatr.Enabled = true;
                LoadMatrDoCurso(cmbCurso.SelectedItem.ToString());
            }
        }

        private void cmbMatr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMatr.SelectedIndex != -1)
            {
                ResetDisciplinas();
                ResetFaltas();
                ResetNotas();
                SetAnoSemestre();
                txtMatr.Text = cn.ObtemNomeDoAluno(cmbMatr.SelectedItem.ToString());
                cmbDiscSigla.Enabled = true;
                LoadDisciplinasDisponiveis(cmbMatr.SelectedItem.ToString(), cmbCurso.SelectedItem.ToString());
            }
        }

        private void cmbDiscSigla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiscSigla.SelectedIndex != -1)
            {
                ResetFaltas();
                ResetNotas();
                SetAnoSemestre();
                cmbDiscSigla.Enabled = true;
                LoadDisciplinas(cmbCurso.SelectedItem.ToString());
                int index = cn.ObtemCodigoDisciplina(cmbDiscSigla.SelectedItem.ToString());
                txtDiscNome.Text = cn.ObtemNomeDisciplina(cod: index);
            }
        }

        private void nroFaltas_ValueChanged(object sender, EventArgs e)
        {
            txtConc.Text = Matricula.EvalConceito(int.Parse(txtMed.Text), (int)nroFaltas.Value);
        }

        private void mskDisAnoSem_TextChanged(object sender, EventArgs e)
        {
            if(mskDisAnoSem.Text.Length != 6)
            {
                EPMat.SetError(mskDisAnoSem, "Informe um ano/semestre");
            }
            else
            {
                string[] periodo = mskDisAnoSem.Text.Split('/');
                if (int.TryParse(periodo[0], out int ano) && int.TryParse(periodo[1], out int sem))
                {
                    if(ano <= 0)
                    {
                        EPMat.SetError(mskDisAnoSem, "Informe um ano válido");
                    }
                    else if(sem != 1 && sem != 2)
                    {
                        EPMat.SetError(mskDisAnoSem, "Informe um semestre válido (1 ou 2)");
                    }
                }
            }
        }

        private void mskDisAnoSem_Validating(object sender, CancelEventArgs e)
        {
            if (mskDisAnoSem.Text.Length != 6)
            {
                EPMat.SetError(mskDisAnoSem, "Informe um ano/semestre");
            }
            else
            {
                string[] periodo = mskDisAnoSem.Text.Split('/');
                if (int.TryParse(periodo[0], out int ano) && int.TryParse(periodo[1], out int sem))
                {
                    if (ano <= 0)
                    {
                        EPMat.SetError(mskDisAnoSem, "Informe um ano válido");
                    }
                    else if (sem != 1 && sem != 2)
                    {
                        EPMat.SetError(mskDisAnoSem, "Informe um semestre válido (1 ou 2)");
                    }
                }
            }
        }

        private void mskDisAnoSem_Validated(object sender, EventArgs e)
        {
            EPMat.SetError(mskDisAnoSem, "");
        }
        #endregion


    }
}
