using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace ProjectLayers.Code.DAL
{
    class DatabaseAcess
    {
        private string server = "localhost";
        private string port = "5432";
        private string user = "postgres";
        private string password = "univel";
        private string database = "exemplo_crud";

        private NpgsqlConnection conn;
        private DataTable data;
        private NpgsqlDataAdapter da;
        private NpgsqlDataReader dr;
        private NpgsqlCommandBuilder cb;

        public void ConectaBanco()
        {
            if (conn == null)
            {
                string connStr = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4}", server, port, user, password, database);
                try
                {
                    conn = new NpgsqlConnection(connStr);
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar banco de dados!\n" + ex.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public int ExecutaComando(string sql)
        {
            int i = 0;
            try
            {
                NpgsqlCommand comando = new NpgsqlCommand(sql, conn);
                i = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao executar comando!\n" + ex.ToString(), "Erro na execução", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return i;
        }

        public DataTable RetDataTable(string sql)
        {
            data = new DataTable();
            da = new NpgsqlDataAdapter(sql, conn);
            cb = new NpgsqlCommandBuilder(da);
            return data;
        }

        public NpgsqlDataReader RetDataReader(string sql)
        {
            NpgsqlCommand comando = new NpgsqlCommand(sql, conn);
            NpgsqlDataReader dr = comando.ExecuteReader();
            return dr;
        }

    }
}
