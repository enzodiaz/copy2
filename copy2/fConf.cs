using System;
using System.Data.SQLite;
using System.Data;
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
            this.Close();

        }

        private void frmConf_Load(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data source = copy.sqlite" +
                "");
            string sel = "SELECT info,titulo FROM botones WHERE id_boton IS NOT NULL AND id_boton= ";
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
            if (txtEditar.Text.Length > 0)
            {
                SQLiteConnection con = new SQLiteConnection("Data source = copy.sqlite");
                Form1 f1 = new Form1();
                switch (Globales.num)
                {
                    case 1:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "UPDATE botones SET titulo =:titulo,info =:info WHERE id_boton = 'button1' ";
                            command.Parameters.Add("info", DbType.String).Value = txtEditar.Text;
                            command.Parameters.Add("titulo", DbType.String).Value = txtTit.Text;
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                        this.Close();
                        break;

                    case 2:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "UPDATE botones SET titulo =:titulo,info =:info WHERE id_boton = 'button2' ";
                            command.Parameters.Add("info", DbType.String).Value = txtEditar.Text;
                            command.Parameters.Add("titulo", DbType.String).Value = txtTit.Text;
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                        this.Close();
                        break;

                    case 3:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "UPDATE botones SET titulo =:titulo,info =:info WHERE id_boton = 'button3' ";
                            command.Parameters.Add("info", DbType.String).Value = txtEditar.Text;
                            command.Parameters.Add("titulo", DbType.String).Value = txtTit.Text;
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                        this.Close();
                        break;

                    case 4:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "UPDATE botones SET titulo =:titulo,info =:info WHERE id_boton = 'button4' ";
                            command.Parameters.Add("info", DbType.String).Value = txtEditar.Text;
                            command.Parameters.Add("titulo", DbType.String).Value = txtTit.Text;
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                        this.Close();
                        break;

                    case 5:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "UPDATE botones SET titulo =:titulo,info =:info WHERE id_boton = 'button5' ";
                            command.Parameters.Add("info", DbType.String).Value = txtEditar.Text;
                            command.Parameters.Add("titulo", DbType.String).Value = txtTit.Text;
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                        this.Close();
                        break;

                    case 6:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "UPDATE botones SET titulo =:titulo,info =:info WHERE id_boton = 'button6' ";
                            command.Parameters.Add("info", DbType.String).Value = txtEditar.Text;
                            command.Parameters.Add("titulo", DbType.String).Value = txtTit.Text;
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                        this.Close();
                        break;

                    case 7:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "UPDATE botones SET titulo =:titulo,info =:info WHERE id_boton = 'button7' ";
                            command.Parameters.Add("info", DbType.String).Value = txtEditar.Text;
                            command.Parameters.Add("titulo", DbType.String).Value = txtTit.Text;
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                        this.Close();
                        break;

                    case 8:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "UPDATE botones SET titulo =:titulo,info =:info WHERE id_boton = 'button8' ";
                            command.Parameters.Add("info", DbType.String).Value = txtEditar.Text;
                            command.Parameters.Add("titulo", DbType.String).Value = txtTit.Text;
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                        this.Close();
                        break;

                    case 9:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "UPDATE botones SET titulo =:titulo,info =:info WHERE id_boton = 'button9' ";
                            command.Parameters.Add("info", DbType.String).Value = txtEditar.Text;
                            command.Parameters.Add("titulo", DbType.String).Value = txtTit.Text;
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                        this.Close();
                        break;

                    case 10:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "UPDATE botones SET titulo =:titulo,info =:info WHERE id_boton = 'button10' ";
                            command.Parameters.Add("info", DbType.String).Value = txtEditar.Text;
                            command.Parameters.Add("titulo", DbType.String).Value = txtTit.Text;
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                        this.Close();
                        break;

                    case 11:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "UPDATE botones SET titulo =:titulo,info =:info WHERE id_boton = 'button11' ";
                            command.Parameters.Add("info", DbType.String).Value = txtEditar.Text;
                            command.Parameters.Add("titulo", DbType.String).Value = txtTit.Text;
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                        this.Close();
                        break;

                    case 12:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "UPDATE botones SET titulo =:titulo,info =:info WHERE id_boton = 'button12' ";
                            command.Parameters.Add("info", DbType.String).Value = txtEditar.Text;
                            command.Parameters.Add("titulo", DbType.String).Value = txtTit.Text;
                            command.ExecuteNonQuery();
                        }
                        con.Close();
                        this.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Debe completar el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool arr;
        private int mouseX;
        private int mouseY;

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            arr = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (arr)
                {
                    this.Top = Cursor.Position.Y - mouseY;
                    this.Left = Cursor.Position.X - mouseX;
                }

            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            arr = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
