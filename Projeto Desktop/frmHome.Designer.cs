namespace Projeto_Desktop
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.pnlMenuEsquerdo = new System.Windows.Forms.Panel();
            this.btnVisaoGeral = new System.Windows.Forms.Button();
            this.btnSetores = new System.Windows.Forms.Button();
            this.btnGuardaNoturno = new System.Windows.Forms.Button();
            this.btnBairros = new System.Windows.Forms.Button();
            this.btnAdm = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbLogoSafeHouse = new System.Windows.Forms.PictureBox();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlMenuEsquerdo.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoSafeHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuEsquerdo
            // 
            this.pnlMenuEsquerdo.AutoScroll = true;
            this.pnlMenuEsquerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenuEsquerdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMenuEsquerdo.Controls.Add(this.btnVisaoGeral);
            this.pnlMenuEsquerdo.Controls.Add(this.btnSetores);
            this.pnlMenuEsquerdo.Controls.Add(this.btnGuardaNoturno);
            this.pnlMenuEsquerdo.Controls.Add(this.btnBairros);
            this.pnlMenuEsquerdo.Controls.Add(this.btnAdm);
            this.pnlMenuEsquerdo.Controls.Add(this.btnSair);
            this.pnlMenuEsquerdo.Controls.Add(this.pnlLogo);
            this.pnlMenuEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuEsquerdo.Name = "pnlMenuEsquerdo";
            this.pnlMenuEsquerdo.Size = new System.Drawing.Size(206, 768);
            this.pnlMenuEsquerdo.TabIndex = 0;
            // 
            // btnVisaoGeral
            // 
            this.btnVisaoGeral.FlatAppearance.BorderSize = 0;
            this.btnVisaoGeral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisaoGeral.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisaoGeral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnVisaoGeral.Location = new System.Drawing.Point(0, 833);
            this.btnVisaoGeral.Name = "btnVisaoGeral";
            this.btnVisaoGeral.Size = new System.Drawing.Size(184, 120);
            this.btnVisaoGeral.TabIndex = 8;
            this.btnVisaoGeral.Text = "Visão Geral";
            this.btnVisaoGeral.UseVisualStyleBackColor = true;
            this.btnVisaoGeral.Click += new System.EventHandler(this.btnVisaoGeral_Click);
            this.btnVisaoGeral.Leave += new System.EventHandler(this.btnVisaoGeral_Leave);
            // 
            // btnSetores
            // 
            this.btnSetores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetores.FlatAppearance.BorderSize = 0;
            this.btnSetores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetores.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSetores.Location = new System.Drawing.Point(0, 713);
            this.btnSetores.Name = "btnSetores";
            this.btnSetores.Size = new System.Drawing.Size(187, 120);
            this.btnSetores.TabIndex = 7;
            this.btnSetores.Text = "Setores";
            this.btnSetores.UseVisualStyleBackColor = true;
            this.btnSetores.Click += new System.EventHandler(this.btnSetores_Click_1);
            this.btnSetores.Leave += new System.EventHandler(this.btnSetores_Leave);
            // 
            // btnGuardaNoturno
            // 
            this.btnGuardaNoturno.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuardaNoturno.FlatAppearance.BorderSize = 0;
            this.btnGuardaNoturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaNoturno.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardaNoturno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnGuardaNoturno.Location = new System.Drawing.Point(0, 593);
            this.btnGuardaNoturno.Name = "btnGuardaNoturno";
            this.btnGuardaNoturno.Size = new System.Drawing.Size(187, 120);
            this.btnGuardaNoturno.TabIndex = 3;
            this.btnGuardaNoturno.Text = "Guarda Noturno";
            this.btnGuardaNoturno.UseVisualStyleBackColor = true;
            this.btnGuardaNoturno.Click += new System.EventHandler(this.btnGuardaNoturno_Click);
            this.btnGuardaNoturno.Leave += new System.EventHandler(this.btnGuardaNoturno_Leave);
            // 
            // btnBairros
            // 
            this.btnBairros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBairros.FlatAppearance.BorderSize = 0;
            this.btnBairros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBairros.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBairros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBairros.Location = new System.Drawing.Point(0, 473);
            this.btnBairros.Name = "btnBairros";
            this.btnBairros.Size = new System.Drawing.Size(187, 120);
            this.btnBairros.TabIndex = 2;
            this.btnBairros.Text = "Bairros";
            this.btnBairros.UseVisualStyleBackColor = true;
            this.btnBairros.Click += new System.EventHandler(this.btnBairros_Click);
            this.btnBairros.Leave += new System.EventHandler(this.btnBairros_Leave);
            // 
            // btnAdm
            // 
            this.btnAdm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdm.FlatAppearance.BorderSize = 0;
            this.btnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdm.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAdm.Location = new System.Drawing.Point(0, 353);
            this.btnAdm.Name = "btnAdm";
            this.btnAdm.Size = new System.Drawing.Size(187, 120);
            this.btnAdm.TabIndex = 6;
            this.btnAdm.Text = "Administrador";
            this.btnAdm.UseVisualStyleBackColor = true;
            this.btnAdm.Click += new System.EventHandler(this.btnAdm_Click);
            this.btnAdm.Leave += new System.EventHandler(this.btnAdm_Leave);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSair.Location = new System.Drawing.Point(0, 953);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(187, 120);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pbLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(187, 353);
            this.pnlLogo.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(180, 351);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click_1);
            // 
            // pbLogoSafeHouse
            // 
            this.pbLogoSafeHouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogoSafeHouse.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoSafeHouse.Image")));
            this.pbLogoSafeHouse.Location = new System.Drawing.Point(212, 4);
            this.pbLogoSafeHouse.Name = "pbLogoSafeHouse";
            this.pbLogoSafeHouse.Size = new System.Drawing.Size(800, 752);
            this.pbLogoSafeHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoSafeHouse.TabIndex = 1;
            this.pbLogoSafeHouse.TabStop = false;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPrincipal.Location = new System.Drawing.Point(213, 12);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(800, 744);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.pbLogoSafeHouse);
            this.Controls.Add(this.pnlMenuEsquerdo);
            this.Controls.Add(this.pnlPrincipal);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.pnlMenuEsquerdo.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoSafeHouse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuEsquerdo;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnBairros;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGuardaNoturno;
        private System.Windows.Forms.PictureBox pbLogoSafeHouse;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Button btnAdm;
        private System.Windows.Forms.Button btnSetores;
        private System.Windows.Forms.Button btnVisaoGeral;
    }
}

