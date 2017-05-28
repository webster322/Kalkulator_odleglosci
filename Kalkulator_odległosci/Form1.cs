﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_odległosci
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double reimburseRate = .39;
        double amountOwed;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;
            if (startingMileage <= endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                label4.Text = amountOwed.ToString() + " zł";
            }
            else
            {
                MessageBox.Show("Początkowy stan licznika musi być mniejszy niż końcowy", "Nie mogę obliczyć odległości");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " kilometrów", "Przebyta odległość");
        }
    }
}
