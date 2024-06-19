namespace wfaSCA
{
    partial class FrmDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepartamento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TSDepto = new System.Windows.Forms.ToolStrip();
            this.TSBNovo = new System.Windows.Forms.ToolStripButton();
            this.TSBSalvar = new System.Windows.Forms.ToolStripButton();
            this.TSBLimpar = new System.Windows.Forms.ToolStripButton();
            this.TSBDelete = new System.Windows.Forms.ToolStripButton();
            this.txtDeptoSigla = new System.Windows.Forms.TextBox();
            this.lblDeptoSigla = new System.Windows.Forms.Label();
            this.dgvDepto = new System.Windows.Forms.DataGridView();
            this.lblDeptoNome = new System.Windows.Forms.Label();
            this.txtDeptoNome = new System.Windows.Forms.TextBox();
            this.btnDeptoPesq = new System.Windows.Forms.Button();
            this.EPDepto = new System.Windows.Forms.ErrorProvider(this.components);
            this.STSDepto = new System.Windows.Forms.StatusStrip();
            this.STSDeptoStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSDepto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPDepto)).BeginInit();
            this.STSDepto.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSDepto
            // 
            this.TSDepto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBNovo,
            this.TSBSalvar,
            this.TSBLimpar,
            this.TSBDelete});
            this.TSDepto.Location = new System.Drawing.Point(0, 0);
            this.TSDepto.Name = "TSDepto";
            this.TSDepto.Size = new System.Drawing.Size(586, 25);
            this.TSDepto.TabIndex = 0;
            this.TSDepto.Text = "toolStrip1";
            // 
            // TSBNovo
            // 
            this.TSBNovo.Image = ((System.Drawing.Image)(resources.GetObject("TSBNovo.Image")));
            this.TSBNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBNovo.Name = "TSBNovo";
            this.TSBNovo.Size = new System.Drawing.Size(78, 22);
            this.TSBNovo.Text = "&Adicionar";
            this.TSBNovo.Click += new System.EventHandler(this.TSBNovo_Click);
            // 
            // TSBSalvar
            // 
            this.TSBSalvar.Image = ((System.Drawing.Image)(resources.GetObject("TSBSalvar.Image")));
            this.TSBSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBSalvar.Name = "TSBSalvar";
            this.TSBSalvar.Size = new System.Drawing.Size(73, 22);
            this.TSBSalvar.Text = "A&tualizar";
            this.TSBSalvar.Click += new System.EventHandler(this.TSBSalvar_Click);
            // 
            // TSBLimpar
            // 
            this.TSBLimpar.Image = global::wfaSCA.Properties.Resources.erase;
            this.TSBLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBLimpar.Name = "TSBLimpar";
            this.TSBLimpar.Size = new System.Drawing.Size(64, 22);
            this.TSBLimpar.Text = "&Limpar";
            this.TSBLimpar.Click += new System.EventHandler(this.TSBLimpar_Click);
            // 
            // TSBDelete
            // 
            this.TSBDelete.Image = ((System.Drawing.Image)(resources.GetObject("TSBDelete.Image")));
            this.TSBDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBDelete.Name = "TSBDelete";
            this.TSBDelete.Size = new System.Drawing.Size(62, 22);
            this.TSBDelete.Text = "Excluir";
            this.TSBDelete.Click += new System.EventHandler(this.TSBDelete_Click);
            // 
            // txtDeptoSigla
            // 
            this.txtDeptoSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptoSigla.Location = new System.Drawing.Point(74, 37);
            this.txtDeptoSigla.MaxLength = 10;
            this.txtDeptoSigla.Name = "txtDeptoSigla";
            this.txtDeptoSigla.Size = new System.Drawing.Size(120, 23);
            this.txtDeptoSigla.TabIndex = 1;
            this.txtDeptoSigla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeptoSigla_KeyPress);
            this.txtDeptoSigla.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeptoSigla_Validating);
            this.txtDeptoSigla.Validated += new System.EventHandler(this.txtDeptoSigla_Validated);
            // 
            // lblDeptoSigla
            // 
            this.lblDeptoSigla.AutoSize = true;
            this.lblDeptoSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptoSigla.ForeColor = System.Drawing.Color.Blue;
            this.lblDeptoSigla.Location = new System.Drawing.Point(23, 40);
            this.lblDeptoSigla.Name = "lblDeptoSigla";
            this.lblDeptoSigla.Size = new System.Drawing.Size(39, 17);
            this.lblDeptoSigla.TabIndex = 2;
            this.lblDeptoSigla.Text = "Sigla";
            // 
            // dgvDepto
            // 
            this.dgvDepto.AllowUserToAddRows = false;
            this.dgvDepto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDepto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepto.Location = new System.Drawing.Point(12, 121);
            this.dgvDepto.Name = "dgvDepto";
            this.dgvDepto.ReadOnly = true;
            this.dgvDepto.Size = new System.Drawing.Size(560, 192);
            this.dgvDepto.TabIndex = 3;
            this.dgvDepto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepto_CellDoubleClick);
            // 
            // lblDeptoNome
            // 
            this.lblDeptoNome.AutoSize = true;
            this.lblDeptoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeptoNome.ForeColor = System.Drawing.Color.Blue;
            this.lblDeptoNome.Location = new System.Drawing.Point(23, 78);
            this.lblDeptoNome.Name = "lblDeptoNome";
            this.lblDeptoNome.Size = new System.Drawing.Size(45, 17);
            this.lblDeptoNome.TabIndex = 5;
            this.lblDeptoNome.Text = "Nome";
            // 
            // txtDeptoNome
            // 
            this.txtDeptoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeptoNome.Location = new System.Drawing.Point(74, 75);
            this.txtDeptoNome.MaxLength = 70;
            this.txtDeptoNome.Name = "txtDeptoNome";
            this.txtDeptoNome.Size = new System.Drawing.Size(380, 23);
            this.txtDeptoNome.TabIndex = 2;
            this.txtDeptoNome.Validating += new System.ComponentModel.CancelEventHandler(this.txtDeptoNome_Validating);
            this.txtDeptoNome.Validated += new System.EventHandler(this.txtDeptoNome_Validated);
            // 
            // btnDeptoPesq
            // 
            this.btnDeptoPesq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeptoPesq.ForeColor = System.Drawing.Color.Blue;
            this.btnDeptoPesq.Location = new System.Drawing.Point(485, 70);
            this.btnDeptoPesq.Name = "btnDeptoPesq";
            this.btnDeptoPesq.Size = new System.Drawing.Size(87, 32);
            this.btnDeptoPesq.TabIndex = 3;
            this.btnDeptoPesq.Text = "&Pesquisar";
            this.btnDeptoPesq.UseVisualStyleBackColor = true;
            this.btnDeptoPesq.Click += new System.EventHandler(this.btnDeptoPesq_Click);
            // 
            // EPDepto
            // 
            this.EPDepto.ContainerControl = this;
            // 
            // STSDepto
            // 
            this.STSDepto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STSDeptoStatus});
            this.STSDepto.Location = new System.Drawing.Point(0, 327);
            this.STSDepto.Name = "STSDepto";
            this.STSDepto.Size = new System.Drawing.Size(586, 22);
            this.STSDepto.TabIndex = 6;
            this.STSDepto.Text = "statusStrip1";
            // 
            // STSDeptoStatus
            // 
            this.STSDeptoStatus.Name = "STSDeptoStatus";
            this.STSDeptoStatus.Size = new System.Drawing.Size(39, 17);
            this.STSDeptoStatus.Text = "Status";
            this.STSDeptoStatus.ToolTipText = "Status da operação";
            // 
            // FrmDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 349);
            this.Controls.Add(this.STSDepto);
            this.Controls.Add(this.btnDeptoPesq);
            this.Controls.Add(this.lblDeptoNome);
            this.Controls.Add(this.txtDeptoNome);
            this.Controls.Add(this.dgvDepto);
            this.Controls.Add(this.lblDeptoSigla);
            this.Controls.Add(this.txtDeptoSigla);
            this.Controls.Add(this.TSDepto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDepartamento";
            this.Text = "DEPARTAMENTO";
            this.Load += new System.EventHandler(this.FrmDepartamento_Load);
            this.TSDepto.ResumeLayout(false);
            this.TSDepto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EPDepto)).EndInit();
            this.STSDepto.ResumeLayout(false);
            this.STSDepto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TSDepto;
        private System.Windows.Forms.ToolStripButton TSBNovo;
        private System.Windows.Forms.ToolStripButton TSBSalvar;
        private System.Windows.Forms.ToolStripButton TSBDelete;
        private System.Windows.Forms.TextBox txtDeptoSigla;
        private System.Windows.Forms.Label lblDeptoSigla;
        private System.Windows.Forms.DataGridView dgvDepto;
        private System.Windows.Forms.Label lblDeptoNome;
        private System.Windows.Forms.TextBox txtDeptoNome;
        private System.Windows.Forms.Button btnDeptoPesq;
        private System.Windows.Forms.ErrorProvider EPDepto;
        private System.Windows.Forms.StatusStrip STSDepto;
        private System.Windows.Forms.ToolStripStatusLabel STSDeptoStatus;
        private System.Windows.Forms.ToolStripButton TSBLimpar;
    }
}