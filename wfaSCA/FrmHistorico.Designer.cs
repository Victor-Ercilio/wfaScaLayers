namespace wfaSCA
{
    partial class FrmHistorico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorico));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblAluNome = new System.Windows.Forms.Label();
            this.txtAluNome = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbMatr = new System.Windows.Forms.ComboBox();
            this.lblMatr = new System.Windows.Forms.Label();
            this.cmbDiscpCod = new System.Windows.Forms.ComboBox();
            this.lblDiscpCod = new System.Windows.Forms.Label();
            this.grpDiscp = new System.Windows.Forms.GroupBox();
            this.txtDiscpNome = new System.Windows.Forms.TextBox();
            this.lblDiscpNome = new System.Windows.Forms.Label();
            this.dgvHist = new System.Windows.Forms.DataGridView();
            this.grpAlu = new System.Windows.Forms.GroupBox();
            this.STSHist = new System.Windows.Forms.StatusStrip();
            this.STSlblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpDiscp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHist)).BeginInit();
            this.grpAlu.SuspendLayout();
            this.STSHist.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.Blue;
            this.btnPesquisar.Location = new System.Drawing.Point(454, 137);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 32);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cmbCurso
            // 
            this.cmbCurso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCurso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCurso.DropDownHeight = 80;
            this.cmbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.IntegralHeight = false;
            this.cmbCurso.Location = new System.Drawing.Point(82, 142);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(123, 24);
            this.cmbCurso.Sorted = true;
            this.cmbCurso.TabIndex = 4;
            // 
            // lblAluNome
            // 
            this.lblAluNome.AutoSize = true;
            this.lblAluNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluNome.ForeColor = System.Drawing.Color.Blue;
            this.lblAluNome.Location = new System.Drawing.Point(18, 22);
            this.lblAluNome.Name = "lblAluNome";
            this.lblAluNome.Size = new System.Drawing.Size(45, 17);
            this.lblAluNome.TabIndex = 2;
            this.lblAluNome.Text = "Nome";
            // 
            // txtAluNome
            // 
            this.txtAluNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAluNome.Location = new System.Drawing.Point(68, 19);
            this.txtAluNome.MaxLength = 70;
            this.txtAluNome.Name = "txtAluNome";
            this.txtAluNome.Size = new System.Drawing.Size(500, 23);
            this.txtAluNome.TabIndex = 1;
            this.txtAluNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAluNome_KeyPress);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.Color.Blue;
            this.lblCurso.Location = new System.Drawing.Point(31, 145);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(45, 17);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "Curso";
            // 
            // cmbMatr
            // 
            this.cmbMatr.DropDownHeight = 80;
            this.cmbMatr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMatr.FormattingEnabled = true;
            this.cmbMatr.IntegralHeight = false;
            this.cmbMatr.Location = new System.Drawing.Point(327, 142);
            this.cmbMatr.Name = "cmbMatr";
            this.cmbMatr.Size = new System.Drawing.Size(121, 24);
            this.cmbMatr.Sorted = true;
            this.cmbMatr.TabIndex = 5;
            // 
            // lblMatr
            // 
            this.lblMatr.AutoSize = true;
            this.lblMatr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatr.ForeColor = System.Drawing.Color.Blue;
            this.lblMatr.Location = new System.Drawing.Point(256, 145);
            this.lblMatr.Name = "lblMatr";
            this.lblMatr.Size = new System.Drawing.Size(65, 17);
            this.lblMatr.TabIndex = 4;
            this.lblMatr.Text = "Matrícula";
            // 
            // cmbDiscpCod
            // 
            this.cmbDiscpCod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbDiscpCod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDiscpCod.DropDownHeight = 80;
            this.cmbDiscpCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDiscpCod.FormattingEnabled = true;
            this.cmbDiscpCod.IntegralHeight = false;
            this.cmbDiscpCod.Location = new System.Drawing.Point(77, 26);
            this.cmbDiscpCod.MaxDropDownItems = 5;
            this.cmbDiscpCod.Name = "cmbDiscpCod";
            this.cmbDiscpCod.Size = new System.Drawing.Size(124, 24);
            this.cmbDiscpCod.Sorted = true;
            this.cmbDiscpCod.TabIndex = 2;
            this.cmbDiscpCod.SelectedIndexChanged += new System.EventHandler(this.cmbDiscpCod_SelectedIndexChanged);
            // 
            // lblDiscpCod
            // 
            this.lblDiscpCod.AutoSize = true;
            this.lblDiscpCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscpCod.ForeColor = System.Drawing.Color.Blue;
            this.lblDiscpCod.Location = new System.Drawing.Point(19, 29);
            this.lblDiscpCod.Name = "lblDiscpCod";
            this.lblDiscpCod.Size = new System.Drawing.Size(39, 17);
            this.lblDiscpCod.TabIndex = 4;
            this.lblDiscpCod.Text = "Sigla";
            // 
            // grpDiscp
            // 
            this.grpDiscp.Controls.Add(this.txtDiscpNome);
            this.grpDiscp.Controls.Add(this.lblDiscpNome);
            this.grpDiscp.Controls.Add(this.cmbDiscpCod);
            this.grpDiscp.Controls.Add(this.lblDiscpCod);
            this.grpDiscp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDiscp.ForeColor = System.Drawing.Color.Blue;
            this.grpDiscp.Location = new System.Drawing.Point(34, 68);
            this.grpDiscp.Name = "grpDiscp";
            this.grpDiscp.Size = new System.Drawing.Size(614, 60);
            this.grpDiscp.TabIndex = 5;
            this.grpDiscp.TabStop = false;
            this.grpDiscp.Text = "Disciplina";
            // 
            // txtDiscpNome
            // 
            this.txtDiscpNome.Enabled = false;
            this.txtDiscpNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscpNome.Location = new System.Drawing.Point(278, 27);
            this.txtDiscpNome.MaxLength = 70;
            this.txtDiscpNome.Name = "txtDiscpNome";
            this.txtDiscpNome.Size = new System.Drawing.Size(290, 23);
            this.txtDiscpNome.TabIndex = 3;
            this.txtDiscpNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscpNome_KeyPress);
            // 
            // lblDiscpNome
            // 
            this.lblDiscpNome.AutoSize = true;
            this.lblDiscpNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscpNome.ForeColor = System.Drawing.Color.Blue;
            this.lblDiscpNome.Location = new System.Drawing.Point(227, 29);
            this.lblDiscpNome.Name = "lblDiscpNome";
            this.lblDiscpNome.Size = new System.Drawing.Size(45, 17);
            this.lblDiscpNome.TabIndex = 5;
            this.lblDiscpNome.Text = "Nome";
            // 
            // dgvHist
            // 
            this.dgvHist.AccessibleName = "Lista das notas dos alunos em suas respectivas matrículas";
            this.dgvHist.AllowUserToAddRows = false;
            this.dgvHist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHist.Location = new System.Drawing.Point(34, 184);
            this.dgvHist.Name = "dgvHist";
            this.dgvHist.ReadOnly = true;
            this.dgvHist.Size = new System.Drawing.Size(614, 205);
            this.dgvHist.TabIndex = 6;
            // 
            // grpAlu
            // 
            this.grpAlu.Controls.Add(this.txtAluNome);
            this.grpAlu.Controls.Add(this.lblAluNome);
            this.grpAlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAlu.ForeColor = System.Drawing.Color.Blue;
            this.grpAlu.Location = new System.Drawing.Point(34, 12);
            this.grpAlu.Name = "grpAlu";
            this.grpAlu.Size = new System.Drawing.Size(614, 50);
            this.grpAlu.TabIndex = 7;
            this.grpAlu.TabStop = false;
            this.grpAlu.Text = "Aluno";
            // 
            // STSHist
            // 
            this.STSHist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.STSlblStatus});
            this.STSHist.Location = new System.Drawing.Point(0, 403);
            this.STSHist.Name = "STSHist";
            this.STSHist.Size = new System.Drawing.Size(695, 22);
            this.STSHist.TabIndex = 8;
            this.STSHist.Text = "statusStrip1";
            // 
            // STSlblStatus
            // 
            this.STSlblStatus.Name = "STSlblStatus";
            this.STSlblStatus.Size = new System.Drawing.Size(39, 17);
            this.STSlblStatus.Text = "Status";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Blue;
            this.btnLimpar.Location = new System.Drawing.Point(557, 137);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(91, 32);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 425);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.STSHist);
            this.Controls.Add(this.grpAlu);
            this.Controls.Add(this.dgvHist);
            this.Controls.Add(this.grpDiscp);
            this.Controls.Add(this.lblMatr);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.cmbMatr);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.btnPesquisar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHistorico";
            this.Tag = "";
            this.Text = "HISTÓRICO";
            this.Load += new System.EventHandler(this.FrmHistorico_Load);
            this.grpDiscp.ResumeLayout(false);
            this.grpDiscp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHist)).EndInit();
            this.grpAlu.ResumeLayout(false);
            this.grpAlu.PerformLayout();
            this.STSHist.ResumeLayout(false);
            this.STSHist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label lblAluNome;
        private System.Windows.Forms.TextBox txtAluNome;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cmbMatr;
        private System.Windows.Forms.Label lblMatr;
        private System.Windows.Forms.ComboBox cmbDiscpCod;
        private System.Windows.Forms.Label lblDiscpCod;
        private System.Windows.Forms.GroupBox grpDiscp;
        private System.Windows.Forms.TextBox txtDiscpNome;
        private System.Windows.Forms.Label lblDiscpNome;
        private System.Windows.Forms.DataGridView dgvHist;
        private System.Windows.Forms.GroupBox grpAlu;
        private System.Windows.Forms.StatusStrip STSHist;
        private System.Windows.Forms.ToolStripStatusLabel STSlblStatus;
        private System.Windows.Forms.Button btnLimpar;
    }
}