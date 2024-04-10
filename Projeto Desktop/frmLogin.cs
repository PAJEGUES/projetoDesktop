using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Projeto_Desktop
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public clAdministrador adm = new clAdministrador();

        private void button1_Click(object sender, EventArgs e)
        {
            if (adm.Login(txtUsuario.Text, txtSenha.Text) != 0)
            {
                frmHome home = new frmHome();
                home.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCadastroAdministrador adm = new frmCadastroAdministrador(true);
            adm.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            AjustarControles();
        }

        private void AjustarControles()
        {
            float larguraInicial = 1024;
            float alturaInicial = 768;

            float larguraFinal = this.Width;
            float alturaFinal = this.Height;

            float pxB = 52 - (larguraInicial / 2 - larguraFinal / 2);
            float pyB = 43 - (alturaInicial / 2 - alturaFinal / 2);
            groupBox1.Location = new Point((int)pxB, (int)pyB);
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            AjustarControles();
        }
    }
}
