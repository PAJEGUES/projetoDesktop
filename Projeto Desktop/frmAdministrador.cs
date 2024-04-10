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
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }

        clAdministrador adm = new clAdministrador();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadastroAdministrador cadastro = new frmCadastroAdministrador(false);
            cadastro.ShowDialog();
            dgvAdm.DataSource = adm.CarregaAdm();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisa.Text != "")
                {
                    adm.usuario = txtPesquisa.Text;
                    dgvAdm.DataSource = adm.PesquisaPorNome();
                }
                else
                {
                    dgvAdm.DataSource = adm.CarregaAdm();
                }

                //Escolha das colunas que ficarão invisíveis
                dgvAdm.Columns[0].Visible = false;
                dgvAdm.Columns[2].Visible = false;

                //Tamanho da coluna do nome
                dgvAdm.Columns[1].Width = 183;    
                dgvAdm.Columns[3].Width = 181;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void frmAdministrador_Load(object sender, EventArgs e)
        {
            try
            {
                dgvAdm.DataSource = adm.CarregaAdm();

                //Escolha das colunas que ficarão invisíveis
                dgvAdm.Columns[0].Visible = false;
                dgvAdm.Columns[2].Visible = false;

                //Tamanho da coluna do nome
                dgvAdm.Columns[1].Width = 183;
                dgvAdm.Columns[3].Width = 181;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvAdm.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvAdm.SelectedRows;
                adm.idadministrador = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show("Você tem certeza que deseja excluir o Administrador " + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    adm.Excluir();
                    txtPesquisa_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um cliente para poder exclui-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvAdm.SelectedRows;

            if (linha.Count > 0)
            {
                adm.idadministrador = int.Parse(linha[0].Cells[0].Value.ToString());
                adm.email = linha[0].Cells[1].Value.ToString();
                adm.senha = linha[0].Cells[2].Value.ToString();
                adm.usuario = linha[0].Cells[3].Value.ToString();

                frmCadastroAdministrador formulario = new frmCadastroAdministrador(true);
                formulario.adm = adm;
                formulario.ShowDialog();
                dgvAdm.DataSource = adm.CarregaAdm();
            }

            else
            {
                MessageBox.Show("Você precisa selecionar um Administrador para poder alterar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
