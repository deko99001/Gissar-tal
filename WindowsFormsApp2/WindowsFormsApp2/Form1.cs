using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Random slump = new Random();       
        int counter = 0;
        int slumptal;
        public Form1()
        {
            InitializeComponent();
         slumptal = slump.Next(1, 100);
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tal = int.Parse(textBox1.Text);
            if (slumptal == tal)
                {
                    counter++;               
                    label3.Text = ("Det är rätt tal");    
                }

                else if (slumptal > tal)
                {
                    counter++;
                    label3.Text = "Gissningen är för låg";
            }
                else if (slumptal < tal)
                {
                    label3.Text = "Gissningen är för hög";
                    counter++;
                    label2.Text = counter.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
