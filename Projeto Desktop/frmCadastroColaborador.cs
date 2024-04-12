using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Desktop
{
    public partial class frmCadastroColaborador : Form
    {
        public frmCadastroColaborador()
        {
            InitializeComponent();

        }

        public clColaborador colaborador = new clColaborador();
        public clBairro bairro = new clBairro();


        private bool ValidarCPF(string cpf)
        {

            int[] multiplicadoresPrimeiroDigito = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicadoresSegundoDigito = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = mTBCPF.Text;
            cpf = cpf.Trim().Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadoresPrimeiroDigito[i];
            }

            int resto = soma % 11;
            int primeiroDigito = resto < 2 ? 0 : 11 - resto;

            if (int.Parse(cpf[9].ToString()) != primeiroDigito)
            {
                return false;
            }

            soma = 0;
            tempCpf += primeiroDigito.ToString();

            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * multiplicadoresSegundoDigito[i];
            }

            resto = soma % 11;
            int segundoDigito = resto < 2 ? 0 : 11 - resto;

            return int.Parse(cpf[10].ToString()) == segundoDigito;
        }

        //Método Cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            bool salvar = true;

            string nome = txtNome.Text.Replace(" ", "");
            string veiculo = txtVeiculo.Text;
            string cpf = mTBCPF.Text.Replace(".", "").Replace("-", "").Replace(" ", "");
            string placa = mtbPlaca.Text.Replace("-", "");
            string formaPagamento = cbPagamento.SelectedItem?.ToString();
            string diaPagamento = cbDiaPagamento.SelectedItem?.ToString();
            string email = txtEmail.Text;
            DateTime dataNascimento = dTPIdade.Value;
            DateTime hoje = System.DateTime.Now;
            int idade = Convert.ToInt32((hoje - dataNascimento).TotalDays / 365);


            if(nome.Length == 0)
            {
                MessageBox.Show("Nome preenchido Incorretamente!");
                salvar = false;
            }

            if(veiculo == "")
            {
                MessageBox.Show("Motocicleta preenchido Incorretamente!");
                salvar = false;
            }

            if(!ValidarCPF(cpf))
            {
                MessageBox.Show("CPF Inválido!");
                salvar = false;
            }

            if (placa.Length < 7)
            {

                MessageBox.Show("Placa deve ser preenchida!");
                salvar = false;
            }

            if (idade < 18)
            {
                salvar = false;
                MessageBox.Show("A idade do colaborador deve ser maior ou igual a 18 anos!");
            }

            if (formaPagamento == null)
            {
                MessageBox.Show("Forma de pagamento deve ser preenchido!");
                salvar = false;
            }

            if (diaPagamento == null)
            {
                MessageBox.Show("Dia do pagamento deve ser preenchido!");
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

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"); 
            Match match = regex.Match(email);

            if (!match.Success)
            {
                MessageBox.Show("O email inserido é inválido!");
                salvar = false;
            }

            if (salvar)
            {
                colaborador.nome = txtNome.Text;
                colaborador.veiculo = txtVeiculo.Text;
                colaborador.placa = mtbPlaca.Text;
                colaborador.email = txtEmail.Text;
                colaborador.senha = txtSenha.Text;
                colaborador.cpf = mTBCPF.Text;
                colaborador.nascimento = dTPIdade.Value;
                colaborador.formapagamento = cbPagamento.Text;
                colaborador.diapagamento = Convert.ToInt32(cbDiaPagamento.Text);


                if (lblID.Text == "")
                {
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    int id = colaborador.Salvar();
                    foreach (var item in listBox1.SelectedItems)
                    {
                        bairro.AtualizarColaborador(item.ToString(), id);
                    }
                    lblID.Text = Convert.ToString(id);
                }
                else
                {
                    colaborador.idcolaborador = int.Parse(lblID.Text);
                    int attColaborador = colaborador.Atualizar();

                    if (attColaborador != 0)
                    {
                        MessageBox.Show("Cliente Alterado com sucesso!", "Salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao alterar Cliente, contate o desenvolvedor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.Close();
            }        

            

        }

        //Método Limpar
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mTBCPF.Text = "";
            cbPagamento.Text = "";
            txtEmail.Text = "";
            cbDiaPagamento.Text = "";
            txtNome.Text = "";
            mtbPlaca.Text = "";
            txtSenha.Text = "";
            txtVeiculo.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        //Método Atualizar
        private void frmCadastroColaborador_Load(object sender, EventArgs e)
        {

            AjustarControles();

            if (colaborador.idcolaborador != 0)
            {
                lblID.Text = colaborador.idcolaborador.ToString();
                mTBCPF.Text = colaborador.cpf;
                dTPIdade.Value = colaborador.nascimento;
                cbPagamento.Text = colaborador.formapagamento;
                txtEmail.Text = colaborador.email;
                cbDiaPagamento.Text = Convert.ToString(colaborador.diapagamento);
                txtNome.Text = colaborador.nome;
                mtbPlaca.Text = colaborador.placa;
                txtSenha.Text = colaborador.senha;
                txtVeiculo.Text = colaborador.veiculo;
                btnCadastrar.Text = "Atualizar";

                clBairro b = new clBairro();

                DataTable bairros = b.CarregaBairros();
                if (bairros.Rows.Count > 0)
                {
                    foreach (DataRow bairro in bairros.Rows)
                    {
                        listBox1.Items.Add(bairro["nomebairro"]);
                    }
                }
                else
                {
                    Console.WriteLine("sem itens");
                }
                
            }

            else
            {
                clBairro b = new clBairro();

                DataTable bairros = b.CarregaBairros();
                if (bairros.Rows.Count > 0)
                {
                    foreach (DataRow bairro in bairros.Rows)
                    {
                        listBox1.Items.Add(bairro["nomebairro"]);
                    }
                }
                else
                {
                    Console.WriteLine("sem itens");
                }
            }
        }

        private void frmCadastroColaborador_Resize(object sender, EventArgs e)
        {
            AjustarControles();
        }
    }
}
