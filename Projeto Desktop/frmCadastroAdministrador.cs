using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Desktop
{
    public partial class frmCadastroAdministrador : Form
    {
        bool editarOn;
        public frmCadastroAdministrador(bool editar)
        {
            InitializeComponent();
            this.editarOn = editar;
        }

        public clAdministrador adm = new clAdministrador();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool salvar = true;

            string email = txtEmail.Text;


            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);

            if (!match.Success)
            {
                MessageBox.Show("O email inserido é inválido!");
                salvar = false;
            }

            if (txtUsuario.Text.Length > 20)
            {
                MessageBox.Show("O Usuario deve conter no máximo 20 dígitos!");
                salvar = false;
            }

            if (txtSenha.Text.Length < 8)
            {
                MessageBox.Show("A senha deve conter 8 dígitos!");
                salvar = false;
            }

            if (txtSenha.Text.Length > 12)
            {
                MessageBox.Show("A senha pode conter no máximo 12 dígitos!");
                salvar = false;
            }

            adm.email = txtEmail.Text;
            adm.usuario = txtUsuario.Text;
            adm.senha = txtSenha.Text;

            if (!this.editarOn)
            {
                if (salvar)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    int id = adm.Salvar();
                    lblID.Text = Convert.ToString(id);
                }

                else
                {
                    MessageBox.Show("Erro ao cadastrar Usuario!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DataTable table = adm.Recuperar(txtUsuario.Text, txtEmail.Text);

                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Usuario Inexistente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                adm.idadministrador = Convert.ToInt32(table.Rows[0]["idadministrador"]);

                int attColaborador = adm.Atualizar();

                if (attColaborador != 0)
                {
                    MessageBox.Show("Administrador Alterado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao alterar Administrador, contate o desenvolvedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();


        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtUsuario.Text = "";
        }

        private void frmCadastroAdministrador_Load(object sender, EventArgs e)
        {
            AjustarControles();
            if (adm.idadministrador == 0)
            {
                lblID.Text = adm.idadministrador.ToString();
                txtEmail.Text = adm.email;
                txtSenha.Text = adm.senha;
                txtUsuario.Text = adm.usuario;
                btnCadastrar.Text = "CADASTRAR";
            }


            if (adm.idadministrador != 0)
            {
                lblID.Text = adm.idadministrador.ToString();
                txtEmail.Text = adm.email;
                txtEmail.Enabled = false;
                txtSenha.Text = adm.senha;
                txtUsuario.Text = adm.usuario;
                txtUsuario.Enabled = false;
                btnCadastrar.Text = "ATUALIZAR";
            }

        }

        private void pbSeta_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void frmCadastroAdministrador_Resize(object sender, EventArgs e)
        {
            AjustarControles();
        }
    }

}
