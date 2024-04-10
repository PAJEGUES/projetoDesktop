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
    public class clAdministrador
    {
        public int idadministrador;
        public string email,senha,usuario;

        conectaBD BD = new conectaBD();

        public int Salvar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO cadastroAdministrador ( EMAIL, USUARIO, SENHA ) " +
                    " values ('{0}', '{1}', '{2}')", email, usuario, senha) + "; SELECT SCOPE_IDENTITY();";



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

                BD._sql = "DELETE FROM cadastroAdministrador WHERE idadministrador = " + idadministrador;

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

                BD._sql = "UPDATE cadastroAdministrador SET USUARIO = '" + usuario + "', senha = '" + senha + "', email = '" + email + "' where idadministrador = " + idadministrador;

                return BD.ExecutaComando(false);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;


        }

        public int Login(string usuario, string senha)
        {
            try
            {

                BD._sql = "SELECT * FROM cadastroAdministrador WHERE cadastroAdministrador.usuario = '" + usuario + "' AND cadastroAdministrador.senha = '"+ senha + "'";
                DataTable usuarios = BD.ExecutaSelect();
                return usuarios.Rows.Count;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;


        }

        public DataTable Recuperar(string usuario, string email)
        {
            try
            {

                BD._sql = "SELECT * FROM cadastroAdministrador WHERE cadastroAdministrador.usuario = '" + usuario + "' AND cadastroAdministrador.email = '" + email + "'";
                DataTable usuarios = BD.ExecutaSelect();
                return usuarios;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;


        }

        public DataTable CarregaAdm()
        {
            try
            {
                BD._sql = "SELECT * FROM cadastroAdministrador ";

                return BD.ExecutaSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable PesquisaPorNome()
        {
            try
            {
                BD._sql = "SELECT * FROM cadastroAdministrador " +
                         " WHERE USUARIO LIKE '%" + usuario + "%' ";

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
