using STSM.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STSM.Forms
{
    public partial class Login : Form
    {
        int k = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Loading loading = new Loading();
            loading.ShowDialog();
            loading.Close();
            incorrect_txt.Visible = false;
            if (Globals.isReady)
            {

            }
            else
            {
                Application.Exit();
            }

        }
        public int timeLeft { get; set; }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private int i = 0;
        private void login_btn_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                login_btn.Text = "Logging in ...";
                login_btn.Textcolor = Color.White;
                login_btn.OnHovercolor = Color.Transparent;
                login_btn.Normalcolor = Color.Transparent;
                login_btn.OnHoverTextColor = Color.White;
                login_btn.Activecolor = Color.Transparent;
                login_btn.Cursor = Cursors.No;
                i = 1;
                timeLeft = 20;
                timer1.Start();
            }
        }

        private void pass_tb_vc(object sender, EventArgs e)
        {
            pass_tb.HintText = "";
            pass_tb.isPassword = true;
        }

        private void username_tb_vc(object sender, EventArgs e)
        {
            username_tb.HintText = "";
            username_tb.isPassword = false;
        }
        Users u = new Users();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else {
                if(username_tb.Text=="" || pass_tb.Text=="")
                {
                    timer1.Stop();
                    if (k == 3)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        k++;
                        incorrect_txt.Visible = true;
                        incorrect_txt.Text = "Username or Password incorrect!\n        please try again " + k + "/ 3";
                        login_btn.Text = "Login";
                        login_btn.Textcolor = Color.White;
                        login_btn.OnHovercolor = Color.White;
                        login_btn.Normalcolor = Color.FromArgb(0, 0, 64);
                        login_btn.OnHoverTextColor = Color.FromArgb(0, 0, 64);
                        login_btn.Activecolor = Color.White;
                        login_btn.Cursor = Cursors.Hand;
                        i = 0;
                    }
                }
                else { 
                if (u.serchUserID(username_tb.Text) == 0)
                {
                    timer1.Stop();
                    if (k == 3)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        k++;
                        incorrect_txt.Visible = true;
                        incorrect_txt.Text = "Username or Password incorrect!\n        please try again " + k + "/ 3";
                        login_btn.Text = "Login";
                        login_btn.Textcolor = Color.White;
                        login_btn.OnHovercolor = Color.White;
                        login_btn.Normalcolor = Color.FromArgb(0, 0, 64);
                        login_btn.OnHoverTextColor = Color.FromArgb(0, 0, 64);
                        login_btn.Activecolor = Color.White;
                        login_btn.Cursor = Cursors.Hand;
                        i = 0;
                    }
                }
                else
                {
                    timer1.Stop();
                        if (u.getUsername(u.serchUserID(username_tb.Text)) == username_tb.Text)
                        {
                            if (u.serchUserID(pass_tb.Text) == 0)
                            {
                                timer1.Stop();
                                if (k == 3)
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                    k++;
                                    incorrect_txt.Visible = true;
                                    incorrect_txt.Text = "Username or Password incorrect!\n        please try again " + k + "/ 3";
                                    login_btn.Text = "Login";
                                    login_btn.Textcolor = Color.White;
                                    login_btn.OnHovercolor = Color.White;
                                    login_btn.Normalcolor = Color.FromArgb(0, 0, 64);
                                    login_btn.OnHoverTextColor = Color.FromArgb(0, 0, 64);
                                    login_btn.Activecolor = Color.White;
                                    login_btn.Cursor = Cursors.Hand;
                                    i = 0;
                                }
                            }
                            else
                            {
                                if (u.getPassword(u.serchUserID(pass_tb.Text)) == pass_tb.Text)
                                {
                                    try
                                    {
                                        MainMenu m = new MainMenu();
                                        this.Hide();
                                        m.ShowDialog();
                                        this.Show();
                                        k = 0;
                                        incorrect_txt.Visible = false;
                                        login_btn.Text = "Login";
                                        login_btn.Textcolor = Color.White;
                                        login_btn.OnHovercolor = Color.White;
                                        login_btn.Normalcolor = Color.FromArgb(0, 0, 64);
                                        login_btn.OnHoverTextColor = Color.FromArgb(0, 0, 64);
                                        login_btn.Activecolor = Color.White;
                                        login_btn.Cursor = Cursors.Hand;
                                        i = 0;
                                        username_tb.Text = "";
                                        pass_tb.Text = "";
                                        username_tb.Focus();
                                    }
                                    catch (Exception)
                                    {
                                        timer1.Stop();
                                        if (k == 3)
                                        {
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                            k++;
                                            incorrect_txt.Visible = true;
                                            incorrect_txt.Text = "Username or Password incorrect!\n        please try again " + k + "/ 3";
                                            login_btn.Text = "Login";
                                            login_btn.Textcolor = Color.White;
                                            login_btn.OnHovercolor = Color.White;
                                            login_btn.Normalcolor = Color.FromArgb(0, 0, 64);
                                            login_btn.OnHoverTextColor = Color.FromArgb(0, 0, 64);
                                            login_btn.Activecolor = Color.White;
                                            login_btn.Cursor = Cursors.Hand;
                                            i = 0;
                                        }
                                    }
                                }
                                else
                                {
                                    if (k == 3)
                                    {
                                        Environment.Exit(0);
                                    }
                                    else
                                    {
                                        k++;
                                        incorrect_txt.Visible = true;
                                        incorrect_txt.Text = "Username or Password incorrect!\n        please try again " + k + "/ 3";
                                        login_btn.Text = "Login";
                                        login_btn.Textcolor = Color.White;
                                        login_btn.OnHovercolor = Color.White;
                                        login_btn.Normalcolor = Color.FromArgb(0, 0, 64);
                                        login_btn.OnHoverTextColor = Color.FromArgb(0, 0, 64);
                                        login_btn.Activecolor = Color.White;
                                        login_btn.Cursor = Cursors.Hand;
                                        i = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
                
        }
        private void Enter_Key(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = e.SuppressKeyPress = true;
                if (i == 0)
                {
                    login_btn.Text = "Logging in ...";
                    login_btn.Textcolor = Color.White;
                    login_btn.OnHovercolor = Color.Transparent;
                    login_btn.Normalcolor = Color.Transparent;
                    login_btn.OnHoverTextColor = Color.White;
                    login_btn.Activecolor = Color.Transparent;
                    login_btn.Cursor = Cursors.No;
                    i = 1;
                    timeLeft = 20;
                    timer1.Start();
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                e.Handled = e.SuppressKeyPress = true;
                pass_tb.Focus();
            }
            if (e.KeyCode == Keys.Up)
            {
                e.Handled = e.SuppressKeyPress = true;
                username_tb.Focus();
            }
            if (e.KeyCode == Keys.F1)
            {
                config loading = new config();
                loading.ShowDialog();
            }
        }
    }
}
