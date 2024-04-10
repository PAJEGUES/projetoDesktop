using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data;

namespace Projeto_Desktop
{
    public class clColaborador
    {
        // atributos
        public int idcolaborador;
        public string nome;
        public string veiculo;
        public string placa;
        public string email;
        public string senha;
        public string cpf;
        public DateTime nascimento;
        public string formapagamento;
        public int diapagamento;

        public conectaBD BD = new conectaBD();

        // métodos

        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO cadastroColaborador ( NOME, VEICULO, PLACA, EMAIL, " +
                                                       "SENHA, CPF, NASCIMENTO, FORMAPAGAMENTO, DIAPAGAMENTO ) " +
                                              " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}' )",
                                                nome, veiculo, placa, email, senha, cpf, nascimento.ToShortDateString(),
                                                formapagamento, diapagamento) + "; SELECT SCOPE_IDENTITY();";



                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    return id;
                }
                else
                {
                    id = -1;
                }
            }

            catch (Exception ex)
            {
                id = -1;
            }

            return id;
        }


        public void Excluir()
        {
            try
            {
                int exOK = 0;

                BD._sql = "DELETE FROM cadastroColaborador WHERE idcolaborador = " + idcolaborador;

                exOK = BD.ExecutaComando(false);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int Atualizar()
        {
            try
            {

                BD._sql = "UPDATE cadastroColaborador SET NOME = '" + nome + "', VEICULO = '" + veiculo + "', PLACA = '" + placa + "', EMAIL = '" + email + "', SENHA = '" + senha + "', CPF = '" + cpf + "', NASCIMENTO = '" + nascimento + "', " +
                      "FORMAPAGAMENTO = '" + formapagamento + "', DIAPAGAMENTO = '" + diapagamento + "' where idcolaborador = " + idcolaborador;

                return BD.ExecutaComando(false);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;



        }

        public DataTable PesquisaPorNome()
        {
            try
            {
                BD._sql = "SELECT * FROM cadastroColaborador " +
                         " WHERE NOME LIKE '%" + nome + "%' ";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable CarregaClientes()
        {
            try
            {
                BD._sql = "SELECT * FROM cadastroColaborador ";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public DataTable listaColaborador()
        {
            try
            {
                BD._sql = "SELECT * FROM cadastroColaborador";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public DataTable listaBairro()
        {
            try
            {
                BD._sql = "SELECT * FROM cadastroBairro";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable PesquisaGeral( string pesquisa )
        {
            try
            {
                BD._sql = "SELECT* FROM VW_VISAO_GERAL WHERE NOME LIKE '%" + pesquisa + "%' OR[NOME SETOR] LIKE '%" + pesquisa + "%' OR[NOME BAIRRO] LIKE '%" + pesquisa + "%' ";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
