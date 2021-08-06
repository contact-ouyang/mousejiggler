using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkaneSystems.MouseJiggle
{
    public partial class PasswordForm : Form
    {
        public MainForm mainForm { get; set; }
        public string password { get; set; }
        public PasswordForm(MainForm mainForm)
        {
            this.mainForm = mainForm;
            ResourceManager myManager = new ResourceManager(typeof(PasswordForm));
            this.password = myManager.GetString("password");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == this.password)
            {
                this.Hide();
                this.mainForm.Show();
            }
        }

        private void PasswordForm_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.PerformClick();
        }
    }
}
