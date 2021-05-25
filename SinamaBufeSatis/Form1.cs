﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinamaBufeSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0; //butona her basılıdıngda 0 lanmaması için buraya tanımladık
        int gunlukkazanc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, bilet, su, cay,toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            su    = Convert.ToInt16(TxtSu.Text);
            cay   = Convert.ToInt16(TxtCay.Text);
            toplam = misir*4 + bilet*8 + su*1 + cay*2;
            LblToplam.Text = toplam.ToString() + " ₺ ";

            kasatutar = kasatutar + toplam;
            LblKasa.Text = kasatutar.ToString() + " ₺ ";

            gunlukkazanc = gunlukkazanc + toplam;
            ToplamKazanc.Text = gunlukkazanc.ToString() + " ₺ ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtMisir.Text = "";
            TxtBilet.Text = "";
            TxtSu.Text = "";
            TxtCay.Text = "";
            TxtMisir.Focus();
            LblKasa.Text = 0.ToString() ;
            LblToplam.Text = 0.ToString();
        }   
    }       
}
