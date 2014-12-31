using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultCalculationApp
{
    public partial class ResultCalculatorUI : Form
    {
        public ResultCalculatorUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            double physicsMarks = Convert.ToDouble(physicsTextBox.Text);
            double chemistryMarks = Convert.ToDouble(chemistryTextBox.Text);
            double mathMarks = Convert.ToDouble(mathTextBox.Text);

            Result aResult = new Result(physicsMarks, chemistryMarks, mathMarks);
            aResult.CalcutateAverage();
            aResult.CalculateGrade();

            averageTextBox.Text = aResult.Average.ToString();
            gradeLetterTextBox.Text = aResult.Grade.ToString();
        }

    }
}
