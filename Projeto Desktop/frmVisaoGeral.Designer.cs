namespace Projeto_Desktop
{
    partial class frmVisaoGeral
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
            this.dgvColaborador = new System.Windows.Forms.DataGridView();
            this.lblVisao = new System.Windows.Forms.Label();
            this.txtPesquisaGeral = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaborador)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvColaborador
            // 
            this.dgvColaborador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColaborador.Location = new System.Drawing.Point(12, 78);
            this.dgvColaborador.Name = "dgvColaborador";
            this.dgvColaborador.Size = new System.Drawing.Size(760, 623);
            this.dgvColaborador.TabIndex = 3;
            this.dgvColaborador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvColaborador_CellContentClick);
            // 
            // lblVisao
            // 
            this.lblVisao.AutoSize = true;
            this.lblVisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblVisao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblVisao.Location = new System.Drawing.Point(12, 16);
            this.lblVisao.Name = "lblVisao";
            this.lblVisao.Size = new System.Drawing.Size(92, 24);
            this.lblVisao.TabIndex = 16;
            this.lblVisao.Text = "Pesquisa:";
            // 
            // txtPesquisaGeral
            // 
            this.txtPesquisaGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtPesquisaGeral.Location = new System.Drawing.Point(12, 43);
            this.txtPesquisaGeral.Name = "txtPesquisaGeral";
            this.txtPesquisaGeral.Size = new System.Drawing.Size(760, 29);
            this.txtPesquisaGeral.TabIndex = 15;
            this.txtPesquisaGeral.TextChanged += new System.EventHandler(this.txtPesquisaGeral_TextChanged);
            // 
            // frmVisaoGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(784, 713);
            this.Controls.Add(this.lblVisao);
            this.Controls.Add(this.txtPesquisaGeral);
            this.Controls.Add(this.dgvColaborador);
            this.Name = "frmVisaoGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVisaoGeral";
            this.Load += new System.EventHandler(this.frmVisaoGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColaborador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColaborador;
        private System.Windows.Forms.Label lblVisao;
        private System.Windows.Forms.TextBox txtPesquisaGeral;
    }
}