using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Projeto_Desktop
{
    public partial class frmHome : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidhtEllipse,
            int nHeightEllipse
        );

        public frmHome() 
        { 
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(activeForm !=null) 
            { 
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(childForm);
            pnlPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pbLogo_Click_1(object sender, EventArgs e)
        {
            pbLogoSafeHouse.Visible = true;
            btnAdm.BackColor = Color.FromArgb(24, 30, 54);
            btnBairros.BackColor = Color.FromArgb(24, 30, 54);
            btnGuardaNoturno.BackColor = Color.FromArgb(24, 30, 54);
            btnSetores.BackColor = Color.FromArgb(24, 30, 54);
            btnVisaoGeral.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnVisaoGeral_Click(object sender, EventArgs e)
        {
            pnlMenuEsquerdo.Height = btnVisaoGeral.Height;
            pnlMenuEsquerdo.Top = btnVisaoGeral.Top;
            btnVisaoGeral.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new frmVisaoGeral());
            pbLogoSafeHouse.Visible = false;
        }

        private void btnSetores_Click_1(object sender, EventArgs e)
        {
            pnlMenuEsquerdo.Height = btnSetores.Height;
            pnlMenuEsquerdo.Top = btnSetores.Top;
            btnSetores.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new frmSetores());
            pbLogoSafeHouse.Visible = false;
        }

        private void btnGuardaNoturno_Click(object sender, EventArgs e)
        {
            pnlMenuEsquerdo.Height = btnGuardaNoturno.Height;
            pnlMenuEsquerdo.Top = btnGuardaNoturno.Top;
            pnlMenuEsquerdo.Left = btnGuardaNoturno.Left;
            btnGuardaNoturno.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new frmGuardaNoturno());
            pbLogoSafeHouse.Visible = false;
        }

        private void btnBairros_Click(object sender, EventArgs e)
        {
            pnlMenuEsquerdo.Height = btnBairros.Height;
            pnlMenuEsquerdo.Top = btnBairros.Top;
            btnBairros.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new frmBairro());
            pbLogoSafeHouse.Visible = false;
        }

        private void btnAdm_Click(object sender, EventArgs e)
        {
            pnlMenuEsquerdo.Height = btnAdm.Height;
            pnlMenuEsquerdo.Top = btnAdm.Top;
            btnAdm.BackColor = Color.FromArgb(46, 51, 73);
            openChildForm(new frmAdministrador());
            pbLogoSafeHouse.Visible = false;
        }

        private void btnAdm_Leave(object sender, EventArgs e)
        {
            btnAdm.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnBairros_Leave(object sender, EventArgs e)
        {
            btnBairros.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnGuardaNoturno_Leave(object sender, EventArgs e)
        {
            btnGuardaNoturno.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSetores_Leave(object sender, EventArgs e)
        {
            btnSetores.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnVisaoGeral_Leave(object sender, EventArgs e)
        {
            btnVisaoGeral.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
