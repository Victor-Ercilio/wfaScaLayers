namespace wfaSCA
{
    partial class FrmAlunos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlunos));
            this.lblAluMat = new System.Windows.Forms.Label();
            this.txtAluMat = new System.Windows.Forms.TextBox();
            this.grpAluSexo = new System.Windows.Forms.GroupBox();
            this.rdbAluSexOutro = new System.Windows.Forms.RadioButton();
            this.rdbAluSexMasc = new System.Windows.Forms.RadioButton();
            this.rdbAluSexFem = new System.Windows.Forms.RadioButton();
            this.grpAluEnd = new System.Windows.Forms.GroupBox();
            this.nroEndNro = new System.Windows.Forms.NumericUpDown();
            this.mskEndCEP = new System.Windows.Forms.MaskedTextBox();
            this.cmbAluEndUF = new System.Windows.Forms.ComboBox();
            this.lblAluEndUF = new System.Windows.Forms.Label();
            this.txtAluEndMun = new System.Windows.Forms.TextBox();
            this.lblAluEndMun = new System.Windows.Forms.Label();
            this.txtAluEndBairro = new System.Windows.Forms.TextBox();
            this.lblAluEndBairro = new System.Windows.Forms.Label();
            this.txtAluEndComplt = new System.Windows.Forms.TextBox();
            this.lblAluEndComplt = new System.Windows.Forms.Label();
            this.lblEndNro = new System.Windows.Forms.Label();
            this.txtAluEnd = new System.Windows.Forms.TextBox();
            this.lblAluEnd = new System.Windows.Forms.Label();
            this.txtAluEndLogra = new System.Windows.Forms.TextBox();
            this.lblAluEndLogra = new System.Windows.Forms.Label();
            this.lblAluEndCEP = new System.Windows.Forms.Label();
            this.txtAluNome = new System.Windows.Forms.TextBox();
            this.lblAluNome = new System.Windows.Forms.Label();
            this.lblAluDtNsc = new System.Windows.Forms.Label();
            this.lblAluCurso = new System.Windows.Forms.Label();
            this.lblAluIngresso = new System.Windows.Forms.Label();
            this.TCAlu = new System.Windows.Forms.TabControl();
            this.pgCad = new System.Windows.Forms.TabPage();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskDtNsc = new System.Windows.Forms.MaskedTextBox();
            this.mskIng = new System.Windows.Forms.MaskedTextBox();
            this.lblAluEmail = new System.Windows.Forms.Label();
            this.lblAluCPF = new System.Windows.Forms.Label();
            this.txtAluEmail = new System.Windows.Forms.TextBox();
            this.pgCons = new System.Windows.Forms.TabPage();
            this.btnPesq = new System.Windows.Forms.Button();
            this.txtConsNome = new System.Windows.Forms.TextBox();
            this.lblConsNome = new System.Windows.Forms.Label();
            this.txtConsMat = new System.Windows.Forms.TextBox();
            this.lblConsMat = new System.Windows.Forms.Label();
            this.dgvAlu = new System.Windows.Forms.DataGridView();
            this.STSAlu = new System.Windows.Forms.StatusStrip();
            this.STSlblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSAlu = new System.Windows.Forms.ToolStrip();
            this.TSbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.TSbtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.TSbtnClean = new System.Windows.Forms.ToolStripButton();
            this.TSbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.EPAlu = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpAluSexo.SuspendLayout();
            this.grpAluEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nroEndNro)).BeginInit();
            this.TCAlu.SuspendLayout();
            this.pgCad.SuspendLayout();
            this.pgCons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlu)).BeginInit();
            this.STSAlu.SuspendLayout();
            this.TSAlu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPAlu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAluMat
            // 
            this.lblAluMat.AutoSize = true;
            this.lblAluMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluMat.ForeColor = System.Drawing.Color.Blue;
            this.lblAluMat.Location = new System.Drawing.Point(19, 7);
            this.lblAluMat.Name = "lblAluMat";
            this.lblAluMat.Size = new System.Drawing.Size(65, 17);
            this.lblAluMat.TabIndex = 0;
            this.lblAluMat.Text = "Matrícula";
            // 
            // txtAluMat
            // 
            this.txtAluMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAluMat.Location = new System.Drawing.Point(19, 33);
            this.txtAluMat.MaxLength = 10;
            this.txtAluMat.Name = "txtAluMat";
            this.txtAluMat.Size = new System.Drawing.Size(141, 23);
            this.txtAluMat.TabIndex = 1;
            this.txtAluMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAluMat_KeyPress);
            this.txtAluMat.Validating += new System.ComponentModel.CancelEventHandler(this.txtAluMat_Validating);
            this.txtAluMat.Validated += new System.EventHandler(this.txtAluMat_Validated);
            // 
            // grpAluSexo
            // 
            this.grpAluSexo.Controls.Add(this.rdbAluSexOutro);
            this.grpAluSexo.Controls.Add(this.rdbAluSexMasc);
            this.grpAluSexo.Controls.Add(this.rdbAluSexFem);
            this.grpAluSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAluSexo.ForeColor = System.Drawing.Color.Blue;
            this.grpAluSexo.Location = new System.Drawing.Point(20, 70);
            this.grpAluSexo.Name = "grpAluSexo";
            this.grpAluSexo.Size = new System.Drawing.Size(140, 122);
            this.grpAluSexo.TabIndex = 3;
            this.grpAluSexo.TabStop = false;
            this.grpAluSexo.Text = "Sexo";
            // 
            // rdbAluSexOutro
            // 
            this.rdbAluSexOutro.AutoSize = true;
            this.rdbAluSexOutro.Location = new System.Drawing.Point(12, 84);
            this.rdbAluSexOutro.Name = "rdbAluSexOutro";
            this.rdbAluSexOutro.Size = new System.Drawing.Size(69, 21);
            this.rdbAluSexOutro.TabIndex = 6;
            this.rdbAluSexOutro.Text = "Outros";
            this.rdbAluSexOutro.UseVisualStyleBackColor = true;
            // 
            // rdbAluSexMasc
            // 
            this.rdbAluSexMasc.AutoSize = true;
            this.rdbAluSexMasc.Location = new System.Drawing.Point(12, 57);
            this.rdbAluSexMasc.Name = "rdbAluSexMasc";
            this.rdbAluSexMasc.Size = new System.Drawing.Size(89, 21);
            this.rdbAluSexMasc.TabIndex = 5;
            this.rdbAluSexMasc.Text = "Masculino";
            this.rdbAluSexMasc.UseVisualStyleBackColor = true;
            // 
            // rdbAluSexFem
            // 
            this.rdbAluSexFem.AutoSize = true;
            this.rdbAluSexFem.Checked = true;
            this.rdbAluSexFem.Location = new System.Drawing.Point(12, 30);
            this.rdbAluSexFem.Name = "rdbAluSexFem";
            this.rdbAluSexFem.Size = new System.Drawing.Size(83, 21);
            this.rdbAluSexFem.TabIndex = 4;
            this.rdbAluSexFem.TabStop = true;
            this.rdbAluSexFem.Text = "Feminino";
            this.rdbAluSexFem.UseVisualStyleBackColor = true;
            // 
            // grpAluEnd
            // 
            this.grpAluEnd.Controls.Add(this.nroEndNro);
            this.grpAluEnd.Controls.Add(this.mskEndCEP);
            this.grpAluEnd.Controls.Add(this.cmbAluEndUF);
            this.grpAluEnd.Controls.Add(this.lblAluEndUF);
            this.grpAluEnd.Controls.Add(this.txtAluEndMun);
            this.grpAluEnd.Controls.Add(this.lblAluEndMun);
            this.grpAluEnd.Controls.Add(this.txtAluEndBairro);
            this.grpAluEnd.Controls.Add(this.lblAluEndBairro);
            this.grpAluEnd.Controls.Add(this.txtAluEndComplt);
            this.grpAluEnd.Controls.Add(this.lblAluEndComplt);
            this.grpAluEnd.Controls.Add(this.lblEndNro);
            this.grpAluEnd.Controls.Add(this.txtAluEnd);
            this.grpAluEnd.Controls.Add(this.lblAluEnd);
            this.grpAluEnd.Controls.Add(this.txtAluEndLogra);
            this.grpAluEnd.Controls.Add(this.lblAluEndLogra);
            this.grpAluEnd.Controls.Add(this.lblAluEndCEP);
            this.grpAluEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAluEnd.ForeColor = System.Drawing.Color.Blue;
            this.grpAluEnd.Location = new System.Drawing.Point(22, 208);
            this.grpAluEnd.Name = "grpAluEnd";
            this.grpAluEnd.Size = new System.Drawing.Size(621, 259);
            this.grpAluEnd.TabIndex = 3;
            this.grpAluEnd.TabStop = false;
            this.grpAluEnd.Text = "Endereço";
            // 
            // nroEndNro
            // 
            this.nroEndNro.Location = new System.Drawing.Point(519, 108);
            this.nroEndNro.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nroEndNro.Name = "nroEndNro";
            this.nroEndNro.Size = new System.Drawing.Size(86, 23);
            this.nroEndNro.TabIndex = 15;
            this.nroEndNro.Validating += new System.ComponentModel.CancelEventHandler(this.nroEndNro_Validating);
            this.nroEndNro.Validated += new System.EventHandler(this.nroEndNro_Validated);
            // 
            // mskEndCEP
            // 
            this.mskEndCEP.Location = new System.Drawing.Point(17, 47);
            this.mskEndCEP.Mask = "00000-000";
            this.mskEndCEP.Name = "mskEndCEP";
            this.mskEndCEP.Size = new System.Drawing.Size(100, 23);
            this.mskEndCEP.TabIndex = 12;
            this.mskEndCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskEndCEP.ValidatingType = typeof(System.DateTime);
            this.mskEndCEP.Validating += new System.ComponentModel.CancelEventHandler(this.mskEndCEP_Validating);
            this.mskEndCEP.Validated += new System.EventHandler(this.mskEndCEP_Validated);
            // 
            // cmbAluEndUF
            // 
            this.cmbAluEndUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAluEndUF.DropDownHeight = 80;
            this.cmbAluEndUF.FormattingEnabled = true;
            this.cmbAluEndUF.IntegralHeight = false;
            this.cmbAluEndUF.ItemHeight = 16;
            this.cmbAluEndUF.Location = new System.Drawing.Point(484, 227);
            this.cmbAluEndUF.MaxDropDownItems = 5;
            this.cmbAluEndUF.Name = "cmbAluEndUF";
            this.cmbAluEndUF.Size = new System.Drawing.Size(121, 24);
            this.cmbAluEndUF.Sorted = true;
            this.cmbAluEndUF.TabIndex = 19;
            this.cmbAluEndUF.Validating += new System.ComponentModel.CancelEventHandler(this.cmbAluEndUF_Validating);
            this.cmbAluEndUF.Validated += new System.EventHandler(this.cmbAluEndUF_Validated);
            // 
            // lblAluEndUF
            // 
            this.lblAluEndUF.AutoSize = true;
            this.lblAluEndUF.Location = new System.Drawing.Point(481, 205);
            this.lblAluEndUF.Name = "lblAluEndUF";
            this.lblAluEndUF.Size = new System.Drawing.Size(52, 17);
            this.lblAluEndUF.TabIndex = 26;
            this.lblAluEndUF.Text = "Estado";
            // 
            // txtAluEndMun
            // 
            this.txtAluEndMun.Location = new System.Drawing.Point(17, 227);
            this.txtAluEndMun.MaxLength = 70;
            this.txtAluEndMun.Name = "txtAluEndMun";
            this.txtAluEndMun.Size = new System.Drawing.Size(446, 23);
            this.txtAluEndMun.TabIndex = 18;
            this.txtAluEndMun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAluEndMun_KeyPress);
            this.txtAluEndMun.Validating += new System.ComponentModel.CancelEventHandler(this.txtAluEndMun_Validating);
            this.txtAluEndMun.Validated += new System.EventHandler(this.txtAluEndMun_Validated);
            // 
            // lblAluEndMun
            // 
            this.lblAluEndMun.AutoSize = true;
            this.lblAluEndMun.Location = new System.Drawing.Point(14, 205);
            this.lblAluEndMun.Name = "lblAluEndMun";
            this.lblAluEndMun.Size = new System.Drawing.Size(67, 17);
            this.lblAluEndMun.TabIndex = 24;
            this.lblAluEndMun.Text = "Município";
            // 
            // txtAluEndBairro
            // 
            this.txtAluEndBairro.Location = new System.Drawing.Point(140, 171);
            this.txtAluEndBairro.MaxLength = 70;
            this.txtAluEndBairro.Name = "txtAluEndBairro";
            this.txtAluEndBairro.Size = new System.Drawing.Size(465, 23);
            this.txtAluEndBairro.TabIndex = 17;
            this.txtAluEndBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAluEndBairro_KeyPress);
            this.txtAluEndBairro.Validating += new System.ComponentModel.CancelEventHandler(this.txtAluEndBairro_Validating);
            this.txtAluEndBairro.Validated += new System.EventHandler(this.txtAluEndBairro_Validated);
            // 
            // lblAluEndBairro
            // 
            this.lblAluEndBairro.AutoSize = true;
            this.lblAluEndBairro.Location = new System.Drawing.Point(137, 149);
            this.lblAluEndBairro.Name = "lblAluEndBairro";
            this.lblAluEndBairro.Size = new System.Drawing.Size(46, 17);
            this.lblAluEndBairro.TabIndex = 22;
            this.lblAluEndBairro.Text = "Bairro";
            // 
            // txtAluEndComplt
            // 
            this.txtAluEndComplt.Location = new System.Drawing.Point(17, 171);
            this.txtAluEndComplt.MaxLength = 20;
            this.txtAluEndComplt.Name = "txtAluEndComplt";
            this.txtAluEndComplt.Size = new System.Drawing.Size(100, 23);
            this.txtAluEndComplt.TabIndex = 16;
            this.txtAluEndComplt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAluEndComplt_KeyPress);
            this.txtAluEndComplt.Validating += new System.ComponentModel.CancelEventHandler(this.txtAluEndComplt_Validating);
            this.txtAluEndComplt.Validated += new System.EventHandler(this.txtAluEndComplt_Validated);
            // 
            // lblAluEndComplt
            // 
            this.lblAluEndComplt.AutoSize = true;
            this.lblAluEndComplt.Location = new System.Drawing.Point(14, 149);
            this.lblAluEndComplt.Name = "lblAluEndComplt";
            this.lblAluEndComplt.Size = new System.Drawing.Size(94, 17);
            this.lblAluEndComplt.TabIndex = 20;
            this.lblAluEndComplt.Text = "Complemento";
            // 
            // lblEndNro
            // 
            this.lblEndNro.AutoSize = true;
            this.lblEndNro.Location = new System.Drawing.Point(516, 85);
            this.lblEndNro.Name = "lblEndNro";
            this.lblEndNro.Size = new System.Drawing.Size(58, 17);
            this.lblEndNro.TabIndex = 18;
            this.lblEndNro.Text = "Numero";
            // 
            // txtAluEnd
            // 
            this.txtAluEnd.Location = new System.Drawing.Point(140, 107);
            this.txtAluEnd.MaxLength = 70;
            this.txtAluEnd.Name = "txtAluEnd";
            this.txtAluEnd.Size = new System.Drawing.Size(364, 23);
            this.txtAluEnd.TabIndex = 14;
            this.txtAluEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAluEnd_KeyPress);
            this.txtAluEnd.Validating += new System.ComponentModel.CancelEventHandler(this.txtAluEnd_Validating);
            this.txtAluEnd.Validated += new System.EventHandler(this.txtAluEnd_Validated);
            // 
            // lblAluEnd
            // 
            this.lblAluEnd.AutoSize = true;
            this.lblAluEnd.Location = new System.Drawing.Point(137, 85);
            this.lblAluEnd.Name = "lblAluEnd";
            this.lblAluEnd.Size = new System.Drawing.Size(69, 17);
            this.lblAluEnd.TabIndex = 16;
            this.lblAluEnd.Text = "Endereço";
            // 
            // txtAluEndLogra
            // 
            this.txtAluEndLogra.Location = new System.Drawing.Point(17, 107);
            this.txtAluEndLogra.MaxLength = 10;
            this.txtAluEndLogra.Name = "txtAluEndLogra";
            this.txtAluEndLogra.Size = new System.Drawing.Size(100, 23);
            this.txtAluEndLogra.TabIndex = 13;
            this.txtAluEndLogra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAluEndLogra_KeyPress);
            this.txtAluEndLogra.Validating += new System.ComponentModel.CancelEventHandler(this.txtAluEndLogra_Validating);
            this.txtAluEndLogra.Validated += new System.EventHandler(this.txtAluEndLogra_Validated);
            // 
            // lblAluEndLogra
            // 
            this.lblAluEndLogra.AutoSize = true;
            this.lblAluEndLogra.Location = new System.Drawing.Point(14, 85);
            this.lblAluEndLogra.Name = "lblAluEndLogra";
            this.lblAluEndLogra.Size = new System.Drawing.Size(82, 17);
            this.lblAluEndLogra.TabIndex = 14;
            this.lblAluEndLogra.Text = "Logradouro";
            // 
            // lblAluEndCEP
            // 
            this.lblAluEndCEP.AutoSize = true;
            this.lblAluEndCEP.Location = new System.Drawing.Point(14, 27);
            this.lblAluEndCEP.Name = "lblAluEndCEP";
            this.lblAluEndCEP.Size = new System.Drawing.Size(35, 17);
            this.lblAluEndCEP.TabIndex = 12;
            this.lblAluEndCEP.Text = "CEP";
            // 
            // txtAluNome
            // 
            this.txtAluNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAluNome.Location = new System.Drawing.Point(186, 33);
            this.txtAluNome.MaxLength = 70;
            this.txtAluNome.Name = "txtAluNome";
            this.txtAluNome.Size = new System.Drawing.Size(455, 23);
            this.txtAluNome.TabIndex = 2;
            this.txtAluNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAluNome_KeyPress);
            this.txtAluNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtAluNome_Validating);
            this.txtAluNome.Validated += new System.EventHandler(this.txtAluNome_Validated);
            // 
            // lblAluNome
            // 
            this.lblAluNome.AutoSize = true;
            this.lblAluNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluNome.ForeColor = System.Drawing.Color.Blue;
            this.lblAluNome.Location = new System.Drawing.Point(183, 7);
            this.lblAluNome.Name = "lblAluNome";
            this.lblAluNome.Size = new System.Drawing.Size(45, 17);
            this.lblAluNome.TabIndex = 4;
            this.lblAluNome.Text = "Nome";
            // 
            // lblAluDtNsc
            // 
            this.lblAluDtNsc.AutoSize = true;
            this.lblAluDtNsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluDtNsc.ForeColor = System.Drawing.Color.Blue;
            this.lblAluDtNsc.Location = new System.Drawing.Point(183, 126);
            this.lblAluDtNsc.Name = "lblAluDtNsc";
            this.lblAluDtNsc.Size = new System.Drawing.Size(78, 17);
            this.lblAluDtNsc.TabIndex = 6;
            this.lblAluDtNsc.Text = "Data Nasc.";
            // 
            // lblAluCurso
            // 
            this.lblAluCurso.AutoSize = true;
            this.lblAluCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluCurso.ForeColor = System.Drawing.Color.Blue;
            this.lblAluCurso.Location = new System.Drawing.Point(283, 127);
            this.lblAluCurso.Name = "lblAluCurso";
            this.lblAluCurso.Size = new System.Drawing.Size(45, 17);
            this.lblAluCurso.TabIndex = 8;
            this.lblAluCurso.Text = "Curso";
            // 
            // lblAluIngresso
            // 
            this.lblAluIngresso.AutoSize = true;
            this.lblAluIngresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluIngresso.ForeColor = System.Drawing.Color.Blue;
            this.lblAluIngresso.Location = new System.Drawing.Point(413, 126);
            this.lblAluIngresso.Name = "lblAluIngresso";
            this.lblAluIngresso.Size = new System.Drawing.Size(62, 17);
            this.lblAluIngresso.TabIndex = 10;
            this.lblAluIngresso.Text = "Ingresso";
            // 
            // TCAlu
            // 
            this.TCAlu.Controls.Add(this.pgCad);
            this.TCAlu.Controls.Add(this.pgCons);
            this.TCAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCAlu.Location = new System.Drawing.Point(12, 28);
            this.TCAlu.Name = "TCAlu";
            this.TCAlu.SelectedIndex = 0;
            this.TCAlu.Size = new System.Drawing.Size(689, 504);
            this.TCAlu.TabIndex = 12;
            this.TCAlu.SelectedIndexChanged += new System.EventHandler(this.TCAlu_SelectedIndexChanged);
            // 
            // pgCad
            // 
            this.pgCad.Controls.Add(this.cmbCurso);
            this.pgCad.Controls.Add(this.mskCPF);
            this.pgCad.Controls.Add(this.mskDtNsc);
            this.pgCad.Controls.Add(this.mskIng);
            this.pgCad.Controls.Add(this.txtAluMat);
            this.pgCad.Controls.Add(this.lblAluMat);
            this.pgCad.Controls.Add(this.lblAluIngresso);
            this.pgCad.Controls.Add(this.grpAluSexo);
            this.pgCad.Controls.Add(this.grpAluEnd);
            this.pgCad.Controls.Add(this.lblAluCurso);
            this.pgCad.Controls.Add(this.lblAluEmail);
            this.pgCad.Controls.Add(this.lblAluNome);
            this.pgCad.Controls.Add(this.lblAluCPF);
            this.pgCad.Controls.Add(this.txtAluEmail);
            this.pgCad.Controls.Add(this.txtAluNome);
            this.pgCad.Controls.Add(this.lblAluDtNsc);
            this.pgCad.Location = new System.Drawing.Point(4, 25);
            this.pgCad.Name = "pgCad";
            this.pgCad.Padding = new System.Windows.Forms.Padding(3);
            this.pgCad.Size = new System.Drawing.Size(681, 475);
            this.pgCad.TabIndex = 0;
            this.pgCad.Text = "Cadastro";
            this.pgCad.UseVisualStyleBackColor = true;
            // 
            // cmbCurso
            // 
            this.cmbCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCurso.DropDownHeight = 80;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.IntegralHeight = false;
            this.cmbCurso.ItemHeight = 16;
            this.cmbCurso.Location = new System.Drawing.Point(286, 150);
            this.cmbCurso.MaxDropDownItems = 5;
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(115, 24);
            this.cmbCurso.Sorted = true;
            this.cmbCurso.TabIndex = 9;
            this.cmbCurso.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCurso_Validating);
            this.cmbCurso.Validated += new System.EventHandler(this.cmbCurso_Validated);
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(506, 148);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(100, 23);
            this.mskCPF.TabIndex = 11;
            this.mskCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCPF.ValidatingType = typeof(System.DateTime);
            this.mskCPF.Validating += new System.ComponentModel.CancelEventHandler(this.mskCPF_Validating);
            this.mskCPF.Validated += new System.EventHandler(this.mskCPF_Validated);
            // 
            // mskDtNsc
            // 
            this.mskDtNsc.Location = new System.Drawing.Point(186, 150);
            this.mskDtNsc.Mask = "00/00/0000";
            this.mskDtNsc.Name = "mskDtNsc";
            this.mskDtNsc.Size = new System.Drawing.Size(80, 23);
            this.mskDtNsc.TabIndex = 8;
            this.mskDtNsc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskDtNsc.ValidatingType = typeof(System.DateTime);
            this.mskDtNsc.Validating += new System.ComponentModel.CancelEventHandler(this.mskDtNsc_Validating);
            this.mskDtNsc.Validated += new System.EventHandler(this.mskDtNsc_Validated);
            // 
            // mskIng
            // 
            this.mskIng.Location = new System.Drawing.Point(416, 150);
            this.mskIng.Mask = "0000/0";
            this.mskIng.Name = "mskIng";
            this.mskIng.ReadOnly = true;
            this.mskIng.Size = new System.Drawing.Size(69, 23);
            this.mskIng.TabIndex = 10;
            this.mskIng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskIng.Validating += new System.ComponentModel.CancelEventHandler(this.mskIng_Validating);
            this.mskIng.Validated += new System.EventHandler(this.mskIng_Validated);
            // 
            // lblAluEmail
            // 
            this.lblAluEmail.AutoSize = true;
            this.lblAluEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluEmail.ForeColor = System.Drawing.Color.Blue;
            this.lblAluEmail.Location = new System.Drawing.Point(181, 89);
            this.lblAluEmail.Name = "lblAluEmail";
            this.lblAluEmail.Size = new System.Drawing.Size(46, 17);
            this.lblAluEmail.TabIndex = 4;
            this.lblAluEmail.Text = "Email:";
            // 
            // lblAluCPF
            // 
            this.lblAluCPF.AutoSize = true;
            this.lblAluCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluCPF.ForeColor = System.Drawing.Color.Blue;
            this.lblAluCPF.Location = new System.Drawing.Point(503, 124);
            this.lblAluCPF.Name = "lblAluCPF";
            this.lblAluCPF.Size = new System.Drawing.Size(34, 17);
            this.lblAluCPF.TabIndex = 6;
            this.lblAluCPF.Text = "CPF";
            // 
            // txtAluEmail
            // 
            this.txtAluEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAluEmail.Location = new System.Drawing.Point(228, 86);
            this.txtAluEmail.MaxLength = 70;
            this.txtAluEmail.Name = "txtAluEmail";
            this.txtAluEmail.Size = new System.Drawing.Size(413, 23);
            this.txtAluEmail.TabIndex = 7;
            this.txtAluEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAluEmail_KeyPress);
            this.txtAluEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtAluEmail_Validating);
            this.txtAluEmail.Validated += new System.EventHandler(this.txtAluEmail_Validated);
            // 
            // pgCons
            // 
            this.pgCons.Controls.Add(this.btnPesq);
            this.pgCons.Controls.Add(this.txtConsNome);
            this.pgCons.Controls.Add(this.lblConsNome);
            this.pgCons.Controls.Add(this.txtConsMat);
            this.pgCons.Controls.Add(this.lblConsMat);
            this.pgCons.Controls.Add(this.dgvAlu);
            this.pgCons.Location = new System.Drawing.Point(4, 25);
            this.pgCons.Name = "pgCons";
            this.pgCons.Padding = new System.Windows.Forms.Padding(3);
            this.pgCons.Size = new System.Drawing.Size(681, 475);
            this.pgCons.TabIndex = 1;
            this.pgCons.Text = "Consultar";
            this.pgCons.UseVisualStyleBackColor = true;
            // 
            // btnPesq
            // 
            this.btnPesq.ForeColor = System.Drawing.Color.Blue;
            this.btnPesq.Location = new System.Drawing.Point(564, 37);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(84, 33);
            this.btnPesq.TabIndex = 4;
            this.btnPesq.Text = "&Pesquisar";
            this.btnPesq.UseVisualStyleBackColor = true;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // txtConsNome
            // 
            this.txtConsNome.Location = new System.Drawing.Point(153, 42);
            this.txtConsNome.MaxLength = 70;
            this.txtConsNome.Name = "txtConsNome";
            this.txtConsNome.Size = new System.Drawing.Size(387, 23);
            this.txtConsNome.TabIndex = 3;
            this.txtConsNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtConsNome_Validating);
            this.txtConsNome.Validated += new System.EventHandler(this.txtConsNome_Validated);
            // 
            // lblConsNome
            // 
            this.lblConsNome.AutoSize = true;
            this.lblConsNome.ForeColor = System.Drawing.Color.Blue;
            this.lblConsNome.Location = new System.Drawing.Point(150, 22);
            this.lblConsNome.Name = "lblConsNome";
            this.lblConsNome.Size = new System.Drawing.Size(45, 17);
            this.lblConsNome.TabIndex = 1;
            this.lblConsNome.Text = "Nome";
            // 
            // txtConsMat
            // 
            this.txtConsMat.Location = new System.Drawing.Point(25, 42);
            this.txtConsMat.MaxLength = 10;
            this.txtConsMat.Name = "txtConsMat";
            this.txtConsMat.Size = new System.Drawing.Size(101, 23);
            this.txtConsMat.TabIndex = 2;
            this.txtConsMat.Validating += new System.ComponentModel.CancelEventHandler(this.txtConsMat_Validating);
            this.txtConsMat.Validated += new System.EventHandler(this.txtConsMat_Validated);
            // 
            // lblConsMat
            // 
            this.lblConsMat.AutoSize = true;
            this.lblConsMat.ForeColor = System.Drawing.Color.Blue;
            this.lblConsMat.Location = new System.Drawing.Point(22, 22);
            this.lblConsMat.Name = "lblConsMat";
            this.lblConsMat.Size = new System.Drawing.Size(65, 17);
            this.lblConsMat.TabIndex = 1;
            this.lblConsMat.Text = "Matricula";
            // 
            // dgvAlu
            // 
            this.dgvAlu.AllowUserToAddRows = false;
            this.dgvAlu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAlu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlu.Location = new System.Drawing.Point(16, 85);
            this.dgvAlu.Name = "dgvAlu";
            this.dgvAlu.ReadOnly = true;
            this.dgvAlu.Size = new System.Drawing.Size(647, 374);
            this.dgvAlu.TabIndex = 0;
            this.dgvAlu.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlu_CellDoubleClick);
            // 
            // STSAlu
            // 
            this.STSAlu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STSlblStatus});
            this.STSAlu.Location = new System.Drawing.Point(0, 551);
            this.STSAlu.Name = "STSAlu";
            this.STSAlu.Size = new System.Drawing.Size(713, 22);
            this.STSAlu.TabIndex = 13;
            this.STSAlu.Text = "statusStrip1";
            // 
            // STSlblStatus
            // 
            this.STSlblStatus.Name = "STSlblStatus";
            this.STSlblStatus.Size = new System.Drawing.Size(39, 17);
            this.STSlblStatus.Text = "Status";
            // 
            // TSAlu
            // 
            this.TSAlu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSbtnAdd,
            this.TSbtnUpdate,
            this.TSbtnClean,
            this.TSbtnDelete});
            this.TSAlu.Location = new System.Drawing.Point(0, 0);
            this.TSAlu.Name = "TSAlu";
            this.TSAlu.Size = new System.Drawing.Size(713, 25);
            this.TSAlu.TabIndex = 14;
            this.TSAlu.Text = "toolStrip1";
            // 
            // TSbtnAdd
            // 
            this.TSbtnAdd.Image = global::wfaSCA.Properties.Resources.new_file_png;
            this.TSbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtnAdd.Name = "TSbtnAdd";
            this.TSbtnAdd.Size = new System.Drawing.Size(78, 22);
            this.TSbtnAdd.Text = "&Adicionar";
            this.TSbtnAdd.Click += new System.EventHandler(this.TSbtnAdd_Click);
            // 
            // TSbtnUpdate
            // 
            this.TSbtnUpdate.Image = global::wfaSCA.Properties.Resources.save_png;
            this.TSbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtnUpdate.Name = "TSbtnUpdate";
            this.TSbtnUpdate.Size = new System.Drawing.Size(73, 22);
            this.TSbtnUpdate.Text = "A&tualizar";
            this.TSbtnUpdate.Click += new System.EventHandler(this.TSbtnUpdate_Click);
            // 
            // TSbtnClean
            // 
            this.TSbtnClean.Image = global::wfaSCA.Properties.Resources.erase;
            this.TSbtnClean.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtnClean.Name = "TSbtnClean";
            this.TSbtnClean.Size = new System.Drawing.Size(64, 22);
            this.TSbtnClean.Text = "&Limpar";
            this.TSbtnClean.Click += new System.EventHandler(this.TSbtnClean_Click);
            // 
            // TSbtnDelete
            // 
            this.TSbtnDelete.Image = global::wfaSCA.Properties.Resources.delete_png;
            this.TSbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtnDelete.Name = "TSbtnDelete";
            this.TSbtnDelete.Size = new System.Drawing.Size(62, 22);
            this.TSbtnDelete.Text = "&Excluir";
            this.TSbtnDelete.Click += new System.EventHandler(this.TSbtnDelete_Click);
            // 
            // EPAlu
            // 
            this.EPAlu.ContainerControl = this;
            // 
            // FrmAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 573);
            this.Controls.Add(this.TSAlu);
            this.Controls.Add(this.STSAlu);
            this.Controls.Add(this.TCAlu);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAlunos";
            this.Text = "A L U N O S";
            this.Load += new System.EventHandler(this.FrmAlunos_Load);
            this.grpAluSexo.ResumeLayout(false);
            this.grpAluSexo.PerformLayout();
            this.grpAluEnd.ResumeLayout(false);
            this.grpAluEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nroEndNro)).EndInit();
            this.TCAlu.ResumeLayout(false);
            this.pgCad.ResumeLayout(false);
            this.pgCad.PerformLayout();
            this.pgCons.ResumeLayout(false);
            this.pgCons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlu)).EndInit();
            this.STSAlu.ResumeLayout(false);
            this.STSAlu.PerformLayout();
            this.TSAlu.ResumeLayout(false);
            this.TSAlu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPAlu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAluMat;
        private System.Windows.Forms.TextBox txtAluMat;
        private System.Windows.Forms.GroupBox grpAluSexo;
        private System.Windows.Forms.RadioButton rdbAluSexFem;
        private System.Windows.Forms.RadioButton rdbAluSexOutro;
        private System.Windows.Forms.RadioButton rdbAluSexMasc;
        private System.Windows.Forms.GroupBox grpAluEnd;
        private System.Windows.Forms.ComboBox cmbAluEndUF;
        private System.Windows.Forms.Label lblAluEndUF;
        private System.Windows.Forms.TextBox txtAluEndMun;
        private System.Windows.Forms.Label lblAluEndMun;
        private System.Windows.Forms.TextBox txtAluEndBairro;
        private System.Windows.Forms.Label lblAluEndBairro;
        private System.Windows.Forms.TextBox txtAluEndComplt;
        private System.Windows.Forms.Label lblAluEndComplt;
        private System.Windows.Forms.Label lblEndNro;
        private System.Windows.Forms.TextBox txtAluEnd;
        private System.Windows.Forms.Label lblAluEnd;
        private System.Windows.Forms.TextBox txtAluEndLogra;
        private System.Windows.Forms.Label lblAluEndLogra;
        private System.Windows.Forms.Label lblAluEndCEP;
        private System.Windows.Forms.TextBox txtAluNome;
        private System.Windows.Forms.Label lblAluNome;
        private System.Windows.Forms.Label lblAluDtNsc;
        private System.Windows.Forms.Label lblAluCurso;
        private System.Windows.Forms.Label lblAluIngresso;
        private System.Windows.Forms.TabControl TCAlu;
        private System.Windows.Forms.TabPage pgCad;
        private System.Windows.Forms.TabPage pgCons;
        private System.Windows.Forms.StatusStrip STSAlu;
        private System.Windows.Forms.ToolStripStatusLabel STSlblStatus;
        private System.Windows.Forms.ToolStrip TSAlu;
        private System.Windows.Forms.ToolStripButton TSbtnAdd;
        private System.Windows.Forms.ToolStripButton TSbtnUpdate;
        private System.Windows.Forms.ToolStripButton TSbtnClean;
        private System.Windows.Forms.ToolStripButton TSbtnDelete;
        private System.Windows.Forms.MaskedTextBox mskIng;
        private System.Windows.Forms.ErrorProvider EPAlu;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.MaskedTextBox mskDtNsc;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.TextBox txtConsNome;
        private System.Windows.Forms.Label lblConsNome;
        private System.Windows.Forms.TextBox txtConsMat;
        private System.Windows.Forms.Label lblConsMat;
        private System.Windows.Forms.DataGridView dgvAlu;
        private System.Windows.Forms.NumericUpDown nroEndNro;
        private System.Windows.Forms.MaskedTextBox mskEndCEP;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblAluCPF;
        private System.Windows.Forms.Label lblAluEmail;
        private System.Windows.Forms.TextBox txtAluEmail;
    }
}

