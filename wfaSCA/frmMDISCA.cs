using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSCA
{
    public partial class FrmMDISCA : Form
    {
        private int childFormNumber = 0;

        public FrmMDISCA()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlunos objAluno = new FrmAlunos();
            objAluno.ShowDialog();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartamento objDepto = new FrmDepartamento();
            objDepto.ShowDialog();
        }

        private void esrtadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstados objEst = new FrmEstados();
            objEst.ShowDialog();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDisciplinas objDisp = new FrmDisciplinas();
            objDisp.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCursos objCur = new FrmCursos();
            objCur.ShowDialog();   
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmMatriculas objMat = new FrmMatriculas();
            objMat.ShowDialog();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHistorico objHist = new FrmHistorico();
            objHist.ShowDialog();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConceito objConc = new FrmConceito();
            objConc.ShowDialog();
        }
    }
}
