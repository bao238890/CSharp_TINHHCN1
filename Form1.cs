﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_TINHHCN1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuvi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDientich_Click(object sender, EventArgs e)
        {
            Double a, b, P, S;
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            S = a * b;
            txtKQ.Text = S.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbChuvi_CheckedChanged(object sender, EventArgs e)
        {
            if (txta.Text == "" || txtb.Text == "")
            {
                MessageBox.Show("Phải nhập a và b");
                return;
            }
            Double a, b, P, S;
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            P = (a + b) * 2;
            txtKQ.Text = P.ToString();
        }

        private void rdbDientich_CheckedChanged(object sender, EventArgs e)
        {
            Double a, b, P, S;
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            S = a * b;
            txtKQ.Text = S.ToString();
        }
    }
    }
