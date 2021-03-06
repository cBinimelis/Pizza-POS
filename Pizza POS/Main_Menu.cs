﻿using System;
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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

        private void pb_exit_Click(object sender, EventArgs e)
        {
            try { 
            if (MessageBox.Show("¿Estás seguro que deseas salir?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Util.getF1().Close();
            }
            }
            catch
            {

            }
        }

        private void pb_food_Click(object sender, EventArgs e)
        {
            Food_Select fs = new Food_Select();
            fs.Show();
            this.Close();
        }
    }
}
