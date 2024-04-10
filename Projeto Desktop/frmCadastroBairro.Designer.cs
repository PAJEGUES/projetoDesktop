namespace Projeto_Desktop
{
    partial class frmCadastroBairro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroBairro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSetor = new System.Windows.Forms.ComboBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.pbSeta = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.pbLogoSafeHouse = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoSafeHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSetor);
            this.groupBox1.Controls.Add(this.lblSetor);
            this.groupBox1.Controls.Add(this.pbSeta);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.pbLogoSafeHouse);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 705);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmbSetor
            // 
            this.cmbSetor.Font = new System.Drawing.Font("Impact", 24F);
            this.cmbSetor.FormattingEnabled = true;
            this.cmbSetor.Location = new System.Drawing.Point(571, 289);
            this.cmbSetor.Name = "cmbSetor";
            this.cmbSetor.Size = new System.Drawing.Size(276, 47);
            this.cmbSetor.TabIndex = 51;
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Impact", 24F);
            this.lblSetor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblSetor.Location = new System.Drawing.Point(564, 247);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(173, 39);
            this.lblSetor.TabIndex = 50;
            this.lblSetor.Text = "Nome Setor:";
            // 
            // pbSeta
            // 
            this.pbSeta.Image = ((System.Drawing.Image)(resources.GetObject("pbSeta.Image")));
            this.pbSeta.Location = new System.Drawing.Point(6, 9);
            this.pbSeta.Name = "pbSeta";
            this.pbSeta.Size = new System.Drawing.Size(100, 92);
            this.pbSeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSeta.TabIndex = 49;
            this.pbSeta.TabStop = false;
            this.pbSeta.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Impact", 24F);
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblID.Location = new System.Drawing.Point(732, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 39);
            this.lblID.TabIndex = 48;
            this.lblID.Visible = false;
            // 
            // pbLogoSafeHouse
            // 
            this.pbLogoSafeHouse.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoSafeHouse.Image")));
            this.pbLogoSafeHouse.Location = new System.Drawing.Point(138, 145);
            this.pbLogoSafeHouse.Name = "pbLogoSafeHouse";
            this.pbLogoSafeHouse.Size = new System.Drawing.Size(412, 415);
            this.pbLogoSafeHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoSafeHouse.TabIndex = 47;
            this.pbLogoSafeHouse.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Lime;
            this.btnCadastrar.Font = new System.Drawing.Font("Impact", 24F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(571, 380);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(276, 87);
            this.btnCadastrar.TabIndex = 46;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Red;
            this.btnLimpar.Font = new System.Drawing.Font("Impact", 24F);
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(571, 473);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(276, 87);
            this.btnLimpar.TabIndex = 45;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(564, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 39);
            this.label1.TabIndex = 44;
            this.label1.Text = "Nome do Bairro:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Impact", 24F);
            this.txtNome.Location = new System.Drawing.Point(571, 187);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(276, 47);
            this.txtNome.TabIndex = 43;
            // 
            // frmCadastroBairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCadastroBairro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Bairros";
            this.Load += new System.EventHandler(this.frmCadastroBairro_Load);
            this.Resize += new System.EventHandler(this.frmCadastroBairro_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoSafeHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSetor;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.PictureBox pbSeta;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox pbLogoSafeHouse;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
    }
}