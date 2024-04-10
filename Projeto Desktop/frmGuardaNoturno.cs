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
    public partial class frmGuardaNoturno : Form
    {
        public frmGuardaNoturno()
        {
            InitializeComponent();
        }

        clColaborador colaborador = new clColaborador();

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadastroColaborador cadastro = new frmCadastroColaborador();
            cadastro.ShowDialog();
            dgvColaborador.DataSource = colaborador.CarregaClientes();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisa.Text != "")
                {
                    colaborador.nome = txtPesquisa.Text;
                    dgvColaborador.DataSource = colaborador.PesquisaPorNome();
                }
                else
                {
                    dgvColaborador.DataSource = colaborador.CarregaClientes();
                }
                

                //Escolha das colunas que ficarão invisíveis
                dgvColaborador.Columns[0].Visible = false;

                //Tamanho da coluna do nome
                dgvColaborador.Columns[1].Width = 183;
                dgvColaborador.Columns[2].Width = 181;
                dgvColaborador.Columns[3].Width = 181;
                dgvColaborador.Columns[4].Width = 181;
                dgvColaborador.Columns[5].Width = 181;
                dgvColaborador.Columns[6].Width = 181;
                dgvColaborador.Columns[7].Width = 181;
                dgvColaborador.Columns[8].Width = 181;
                dgvColaborador.Columns[9].Width = 181;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvColaborador.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvColaborador.SelectedRows;
                colaborador.idcolaborador = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show("Você tem certeza que deseja excluir o cliente " + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    colaborador.Excluir();
                    txtPesquisa_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um cliente para poder exclui-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmGuardaNoturno_Shown(object sender, EventArgs e)
        {
            try
            {
                dgvColaborador.DataSource = colaborador.CarregaClientes();

                //Escolha das colunas que ficarão invisíveis
                dgvColaborador.Columns[0].Visible = false;

                //Tamanho da coluna do nome
                dgvColaborador.Columns[1].Width = 183;
                dgvColaborador.Columns[2].Width = 181;
                dgvColaborador.Columns[3].Width = 181;
                dgvColaborador.Columns[4].Width = 181;
                dgvColaborador.Columns[5].Width = 181;
                dgvColaborador.Columns[6].Width = 181;
                dgvColaborador.Columns[7].Width = 181;
                dgvColaborador.Columns[8].Width = 181;
                dgvColaborador.Columns[9].Width = 181;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgvColaborador.SelectedRows;

            if (linha.Count > 0)
            {
                colaborador.idcolaborador = int.Parse(linha[0].Cells[0].Value.ToString());
                colaborador.nome = linha[0].Cells[1].Value.ToString();
                colaborador.veiculo = linha[0].Cells[2].Value.ToString();
                colaborador.placa = linha[0].Cells[3].Value.ToString();
                colaborador.email = linha[0].Cells[4].Value.ToString();
                colaborador.senha = linha[0].Cells[5].Value.ToString();
                colaborador.cpf = linha[0].Cells[6].Value.ToString();
                colaborador.nascimento = Convert.ToDateTime(linha[0].Cells[7].Value.ToString());
                colaborador.formapagamento = linha[0].Cells[8].Value.ToString();
                colaborador.diapagamento = Convert.ToInt32(linha[0].Cells[9].Value.ToString());

                frmCadastroColaborador formulario = new frmCadastroColaborador();
                formulario.colaborador = colaborador;
                formulario.ShowDialog();
                dgvColaborador.DataSource = colaborador.CarregaClientes();
            }

            else
            {
                MessageBox.Show("Você precisa selecionar um cliente para poder altera-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

            private void lblColaborador_Click(object sender, EventArgs e)
        {

        }

        private void frmGuardaNoturno_Load(object sender, EventArgs e)
        {

        }
    }
}
