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
    public class clSetor
    {
        public int idcolaborador;
        public int idsetor;
        public string nomesetor;
        

        conectaBD BD = new conectaBD();


        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO cadastroSetor ( NOMESETOR, IDCOLABORADOR )" +
                                              " values ('{0}','{1}' )" 
                                                , nomesetor, idcolaborador) + "; SELECT SCOPE_IDENTITY();";

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

                BD._sql = "DELETE FROM cadastroSetor WHERE idsetor = " + idsetor;

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
                BD._sql = "UPDATE cadastroSetor SET NOMESETOR = '" + nomesetor + "', IDCOLABORADOR = '" + idcolaborador + "' where idsetor = " + idsetor;

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
                BD._sql = "SELECT * FROM cadastroSetor " +
                         " WHERE NOME LIKE '%" + nomesetor + "%' ";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable CarregaSetor()
        {
            try
            {
                BD._sql = "SELECT cS.idsetor AS id, cS.nomesetor AS Setor, cC.nome AS Colaborador FROM projetoDesktop.dbo.cadastroSetor AS cS JOIN projetoDesktop.dbo.cadastroColaborador AS cC ON cS.idcolaborador = cC.idcolaborador; ";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        public DataTable listaSetor()
        {
            try
            {
                BD._sql = "SELECT * FROM cadastroSetor";

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
