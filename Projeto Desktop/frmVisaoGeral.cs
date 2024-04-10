using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Desktop
{
    partial class frmVisaoGeral : Form
    {
        public frmVisaoGeral()
        {
            InitializeComponent();
        }

        clColaborador visaoGeralColaborador = new clColaborador();

        private void frmVisaoGeral_Load(object sender, EventArgs e)
        {

            try
            {
                dgvColaborador.DataSource = visaoGeralColaborador.PesquisaGeral(txtPesquisaGeral.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }

            dgvColaborador.Columns[9].Visible = false;
            dgvColaborador.Columns[11].Visible = false;

            dgvColaborador.Columns[0].Width = 100;
            dgvColaborador.Columns[1].Width = 128;
            dgvColaborador.Columns[2].Width = 78;
            dgvColaborador.Columns[3].Width = 128;
            dgvColaborador.Columns[4].Width = 199;
            dgvColaborador.Columns[5].Width = 100;
            dgvColaborador.Columns[6].Width = 128;
            dgvColaborador.Columns[7].Width = 64;
            dgvColaborador.Columns[8].Width = 64;           
            dgvColaborador.Columns[10].Width = 100;         
            dgvColaborador.Columns[12].Width = 158;


        }

        private void txtPesquisaGeral_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvColaborador.DataSource = visaoGeralColaborador.PesquisaGeral(txtPesquisaGeral.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void dgvColaborador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
