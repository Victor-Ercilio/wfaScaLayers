namespace wfaSCA
{
    partial class FrmCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCursos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TSCursos = new System.Windows.Forms.ToolStrip();
            this.TSbCurAdd = new System.Windows.Forms.ToolStripButton();
            this.TSbCurUpdate = new System.Windows.Forms.ToolStripButton();
            this.TSbCurLimpar = new System.Windows.Forms.ToolStripButton();
            this.TSbCurDelete = new System.Windows.Forms.ToolStripButton();
            this.STSCursos = new System.Windows.Forms.StatusStrip();
            this.STSlblCurStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.EPCursos = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbCurSglDepto = new System.Windows.Forms.ComboBox();
            this.btnCurPesq = new System.Windows.Forms.Button();
            this.txtCurSigla = new System.Windows.Forms.TextBox();
            this.lblCurSigla = new System.Windows.Forms.Label();
            this.lblCurNome = new System.Windows.Forms.Label();
            this.txtCurNome = new System.Windows.Forms.TextBox();
            this.dgvCur = new System.Windows.Forms.DataGridView();
            this.lblCurSglDepto = new System.Windows.Forms.Label();
            this.TSCursos.SuspendLayout();
            this.STSCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCur)).BeginInit();
            this.SuspendLayout();
            // 
            // TSCursos
            // 
            this.TSCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSbCurAdd,
            this.TSbCurUpdate,
            this.TSbCurLimpar,
            this.TSbCurDelete});
            this.TSCursos.Location = new System.Drawing.Point(0, 0);
            this.TSCursos.Name = "TSCursos";
            this.TSCursos.Size = new System.Drawing.Size(620, 25);
            this.TSCursos.TabIndex = 0;
            this.TSCursos.Text = "toolStrip1";
            // 
            // TSbCurAdd
            // 
            this.TSbCurAdd.Image = ((System.Drawing.Image)(resources.GetObject("TSbCurAdd.Image")));
            this.TSbCurAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbCurAdd.Name = "TSbCurAdd";
            this.TSbCurAdd.Size = new System.Drawing.Size(78, 22);
            this.TSbCurAdd.Text = "&Adicionar";
            this.TSbCurAdd.Click += new System.EventHandler(this.TSbCurAdd_Click);
            // 
            // TSbCurUpdate
            // 
            this.TSbCurUpdate.Image = ((System.Drawing.Image)(resources.GetObject("TSbCurUpdate.Image")));
            this.TSbCurUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbCurUpdate.Name = "TSbCurUpdate";
            this.TSbCurUpdate.Size = new System.Drawing.Size(73, 22);
            this.TSbCurUpdate.Text = "A&tualizar";
            this.TSbCurUpdate.Click += new System.EventHandler(this.TSbCurUpdate_Click);
            // 
            // TSbCurLimpar
            // 
            this.TSbCurLimpar.Image = ((System.Drawing.Image)(resources.GetObject("TSbCurLimpar.Image")));
            this.TSbCurLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbCurLimpar.Name = "TSbCurLimpar";
            this.TSbCurLimpar.Size = new System.Drawing.Size(111, 22);
            this.TSbCurLimpar.Text = "&Limpar Campos";
            this.TSbCurLimpar.Click += new System.EventHandler(this.TSbCurLimpar_Click);
            // 
            // TSbCurDelete
            // 
            this.TSbCurDelete.Image = ((System.Drawing.Image)(resources.GetObject("TSbCurDelete.Image")));
            this.TSbCurDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbCurDelete.Name = "TSbCurDelete";
            this.TSbCurDelete.Size = new System.Drawing.Size(62, 22);
            this.TSbCurDelete.Text = "&Excluir";
            this.TSbCurDelete.Click += new System.EventHandler(this.TSbCurDelete_Click);
            // 
            // STSCursos
            // 
            this.STSCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STSlblCurStatus});
            this.STSCursos.Location = new System.Drawing.Point(0, 330);
            this.STSCursos.Name = "STSCursos";
            this.STSCursos.Size = new System.Drawing.Size(620, 22);
            this.STSCursos.TabIndex = 1;
            this.STSCursos.Text = "statusStrip1";
            // 
            // STSlblCurStatus
            // 
            this.STSlblCurStatus.Name = "STSlblCurStatus";
            this.STSlblCurStatus.Size = new System.Drawing.Size(39, 17);
            this.STSlblCurStatus.Text = "Status";
            // 
            // EPCursos
            // 
            this.EPCursos.ContainerControl = this;
            // 
            // cmbCurSglDepto
            // 
            this.cmbCurSglDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurSglDepto.FormattingEnabled = true;
            this.cmbCurSglDepto.Location = new System.Drawing.Point(343, 41);
            this.cmbCurSglDepto.Name = "cmbCurSglDepto";
            this.cmbCurSglDepto.Size = new System.Drawing.Size(121, 24);
            this.cmbCurSglDepto.Sorted = true;
            this.cmbCurSglDepto.TabIndex = 2;
            // 
            // btnCurPesq
            // 
            this.btnCurPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurPesq.Location = new System.Drawing.Point(513, 78);
            this.btnCurPesq.Name = "btnCurPesq";
            this.btnCurPesq.Size = new System.Drawing.Size(91, 33);
            this.btnCurPesq.TabIndex = 4;
            this.btnCurPesq.Text = "&Pesquisar";
            this.btnCurPesq.UseVisualStyleBackColor = true;
            this.btnCurPesq.Click += new System.EventHandler(this.btnCurPesq_Click);
            // 
            // txtCurSigla
            // 
            this.txtCurSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurSigla.Location = new System.Drawing.Point(64, 41);
            this.txtCurSigla.MaxLength = 10;
            this.txtCurSigla.Name = "txtCurSigla";
            this.txtCurSigla.Size = new System.Drawing.Size(142, 23);
            this.txtCurSigla.TabIndex = 1;
            this.txtCurSigla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurSigla_KeyPress);
            // 
            // lblCurSigla
            // 
            this.lblCurSigla.AutoSize = true;
            this.lblCurSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurSigla.ForeColor = System.Drawing.Color.Blue;
            this.lblCurSigla.Location = new System.Drawing.Point(12, 44);
            this.lblCurSigla.Name = "lblCurSigla";
            this.lblCurSigla.Size = new System.Drawing.Size(39, 17);
            this.lblCurSigla.TabIndex = 5;
            this.lblCurSigla.Text = "Sigla";
            // 
            // lblCurNome
            // 
            this.lblCurNome.AutoSize = true;
            this.lblCurNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurNome.ForeColor = System.Drawing.Color.Blue;
            this.lblCurNome.Location = new System.Drawing.Point(12, 86);
            this.lblCurNome.Name = "lblCurNome";
            this.lblCurNome.Size = new System.Drawing.Size(45, 17);
            this.lblCurNome.TabIndex = 7;
            this.lblCurNome.Text = "Nome";
            // 
            // txtCurNome
            // 
            this.txtCurNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurNome.Location = new System.Drawing.Point(64, 83);
            this.txtCurNome.MaxLength = 70;
            this.txtCurNome.Name = "txtCurNome";
            this.txtCurNome.Size = new System.Drawing.Size(427, 23);
            this.txtCurNome.TabIndex = 3;
            // 
            // dgvCur
            // 
            this.dgvCur.AllowUserToAddRows = false;
            this.dgvCur.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCur.Location = new System.Drawing.Point(12, 133);
            this.dgvCur.Name = "dgvCur";
            this.dgvCur.ReadOnly = true;
            this.dgvCur.Size = new System.Drawing.Size(596, 183);
            this.dgvCur.TabIndex = 10;
            this.dgvCur.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCur_CellDoubleClick);
            // 
            // lblCurSglDepto
            // 
            this.lblCurSglDepto.AutoSize = true;
            this.lblCurSglDepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurSglDepto.ForeColor = System.Drawing.Color.Blue;
            this.lblCurSglDepto.Location = new System.Drawing.Point(252, 44);
            this.lblCurSglDepto.Name = "lblCurSglDepto";
            this.lblCurSglDepto.Size = new System.Drawing.Size(85, 17);
            this.lblCurSglDepto.TabIndex = 11;
            this.lblCurSglDepto.Text = "Sigla Depto.";
            // 
            // FrmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 352);
            this.Controls.Add(this.txtCurNome);
            this.Controls.Add(this.btnCurPesq);
            this.Controls.Add(this.lblCurNome);
            this.Controls.Add(this.lblCurSglDepto);
            this.Controls.Add(this.dgvCur);
            this.Controls.Add(this.lblCurSigla);
            this.Controls.Add(this.txtCurSigla);
            this.Controls.Add(this.cmbCurSglDepto);
            this.Controls.Add(this.STSCursos);
            this.Controls.Add(this.TSCursos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCursos";
            this.Text = "CURSOS";
            this.Load += new System.EventHandler(this.FrmCursos_Load);
            this.TSCursos.ResumeLayout(false);
            this.TSCursos.PerformLayout();
            this.STSCursos.ResumeLayout(false);
            this.STSCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EPCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TSCursos;
        private System.Windows.Forms.ToolStripButton TSbCurAdd;
        private System.Windows.Forms.ToolStripButton TSbCurUpdate;
        private System.Windows.Forms.ToolStripButton TSbCurDelete;
        private System.Windows.Forms.StatusStrip STSCursos;
        private System.Windows.Forms.ToolStripStatusLabel STSlblCurStatus;
        private System.Windows.Forms.ErrorProvider EPCursos;
        private System.Windows.Forms.Label lblCurNome;
        private System.Windows.Forms.TextBox txtCurNome;
        private System.Windows.Forms.Label lblCurSigla;
        private System.Windows.Forms.TextBox txtCurSigla;
        private System.Windows.Forms.Button btnCurPesq;
        private System.Windows.Forms.ComboBox cmbCurSglDepto;
        private System.Windows.Forms.Label lblCurSglDepto;
        private System.Windows.Forms.DataGridView dgvCur;
        private System.Windows.Forms.ToolStripButton TSbCurLimpar;
    }
}