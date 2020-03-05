using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteDeMatematica
{
    public partial class Form2 : Form
    {
       
        int Temp;

        public class BancoD
        {
            private static SQLiteConnection sqliteConnection;
            public BancoD() { }
            private static SQLiteConnection DbConnection()
            {
                sqliteConnection = new SQLiteConnection("Data Source= C:\\Users\\Bruno\\Desktop\\C#\\TesteDeMatematica\\Cadastro.sqlite3; Version=3;");
                sqliteConnection.Open();
                return sqliteConnection;
            }

            public static DataTable GetPlacares()
            {
                SQLiteDataAdapter da = null;
                DataTable dt = new DataTable();
                try
                {
                    using (var cmd = DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "SELECT * FROM Placares ORDER BY Placares.Tempo";
                        da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                        da.Fill(dt);
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public static void Add(string nome, int tempo)
            {
                try
                {
                    using (var cmd = DbConnection().CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO Placares(Nome, Tempo ) values (@Nome, @Tempo)";
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@Tempo", tempo);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

            public Form2(int t)
        {
            Temp = t;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ExibirDados()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = BancoD.GetPlacares();
                dgvPlacar.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            string nome;

            if (txtNome.Text == null)
                nome = "Jogador";
            else
                nome = txtNome.Text;
            
            BancoD.Add(nome, Temp);
            ExibirDados();
        }
    }
}
