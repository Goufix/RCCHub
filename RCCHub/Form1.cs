using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCCHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set Login preferences
            if (Properties.Settings.Default.Nick != null && Properties.Settings.Default.TAG != null && Properties.Settings.Default.Patente != null)
            {
                txtNick.Text = Properties.Settings.Default.Nick;
                txtTAG.Text = Properties.Settings.Default.TAG;
                txtPatente.Text = Properties.Settings.Default.Patente;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            // Set Config based on inputs
            Config c = new Config();
            c.SetCfg(txtNick.Text, txtTAG.Text, txtPatente.Text);
            CRH crh = new CRH();
            string link = crh.Link();
            MessageBox.Show(link);
        }
    }
}
