namespace wfaSCA
{
    partial class FrmEstados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TSUF = new System.Windows.Forms.ToolStrip();
            this.TSBUFAdd = new System.Windows.Forms.ToolStripButton();
            this.TSBUFAtualiza = new System.Windows.Forms.ToolStripButton();
            this.TSBUFLimpar = new System.Windows.Forms.ToolStripButton();
            this.TSBUFDelete = new System.Windows.Forms.ToolStripButton();
            this.lblUFSigla = new System.Windows.Forms.Label();
            this.txtUFSigla = new System.Windows.Forms.TextBox();
            this.EPUF = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvUF = new System.Windows.Forms.DataGridView();
            this.txtUFNome = new System.Windows.Forms.TextBox();
            this.lblUFNome = new System.Windows.Forms.Label();
            this.tbcUF = new System.Windows.Forms.TabControl();
            this.tbpUFCad = new System.Windows.Forms.TabPage();
            this.tbpUFCons = new System.Windows.Forms.TabPage();
            this.btnUFPesq = new System.Windows.Forms.Button();
            this.lblUFtbpNome = new System.Windows.Forms.Label();
            this.txtUFConsNome = new System.Windows.Forms.TextBox();
            this.STSUF = new System.Windows.Forms.StatusStrip();
            this.STSStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSUF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPUF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUF)).BeginInit();
            this.tbcUF.SuspendLayout();
            this.tbpUFCad.SuspendLayout();
            this.tbpUFCons.SuspendLayout();
            this.STSUF.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSUF
            // 
            this.TSUF.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBUFAdd,
            this.TSBUFAtualiza,
            this.TSBUFLimpar,
            this.TSBUFDelete});
            this.TSUF.Location = new System.Drawing.Point(0, 0);
            this.TSUF.Name = "TSUF";
            this.TSUF.Size = new System.Drawing.Size(662, 25);
            this.TSUF.TabIndex = 0;
            this.TSUF.Text = "toolStrip1";
            // 
            // TSBUFAdd
            // 
            this.TSBUFAdd.Image = ((System.Drawing.Image)(resources.GetObject("TSBUFAdd.Image")));
            this.TSBUFAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBUFAdd.Name = "TSBUFAdd";
            this.TSBUFAdd.Size = new System.Drawing.Size(78, 22);
            this.TSBUFAdd.Text = "&Adicionar";
            this.TSBUFAdd.Click += new System.EventHandler(this.TSBUFAdd_Click);
            // 
            // TSBUFAtualiza
            // 
            this.TSBUFAtualiza.Image = ((System.Drawing.Image)(resources.GetObject("TSBUFAtualiza.Image")));
            this.TSBUFAtualiza.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBUFAtualiza.Name = "TSBUFAtualiza";
            this.TSBUFAtualiza.Size = new System.Drawing.Size(73, 22);
            this.TSBUFAtualiza.Text = "A&tualizar";
            this.TSBUFAtualiza.Click += new System.EventHandler(this.TSBUFSalvar_Click);
            // 
            // TSBUFLimpar
            // 
            this.TSBUFLimpar.Image = global::wfaSCA.Properties.Resources.erase;
            this.TSBUFLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBUFLimpar.Name = "TSBUFLimpar";
            this.TSBUFLimpar.Size = new System.Drawing.Size(64, 22);
            this.TSBUFLimpar.Text = "&Limpar";
            this.TSBUFLimpar.Click += new System.EventHandler(this.TSBUFLimpar_Click);
            // 
            // TSBUFDelete
            // 
            this.TSBUFDelete.Image = ((System.Drawing.Image)(resources.GetObject("TSBUFDelete.Image")));
            this.TSBUFDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBUFDelete.Name = "TSBUFDelete";
            this.TSBUFDelete.Size = new System.Drawing.Size(62, 22);
            this.TSBUFDelete.Text = "&Excluir";
            this.TSBUFDelete.Click += new System.EventHandler(this.TSBUFDelete_Click);
            // 
            // lblUFSigla
            // 
            this.lblUFSigla.AutoSize = true;
            this.lblUFSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUFSigla.ForeColor = System.Drawing.Color.Blue;
            this.lblUFSigla.Location = new System.Drawing.Point(25, 35);
            this.lblUFSigla.Name = "lblUFSigla";
            this.lblUFSigla.Size = new System.Drawing.Size(39, 17);
            this.lblUFSigla.TabIndex = 1;
            this.lblUFSigla.Text = "Sigla";
            // 
            // txtUFSigla
            // 
            this.txtUFSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUFSigla.Location = new System.Drawing.Point(28, 65);
            this.txtUFSigla.MaxLength = 2;
            this.txtUFSigla.Name = "txtUFSigla";
            this.txtUFSigla.Size = new System.Drawing.Size(100, 23);
            this.txtUFSigla.TabIndex = 2;
            this.txtUFSigla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUFSigla_KeyPress);
            this.txtUFSigla.Validating += new System.ComponentModel.CancelEventHandler(this.txtUFSigla_Validating);
            this.txtUFSigla.Validated += new System.EventHandler(this.txtUFSigla_Validated);
            // 
            // EPUF
            // 
            this.EPUF.ContainerControl = this;
            // 
            // dgvUF
            // 
            this.dgvUF.AllowUserToAddRows = false;
            this.dgvUF.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvUF.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUF.Location = new System.Drawing.Point(21, 55);
            this.dgvUF.Name = "dgvUF";
            this.dgvUF.ReadOnly = true;
            this.dgvUF.Size = new System.Drawing.Size(567, 165);
            this.dgvUF.TabIndex = 3;
            this.dgvUF.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUF_CellDoubleClick);
            // 
            // txtUFNome
            // 
            this.txtUFNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUFNome.Location = new System.Drawing.Point(190, 65);
            this.txtUFNome.MaxLength = 50;
            this.txtUFNome.Name = "txtUFNome";
            this.txtUFNome.Size = new System.Drawing.Size(354, 23);
            this.txtUFNome.TabIndex = 5;
            this.txtUFNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtUFNome_Validating);
            this.txtUFNome.Validated += new System.EventHandler(this.txtUFNome_Validated);
            // 
            // lblUFNome
            // 
            this.lblUFNome.AutoSize = true;
            this.lblUFNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUFNome.ForeColor = System.Drawing.Color.Blue;
            this.lblUFNome.Location = new System.Drawing.Point(187, 35);
            this.lblUFNome.Name = "lblUFNome";
            this.lblUFNome.Size = new System.Drawing.Size(45, 17);
            this.lblUFNome.TabIndex = 4;
            this.lblUFNome.Text = "Nome";
            // 
            // tbcUF
            // 
            this.tbcUF.Controls.Add(this.tbpUFCad);
            this.tbcUF.Controls.Add(this.tbpUFCons);
            this.tbcUF.Location = new System.Drawing.Point(24, 40);
            this.tbcUF.Name = "tbcUF";
            this.tbcUF.SelectedIndex = 0;
            this.tbcUF.Size = new System.Drawing.Size(611, 267);
            this.tbcUF.TabIndex = 6;
            this.tbcUF.SelectedIndexChanged += new System.EventHandler(this.tbcUF_SelectedIndexChanged);
            // 
            // tbpUFCad
            // 
            this.tbpUFCad.Controls.Add(this.txtUFNome);
            this.tbpUFCad.Controls.Add(this.lblUFSigla);
            this.tbpUFCad.Controls.Add(this.lblUFNome);
            this.tbpUFCad.Controls.Add(this.txtUFSigla);
            this.tbpUFCad.Location = new System.Drawing.Point(4, 22);
            this.tbpUFCad.Name = "tbpUFCad";
            this.tbpUFCad.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUFCad.Size = new System.Drawing.Size(603, 241);
            this.tbpUFCad.TabIndex = 0;
            this.tbpUFCad.Text = "Cadastro";
            this.tbpUFCad.UseVisualStyleBackColor = true;
            // 
            // tbpUFCons
            // 
            this.tbpUFCons.Controls.Add(this.btnUFPesq);
            this.tbpUFCons.Controls.Add(this.lblUFtbpNome);
            this.tbpUFCons.Controls.Add(this.txtUFConsNome);
            this.tbpUFCons.Controls.Add(this.dgvUF);
            this.tbpUFCons.Location = new System.Drawing.Point(4, 22);
            this.tbpUFCons.Name = "tbpUFCons";
            this.tbpUFCons.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUFCons.Size = new System.Drawing.Size(603, 241);
            this.tbpUFCons.TabIndex = 1;
            this.tbpUFCons.Text = "Consulta";
            this.tbpUFCons.UseVisualStyleBackColor = true;
            // 
            // btnUFPesq
            // 
            this.btnUFPesq.Location = new System.Drawing.Point(477, 19);
            this.btnUFPesq.Name = "btnUFPesq";
            this.btnUFPesq.Size = new System.Drawing.Size(75, 23);
            this.btnUFPesq.TabIndex = 7;
            this.btnUFPesq.Text = "Pesquisar";
            this.btnUFPesq.UseVisualStyleBackColor = true;
            this.btnUFPesq.Click += new System.EventHandler(this.btnUFPesq_Click);
            // 
            // lblUFtbpNome
            // 
            this.lblUFtbpNome.AutoSize = true;
            this.lblUFtbpNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUFtbpNome.ForeColor = System.Drawing.Color.Blue;
            this.lblUFtbpNome.Location = new System.Drawing.Point(18, 21);
            this.lblUFtbpNome.Name = "lblUFtbpNome";
            this.lblUFtbpNome.Size = new System.Drawing.Size(45, 17);
            this.lblUFtbpNome.TabIndex = 5;
            this.lblUFtbpNome.Text = "Nome";
            // 
            // txtUFConsNome
            // 
            this.txtUFConsNome.Location = new System.Drawing.Point(78, 21);
            this.txtUFConsNome.MaxLength = 50;
            this.txtUFConsNome.Name = "txtUFConsNome";
            this.txtUFConsNome.Size = new System.Drawing.Size(379, 20);
            this.txtUFConsNome.TabIndex = 4;
            // 
            // STSUF
            // 
            this.STSUF.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STSStatus});
            this.STSUF.Location = new System.Drawing.Point(0, 323);
            this.STSUF.Name = "STSUF";
            this.STSUF.Size = new System.Drawing.Size(662, 22);
            this.STSUF.TabIndex = 7;
            this.STSUF.Text = "statusStrip1";
            // 
            // STSStatus
            // 
            this.STSStatus.Name = "STSStatus";
            this.STSStatus.Size = new System.Drawing.Size(39, 17);
            this.STSStatus.Text = "Status";
            // 
            // FrmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 345);
            this.Controls.Add(this.STSUF);
            this.Controls.Add(this.tbcUF);
            this.Controls.Add(this.TSUF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstados";
            this.Text = "ESTADOS";
            this.Load += new System.EventHandler(this.FrmEstados_Load);
            this.TSUF.ResumeLayout(false);
            this.TSUF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPUF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUF)).EndInit();
            this.tbcUF.ResumeLayout(false);
            this.tbpUFCad.ResumeLayout(false);
            this.tbpUFCad.PerformLayout();
            this.tbpUFCons.ResumeLayout(false);
            this.tbpUFCons.PerformLayout();
            this.STSUF.ResumeLayout(false);
            this.STSUF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TSUF;
        private System.Windows.Forms.ToolStripButton TSBUFAdd;
        private System.Windows.Forms.ToolStripButton TSBUFAtualiza;
        private System.Windows.Forms.ToolStripButton TSBUFDelete;
        private System.Windows.Forms.Label lblUFSigla;
        private System.Windows.Forms.TextBox txtUFSigla;
        private System.Windows.Forms.ErrorProvider EPUF;
        private System.Windows.Forms.TextBox txtUFNome;
        private System.Windows.Forms.Label lblUFNome;
        private System.Windows.Forms.DataGridView dgvUF;
        private System.Windows.Forms.TabControl tbcUF;
        private System.Windows.Forms.TabPage tbpUFCad;
        private System.Windows.Forms.TabPage tbpUFCons;
        private System.Windows.Forms.Label lblUFtbpNome;
        private System.Windows.Forms.TextBox txtUFConsNome;
        private System.Windows.Forms.Button btnUFPesq;
        private System.Windows.Forms.StatusStrip STSUF;
        private System.Windows.Forms.ToolStripStatusLabel STSStatus;
        private System.Windows.Forms.ToolStripButton TSBUFLimpar;
    }
}