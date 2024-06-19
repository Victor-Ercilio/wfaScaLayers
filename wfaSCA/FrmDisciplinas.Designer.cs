namespace wfaSCA
{
    partial class FrmDisciplinas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDisciplinas));
            this.tbcDiscp = new System.Windows.Forms.TabControl();
            this.tbDiscpPgCad = new System.Windows.Forms.TabPage();
            this.numCadCod = new System.Windows.Forms.NumericUpDown();
            this.lblCadSglCur = new System.Windows.Forms.Label();
            this.numCrgaHr = new System.Windows.Forms.NumericUpDown();
            this.cmbCadCurso = new System.Windows.Forms.ComboBox();
            this.lblCadCargaHr = new System.Windows.Forms.Label();
            this.txtCadSigla = new System.Windows.Forms.TextBox();
            this.lblCadSigla = new System.Windows.Forms.Label();
            this.lblCadCod = new System.Windows.Forms.Label();
            this.txtCadNome = new System.Windows.Forms.TextBox();
            this.lblCadNome = new System.Windows.Forms.Label();
            this.tbDiscpPgConslt = new System.Windows.Forms.TabPage();
            this.numConsCod = new System.Windows.Forms.NumericUpDown();
            this.cmbConsCurso = new System.Windows.Forms.ComboBox();
            this.btnPesq = new System.Windows.Forms.Button();
            this.txtConsNome = new System.Windows.Forms.TextBox();
            this.lblConsNome = new System.Windows.Forms.Label();
            this.lblConsSglCurso = new System.Windows.Forms.Label();
            this.lblConsCod = new System.Windows.Forms.Label();
            this.dgvDisciplina = new System.Windows.Forms.DataGridView();
            this.STSDiscp = new System.Windows.Forms.StatusStrip();
            this.STSDiscpStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.EPDiscp = new System.Windows.Forms.ErrorProvider(this.components);
            this.TSDiscp = new System.Windows.Forms.ToolStrip();
            this.TSbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.TSbtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.TSbtnClear = new System.Windows.Forms.ToolStripButton();
            this.TSbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.tbcDiscp.SuspendLayout();
            this.tbDiscpPgCad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCadCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrgaHr)).BeginInit();
            this.tbDiscpPgConslt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConsCod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplina)).BeginInit();
            this.STSDiscp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPDiscp)).BeginInit();
            this.TSDiscp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcDiscp
            // 
            this.tbcDiscp.Controls.Add(this.tbDiscpPgCad);
            this.tbcDiscp.Controls.Add(this.tbDiscpPgConslt);
            this.tbcDiscp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcDiscp.Location = new System.Drawing.Point(12, 40);
            this.tbcDiscp.Name = "tbcDiscp";
            this.tbcDiscp.SelectedIndex = 0;
            this.tbcDiscp.Size = new System.Drawing.Size(626, 319);
            this.tbcDiscp.TabIndex = 0;
            this.tbcDiscp.Selected += new System.Windows.Forms.TabControlEventHandler(this.tbcDiscp_Selected);
            // 
            // tbDiscpPgCad
            // 
            this.tbDiscpPgCad.Controls.Add(this.numCadCod);
            this.tbDiscpPgCad.Controls.Add(this.lblCadSglCur);
            this.tbDiscpPgCad.Controls.Add(this.numCrgaHr);
            this.tbDiscpPgCad.Controls.Add(this.cmbCadCurso);
            this.tbDiscpPgCad.Controls.Add(this.lblCadCargaHr);
            this.tbDiscpPgCad.Controls.Add(this.txtCadSigla);
            this.tbDiscpPgCad.Controls.Add(this.lblCadSigla);
            this.tbDiscpPgCad.Controls.Add(this.lblCadCod);
            this.tbDiscpPgCad.Controls.Add(this.txtCadNome);
            this.tbDiscpPgCad.Controls.Add(this.lblCadNome);
            this.tbDiscpPgCad.Location = new System.Drawing.Point(4, 25);
            this.tbDiscpPgCad.Name = "tbDiscpPgCad";
            this.tbDiscpPgCad.Padding = new System.Windows.Forms.Padding(3);
            this.tbDiscpPgCad.Size = new System.Drawing.Size(618, 290);
            this.tbDiscpPgCad.TabIndex = 0;
            this.tbDiscpPgCad.Text = "Cadastrar";
            this.tbDiscpPgCad.UseVisualStyleBackColor = true;
            // 
            // numCadCod
            // 
            this.numCadCod.Location = new System.Drawing.Point(96, 57);
            this.numCadCod.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCadCod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCadCod.Name = "numCadCod";
            this.numCadCod.Size = new System.Drawing.Size(123, 23);
            this.numCadCod.TabIndex = 1;
            this.numCadCod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCadCod.Validating += new System.ComponentModel.CancelEventHandler(this.numCadCod_Validating);
            this.numCadCod.Validated += new System.EventHandler(this.numCadCod_Validated);
            // 
            // lblCadSglCur
            // 
            this.lblCadSglCur.AutoSize = true;
            this.lblCadSglCur.ForeColor = System.Drawing.Color.Blue;
            this.lblCadSglCur.Location = new System.Drawing.Point(37, 158);
            this.lblCadSglCur.Name = "lblCadSglCur";
            this.lblCadSglCur.Size = new System.Drawing.Size(53, 17);
            this.lblCadSglCur.TabIndex = 14;
            this.lblCadSglCur.Text = "Curso: ";
            // 
            // numCrgaHr
            // 
            this.numCrgaHr.Location = new System.Drawing.Point(361, 156);
            this.numCrgaHr.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numCrgaHr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCrgaHr.Name = "numCrgaHr";
            this.numCrgaHr.Size = new System.Drawing.Size(64, 23);
            this.numCrgaHr.TabIndex = 5;
            this.numCrgaHr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCrgaHr.Validating += new System.ComponentModel.CancelEventHandler(this.numCrgaHr_Validating);
            this.numCrgaHr.Validated += new System.EventHandler(this.numCrgaHr_Validated);
            // 
            // cmbCadCurso
            // 
            this.cmbCadCurso.FormattingEnabled = true;
            this.cmbCadCurso.Location = new System.Drawing.Point(96, 155);
            this.cmbCadCurso.Name = "cmbCadCurso";
            this.cmbCadCurso.Size = new System.Drawing.Size(121, 24);
            this.cmbCadCurso.Sorted = true;
            this.cmbCadCurso.TabIndex = 4;
            this.cmbCadCurso.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCadCurso_Validating);
            this.cmbCadCurso.Validated += new System.EventHandler(this.cmbCadCurso_Validated);
            // 
            // lblCadCargaHr
            // 
            this.lblCadCargaHr.AutoSize = true;
            this.lblCadCargaHr.ForeColor = System.Drawing.Color.Blue;
            this.lblCadCargaHr.Location = new System.Drawing.Point(252, 158);
            this.lblCadCargaHr.Name = "lblCadCargaHr";
            this.lblCadCargaHr.Size = new System.Drawing.Size(103, 17);
            this.lblCadCargaHr.TabIndex = 10;
            this.lblCadCargaHr.Text = "Carga horária: ";
            // 
            // txtCadSigla
            // 
            this.txtCadSigla.Location = new System.Drawing.Point(311, 56);
            this.txtCadSigla.MaxLength = 10;
            this.txtCadSigla.Name = "txtCadSigla";
            this.txtCadSigla.Size = new System.Drawing.Size(123, 23);
            this.txtCadSigla.TabIndex = 2;
            this.txtCadSigla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCadSigla_KeyPress);
            this.txtCadSigla.Validating += new System.ComponentModel.CancelEventHandler(this.txtCadSigla_Validating);
            this.txtCadSigla.Validated += new System.EventHandler(this.txtCadSigla_Validated);
            // 
            // lblCadSigla
            // 
            this.lblCadSigla.AutoSize = true;
            this.lblCadSigla.ForeColor = System.Drawing.Color.Blue;
            this.lblCadSigla.Location = new System.Drawing.Point(258, 59);
            this.lblCadSigla.Name = "lblCadSigla";
            this.lblCadSigla.Size = new System.Drawing.Size(47, 17);
            this.lblCadSigla.TabIndex = 8;
            this.lblCadSigla.Text = "Sigla: ";
            // 
            // lblCadCod
            // 
            this.lblCadCod.AutoSize = true;
            this.lblCadCod.ForeColor = System.Drawing.Color.Blue;
            this.lblCadCod.Location = new System.Drawing.Point(30, 59);
            this.lblCadCod.Name = "lblCadCod";
            this.lblCadCod.Size = new System.Drawing.Size(60, 17);
            this.lblCadCod.TabIndex = 6;
            this.lblCadCod.Text = "Código: ";
            // 
            // txtCadNome
            // 
            this.txtCadNome.Location = new System.Drawing.Point(96, 106);
            this.txtCadNome.MaxLength = 70;
            this.txtCadNome.Name = "txtCadNome";
            this.txtCadNome.Size = new System.Drawing.Size(474, 23);
            this.txtCadNome.TabIndex = 3;
            this.txtCadNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtCadNome_Validating);
            this.txtCadNome.Validated += new System.EventHandler(this.txtCadNome_Validated);
            // 
            // lblCadNome
            // 
            this.lblCadNome.AutoSize = true;
            this.lblCadNome.ForeColor = System.Drawing.Color.Blue;
            this.lblCadNome.Location = new System.Drawing.Point(36, 109);
            this.lblCadNome.Name = "lblCadNome";
            this.lblCadNome.Size = new System.Drawing.Size(53, 17);
            this.lblCadNome.TabIndex = 4;
            this.lblCadNome.Text = "Nome: ";
            // 
            // tbDiscpPgConslt
            // 
            this.tbDiscpPgConslt.Controls.Add(this.numConsCod);
            this.tbDiscpPgConslt.Controls.Add(this.cmbConsCurso);
            this.tbDiscpPgConslt.Controls.Add(this.btnPesq);
            this.tbDiscpPgConslt.Controls.Add(this.txtConsNome);
            this.tbDiscpPgConslt.Controls.Add(this.lblConsNome);
            this.tbDiscpPgConslt.Controls.Add(this.lblConsSglCurso);
            this.tbDiscpPgConslt.Controls.Add(this.lblConsCod);
            this.tbDiscpPgConslt.Controls.Add(this.dgvDisciplina);
            this.tbDiscpPgConslt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbDiscpPgConslt.Location = new System.Drawing.Point(4, 25);
            this.tbDiscpPgConslt.Name = "tbDiscpPgConslt";
            this.tbDiscpPgConslt.Padding = new System.Windows.Forms.Padding(3);
            this.tbDiscpPgConslt.Size = new System.Drawing.Size(618, 290);
            this.tbDiscpPgConslt.TabIndex = 1;
            this.tbDiscpPgConslt.Text = "Consulta";
            this.tbDiscpPgConslt.UseVisualStyleBackColor = true;
            // 
            // numConsCod
            // 
            this.numConsCod.Location = new System.Drawing.Point(70, 13);
            this.numConsCod.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numConsCod.Name = "numConsCod";
            this.numConsCod.Size = new System.Drawing.Size(119, 23);
            this.numConsCod.TabIndex = 6;
            this.numConsCod.Validating += new System.ComponentModel.CancelEventHandler(this.numConsCod_Validating);
            // 
            // cmbConsCurso
            // 
            this.cmbConsCurso.FormattingEnabled = true;
            this.cmbConsCurso.Location = new System.Drawing.Point(279, 12);
            this.cmbConsCurso.Name = "cmbConsCurso";
            this.cmbConsCurso.Size = new System.Drawing.Size(131, 24);
            this.cmbConsCurso.Sorted = true;
            this.cmbConsCurso.TabIndex = 7;
            this.cmbConsCurso.Validating += new System.ComponentModel.CancelEventHandler(this.cmbConsCurso_Validating);
            this.cmbConsCurso.Validated += new System.EventHandler(this.cmbConsCurso_Validated);
            // 
            // btnPesq
            // 
            this.btnPesq.ForeColor = System.Drawing.Color.Blue;
            this.btnPesq.Location = new System.Drawing.Point(493, 43);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(84, 32);
            this.btnPesq.TabIndex = 9;
            this.btnPesq.Text = "&Pesquisar";
            this.btnPesq.UseVisualStyleBackColor = true;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // txtConsNome
            // 
            this.txtConsNome.Location = new System.Drawing.Point(70, 47);
            this.txtConsNome.MaxLength = 70;
            this.txtConsNome.Name = "txtConsNome";
            this.txtConsNome.Size = new System.Drawing.Size(404, 23);
            this.txtConsNome.TabIndex = 8;
            this.txtConsNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtConsNome_Validating);
            this.txtConsNome.Validated += new System.EventHandler(this.txtConsNome_Validated);
            // 
            // lblConsNome
            // 
            this.lblConsNome.AutoSize = true;
            this.lblConsNome.ForeColor = System.Drawing.Color.Blue;
            this.lblConsNome.Location = new System.Drawing.Point(15, 50);
            this.lblConsNome.Name = "lblConsNome";
            this.lblConsNome.Size = new System.Drawing.Size(49, 17);
            this.lblConsNome.TabIndex = 5;
            this.lblConsNome.Text = "Nome:";
            // 
            // lblConsSglCurso
            // 
            this.lblConsSglCurso.AutoSize = true;
            this.lblConsSglCurso.ForeColor = System.Drawing.Color.Blue;
            this.lblConsSglCurso.Location = new System.Drawing.Point(224, 15);
            this.lblConsSglCurso.Name = "lblConsSglCurso";
            this.lblConsSglCurso.Size = new System.Drawing.Size(49, 17);
            this.lblConsSglCurso.TabIndex = 3;
            this.lblConsSglCurso.Text = "Curso:";
            // 
            // lblConsCod
            // 
            this.lblConsCod.AutoSize = true;
            this.lblConsCod.ForeColor = System.Drawing.Color.Blue;
            this.lblConsCod.Location = new System.Drawing.Point(8, 15);
            this.lblConsCod.Name = "lblConsCod";
            this.lblConsCod.Size = new System.Drawing.Size(56, 17);
            this.lblConsCod.TabIndex = 1;
            this.lblConsCod.Text = "Código:";
            // 
            // dgvDisciplina
            // 
            this.dgvDisciplina.AllowUserToAddRows = false;
            this.dgvDisciplina.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDisciplina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplina.Location = new System.Drawing.Point(8, 81);
            this.dgvDisciplina.Name = "dgvDisciplina";
            this.dgvDisciplina.ReadOnly = true;
            this.dgvDisciplina.Size = new System.Drawing.Size(604, 203);
            this.dgvDisciplina.TabIndex = 0;
            this.dgvDisciplina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisciplina_CellDoubleClick);
            // 
            // STSDiscp
            // 
            this.STSDiscp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STSDiscpStatus});
            this.STSDiscp.Location = new System.Drawing.Point(0, 373);
            this.STSDiscp.Name = "STSDiscp";
            this.STSDiscp.Size = new System.Drawing.Size(650, 22);
            this.STSDiscp.TabIndex = 1;
            this.STSDiscp.Text = "statusStrip1";
            // 
            // STSDiscpStatus
            // 
            this.STSDiscpStatus.Name = "STSDiscpStatus";
            this.STSDiscpStatus.Size = new System.Drawing.Size(39, 17);
            this.STSDiscpStatus.Text = "Status";
            // 
            // EPDiscp
            // 
            this.EPDiscp.ContainerControl = this;
            // 
            // TSDiscp
            // 
            this.TSDiscp.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TSDiscp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSbtnAdd,
            this.TSbtnUpdate,
            this.TSbtnClear,
            this.TSbtnDelete});
            this.TSDiscp.Location = new System.Drawing.Point(0, 0);
            this.TSDiscp.Name = "TSDiscp";
            this.TSDiscp.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.TSDiscp.Size = new System.Drawing.Size(650, 25);
            this.TSDiscp.TabIndex = 4;
            this.TSDiscp.Text = "toolStrip1";
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
            // TSbtnClear
            // 
            this.TSbtnClear.Image = global::wfaSCA.Properties.Resources.erase;
            this.TSbtnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtnClear.Name = "TSbtnClear";
            this.TSbtnClear.Size = new System.Drawing.Size(64, 22);
            this.TSbtnClear.Text = "&Limpar";
            this.TSbtnClear.Click += new System.EventHandler(this.TSbtnClear_Click);
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
            // FrmDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 395);
            this.Controls.Add(this.TSDiscp);
            this.Controls.Add(this.STSDiscp);
            this.Controls.Add(this.tbcDiscp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDisciplinas";
            this.Text = "DISCIPLINAS";
            this.Load += new System.EventHandler(this.FrmDisciplinas_Load);
            this.tbcDiscp.ResumeLayout(false);
            this.tbDiscpPgCad.ResumeLayout(false);
            this.tbDiscpPgCad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCadCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCrgaHr)).EndInit();
            this.tbDiscpPgConslt.ResumeLayout(false);
            this.tbDiscpPgConslt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numConsCod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplina)).EndInit();
            this.STSDiscp.ResumeLayout(false);
            this.STSDiscp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPDiscp)).EndInit();
            this.TSDiscp.ResumeLayout(false);
            this.TSDiscp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDiscp;
        private System.Windows.Forms.TabPage tbDiscpPgCad;
        private System.Windows.Forms.TabPage tbDiscpPgConslt;
        private System.Windows.Forms.StatusStrip STSDiscp;
        private System.Windows.Forms.ToolStripStatusLabel STSDiscpStatus;
        private System.Windows.Forms.TextBox txtCadNome;
        private System.Windows.Forms.Label lblCadNome;
        private System.Windows.Forms.ComboBox cmbCadCurso;
        private System.Windows.Forms.Label lblCadCargaHr;
        private System.Windows.Forms.TextBox txtCadSigla;
        private System.Windows.Forms.Label lblCadSigla;
        private System.Windows.Forms.Label lblCadCod;
        private System.Windows.Forms.ErrorProvider EPDiscp;
        private System.Windows.Forms.NumericUpDown numCrgaHr;
        private System.Windows.Forms.Label lblCadSglCur;
        private System.Windows.Forms.Label lblConsCod;
        private System.Windows.Forms.DataGridView dgvDisciplina;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.TextBox txtConsNome;
        private System.Windows.Forms.Label lblConsNome;
        private System.Windows.Forms.Label lblConsSglCurso;
        private System.Windows.Forms.ComboBox cmbConsCurso;
        private System.Windows.Forms.ToolStrip TSDiscp;
        private System.Windows.Forms.ToolStripButton TSbtnAdd;
        private System.Windows.Forms.ToolStripButton TSbtnUpdate;
        private System.Windows.Forms.ToolStripButton TSbtnClear;
        private System.Windows.Forms.ToolStripButton TSbtnDelete;
        private System.Windows.Forms.NumericUpDown numConsCod;
        private System.Windows.Forms.NumericUpDown numCadCod;
    }
}