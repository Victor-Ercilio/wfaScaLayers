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
        StatusLabel Status;
        
        public FrmEstados()
        {
            InitializeComponent();
        }
        private void FrmEstados_Load(object sender, EventArgs e)
        {
            CamadaNegocios cn = new CamadaNegocios();
            dgvUF.DataSource = cn.AllEstados();
            dgvUF.Columns["ufe_sig"].HeaderText = "Sigla";
            dgvUF.Columns["ufe_nom"].HeaderText = "Nome";
            SetStatus();
        }

        #region Métodos
        private void SetStatus()
        {
            Status = new StatusLabel(STSStatus);
        }

        private void FilterDGV()
        {
            CamadaNegocios cn = new CamadaNegocios();
            string uf = txtUFSigla.Text;
            string nome = txtUFConsNome.Text;
            DataTable tb = cn.ObtemEstados().Tables[0];

            IEnumerable<DataRow> f = from l in tb.AsEnumerable()
                                     where l.Field<string>("UF") == uf || l.Field<string>("Nome") == nome
                                     select l;
            
        }
        #endregion

        #region ToolStripUF
        private void TSBUFAdd_Click(object sender, EventArgs e)
        {
            Estado uf = new Estado(txtUFSigla.Text, txtUFNome.Text);
            if(uf.Nome.Trim().Length == 0)
            {
                txtUFNome.Focus();
                return;
            }
            if (uf.Sigla.Trim().Length == 0)
            {
                txtUFSigla.Focus();
                return;
            }
            try
            {
                CamadaNegocios cn = new CamadaNegocios();
                
                Status.Set($"Adicionando Estado: {uf.Sigla} - {uf.Nome}", StatusType.INFO);
                cn.AddEstado(uf);
                Status.Set($"Adicionado com sucesso: {uf.Sigla} - {uf.Nome}", StatusType.OK);
                
            }
            catch(OleDbException ex)
            {
                MessageBox.Show($"Estado já cadastrado! {ex.Message}", "Cadastrod de Estado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,MessageBoxOptions.ServiceNotification,true);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cadastro Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Erro na adição do estado: {uf.Sigla} {uf.Nome}", StatusType.ERROR);
            }
        }

        private void TSBUFSalvar_Click(object sender, EventArgs e)
        {
            Estado uf = new Estado(txtUFSigla.Text, txtUFNome.Text);
            if (txtUFNome.Text.Trim().Length == 0)
            {
                MessageBox.Show("Nome precisa ser preenchido", "Cadastro Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EPUF.SetError(txtUFNome, "Nome precisa ser preenchido");
                return;
            }
            else if(txtUFSigla.Text.Trim().Length == 0)
            {
                MessageBox.Show("Sigla precisa estar preenchida", "Cadastro Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EPUF.SetError(txtUFSigla, "Sigla precisa ser preenchida");
                return;
            }
            CamadaNegocios cn = new CamadaNegocios();
            try
            {
                if (cn.ObtemEstado(uf).Tables[0].Rows.Count > 0)
                {
                    Status.Set("Atualizando Estado", StatusType.INFO);
                    cn.UpdateEstado(uf);
                    Status.Set("Atualizado com sucesso", StatusType.OK);
                }
                else
                {
                    Status.Set("Estado não cadastrado", StatusType.ERROR);
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message, "Cadastrod de Estado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, true);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Cadastro Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set("Erro na adição /atualização", StatusType.ERROR);
            }
        }
        private void TSBUFDelete_Click(object sender, EventArgs e)
        {
            Estado uf = new Estado(txtUFSigla.Text, txtUFNome.Text);
            CamadaNegocios cn = new CamadaNegocios();
            try
            {
                Status.Set("Excluindo Estado", StatusType.INFO);
                cn.DeleteEstado(uf);
                Status.Set("Excluido com sucesso", StatusType.OK);
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

        #region PageCadastro
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

        private void txtUFNome_Validating(object sender, CancelEventArgs e)
        {
            if (txtUFNome.Text.Trim().Length == 0)
            {
                EPUF.SetError(txtUFNome, "O nome não pode estar em branco");
                e.Cancel = true;
            }
            else if (!Valida.Nome(txtUFNome.Text, 50))
            {
                EPUF.SetError(txtUFNome, "Apenas letras, espaços e ponto(.) no nome do estado");
                e.Cancel = true;
            }
        }
        private void txtUFNome_Validated(object sender, EventArgs e)
        {
            EPUF.SetError(txtUFNome, "");
        }

        private void txtUFSigla_Validating(object sender, CancelEventArgs e)
        {
            if(!Valida.Sigla(txtUFSigla.Text, 2, space: false, punctuation: false, digit: false))
            {
                EPUF.SetError(txtUFSigla, "Mínimo 1 e no máximo 2 letras");
                e.Cancel = true;
            }
        }
        private void txtUFSigla_Validated(object sender, EventArgs e)
        {
            EPUF.SetError(txtUFSigla, "");
        }

        #endregion

        #region PageConsulta
        private void btnUFPesq_Click(object sender, EventArgs e)
        {
            CamadaNegocios cn = new CamadaNegocios();
            Estado uf = new Estado(nome: txtUFConsNome.Text);
            dgvUF.DataSource = cn.AllEstados();
        }

        private void dgvUF_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUFSigla.Text = dgvUF.CurrentRow.Cells["ufe_sig"].Value.ToString();
            txtUFNome.Text = dgvUF.CurrentRow.Cells["ufe_nom"].Value.ToString();
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

    }
}
