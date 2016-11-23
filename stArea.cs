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
    public partial class stArea : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public string connstring;

        ConexaoDB pgf = new ConexaoDB();

        public stArea()
        {
            InitializeComponent();
        }

        private void calculoArea(NpgsqlConnection conn)
        {
            string tabela = "malha";
            string sql = "select *, st_area(geom) as area from " + tabela + ";";
            carregarDataGridView(sql, conn);
        }

        private void carregarDataGridView(string sql, NpgsqlConnection conn)
        {
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            // Dá um reset no dataset para começar a usar do zero
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            // Sempre fecha a conexão com o banco após a resposta de uma query
            conn.Close();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection(pgf.connOpenDB());
            calculoArea(conn);
        }
    }
}
