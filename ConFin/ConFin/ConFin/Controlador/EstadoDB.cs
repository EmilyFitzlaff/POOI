using ConFin.Modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConFin.Controlador
{
    public class EstadoDB
    {
        public static List<Estado> getEstados()
        {
            List<Estado> lista = new List<Estado>();
            try
            {
                NpgsqlConnection conexao = Conexao.getConexao();
                string sql = "select * from estado"; 
                NpgsqlCommand cmd = new NpgsqlCommand(sql,conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string sigla = (string) dr["est_sigla"];
                    string nome = (string) dr["nome"];
                    Estado estado = new Estado(sigla, nome);
                    lista.Add(estado);
                }
                dr.Close();
                conexao.Close();
            }catch(NpgsqlException erro)
            {
                MessageBox.Show("Erro de SQL: " + erro.Message);
            }
            return lista;
        }

        public static bool setIncluiEstado(Estado estado)
        {
            bool efetuou = false;
            try
            {
                NpgsqlConnection conexao = Conexao.getConexao();
                string sql = "insert into estado (est_sigla,nome) values(@sigla,@nome)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql,conexao);
                cmd.Parameters.Add("@sigla", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.est_sigla;
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.nome;
                int inseriu = cmd.ExecuteNonQuery();
                if(inseriu == 1)
                {
                    efetuou = true;
                }
                conexao.Close();
            }
            catch(NpgsqlException erro)
            {
                MessageBox.Show("Erro de SQL: " + erro.Message);
            }
            return efetuou;
        }

        public static bool setAlteraEstado(Estado estado)
        {
            bool efetuou = false;
            try
            {
                NpgsqlConnection conexao = Conexao.getConexao();
                string sql = "update estado set nome = @nome where est_sigla = @sigla";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.Add("@nome", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.nome;
                cmd.Parameters.Add("@sigla", NpgsqlTypes.NpgsqlDbType.Varchar).Value = estado.est_sigla;
                int alterou = cmd.ExecuteNonQuery();
                if (alterou == 1)
                {
                    efetuou = true;
                }
                conexao.Close();
            }
            catch(NpgsqlException erro)
            {
                MessageBox.Show("Erro de SQL: " + erro.Message);
            }
            return efetuou;
        }

        public static bool setExcluiEstado(string sigla)
        {
            bool efetuou = false;
            try
            {
                NpgsqlConnection conexao = Conexao.getConexao();
                string sql = "delete from estado where est_sigla = @sigla";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);                
                cmd.Parameters.Add("@sigla", NpgsqlTypes.NpgsqlDbType.Varchar).Value = sigla;
                int excluiu = cmd.ExecuteNonQuery();
                if (excluiu == 1)
                {
                    efetuou = true;
                }
                conexao.Close();
            }
            catch (NpgsqlException erro)
            {
                MessageBox.Show("Erro de SQL: " + erro.Message);
            }
            return efetuou;
        }
    }
}
