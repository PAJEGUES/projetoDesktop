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
    public class clBairro
    {
        public int idbairro;
        public int idsetor;
        public int idcolaborador;
        public string nomeBairro;

        conectaBD BD = new conectaBD();

        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO cadastroBairro ( NOMEBAIRRO, IDSETOR ) " +
                    " values ('{0}', '{1}')", nomeBairro, idsetor) + "; SELECT SCOPE_IDENTITY();";



                BD.ExecutaComando(false, out id);
  
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }

            return id;

        }

        public void Excluir()
        {
            try
            {
                int exOK = 0;

                BD._sql = "DELETE FROM cadastroBairro WHERE idbairro = " + idbairro;

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

                BD._sql = "UPDATE cadastroBairro SET NOMEBAIRRO = '" + nomeBairro + "' where idbairro = " + idbairro;

                return BD.ExecutaComando(false);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;


        }

        public int AtualizarColaborador(string bairro, int colaborador)
        {
            try
            {
                BD._sql = "UPDATE cadastroBairro SET IDCOLABORADOR = " + colaborador + "where NOMEBAIRRO = '" + bairro + "'";

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
                BD._sql = "SELECT * FROM cadastroBairro " +
                         " WHERE NOME LIKE '%" + nomeBairro + "%' ";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable CarregaBairros()
        {
            try
            {
                BD._sql = "SELECT * FROM cadastroBairro ";

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
