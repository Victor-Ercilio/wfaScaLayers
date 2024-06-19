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
    public partial class FrmDepartamento : Form
    {
        private StatusLabel Status;
        public FrmDepartamento()
        {
            InitializeComponent();
        }
        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            CamadaNegocios cn = new CamadaNegocios();
            LoadDGV();
            ConfigDGV();
            Status = new StatusLabel(STSDeptoStatus);
        }

        #region Métodos

        private void LoadDGV()
        {
            CamadaNegocios cn = new CamadaNegocios();
            dgvDepto.DataSource = cn.ObtemDeptos().Tables[0];
        }

        private void ConfigDGV()
        {
            dgvDepto.Columns["dep_sgl"].HeaderText = "Sigla";
            dgvDepto.Columns["dep_nom"].HeaderText = "Nome";
            dgvDepto.Columns[1].Width = 400;
        }

        private void CleanError()
        {
            EPDepto.SetError(txtDeptoNome, "");
            EPDepto.SetError(txtDeptoSigla, "");
        }
        #endregion

        #region ToolStrip
        private void TSBNovo_Click(object sender, EventArgs e)
        {
            Departamento depto;
            CamadaNegocios cn = new CamadaNegocios();
            CleanError();
            try
            {
                depto = new Departamento(txtDeptoSigla.Text, txtDeptoNome.Text);
                Status.Set($"Adicionando: {depto.Sigla} - {depto.Nome}", StatusType.INFO);
                cn.AddDepto(depto);
                Status.Set($"Adicionado com sucesso: {depto.Sigla} - {depto.Nome}", StatusType.OK);
                LoadDGV();
            }
            catch (InvalidNameException err)
            {
                EPDepto.SetError(txtDeptoNome, err.Message);
                Status.Set($"Nome inválido", StatusType.ERROR);
            }
            catch (InvalidSiglaException err)
            {
                EPDepto.SetError(txtDeptoSigla, err.Message);
                Status.Set($"Sigla inválida", StatusType.ERROR);
            }
            catch(OleDbException err)
            {
                MessageBox.Show($"Departamento já cadastrado: {err.Message}", "Cadastro de Departamentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Status.Set($"Departamento já cadastrado", StatusType.ERROR);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Casdastro de Departamentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Erro no cadastramento", StatusType.ERROR);
            }
        }

        private void TSBSalvar_Click(object sender, EventArgs e)
        {
            Departamento depto;
            CamadaNegocios cn = new CamadaNegocios();
            CleanError();
            try
            {
                depto = new Departamento(txtDeptoSigla.Text, txtDeptoNome.Text);
                if (cn.ObtemDeptoPorSigla(depto.Sigla).Tables[0].Rows.Count > 0)
                {
                    Status.Set($"Atualizando departamento {depto.Sigla}", StatusType.INFO);
                    cn.UpdateDepto(depto);
                    Status.Set($"Atualizado com sucesso: {depto.Sigla} - {depto.Nome}", StatusType.OK);
                    LoadDGV();
                }
                else
                    Status.Set($"Departamento não cadastrado", StatusType.INFO);

            }
            catch (InvalidNameException err)
            {
                Status.Set($"Nome inválido", StatusType.INFO);
                EPDepto.SetError(txtDeptoNome, err.Message);
            }
            catch (InvalidSiglaException err)
            {
                Status.Set($"Sigla inválida", StatusType.INFO);
                EPDepto.SetError(txtDeptoSigla,  err.Message);
            }
            catch (OleDbException err)
            {
                MessageBox.Show($"Falha na atualização: {err.Message}", "Cadastro de Departamentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Status.Set($"Falha na atualização", StatusType.ERROR);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Casdastro de Departamentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Erro inesperado", StatusType.ERROR);
            }
        }

        private void TSBLimpar_Click(object sender, EventArgs e)
        {
            txtDeptoSigla.Text = "";
            txtDeptoNome.Text = "";
            CleanError();
        }
        private void TSBDelete_Click(object sender, EventArgs e)
        {
            Departamento depto;
            CamadaNegocios cn = new CamadaNegocios();
            try
            {
                depto = new Departamento(txtDeptoSigla.Text, txtDeptoNome.Text);
                if (MessageBox.Show($"Deseja ralmente excluir o Depto. {depto.Sigla}?", "Cadastro de Departamentos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.DeleteDepto(depto);
                    Status.Set($"Depto. excluído com sucesso: {depto.Nome}", StatusType.OK);
                }
                else
                    Status.Set($"Exclusão cancelada", StatusType.INFO);
            }
            catch (InvalidNameException err)
            {
                Status.Set($"Nome inválido", StatusType.INFO);
                EPDepto.SetError(txtDeptoNome, err.Message);
            }
            catch (InvalidSiglaException err)
            {
                Status.Set($"Sigla inválida", StatusType.INFO);
                EPDepto.SetError(txtDeptoSigla, err.Message);
            }
            catch (OleDbException err)
            {
                MessageBox.Show($"Departamento não pode ser excluído! {err.Message}", "Casdastro de Departamentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Departamento não pode ser excluído", StatusType.INFO);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Casdastro de Departamentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Status.Set($"Falha na exclusão", StatusType.ERROR);
            }
        }
        #endregion

        #region Main
        private void btnDeptoPesq_Click(object sender, EventArgs e)
        {
            CamadaNegocios cn = new CamadaNegocios();
            
            if (txtDeptoNome.Text != "")
            {
                Status.Set($"Pesquisando pelo nome... {txtDeptoNome.Text}", StatusType.INFO);
                dgvDepto.DataSource = cn.ObtemDeptoPorNome(txtDeptoNome.Text).Tables[0];
                Status.Set($"Pesquisa realizada! Resultados para o nome: {txtDeptoNome.Text}", StatusType.INFO);
            }
            else if(txtDeptoSigla.Text != "")
            {
                Status.Set($"Pesquisando pela sigla... {txtDeptoSigla.Text}", StatusType.INFO);
                dgvDepto.DataSource = cn.ObtemDeptoPorSigla(txtDeptoSigla.Text).Tables[0];
                Status.Set($"Pesquisa realizada! Resultados para a sigla: {txtDeptoSigla.Text}", StatusType.INFO);
            }
            else
            {
                dgvDepto.DataSource = cn.ObtemDeptos().Tables[0];
                Status.Set($"Tabela departametnos atualizada!", StatusType.INFO);
            }
        }


        private void dgvDepto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDeptoSigla.Text = dgvDepto.CurrentRow.Cells["dep_sgl"].Value.ToString();
            txtDeptoNome.Text = dgvDepto.CurrentRow.Cells["dep_nom"].Value.ToString();
            txtDeptoNome.Focus();
        }

        #region Validando
        private void txtDeptoSigla_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtDeptoSigla_Validating(object sender, CancelEventArgs e)
        {
            if (!Valida.Sigla(txtDeptoSigla.Text, 10))
            {
                EPDepto.SetError(txtDeptoSigla, "Sigla é obrigatório. Máximo 10 letras");
                return;
            }
        }
        private void txtDeptoNome_Validating(object sender, CancelEventArgs e)
        {
            if(!Valida.Nome(txtDeptoNome.Text, 70))
            {
                EPDepto.SetError(txtDeptoNome, "Nome é obrigatório. Máximo 70 letras");
                return;
            }
        }
        #endregion

        #region Valido
        private void txtDeptoSigla_Validated(object sender, EventArgs e)
        {
            EPDepto.SetError(txtDeptoSigla, "");
        }

        private void txtDeptoNome_Validated(object sender, EventArgs e)
        {
            EPDepto.SetError(txtDeptoNome, "");
        }
        #endregion

        #endregion
    }
}
