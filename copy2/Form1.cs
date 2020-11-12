using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace copy2
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            button1.MouseUp += new MouseEventHandler(buttons_Click);
            button2.MouseUp += new MouseEventHandler(buttons_Click);
            button3.MouseUp += new MouseEventHandler(buttons_Click);
            button4.MouseUp += new MouseEventHandler(buttons_Click);
            button5.MouseUp += new MouseEventHandler(buttons_Click);
            button6.MouseUp += new MouseEventHandler(buttons_Click);
            button7.MouseUp += new MouseEventHandler(buttons_Click);
            button8.MouseUp += new MouseEventHandler(buttons_Click);
            button9.MouseUp += new MouseEventHandler(buttons_Click);
            button10.MouseUp += new MouseEventHandler(buttons_Click);
            button11.MouseUp += new MouseEventHandler(buttons_Click);
            button12.MouseUp += new MouseEventHandler(buttons_Click);

        }
        private void buttons_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=copy.sqlite;Version = 3; Cache = Shared");
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Editar", MenuItemEdit_Click));
                m.MenuItems.Add(new MenuItem("Cambiar nombre", MenuItemChangeName_Click));
                m.Show(this, this.PointToClient(Cursor.Position));
            }
            else
            {
                switch (Globales.num)
                {
                    case 1:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "SELECT info FROM botones WHERE id_boton='button1'";
                            string copyText = Convert.ToString(command.ExecuteScalar());
                            Clipboard.SetText(copyText);
                        }
                        con.Close();
                        break;
                    case 2:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "SELECT info FROM botones WHERE id_boton='button2'";
                            string copyText = Convert.ToString(command.ExecuteScalar());
                            Clipboard.SetText(copyText);
                        }
                        con.Close();
                        break;
                    case 3:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "SELECT info FROM botones WHERE id_boton='button3'";
                            string copyText = Convert.ToString(command.ExecuteScalar());
                            Clipboard.SetText(copyText);
                        }
                        con.Close();
                        break;
                    case 4:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "SELECT info FROM botones WHERE id_boton='button4'";
                            string copyText = Convert.ToString(command.ExecuteScalar());
                            Clipboard.SetText(copyText);
                        }
                        con.Close();
                        break;
                    case 5:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "SELECT info FROM botones WHERE id_boton='button5'";
                            string copyText = Convert.ToString(command.ExecuteScalar());
                            Clipboard.SetText(copyText);
                        }
                        con.Close();
                        break;
                    case 6:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "SELECT info FROM botones WHERE id_boton='button6'";
                            string copyText = Convert.ToString(command.ExecuteScalar());
                            Clipboard.SetText(copyText);
                        }
                        con.Close();
                        break;
                    case 7:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "SELECT info FROM botones WHERE id_boton='button7'";
                            string copyText = Convert.ToString(command.ExecuteScalar());
                            Clipboard.SetText(copyText);
                        }
                        con.Close();
                        break;
                    case 8:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "SELECT info FROM botones WHERE id_boton='button8'";
                            string copyText = Convert.ToString(command.ExecuteScalar());
                            Clipboard.SetText(copyText);
                        }
                        con.Close();
                        break;
                    case 9:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "SELECT info FROM botones WHERE id_boton='button9'";
                            string copyText = Convert.ToString(command.ExecuteScalar());
                            Clipboard.SetText(copyText);
                        }
                        con.Close();
                        break;
                    case 10:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "SELECT info FROM botones WHERE id_boton='button10'";
                            string copyText = Convert.ToString(command.ExecuteScalar());
                            Clipboard.SetText(copyText);
                        }
                        con.Close();
                        break;
                    case 11:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "SELECT info FROM botones WHERE id_boton='button11'";
                            string copyText = Convert.ToString(command.ExecuteScalar());
                            Clipboard.SetText(copyText);
                        }
                        con.Close();
                        break;
                    case 12:
                        con.Open();
                        using (SQLiteCommand command = new SQLiteCommand(con))
                        {
                            command.CommandText =
                                "SELECT info FROM botones WHERE id_boton='button12'";
                            string copyText = Convert.ToString(command.ExecuteScalar());
                            Clipboard.SetText(copyText);
                        }
                        con.Close();
                        break;
                }

            }
        }
        private void buttons_Bind()
        {
            SQLiteConnection con = new SQLiteConnection("Data Source=copy.sqlite;Version = 3; Cache = Shared");
            switch (Globales.num)
            {
                case 1:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "SELECT info FROM botones WHERE id_boton='button1'";
                        string copyText = Convert.ToString(command.ExecuteScalar());
                        Clipboard.SetText(copyText);
                    }
                    con.Close();
                    break;
                case 2:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "SELECT info FROM botones WHERE id_boton='button2'";
                        string copyText = Convert.ToString(command.ExecuteScalar());
                        Clipboard.SetText(copyText);
                    }
                    con.Close();
                    break;
                case 3:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "SELECT info FROM botones WHERE id_boton='button3'";
                        string copyText = Convert.ToString(command.ExecuteScalar());
                        Clipboard.SetText(copyText);
                    }
                    con.Close();
                    break;
                case 4:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "SELECT info FROM botones WHERE id_boton='button4'";
                        string copyText = Convert.ToString(command.ExecuteScalar());
                        Clipboard.SetText(copyText);
                    }
                    con.Close();
                    break;
                case 5:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "SELECT info FROM botones WHERE id_boton='button5'";
                        string copyText = Convert.ToString(command.ExecuteScalar());
                        Clipboard.SetText(copyText);
                    }
                    con.Close();
                    break;
                case 6:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "SELECT info FROM botones WHERE id_boton='button6'";
                        string copyText = Convert.ToString(command.ExecuteScalar());
                        Clipboard.SetText(copyText);
                    }
                    con.Close();
                    break;
                case 7:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "SELECT info FROM botones WHERE id_boton='button7'";
                        string copyText = Convert.ToString(command.ExecuteScalar());
                        Clipboard.SetText(copyText);
                    }
                    con.Close();
                    break;
                case 8:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "SELECT info FROM botones WHERE id_boton='button8'";
                        string copyText = Convert.ToString(command.ExecuteScalar());
                        Clipboard.SetText(copyText);
                    }
                    con.Close();
                    break;
                case 9:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "SELECT info FROM botones WHERE id_boton='button9'";
                        string copyText = Convert.ToString(command.ExecuteScalar());
                        Clipboard.SetText(copyText);
                    }
                    con.Close();
                    break;
                case 10:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "SELECT info FROM botones WHERE id_boton='button10'";
                        string copyText = Convert.ToString(command.ExecuteScalar());
                        Clipboard.SetText(copyText);
                    }
                    con.Close();
                    break;
                case 11:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "SELECT info FROM botones WHERE id_boton='button11'";
                        string copyText = Convert.ToString(command.ExecuteScalar());
                        Clipboard.SetText(copyText);
                    }
                    con.Close();
                    break;
                case 12:
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "SELECT info FROM botones WHERE id_boton='button12'";
                        string copyText = Convert.ToString(command.ExecuteScalar());
                        Clipboard.SetText(copyText);
                    }
                    con.Close();
                    break;
            }
        }
        private void MenuItemEdit_Click(Object sender, System.EventArgs e)
        {
            fEditar fe = new fEditar();
            this.Hide();
            fe.Show();

        }
        private void MenuItemChangeName_Click(Object sender, System.EventArgs e)
        {
            fCambiarName cn = new fCambiarName();
            this.Hide();
            cn.Show();
        }

        private void GetAllControl(Control c, List<Control> list)
        {
            foreach (Control control in c.Controls)
            {
                list.Add(control);

                if (control.GetType() == typeof(Panel))
                    GetAllControl(control, list);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            List<Control> list = new List<Control>();

            GetAllControl(this, list);
            int i = 17;
            foreach (Control control in list)
            {
                if (control.GetType() == typeof(Button))
                {
                    i--;
                    SQLiteConnection con = new SQLiteConnection("Data source = copy.sqlite");
                    con.Open();
                    using (SQLiteCommand command = new SQLiteCommand(con))
                    {
                        command.CommandText =
                            "SELECT titulo FROM botones WHERE id_boton=:id";
                        command.Parameters.Add("id", DbType.String).Value = control.Name;
                        string tituloTempo = Convert.ToString(command.ExecuteScalar());
                        control.Text = tituloTempo;
                    }
                    con.Close();
                }
            }
            Globales.num = 0;
            button17.Text = "Salir";
        }

        private void button1_MouseUp(object sender, EventArgs e)
        {
            Globales.num = 1;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            Globales.num = 2;
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            Globales.num = 3;
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            Globales.num = 4;
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            Globales.num = 5;
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            Globales.num = 6;
        }

        private void button7_MouseUp(object sender, MouseEventArgs e)
        {
            Globales.num = 7;
        }

        private void button8_MouseUp(object sender, MouseEventArgs e)
        {
            Globales.num = 8;
        }

        private void button9_MouseUp(object sender, MouseEventArgs e)
        {
            Globales.num = 9;
        }

        private void button10_MouseUp(object sender, MouseEventArgs e)
        {
            Globales.num = 10;
        }

        private void button11_MouseUp(object sender, MouseEventArgs e)
        {
            Globales.num = 11;
        }

        private void button12_MouseUp(object sender, MouseEventArgs e)
        {
            Globales.num = 12;
        }

        private void button13_MouseUp(object sender, MouseEventArgs e)
        {
            Globales.num = 13;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

                Show();
                this.WindowState = FormWindowState.Normal;
                notifyIcon1.Visible = false;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.notifyIcon1.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.notifyIcon1.ContextMenuStrip.Items.Add("Abrir", null, niOpen_Click);
            this.notifyIcon1.ContextMenuStrip.Items.Add("Salir", null, niExit_Click);
        }
        void niOpen_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
        void niExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Globales.num = 1;
                buttons_Bind();
            }
            if (e.KeyCode == Keys.F2)
            {
                Globales.num = 2;
                buttons_Bind();
            }
            if (e.KeyCode == Keys.F3)
            {
                Globales.num = 3;
                buttons_Bind();
            }
            if (e.KeyCode == Keys.F4)
            {
                Globales.num = 4;
                buttons_Bind();
            }
            if (e.KeyCode == Keys.F5)
            {
                Globales.num = 5;
                buttons_Bind();
            }
            if (e.KeyCode == Keys.F6)
            {
                Globales.num = 6;
                buttons_Bind();
            }
            if (e.KeyCode == Keys.F7)
            {
                Globales.num = 7;
                buttons_Bind();
            }
            if (e.KeyCode == Keys.F8)
            {
                Globales.num = 8;
                buttons_Bind();
            }
            if (e.KeyCode == Keys.F9)
            {
                Globales.num = 9;
                buttons_Bind();
            }
            if (e.KeyCode == Keys.F10)
            {
                Globales.num = 10;
                buttons_Bind();
            }
            if (e.KeyCode == Keys.F11)
            {
                Globales.num = 11;
                buttons_Bind();
            }
            if (e.KeyCode == Keys.F12)
            {
                Globales.num = 12;
                buttons_Bind();
            }
        }
    }
    static class Globales
    {
        public static int num = 0;
    }
}
