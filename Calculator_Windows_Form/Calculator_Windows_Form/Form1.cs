using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator_Windows_Form
{
    public partial class Form1 : Form
    {
        String Operations = "";
        Double Values;
        public Form1()
        {
            InitializeComponent();
        }
        private void But_CE_Click(object sender, EventArgs e)
        {
            But_C_Click(sender, e);
            Values = 0;
            Lab_Equestion.Text = "";
        }

        private void But_C_Click(object sender, EventArgs e)
        {
            Value_Calculator.Text = "0";
            Lab_Equestion.Text = "";
        }

        private void But_Values(object sender, EventArgs e)
        {
            Button value_insert = (Button)sender;
            String values = value_insert.Text;

            if (Value_Calculator.Text == "0")
                Value_Calculator.Clear();

            if (values.Equals("."))
            {
                if (!Value_Calculator.Text.Contains("."))
                {
                    Value_Calculator.Text = Value_Calculator.Text + values;
                    Lab_Equestion.Text = Lab_Equestion.Text + values;
                }
            }
            else
            {
                Value_Calculator.Text = Value_Calculator.Text + values;
                Lab_Equestion.Text = Lab_Equestion.Text + values;
            }
        }

        private void But_Operations(object sender, EventArgs e)
        {
            Button button_operation = (Button)sender;

            Values = double.Parse(Value_Calculator.Text);
            Operations = button_operation.Text;
            Value_Calculator.Clear();
            Lab_Equestion.Text = Lab_Equestion.Text + button_operation.Text;
        }

        private void But_Equal_Click(object sender, EventArgs e)
        {
            double Text_Calculator_value = double.Parse(Value_Calculator.Text);


            if (Operations.Equals("+"))
            {
                Value_Calculator.Text = Convert.ToString(Values + Text_Calculator_value);
            }
            else if (Operations.Equals("-"))
            {
                Value_Calculator.Text = Convert.ToString(Values - Text_Calculator_value);
            }
            else if (Operations.Equals("*"))
            {
                Value_Calculator.Text = Convert.ToString(Values * Text_Calculator_value);
            }
            else if (Operations.Equals("/"))
            {
                Value_Calculator.Text = Convert.ToString(Values / Text_Calculator_value);
            }

            Lab_Equestion.Text = Value_Calculator.Text;
        }
    }
}
