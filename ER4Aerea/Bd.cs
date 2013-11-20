using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ER4Aerea
{
    public class Bd
    {
        private OleDbConnection conn;
        private string usuario { get; set; }
        private string senha { get; set; }
        public static string NOME_USUARIO_LOGADO { get; set; }
        public static int ID_USUARIO_LOGADO { get; set; }
        
        private static Bd instance;
        private Bd(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
            string strConexao = "Provider=MSDAORA;Data Source=XE;User Id=" + usuario + ";Password=" + senha + ";";
            this.conn = new OleDbConnection();
            this.conn.ConnectionString = strConexao;
            try
            {
                this.conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public static Bd Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new Bd("PI", "PI");
                }
                return instance;
            }
        }
        public OleDbConnection obterConexao()
        {
            return this.conn;
        }
        public OleDbDataReader obterQuery(string strSelect)
        {
            OleDbCommand cmd = new OleDbCommand(strSelect, this.conn);

            OleDbDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            return dr;
        }
        public string aspas(string str) {
            return (char)39 + str + (char)39;
        }

        public void executaComando(string sql)
        {
            try
            {
                OleDbConnection cnn = this.obterConexao();

                OleDbCommand cmd = cnn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sql;
                MessageBox.Show(sql);
                cmd.ExecuteNonQuery();
            }
            catch (OleDbException e)
            {
                throw e;
            }

        }
        public int obterSequencia(string sequence) {

            OleDbCommand cmd = new OleDbCommand("Select " + sequence + ".nextval from dual", obterConexao());
            
            OleDbDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();
            dr.Read();
            string valor=dr[0].ToString();
            return Int32.Parse(valor);
        }

    }
}
