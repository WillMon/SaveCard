using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            //Enables Treasure option lables 
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            // Disables Mystory option lables 
            label4.Visible = false;
            label5.Visible = false;
            //Enables Save option
            button3.Visible = true;
            //Enables Trasure Textboxs
            textBox3.Visible = true;
            richTextBox1.Visible = true;
            textBox1.Visible = true;
            // Disables Mystory Textboxs
            textBox4.Visible = false;
            richTextBox2.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            //Clears Mystory Textboxes
            textBox4.Clear();
            richTextBox2.Clear();
            textBox6.Clear();
            textBox7.Clear();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            //Enables Mystory Options lables  
            label1.Visible = true;
            label2.Visible = true;
            //Disables Treasure Options
            label3.Visible = false;
            //enables Mystery Optional TextBoxes
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
            //Clears Treasure Textboxs
            textBox3.Clear();
            richTextBox1.Clear();
            textBox1.Clear();
        }
        // Checks for the the 
        bool NotAlloweed()
        {
            if (textBox1.Visible)
            {
                if (textBox1.Text == "" ||
                richTextBox1.Text == "" ||
                textBox3.Text == "")
                {
                    MessageBox.Show("More information is needed");
                    return true;
                }
            }

            if (textBox4.Visible)
            {
                if (textBox4.Text == "" ||
                textBox6.Text == "" ||
                textBox7.Text == "" ||
                richTextBox2.Text == "")
                {
                    MessageBox.Show("More information is needed");
                    return true;
                }
            }
        
            return false;
        }
        // Saves Card Stats to CardSave.xml
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (!NotAlloweed()) {
                if (label3.Visible)
                {
                    Tcard = new Treasure(textBox1.Text, richTextBox1.Text, textBox3.Text);
                    Utilities.SerializeXML<Treasure>(textBox1.Text.ToString(), Tcard, @"../../CardSaved/");
                    MessageBox.Show(textBox1.Text.ToString() + " Has been Save to CardSaved");


                }
                else if (label4.Visible)
                {
                    Mcard = new Mystery(textBox4.Text, richTextBox2.Text, textBox6.Text, textBox7.Text);
                    Utilities.SerializeXML<Mystery>(textBox4.Text.ToString(), Mcard, @"../../CardSaved/");
                    MessageBox.Show(textBox4.Text.ToString() + " Has been Save to CardSaved");

                }
            }
            // Clears all the Boxes 
            textBox4.Clear();
            richTextBox2.Clear();
            textBox6.Clear();
            textBox7.Clear();

            textBox3.Clear();
            richTextBox1.Clear();
            textBox1.Clear();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"../../CardSaved/"))
                Directory.CreateDirectory(@"../../CardSaved/");
        }
    }
}
