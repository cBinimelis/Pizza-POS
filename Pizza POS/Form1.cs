using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿E?");
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Util.setF1(this);
            Main_Menu mm = new Main_Menu();
            mm.Show();
            this.Hide();
        }
    }
}
