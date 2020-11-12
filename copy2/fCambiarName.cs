using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace copy2
{
    public partial class fCambiarName : Form
    {
        public fCambiarName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button1' ";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                        f1.Show();
                        this.Hide();
                    }
                    con.Close();
                    break;

                case 2:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button2'";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    f1.Show();
                    this.Hide();
                    break;

                case 3:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button3'";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    f1.Show();
                    this.Hide();
                    break;

                case 4:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button4'";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    f1.Show();
                    this.Hide();
                    break;

                case 5:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button5'";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    f1.Show();
                    this.Hide();
                    break;

                case 6:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button6'";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    f1.Show();
                    this.Hide();
                    break;

                case 7:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button7'";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    f1.Show();
                    this.Hide();
                    break;

                case 8:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button8'";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    f1.Show();
                    this.Hide();
                    break;

                case 9:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button9'";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    f1.Show();
                    this.Hide();
                    break;

                case 10:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button10'";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    f1.Show();
                    this.Hide();
                    break;

                case 11:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button11'";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    f1.Show();
                    this.Hide();
                    break;

                case 12:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button12'";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    f1.Show();
                    this.Hide();
                    break;

                case 13:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button13'";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    f1.Show();
                    this.Hide();
                    break;

                case 14:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button14'";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    f1.Show();
                    this.Hide();
                    break;

                case 15:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button15'";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    f1.Show();
                    this.Hide();
                    break;

                case 16:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "UPDATE botones SET titulo =:text WHERE id_boton = 'button16'";
                        command.Parameters.Add("text", DbType.String).Value = textBox1.Text;
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    f1.Show();
                    this.Hide();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Close();
            f1.Show();
        }

        private void fCambiarName_Load(object sender, EventArgs e)
        {

        }

        private void fCambiarName_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
