﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("C:\\Users\\Vitaly\\Desktop\\C#\\Project Films\\Фон\\bg_action.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("C:\\Users\\Vitaly\\Desktop\\C#\\Project Films\\Фон\\MenuF.jpg");
            this.BackgroundImageLayout = ImageLayout.Tile;

        }
    }
}
