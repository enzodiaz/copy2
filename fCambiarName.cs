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
            button1.DialogResult = DialogResult.OK;
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
                        
                    }
                    con.Close();
                    this.Close();
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
                    this.Close();
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
                    this.Close();
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
                    this.Close();
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
                    this.Close();
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
                    this.Close();
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
                    this.Close();
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
                    this.Close();
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
                    this.Close();
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
                    this.Close();
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
                    this.Close();
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
                    this.Close();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
