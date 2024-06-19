using Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSCA
{
    public partial class FrmAlunos : Form
    {
        private CamadaNegocios cn = new CamadaNegocios();
        private StatusLabel Status;
        private Aluno alu;
        private List<string> CPFs;
        private List<string> Matr;
        public FrmAlunos()
        {
            InitializeComponent();
        }

        private void FrmAlunos_Load(object sender, EventArgs e)
        {
            LoadCursos();
            LoadDgv();
            LoadEstados();
            LoadCPFs();
            LoadMatriculas();
            SetAnoSemestre();
            Status = new StatusLabel(STSlblStatus);
        }

        #region Métodos
        private void LoadCursos()
        {
            try
            {
                DataTable tb = cn.ObtemCrusos().Tables[0];
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    cmbCurso.Items.Add(tb.Rows[i]["cur_sgl"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alunos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDgv()
        {
            try
            {
                dgvAlu.DataSource = cn.ObtemAlunos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alunos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEstados()
        {
            try
            {
                DataTable tb = cn.ObtemEstados().Tables[0];
                for (int i = 0; i < tb.Rows.Count; i++)
                {
                    cmbAluEndUF.Items.Add(tb.Rows[i]["ufe_sig"].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alunos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCPFs()
        {
            if(CPFs is null)
                CPFs = new List<string>();
            else
                CPFs.Clear();
            for (int i = 0; i < dgvAlu.Rows.Count; i++)
            {
                CPFs.Add(dgvAlu.Rows[i].Cells["CPF"].Value.ToString());
            }
        }

        private void LoadMatriculas()
        {
            if (Matr is null)
                Matr = new List<string>();
            else
                Matr.Clear();
            for (int i = 0; i < dgvAlu.Rows.Count; i++)
            {
                CPFs.Add(dgvAlu.Rows[i].Cells["Matricula"].Value.ToString());
            }
        }

        private bool ExistsCPF(string cpf)
        {
            return CPFs.Contains(cpf);
        }

        private void CleanErroCad()
        {
            EPAlu.SetError(txtAluMat, "");
            EPAlu.SetError(txtAluNome, "");
            EPAlu.SetError(mskDtNsc, "");
            EPAlu.SetError(cmbCurso, "");
            EPAlu.SetError(mskIng, "");
            EPAlu.SetError(nroEndNro, "");
            EPAlu.SetError(mskEndCEP, "");
            EPAlu.SetError(txtAluEndLogra, "");
            EPAlu.SetError(txtAluEnd, "");
            EPAlu.SetError(txtAluEndComplt, "");
            EPAlu.SetError(txtAluEndBairro, "");
            EPAlu.SetError(txtAluEndMun, "");
            EPAlu.SetError(cmbAluEndUF, "");
            EPAlu.SetError(txtAluEmail, "");
            EPAlu.SetError(mskCPF, "");
        }

        private void CleanErroCons()
        {
            EPAlu.SetError(txtConsMat, "");
            EPAlu.SetError(txtConsNome, "");
        }

        private void SetAnoSemestre()
        {
            int ano = DateTime.Today.Year;
            int semestre = (DateTime.Today.Month >= 6 ? 2 : 1);
            mskIng.Text = $"{ano}{semestre}";
        }

        private bool IsNotFilled(object obj)
        {
            if (obj is TextBox)
                return string.IsNullOrEmpty(((TextBox)obj).Text);
            else if (obj is ComboBox)
                return (((ComboBox)obj).SelectedIndex == -1);
            else if (obj is MaskedTextBox)
                return (((MaskedTextBox)obj).Text == "");
            else if (obj is NumericUpDown)
                return( ((NumericUpDown)obj).Value == 0);
            else
                return false;
        }

        private bool IsAllFieldsFill()
        {
            if (IsNotFilled(txtAluMat)) { txtAluMat.Focus(); return false; }
            if (IsNotFilled(txtAluNome)) { txtAluNome.Focus(); return false; }
            if (IsNotFilled(mskDtNsc)) { mskDtNsc.Focus(); return false; }
            if (IsNotFilled(cmbCurso)) { cmbCurso.Focus(); return false; }
            if (IsNotFilled(mskIng)) { mskIng.Focus(); return false; }
            if (IsNotFilled(nroEndNro)) { nroEndNro.Focus(); return false; }
            if (IsNotFilled(mskEndCEP)) { mskEndCEP.Focus(); return false; }
            if (IsNotFilled(txtAluEndLogra)) { txtAluEndLogra.Focus(); return false; }
            if (IsNotFilled(txtAluEnd)) { txtAluEnd.Focus(); return false; }
            if (IsNotFilled(txtAluEndBairro)) { txtAluEndBairro.Focus(); return false; }
            if (IsNotFilled(txtAluEndMun)) { txtAluEndMun.Focus(); return false; }
            if (IsNotFilled(cmbAluEndUF)) { cmbAluEndUF.Focus(); return false; }
            if (IsNotFilled(txtAluEmail)) { txtAluEmail.Focus(); return false; }
            if (IsNotFilled(mskCPF)) { mskCPF.Focus(); return false; }
            return true;
        }

        private bool LoadAluData()
        {
            if (IsAllFieldsFill())
            {
                string sexo = "";
                if (rdbAluSexFem.Checked) sexo = "F";
                else if (rdbAluSexMasc.Checked) sexo = "M";
                else sexo = "O";

                alu = new Aluno(
                    txtAluNome.Text,
                    txtAluMat.Text,
                    mskIng.Text,
                    mskDtNsc.Text,
                    mskCPF.Text,
                    sexo,
                    txtAluEmail.Text,
                    mskEndCEP.Text,
                    txtAluEndLogra.Text,
                    txtAluEnd.Text,
                    (int)nroEndNro.Value,
                    txtAluEndComplt.Text,
                    txtAluEndBairro.Text,
                    txtAluEndMun.Text,
                    cmbAluEndUF.SelectedItem.ToString(), 
                    cmbCurso.SelectedItem.ToString()
                    ) ;
                return true;
            }
            return false;
        }

        private bool ExistsMatricula(string matricula)
        {
            return Matr.Contains(matricula);
        }
        #endregion

        #region ToolStrip
        private void TSbtnAdd_Click(object sender, EventArgs e)
        {
            if (!LoadAluData())
            {
                Status.Set($"Cadastramento não realizado, preencha os campos!", StatusType.INFO);
                return;
            }
            else if (ExistsCPF(alu.CPF))
            {
                Status.Set($"Cadastramento não realizado, CPF já incluso: {alu.CPF}", StatusType.WARNING);
                EPAlu.SetError(mskCPF, "CPF já cadastrado");
                mskCPF.Focus();
                mskCPF.SelectAll();
                return;
            }
            else if (ExistsMatricula(alu.Matricula))
            {
                Status.Set($"Cadastramento não realizado, matricula ({alu.Matricula}) já cadastrada", StatusType.WARNING);
                EPAlu.SetError(txtAluMat, "Matricula já cadastrada");
                txtAluMat.Focus();
                txtAluMat.SelectAll();
                return;
            }
            Status.Set($"Cadastrando aluno: {alu.Nome}", StatusType.INFO);
            try
            {
                cn.AddAluno(alu);
                LoadDgv();
                Status.Set($"Aluno cadastrado: {alu.Matricula} {alu.Nome}", StatusType.OK);
            }
            catch(OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro de alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Não foi possivel adicionar o(a) aluno(a): {alu.Matricula} {alu.Nome}", StatusType.ERROR);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Cadastro de alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Não foi possivel adicionar o(a) aluno(a): {alu.Matricula} {alu.Nome}", StatusType.ERROR);
            }
        }

        private void TSbtnUpdate_Click(object sender, EventArgs e)
        {
            if (!LoadAluData())
            {
                return;
            }
            try
            {
                Status.Set($"Atualizando aluno: {alu.Matricula} {alu.Nome}", StatusType.INFO);
                cn.UpdateAluno(alu);
                LoadDgv();
                Status.Set($"Aluno atualizado: {alu.Matricula} {alu.Nome}", StatusType.OK);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Atualição de alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Não foi possivel atualizar o(a) aluno(a): {alu.Matricula} {alu.Nome}", StatusType.ERROR);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Atualização de alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Não foi possivel atualizarr o(a) aluno(a): {alu.Matricula} {alu.Nome}", StatusType.ERROR);
            }
        }

        private void TSbtnClean_Click(object sender, EventArgs e)
        {
            if (TCAlu.SelectedIndex == 0)
            {
                txtAluMat.Text = "";
                txtAluMat.ReadOnly = false;
                txtAluNome.Text = "";
                rdbAluSexFem.Checked = true;
                mskDtNsc.Text = "";
                cmbCurso.SelectedIndex = -1;
                mskIng.Text = "";
                mskEndCEP.Text = "";
                txtAluEndLogra.Text = "";
                txtAluEnd.Text = "";
                nroEndNro.Value = 0;
                txtAluEndComplt.Text = "";
                txtAluEndBairro.Text = "";
                txtAluEndMun.Text = "";
                cmbAluEndUF.SelectedIndex = -1;
                txtAluEmail.Text = "";
                mskCPF.Text = "";
                SetAnoSemestre();
                CleanErroCad();
            }
            else
            {
                txtConsMat.Text = "";
                txtConsNome.Text = "";
                CleanErroCons();
            }
        }

        private void TSbtnDelete_Click(object sender, EventArgs e)
        {
            string matricula = txtAluMat.Text;
            string nome = txtAluNome.Text;
            try
            {
                Status.Set($"Excluindo aluno(a): {matricula} {nome}", StatusType.INFO);
                cn.DeleteAluno(matricula);
                LoadDgv();
                Status.Set($"Aluno(a) excluido(a): {matricula} {nome}", StatusType.OK);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Exclusão de alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Não foi possivel excluir o(a) aluno(a): {nome}", StatusType.ERROR);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Exclusão de alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Não foi possivel excluir o(a) aluno(a): {nome}", StatusType.ERROR);
            }
        }

        #endregion

        #region TabControl
        private void TCAlu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TCAlu.SelectedIndex == 0)
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

        #region PageCadastro

        #region Evento keypress
        private void txtAluMat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.KeyChar = (char)0;
        }

        private void txtAluNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Valida.CheckChar(e.KeyChar, punctuation: false, digit:false))
                e.KeyChar = (char)0;
        }

        private void txtAluEndLogra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Valida.CheckChar(e.KeyChar, digit: false))
                e.KeyChar = (char)0;
        }

        private void txtAluEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Valida.CheckChar(e.KeyChar))
                e.KeyChar= (char)0;
        }

        private void txtAluEndComplt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Valida.CheckChar(e.KeyChar))
                e.KeyChar = (char)0;
        }

        private void txtAluEndBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Valida.CheckChar(e.KeyChar, digit: false))
                e.KeyChar = (char)0;
        }

        private void txtAluEndMun_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Valida.CheckChar(e.KeyChar, punctuation: false ,digit: false))
                e.KeyChar = (char)0;
        }
        private void txtAluEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Valida.CheckChar(e.KeyChar, space: false))
            {
                e.KeyChar = (char)0;
            }
        }
        #endregion

        #region Validando
        private void txtAluMat_Validating(object sender, CancelEventArgs e)
        {
            if (!Valida.Matricula(txtAluMat.Text))
            {
                EPAlu.SetError(txtAluMat, "Matricula deve conter digitos 0-9. Tamanho máximo 10.");
                e.Cancel = true;
            }
        }

        private void txtAluNome_Validating(object sender, CancelEventArgs e)
        {
            if(!Valida.Nome(txtAluNome.Text, 70, 3))
            {
                EPAlu.SetError(txtAluNome, "Nome deve conter letras. Máximo 70 caracteres.");
                e.Cancel= true;
            }
        }

        private void mskDtNsc_Validating(object sender, CancelEventArgs e)
        {
            
            if (mskDtNsc.Text.Length != 10)
            {
                EPAlu.SetError(mskDtNsc, "Data de nascimento é obrigatória.");
                e.Cancel = true;
            }
            else
            {
                if( DateTime.TryParse(mskDtNsc.Text, out DateTime birth))
                {
                    if((birth - DateTime.Today).TotalDays >= 0)
                    {
                        EPAlu.SetError(mskDtNsc, "Data de nascimento no futuro não é válida.");
                        e.Cancel = true;
                    }
                }
                else
                {
                    EPAlu.SetError(mskDtNsc, "Ano, mês ou dia inválidos.");
                    e.Cancel = true;
                }
            }
        }

        private void cmbCurso_Validating(object sender, CancelEventArgs e)
        {
            if(cmbCurso.SelectedIndex == -1)
            {
                EPAlu.SetError(cmbCurso, "Selecione um curso.");
                e.Cancel = true;
            }
        }

        private void mskIng_Validating(object sender, CancelEventArgs e)
        {
            if(mskIng.Text.Length != 6)
            {
                EPAlu.SetError(mskIng, "Informe a data de ingresso");
                e.Cancel = true;
            }
        }

        private void nroEndNro_Validating(object sender, CancelEventArgs e)
        {
            if(nroEndNro.Value == 0)
            {
                EPAlu.SetError(nroEndNro, "Informe um número.");
                e.Cancel = true;
            }
        }
        private void mskEndCEP_Validating(object sender, CancelEventArgs e)
        {
            if(mskEndCEP.Text.Length != 9)
            {
                EPAlu.SetError(mskEndCEP, "Preencha o CEP");
                e.Cancel = true;
            }
        }

        private void txtAluEndLogra_Validating(object sender, CancelEventArgs e)
        {
            if(!Valida.Nome(txtAluEndLogra.Text, 10))
            {
                EPAlu.SetError(txtAluEndLogra, "Informar o logradouro é obrigatório");
                e.Cancel = true;
            }
        }

        private void txtAluEnd_Validating(object sender, CancelEventArgs e)
        {
            if(!Valida.Nome(txtAluEnd.Text, 70))
            {
                EPAlu.SetError(txtAluEnd, "Informe o endereço.");
                e.Cancel = true;
            }
        }

        private void txtAluEndComplt_Validating(object sender, CancelEventArgs e)
        {
            if (!Valida.Nome(txtAluEndComplt.Text, 20, 0, digit: true))
            {
                EPAlu.SetError(txtAluEndComplt, "Complemento inválido");
                e.Cancel = true;
            }
        }

        private void txtAluEndBairro_Validating(object sender, CancelEventArgs e)
        {
            if (!Valida.Nome(txtAluEndBairro.Text, 70, punctuation: false))
            {
                EPAlu.SetError(txtAluEndBairro, "Informe um bairro válido.");
                e.Cancel = true;
            }
        }

        private void txtAluEndMun_Validating(object sender, CancelEventArgs e)
        {
            if(!Valida.Nome(txtAluEndMun.Text, 70))
            {
                EPAlu.SetError(txtAluEndMun, "Informe um municipio. Máximo 70 caracteres");
                e.Cancel = true;
            }
        }

        private void cmbAluEndUF_Validating(object sender, CancelEventArgs e)
        {
            if(cmbAluEndUF.SelectedIndex == -1)
            {
                EPAlu.SetError(cmbAluEndUF, "Selecione um UF");
                e.Cancel= true;
            }
        }

        private void txtAluEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!Valida.Email(txtAluEmail.Text))
            {
                EPAlu.SetError(txtAluEmail, "Informe um email válido");
                e.Cancel = true;
            }
        }

        private void mskCPF_Validating(object sender, CancelEventArgs e)
        {
            if(mskCPF.Text.Length != 14)
            {
                EPAlu.SetError(mskCPF, "O CPF é obrigatório.");
                e.Cancel= true;
            }else if(!Valida.CPF(mskCPF.Text))
            {
                EPAlu.SetError(mskCPF, "Informe um CPF válido.");
                e.Cancel = true;
            }
        }
        #endregion

        #region Validando
        private void txtAluMat_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(txtAluMat, "");
        }

        private void txtAluNome_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(txtAluNome, "");
        }

        private void mskDtNsc_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(mskDtNsc, "");
        }

        private void cmbCurso_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(cmbCurso, "");
        }

        private void mskIng_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(mskIng, "");
        }

        private void txtAluEndLogra_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(txtAluEndLogra, "");
        }

        private void txtAluEnd_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(txtAluEnd, "");
        }

        private void nroEndNro_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(nroEndNro, "");
        }

        private void txtAluEndComplt_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(txtAluEndComplt, "");
        }

        private void txtAluEndBairro_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(txtAluEndBairro, "");
        }

        private void txtAluEndMun_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(txtAluEndMun, "");
        }

        private void cmbAluEndUF_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(cmbAluEndUF, "");
        }
        private void mskEndCEP_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(mskEndCEP, "");
        }
        private void txtAluEmail_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(txtAluEmail, "");
        }
        private void mskCPF_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(mskCPF, "");
        }

        #endregion

        #endregion

        #region PageConsulta
        private void btnPesq_Click(object sender, EventArgs e)
        { 
            string nome = txtConsNome.Text;
            string matricula = txtConsMat.Text;
            try
            {

                Status.Set($"Pesquisando aluno: {nome} {matricula}", StatusType.INFO);
                dgvAlu.DataSource = cn.ObtemAluno(matricula, nome);
                Status.Set("Pesquisa finalizada ", StatusType.OK);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"Erro na operação: {ex.Message}", "Pesquisa de alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Não foi possivel pesquisar o(a) aluno(a): {nome} {matricula}", StatusType.ERROR);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}", "Pesquisa de alunos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Não foi possivel pesquisar o(a) aluno(a): {nome} {matricula}", StatusType.ERROR);
            }
        }

        private void dgvAlu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvAlu.CurrentRow;

            txtAluMat.Text = row.Cells["Matricula"].Value.ToString();
            txtAluNome.Text = row.Cells["Nome"].Value.ToString();

            string sexo = row.Cells["Sexo"].Value.ToString();
            if (sexo == "F")
                rdbAluSexFem.Checked = true;
            else if (sexo == "M")
                rdbAluSexMasc.Checked = true;
            else
                rdbAluSexOutro.Checked = true;

            mskDtNsc.Text = row.Cells["Data_Nasc"].Value.ToString();
            cmbCurso.SelectedItem = row.Cells["Curso"].Value.ToString();
            mskIng.Text = row.Cells["Data_Ingr"].Value.ToString();
            mskEndCEP.Text = row.Cells["CEP"].Value.ToString();
            txtAluEndLogra.Text = row.Cells["Logradouro"].Value.ToString();
            txtAluEnd.Text = row.Cells["Endereco"].Value.ToString();
            nroEndNro.Value = int.Parse(row.Cells["Numero"].Value.ToString());
            txtAluEndComplt.Text = row.Cells["Complemento"].Value.ToString();
            txtAluEndBairro.Text = row.Cells["Bairro"].Value.ToString();
            txtAluEndMun.Text = row.Cells["Cidade"].Value.ToString();
            cmbAluEndUF.SelectedItem = row.Cells["Estado"].Value.ToString();
            txtAluEmail.Text = row.Cells["Email"].Value.ToString();
            mskCPF.Text = row.Cells["CPF"].Value.ToString();

            TCAlu.SelectedIndex = 0;
            txtAluMat.ReadOnly = true;
        }

        #region Validando
        private void txtConsMat_Validating(object sender, CancelEventArgs e)
        {
            if (txtConsMat.Text.Length != 0 && !Valida.Matricula(txtConsMat.Text))
            {
                EPAlu.SetError(txtConsMat, "Apenas digitos (0-9), máximo 10.");
                e.Cancel = true;
            }
        }

        private void txtConsNome_Validating(object sender, CancelEventArgs e)
        {
            if(!Valida.Nome(txtConsNome.Text, 70, 0, punctuation: false))
            {
                EPAlu.SetError(txtConsNome, "Apenas letras e espaços, máximo 70.");
                e.Cancel = true;
            }
        }
        #endregion

        #region Valido
        private void txtConsMat_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(txtConsMat, "");
        }

        private void txtConsNome_Validated(object sender, EventArgs e)
        {
            EPAlu.SetError(txtConsNome, "");
        }



        #endregion

        #endregion

        #endregion

    }
}
