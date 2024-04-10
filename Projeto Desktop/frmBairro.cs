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
    public partial class frmBairro : Form
    {
        public frmBairro()
        {
            InitializeComponent();
        }

        clBairro bairro = new clBairro();
        clSetor setor = new clSetor();

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastroBairro bairro1 = new frmCadastroBairro();
            bairro1.ShowDialog();
            dgvBairro.DataSource = bairro.CarregaBairros();
        }

        private void txtPesquisaBairro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisaBairro.Text != "")
                {
                    bairro.nomeBairro = txtPesquisaBairro.Text;
                    dgvBairro.DataSource = bairro.PesquisaPorNome();
                }
                else
                {
                    dgvBairro.DataSource = bairro.CarregaBairros();
                }


                //Escolha das colunas que ficarão invisíveis
                dgvBairro.Columns[0].Visible = false;

                //Tamanho da coluna do nome
                dgvBairro.Columns[1].Width = 1683;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void frmBairro_Shown(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisaBairro.Text != "")
                {
                    bairro.nomeBairro = txtPesquisaBairro.Text;
                    dgvBairro.DataSource = bairro.PesquisaPorNome();
                }
                else
                {
                    dgvBairro.DataSource = bairro.CarregaBairros();
                }


                //Escolha das colunas que ficarão invisíveis
                dgvBairro.Columns[0].Visible = false;
                dgvBairro.Columns[1].Visible = false;

                //Tamanho da coluna do nome
                dgvBairro.Columns[2].Width = 1683;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvBairro.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvBairro.SelectedRows;
                bairro.idbairro = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show("Você tem certeza que deseja excluir o bairro " + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    bairro.Excluir();
                    txtPesquisaBairro_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um bairro para poder exclui-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection linha = dgvBairro.SelectedRows;

            if (linha.Count > 0)
            {
                bairro.idbairro = int.Parse(linha[0].Cells[0].Value.ToString());
                bairro.nomeBairro = linha[0].Cells[2].Value.ToString();

                frmCadastroBairro atualizar = new frmCadastroBairro();
                atualizar.bairro = bairro;
                atualizar.ShowDialog();
                dgvBairro.DataSource = bairro.CarregaBairros();
            }

            else
            {
                MessageBox.Show("Você precisa selecionar um bairro para poder alterar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        

    private void dgvBairro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
