using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveCard
{
    public partial class Form1 : Form
    {
        
        Treasure Tcard;
        Mystery Mcard;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            label4.Visible = false;
            label5.Visible = false;

            button3.Visible = true;

            textBox3.Visible = true;
            richTextBox1.Visible = true;
            textBox1.Visible = true;

            textBox4.Visible = false;
            richTextBox2.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;

            textBox4.Clear();
            richTextBox2.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Visible = true;
            label2.Visible = true;
            //Disab;es Treasure Options
            label3.Visible = false;
            //enables Mystery OPtions
            label4.Visible = true;
            label5.Visible = true;
            //Enables Save Button
            button3.Visible = true;
            //Treasure Texboxes Desabled
            textBox3.Visible = false;
            richTextBox1.Visible = false;
            textBox1.Visible = false;

            //Mystery TextBoxes Enabled
            textBox4.Visible = true;
            richTextBox2.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;

            textBox3.Clear();
            richTextBox1.Clear();
            textBox1.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (label3.Visible)
            {
                Tcard = new Treasure(textBox1.Text, richTextBox1.Text, textBox3.Text);
                Utilities.SerializeXML<Treasure>(textBox1.Text.ToString(), Tcard, @"C:\Users\william.montero\Desktop\SaveCard\CardSaved\");

            }
            else if (label4.Visible)
            {
                Mcard = new Mystery(textBox4.Text, richTextBox2.Text, textBox6.Text, textBox7.Text);
                Utilities.SerializeXML<Mystery>(textBox4.Text.ToString(), Mcard, @"C:\Users\william.montero\Desktop\SaveCard\CardSaved\");
            }
        }

       
    }
}
