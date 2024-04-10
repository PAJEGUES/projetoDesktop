namespace Projeto_Desktop
{
    partial class frmBairro
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
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtPesquisaBairro = new System.Windows.Forms.TextBox();
            this.dgvBairro = new System.Windows.Forms.DataGridView();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBairro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblBairro.Location = new System.Drawing.Point(32, 18);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(92, 24);
            this.lblBairro.TabIndex = 11;
            this.lblBairro.Text = "Pesquisa:";
            // 
            // txtPesquisaBairro
            // 
            this.txtPesquisaBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPesquisaBairro.Location = new System.Drawing.Point(32, 45);
            this.txtPesquisaBairro.Name = "txtPesquisaBairro";
            this.txtPesquisaBairro.Size = new System.Drawing.Size(720, 29);
            this.txtPesquisaBairro.TabIndex = 10;
            this.txtPesquisaBairro.TextChanged += new System.EventHandler(this.txtPesquisaBairro_TextChanged);
            // 
            // dgvBairro
            // 
            this.dgvBairro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBairro.Location = new System.Drawing.Point(32, 80);
            this.dgvBairro.Name = "dgvBairro";
            this.dgvBairro.Size = new System.Drawing.Size(720, 516);
            this.dgvBairro.TabIndex = 9;
            this.dgvBairro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBairro_CellContentClick);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnRemover.FlatAppearance.BorderSize = 0;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Impact", 20F);
            this.btnRemover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnRemover.Location = new System.Drawing.Point(302, 615);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(180, 80);
            this.btnRemover.TabIndex = 13;
            this.btnRemover.Text = "REMOVER";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Impact", 20F);
            this.btnCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCadastro.Location = new System.Drawing.Point(488, 615);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(180, 80);
            this.btnCadastro.TabIndex = 12;
            this.btnCadastro.Text = "ADICIONAR";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Impact", 20F);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnEditar.Location = new System.Drawing.Point(116, 615);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(180, 80);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmBairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(784, 713);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtPesquisaBairro);
            this.Controls.Add(this.dgvBairro);
            this.Name = "frmBairro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBairro";
            this.Shown += new System.EventHandler(this.frmBairro_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBairro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtPesquisaBairro;
        private System.Windows.Forms.DataGridView dgvBairro;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnEditar;
    }
}