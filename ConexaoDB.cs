using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace espaçoGIS
{
    public partial class ConexaoDB : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public string connstring;

        public ConexaoDB()
        {
            InitializeComponent();

            // Dados de conexão
            password_txt.PasswordChar = '*';
            server_txt.Text = "127.0.0.1";
            port_txt.Text = "5432";
            user_txt.Text = "postgres";
            password_txt.Text = "r3l04d3d";
            database_txt.Text = "teste";
        }

        private void PostGisFunctions_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Botão de conexão ao banco de dados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void connect_btn_Click(object sender, EventArgs e)
        {
                NpgsqlConnection conn = new NpgsqlConnection(connOpenDB());
                MessageBox.Show("Conexão ativada.");
        }

        /// <summary>
        /// Cria uma conexão com o banco de dados PostGIS.
        /// </summary>
        /// <returns></returns>
        public string connOpenDB()
        {
            // Configura a string de conexão
            this.connstring = string.Format("Server={0};Port={1};" +
                   "User Id={2};Password={3};Database={4};",
                   server_txt.Text, port_txt.Text, user_txt.Text,
                   password_txt.Text, database_txt.Text);

            // Checa campos vazios
            if (server_txt.Text == "" || port_txt.Text == "" || user_txt.Text == "" || password_txt.Text == "" || database_txt.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                // Abre a conexão com o banco
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return connstring;
        }
    }
}
