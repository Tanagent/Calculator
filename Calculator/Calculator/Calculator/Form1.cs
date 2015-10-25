using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value = 0;
        String operation = "";
        bool operationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || operationPressed)
                result.Clear();

            operationPressed = false;
            Button button = (Button)sender;
            result.Text += button.Text;
            equation.Text = value + " " + operation;
        }

        private void ClearEntry_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            value = double.Parse(result.Text);
            operationPressed = true;
            equation.Text = value + " " + operation;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            equation.Text = "";

            switch (operation)
            {
                case "+":
                    result.Text = (value + double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - double.Parse(result.Text)).ToString();
                    break;
                case "x":
                    result.Text = (value * double.Parse(result.Text)).ToString();
                    break;
                case "÷":
                    result.Text = (value / double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }

            operationPressed = false;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }
    }
}
