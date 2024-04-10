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
    public partial class frmSetores : Form
    {
        public frmSetores()
        {
            InitializeComponent();
        }

        clSetor setor = new clSetor(); 
        clColaborador colaborador = new clColaborador();

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            frmCadastroSetor setor1 = new frmCadastroSetor();
            setor1.ShowDialog();
            dgvSetor.DataSource = setor.CarregaSetor();

        }

        //Método para mostrar os registros do banco de dados no dgvSetor
        private void frmSetores_Shown(object sender, EventArgs e)
        {

            try
            {
                if (txtPesquisaSetor.Text != "")
                {
                    setor.nomesetor = txtPesquisaSetor.Text;
                    dgvSetor.DataSource = setor.PesquisaPorNome();
                }
                else
                {
                    dgvSetor.DataSource = setor.CarregaSetor();
                }


                //Escolha das colunas que ficarão invisíveis
                dgvSetor.Columns[0].Visible = false;


                //Tamanho da coluna do nome
                dgvSetor.Columns[1].Width = 842;
                dgvSetor.Columns[2].Width = 841;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }

        }

        //Método para pesquisa dos setores
        private void txtPesquisaSetor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtPesquisaSetor.Text != "")
                {
                    setor.nomesetor = txtPesquisaSetor.Text;
                    dgvSetor.DataSource = setor.PesquisaPorNome();
                }
                else
                {
                    dgvSetor.DataSource = setor.CarregaSetor();
                }


                //Escolha das colunas que ficarão invisíveis
                dgvSetor.Columns[0].Visible = false;

                //Tamanho da coluna do nome
                dgvSetor.Columns[1].Width = 842;
                dgvSetor.Columns[2].Width = 841;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO.: " + ex.Message);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvSetor.SelectedRows.Count > 0)
            {
                DataGridViewSelectedRowCollection linha = dgvSetor.SelectedRows;
                setor.idsetor = int.Parse(linha[0].Cells[0].Value.ToString());

                DialogResult resposta = MessageBox.Show("Você tem certeza que deseja excluir o setor " + linha[0].Cells[1].Value.ToString() + " ?", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    setor.Excluir();
                    txtPesquisaSetor_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Você precisa selecionar um setor para poder exclui-lo!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            DataGridViewSelectedRowCollection linha = dgvSetor.SelectedRows;
            
            if(linha.Count > 0)
            {
                setor.idsetor = int.Parse(linha[0].Cells[0].Value.ToString());
                setor.nomesetor = linha[0].Cells[2].Value.ToString();
                setor.idcolaborador = int.Parse(linha[0].Cells[1].Value.ToString());

                frmCadastroSetor atualizar = new frmCadastroSetor();
                atualizar.setor = setor;
                atualizar.ShowDialog();
                dgvSetor.DataSource = setor.CarregaSetor();

            }

            else
            {
                MessageBox.Show("Você precisa selecionar um setor para poder alterar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
            


        }
    }
}
