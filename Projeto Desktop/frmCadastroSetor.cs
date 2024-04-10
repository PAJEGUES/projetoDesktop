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
    public partial class frmCadastroSetor : Form
    {
        public frmCadastroSetor()
        {
            InitializeComponent();
        }

        public clColaborador colaborador = new clColaborador();
        public clSetor setor = new clSetor();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            bool salvar = true;

            if (txtNome.Text == "") 
            {
                salvar = false;
                MessageBox.Show("É necessário digitar o nome do Setor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);       
            }

            string salvarSetor = cmbSetor.SelectedValue?.ToString();

            if (salvarSetor == null)
            {
                salvar = false;
                MessageBox.Show("É necessário selecionar o Colaborador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (salvar)
            {
                setor.nomesetor = txtNome.Text;
                setor.idcolaborador = Convert.ToInt32(cmbSetor.SelectedValue);

                if (lblID.Text == "")
                {
                    int id = setor.Salvar();

                    if (id > 0)
                    {
                        MessageBox.Show("Setor cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblID.Text = Convert.ToString(id);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar Setor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    setor.idsetor = int.Parse(lblID.Text);
                    int attSetor = setor.Atualizar();

                    if (attSetor != 0)
                    {
                        MessageBox.Show("Setor Alterado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar Setor, contate o desenvolvedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            this.Close();
        }

        

        private void pbSeta_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
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

        private void frmCadastroSetor_Load(object sender, EventArgs e)
        {
            AjustarControles();
            cmbSetor.DataSource = colaborador.listaColaborador();
            cmbSetor.ValueMember = "idcolaborador";
            cmbSetor.DisplayMember = "nome";


            if (setor.idsetor != 0)
            {
                lblID.Text = setor.idsetor.ToString();
                txtNome.Text = setor.nomesetor;
                btnCadastrar.Text = "Atualizar";             
            }
           
        }

        private void frmCadastroSetor_Resize(object sender, EventArgs e)
        {
            AjustarControles();
        }
    }
}
