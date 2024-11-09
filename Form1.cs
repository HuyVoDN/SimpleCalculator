using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        Double result = 0.0;
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;

        private Timer ColorTimer;
        private Button LastClickedButton;

        public Calculator()
        {
            InitializeComponent();
            InitializeColorTimer();
        }

        private void InitializeColorTimer() 
        {
            ColorTimer = new Timer();
            ColorTimer.Interval = 100;
            ColorTimer.Tick += new EventHandler(ColorTimer_Tick);
        }
        private void ColorTimer_Tick(object sender, EventArgs e)
        {
            ChangeButtonColorBack(LastClickedButton);
            ColorTimer.Stop();
        }
        private void ChangeButtonColor(Button button)
        {
            button.ForeColor = Color.DarkCyan;
        }
        private void ChangeButtonColorBack(Button button)
        {
            button.ForeColor = Color.White;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Btn_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                ChangeButtonColor(button);
                
                LastClickedButton = button;
                ColorTimer.Start();
        
            }
            if (button.Name == "Zero_Btn")
            { 
                this.Calculation_Box.Text = this.Calculation_Box.Text + "0";
            }
            if (button.Name == "One_Btn")
            {
                this.Calculation_Box.Text = this.Calculation_Box.Text + "1";
            }
            if (button.Name == "Two_Btn")
            {
                this.Calculation_Box.Text = this.Calculation_Box.Text + "2";
            }
            if (button.Name == "Three_Btn")
            {
                this.Calculation_Box.Text = this.Calculation_Box.Text + "3";
            }
            if (button.Name == "Four_Btn")
            {
                this.Calculation_Box.Text = this.Calculation_Box.Text + "4";
            }
            if (button.Name == "Five_Btn")
            {
                this.Calculation_Box.Text = this.Calculation_Box.Text + "5";
            }
            if (button.Name == "Six_Btn")
            {
                this.Calculation_Box.Text = this.Calculation_Box.Text + "6";
            }
            if (button.Name == "Seven_Btn")
            {
                this.Calculation_Box.Text = this.Calculation_Box.Text + "7";
            }
            if (button.Name == "Eight_Btn")
            {
                this.Calculation_Box.Text = this.Calculation_Box.Text + "8";
            }
            if (button.Name == "Nine_Btn")
            {
                this.Calculation_Box.Text = this.Calculation_Box.Text + "9";
            }
            if (button.Name == "Decimal_Btn")
            {
                this.Calculation_Box.Text = this.Calculation_Box.Text + ".";
            }
            input += button.Text;
            
        }
        private void ModBtn_Click(object sender, EventArgs e)
        {
            operand1 = input;     
            operation = '%';
            input = string.Empty;
            this.Calculation_Box.Text = string.Empty;
        }
        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
            this.Calculation_Box.Text = string.Empty;

        }

        private void MultiBtn_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
            this.Calculation_Box.Text = string.Empty;
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
            this.Calculation_Box.Text = string.Empty;
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
            this.Calculation_Box.Text = string.Empty;
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            switch (operation)
            {
                case '+':
                    result = num1 + num2;                  
                    break;

                case '-':
                    result = num1 - num2;          
                    break;

                case '/':
                    result = num1 / num2;             
                    break;

                case '*':
                    result = num1 * num2;               
                    break;

                case '%':
                    result = num1 % num2;                                
                    break;
            }
            Calculation_Box.Text = result.ToString();
            textBox1.Text = operand1 + " " + operation + " " + operand2 + " = " + result.ToString();
            operand1 = string.Empty;
            operand2 = string.Empty;
            input = result.ToString();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (this.Calculation_Box.Text.Length > 0)
            {
                this.Calculation_Box.Text = this.Calculation_Box.Text.Remove(this.Calculation_Box.Text.Length - 1, 1);
                input = this.Calculation_Box.Text;
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.Calculation_Box.Text = string.Empty;
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }   
    }
}
