using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCCHub
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Set Login preferences
            // if (Properties.Settings.Default.Nick != null && Properties.Settings.Default.TAG != null && Properties.Settings.Default.Patente != null)
            //{
            string nick = Properties.Settings.Default.Nick; 
            string TAG = Properties.Settings.Default.TAG;
            string position = Properties.Settings.Default.Position;
            txtTAG.Text = TAG != null ? TAG : "";
            txtNick.Text = nick != null ? nick : "";
            txtPosition.Text = position != null ? position : "";
           // }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            // Set Config based on inputs
            user user = new user();
            user.SetCfg(txtNick.Text, txtTAG.Text, txtPosition.Text);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // close application
           Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 register = new Form1();
            register.Show();
        }
    }
}
