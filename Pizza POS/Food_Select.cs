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
    public partial class Food_Select : Form
    {
        public Food_Select()
        {
            InitializeComponent();
        }

        private void pb_mmenu_Click(object sender, EventArgs e)
        {
            Main_Menu mm = new Main_Menu();
            mm.Show();
            this.Close();
        }
    }
}
