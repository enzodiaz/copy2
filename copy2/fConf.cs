using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace copy2
{
    public partial class frmConf : Form
    {
        public frmConf()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void frmConf_Load(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data source = copy.sqlite" +
                "");
            string sel = "SELECT info,titulo FROM botones WHERE id_boton= ";
            Form1 f1 = new Form1();
            switch (Globales.num)
            {
                case 1:
                    sel += "'button1'";
                    using (SQLiteCommand command = new SQLiteCommand(sel,con))
                    {
                        con.Open();
                        SQLiteDataReader sql = command.ExecuteReader();
                        while (sql.Read())
                        {
                            txtEditar.Text = Convert.ToString(sql[0]);
                            txtTit.Text = Convert.ToString(sql[1]);
                        }
                        con.Close();
                    }
                    break;
                case 2:
                    sel += "'button2'";
                    using (SQLiteCommand command = new SQLiteCommand(sel, con))
                    {
                        con.Open();
                        SQLiteDataReader sql = command.ExecuteReader();
                        while (sql.Read())
                        {
                            txtEditar.Text = Convert.ToString(sql[0]);
                            txtTit.Text = Convert.ToString(sql[1]);
                        }
                        con.Close();
                    }
                    break;

                case 3:
                    sel += "'button3'";
                    using (SQLiteCommand command = new SQLiteCommand(sel, con))
                    {
                        con.Open();
                        SQLiteDataReader sql = command.ExecuteReader();
                        while (sql.Read())
                        {
                            txtEditar.Text = Convert.ToString(sql[0]);
                            txtTit.Text = Convert.ToString(sql[1]);
                        }
                        con.Close();
                    }
                    break;

                case 4:
                    sel += "'button4'";
                    using (SQLiteCommand command = new SQLiteCommand(sel, con))
                    {
                        con.Open();
                        SQLiteDataReader sql = command.ExecuteReader();
                        while (sql.Read())
                        {
                            txtEditar.Text = Convert.ToString(sql[0]);
                            txtTit.Text = Convert.ToString(sql[1]);
                        }
                        con.Close();
                    }
                    break;

                case 5:
                    sel += "'button5'";
                    using (SQLiteCommand command = new SQLiteCommand(sel, con))
                    {
                        con.Open();
                        SQLiteDataReader sql = command.ExecuteReader();
                        while (sql.Read())
                        {
                            txtEditar.Text = Convert.ToString(sql[0]);
                            txtTit.Text = Convert.ToString(sql[1]);
                        }
                        con.Close();
                    }
                    break;

                case 6:
                    sel += "'button6'";
                    using (SQLiteCommand command = new SQLiteCommand(sel, con))
                    {
                        con.Open();
                        SQLiteDataReader sql = command.ExecuteReader();
                        while (sql.Read())
                        {
                            txtEditar.Text = Convert.ToString(sql[0]);
                            txtTit.Text = Convert.ToString(sql[1]);
                        }
                        con.Close();
                    }
                    break;

                case 7:
                    sel += "'button7'";
                    using (SQLiteCommand command = new SQLiteCommand(sel, con))
                    {
                        con.Open();
                        SQLiteDataReader sql = command.ExecuteReader();
                        while (sql.Read())
                        {
                            txtEditar.Text = Convert.ToString(sql[0]);
                            txtTit.Text = Convert.ToString(sql[1]);
                        }
                        con.Close();
                    }
                    break;

                case 8:
                    sel += "'button8'";
                    using (SQLiteCommand command = new SQLiteCommand(sel, con))
                    {
                        con.Open();
                        SQLiteDataReader sql = command.ExecuteReader();
                        while (sql.Read())
                        {
                            txtEditar.Text = Convert.ToString(sql[0]);
                            txtTit.Text = Convert.ToString(sql[1]);
                        }
                        con.Close();
                    }
                    break;

                case 9:
                    sel += "'button9'";
                    using (SQLiteCommand command = new SQLiteCommand(sel, con))
                    {
                        con.Open();
                        SQLiteDataReader sql = command.ExecuteReader();
                        while (sql.Read())
                        {
                            txtEditar.Text = Convert.ToString(sql[0]);
                            txtTit.Text = Convert.ToString(sql[1]);
                        }
                        con.Close();
                    }
                    break;

                case 10:
                    sel += "'button10'";
                    using (SQLiteCommand command = new SQLiteCommand(sel, con))
                    {
                        con.Open();
                        SQLiteDataReader sql = command.ExecuteReader();
                        while (sql.Read())
                        {
                            txtEditar.Text = Convert.ToString(sql[0]);
                            txtTit.Text = Convert.ToString(sql[1]);
                        }
                        con.Close();
                    }
                    break;

                case 11:
                    sel += "'button11'";
                    using (SQLiteCommand command = new SQLiteCommand(sel, con))
                    {
                        con.Open();
                        SQLiteDataReader sql = command.ExecuteReader();
                        while (sql.Read())
                        {
                            txtEditar.Text = Convert.ToString(sql[0]);
                            txtTit.Text = Convert.ToString(sql[1]);
                        }
                        con.Close();
                    }
                    break;

                case 12:
                    sel += "'button12'";
                    using (SQLiteCommand command = new SQLiteCommand(sel, con))
                    {
                        con.Open();
                        SQLiteDataReader sql = command.ExecuteReader();
                        while (sql.Read())
                        {
                            txtEditar.Text = Convert.ToString(sql[0]);
                            txtTit.Text = Convert.ToString(sql[1]);
                        }
                        con.Close();
                    }
                    break;
            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
