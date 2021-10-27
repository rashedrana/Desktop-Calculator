using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Task
{
    public partial class Calculator : Form
    {
        Double result= 0; 
        String operation = "";
        bool isoperation = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_click(object sender, EventArgs e)
        {

            if ((txt_result.Text=="0") || (isoperation))
            {
                txt_result.Clear();            
            }
            Button btn = (Button)sender;

            if (btn.Text == ".")
            {      
            if (!txt_result.Text.Contains("."))
            txt_result.Text = txt_result.Text + btn.Text;          
            }
            else
                txt_result.Text = txt_result.Text + btn.Text;
                isoperation = false;
        }

        private void operator_btn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (result !=0)
            {
                button18.PerformClick();
                result = Double.Parse(txt_result.Text);
                operation = btn.Text;
                label1.Text = result + " " + operation;
                
                isoperation = true;
            }
            result = Double.Parse(txt_result.Text);
            operation = btn.Text;
            label1.Text = result +" "+ operation;
            
            isoperation = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    txt_result.Text = (result + Double.Parse(txt_result.Text)).ToString(); 
                    break;
                case "-":
                    txt_result.Text = (result - Double.Parse(txt_result.Text)).ToString();
                    break;
                case "*":
                    txt_result.Text = (result * Double.Parse(txt_result.Text)).ToString();
                    break;
                case "/":
                    txt_result.Text = (result / Double.Parse(txt_result.Text)).ToString();
                    break;

                default:
                    break;
            }

    }

        private void button15_Click(object sender, EventArgs e)
        {
            txt_result.Clear(); 
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txt_result.Clear();
            result = 0; 
        }
    }
}