using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Desktop
{
    public partial class frmCadastroBairro : Form
    {
        public frmCadastroBairro()
        {
            InitializeComponent();
        }

        public clBairro bairro = new clBairro();
        public clSetor setor = new clSetor();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            bool salvar = true;

            if (txtNome.Text == "")
            {
                salvar = false;
                MessageBox.Show("É necessário digitar o nome do Bairro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string salvarBairro = cmbSetor.SelectedValue?.ToString();

            if (salvarBairro == null)
            {
                salvar = false;
                MessageBox.Show("É necessário selecionar o Setor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(salvar)
            {
                bairro.nomeBairro = txtNome.Text;
                bairro.idsetor = Convert.ToInt32(cmbSetor.SelectedValue);

                if (lblID.Text == "")
                {
                    int id = bairro.Salvar();
                    
                    if (id > 0)
                    {
                        MessageBox.Show("Bairro cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblID.Text = Convert.ToString(id);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar Bairro!", "Erro", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bairro.idbairro = int.Parse(lblID.Text);
                    int attBairro = bairro.Atualizar();

                    if (attBairro != 0)
                    {
                        MessageBox.Show("Bairro Alterado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar Bairro, contate o desenvolvedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            this.Close();   
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            frmHome home = new frmHome();
        }

        private void frmCadastroBairro_Load(object sender, EventArgs e)
        {
            AjustarControles();

            cmbSetor.DataSource = setor.listaSetor();
            cmbSetor.ValueMember = "idsetor";
            cmbSetor.DisplayMember = "nomesetor";

            if (bairro.idbairro != 0)
            {
                lblID.Text = bairro.idbairro.ToString();
                txtNome.Text = bairro.nomeBairro;
                btnCadastrar.Text = "Atualizar";
            }

        }

        private void AjustarControles()
        {
            float larguraInicial = 1024;
            float alturaInicial = 768;

            float larguraFinal = this.Width;
            float alturaFinal = this.Height;

            float pxB = 0 - (larguraInicial / 2 - larguraFinal / 2);
            float pyB = 0 - (alturaInicial / 2 - alturaFinal / 2);
            groupBox1.Location = new Point((int)pxB, (int)pyB);
        }

        private void frmCadastroBairro_Resize(object sender, EventArgs e)
        {
            AjustarControles();
        }
    }
}
