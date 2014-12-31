using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleSpeedMeterApp
{
    public partial class VehicleSpeedMeterUI : Form
    {
        public VehicleSpeedMeterUI()
        {
            InitializeComponent();
        }

        private Vehicle aVechile;

        private void creatButton_Click(object sender, EventArgs e)
        {
            string name = vehicleNameTextBox.Text;
            string regNo = regNoTextBox.Text;

            aVechile = new Vehicle(name, regNo);

            //vehicleNameTextBox.ReadOnly = true;
            //regNoTextBox.ReadOnly = true;
            //creatButton.Enabled = false;


        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            aVechile.InputSpeed = Convert.ToDouble(speedTextBox.Text);
            aVechile.CalculateMinSpeed();
            aVechile.CalculationMaxSpeed();
            aVechile.CalculationAverageSpeed();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = aVechile.MinSpeed.ToString();
            maxSpeedTextBox.Text = aVechile.MaxSpeed.ToString();
            averageSpeedTextBox.Text = aVechile.Averagespeed.ToString();
        }
    }
}
