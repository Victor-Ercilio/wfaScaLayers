using Bll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSCA
{
    public partial class FrmEstados : Form
    {
        private StatusLabel Status;
        private CamadaNegocios Cn;
        
        public FrmEstados()
        {
            InitializeComponent();
        }
        private void FrmEstados_Load(object sender, EventArgs e)
        {
            Cn = new CamadaNegocios();
            dgvUF.DataSource = Cn.Estados.All();
            SetStatus();
        }

        #region Métodos
        private void SetStatus()
        {
            Status = new StatusLabel(STSStatus);
        }

        private void FilterDGV()
        {
            string uf = txtUFSigla.Text;
            string nome = txtUFConsNome.Text;
            dgvUF.DataSource = Cn.Estados.SelectAnyWith(nome);
        }
        #endregion

        #region ToolStripUF
        private void TSBUFAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Estado uf = new Estado(txtUFSigla.Text, txtUFNome.Text);
                
                Status.Set($"Adicionando Estado: {uf.Sigla} - {uf.Nome}", StatusType.INFO);
                //Cn.AddEstado(uf);
                Cn.Estados.Add(uf);
                Status.Set($"Adicionado com sucesso: {uf.Sigla} - {uf.Nome}", StatusType.OK);
                
            }
            catch(InvalidNameException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro de Estado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                EPUF.SetError(txtUFNome, "Nome precisa ser preenchido");
                Status.Set(ex.Message, StatusType.ERROR);
            }
            catch(InvalidSiglaException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro de Estado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                EPUF.SetError(txtUFSigla, "Sigla precisa ser preenchida");
                Status.Set(ex.Message, StatusType.ERROR);
            }
            catch(OleDbException ex)
            {
                MessageBox.Show($"Estado já cadastrado! {ex.Message}", "Cadastro de Estado", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Erro no cadastro do Estado", StatusType.ERROR);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cadastro Estado", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Erro no adicionamento do estado", StatusType.ERROR);
            }
        }

        private void TSBUFSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Estado uf = new Estado(txtUFSigla.Text, txtUFNome.Text);
                if (Cn.ObtemEstado(uf).Tables[0].Rows.Count > 0)
                {
                    Status.Set("Atualizando Estado", StatusType.INFO);
                    Cn.UpdateEstado(uf);
                    //Cn.Estados.Update(uf);
                    Status.Set("Atualizado com sucesso", StatusType.OK);
                }
                else
                {
                    Status.Set("Estado não cadastrado", StatusType.ERROR);
                }
            }
            catch (InvalidNameException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro de Estado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                EPUF.SetError(txtUFNome, "Nome precisa ser preenchido");
                Status.Set(ex.Message, StatusType.ERROR);
            }
            catch (InvalidSiglaException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro de Estado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                EPUF.SetError(txtUFSigla, "Sigla precisa ser preenchida");
                Status.Set(ex.Message, StatusType.ERROR);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro de Estado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, true);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cadastro Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set("Erro na adição /atualização", StatusType.ERROR);
            }
        }
        private void TSBUFDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Estado uf = new Estado(txtUFSigla.Text, txtUFNome.Text);
                Status.Set("Excluindo Estado", StatusType.INFO);
                //Cn.DeleteEstado(uf);
                Cn.Estados.Del(uf);
                Status.Set("Excluido com sucesso", StatusType.OK);
            }
            catch (InvalidNameException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro de Estado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                EPUF.SetError(txtUFNome, "Nome precisa ser preenchido");
                Status.Set(ex.Message, StatusType.ERROR);
            }
            catch (InvalidSiglaException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro de Estado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                EPUF.SetError(txtUFSigla, "Sigla precisa ser preenchida");
                Status.Set(ex.Message, StatusType.ERROR);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Cadastrod de Estado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, true);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cadastro de Estados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set("Erro na Exclusão", StatusType.ERROR);
            }
        }
        private void TSBUFLimpar_Click(object sender, EventArgs e)
        {
            txtUFNome.Text = "";
            txtUFSigla.Text = "";
            EPUF.SetError(txtUFNome, "");
            EPUF.SetError(txtUFSigla, "");
        }

        #endregion

        #region TableControl
        #region PageCadastro
        #region Field Nome
        private void txtUFNome_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string n = Estado.ParseNome(txtUFNome.Text);
            }
            catch(InvalidNameException ex)
            {
                EPUF.SetError(txtUFNome, ex.Message);
                Status.Set(ex.Message, StatusType.ERROR);
                e.Cancel = true;
            }
        }
        private void txtUFNome_Validated(object sender, EventArgs e)
        {
            EPUF.SetError(txtUFNome, "");
        }
        #endregion

        #region Field Sigla
        private void txtUFSigla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            else
            {
                e.KeyChar = (char)0;
            }
        }
        private void txtUFSigla_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                string n = Estado.ParseSigla(txtUFSigla.Text);
            }
            catch (InvalidSiglaException ex)
            {
                EPUF.SetError(txtUFSigla, ex.Message);
                Status.Set(ex.Message, StatusType.ERROR);
                e.Cancel = true;
            }
        }
        private void txtUFSigla_Validated(object sender, EventArgs e)
        {
            EPUF.SetError(txtUFSigla, "");
        }
        #endregion

        #endregion

        #region PageConsulta
        private void btnUFPesq_Click(object sender, EventArgs e)
        {
            try
            {
                //Estado uf = new Estado(nome: txtUFConsNome.Text);
                dgvUF.DataSource = Cn.Estados.SelectAnyWith(nome: txtUFConsNome.Text);
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Cadastrod de Estado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, true);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cadastro de Estados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set("Erro na consulta", StatusType.ERROR);
            }
        }

        private void dgvUF_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUFSigla.Text = dgvUF.CurrentRow.Cells["UF"].Value.ToString();
            txtUFNome.Text = dgvUF.CurrentRow.Cells["Nome"].Value.ToString();
            tbcUF.SelectedIndex = 0;
            txtUFNome.Focus();
        }

        #endregion

        private void tbcUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tbcUF.SelectedIndex == 1)
            {
                foreach (ToolStripItem i in TSUF.Items)
                    i.Enabled = false;
            }
            else
            {
                foreach (ToolStripItem i in TSUF.Items)
                    i.Enabled = true;
            }
        }
        #endregion
    }
}
