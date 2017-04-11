using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_POS_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(panelPigrolac.Enabled == true)
            {
                panelPigrolac.Enabled = false;
            }else
            {
                panelPigrolac.Enabled = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(panelBurger.Enabled == true)
            {
                panelBurger.Enabled = false;
            }
            else
            {
                panelBurger.Enabled = true;
            }
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                txtHamburger.Enabled = true;
            }else
            {
                txtHamburger.Enabled = false;
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
             e.Graphics.DrawString(rctReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rctReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rctReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rctReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rctReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.FileName = "Notepad Txt";
            save.Filter = "Text Files(*.txt) | *.txt | All files (*.*) | *.*";

            if(save.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(save.FileName))
                    sw.WriteLine(rctReceipt.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            rctReceipt.Clear();
            rctReceipt.AppendText(Environment.NewLine);
            rctReceipt.AppendText("\t" + "Shue Co Mini Cafe" + Environment.NewLine);
            rctReceipt.AppendText("-------------------------------------------------------------------" + Environment.NewLine);
            rctReceipt.AppendText(Environment.NewLine);
            rctReceipt.AppendText("Food \t\t" + "Quantity\t" + "Price" + Environment.NewLine);
            rctReceipt.AppendText("Hamburger \t" + txtHamburger.Text + Environment.NewLine);
            rctReceipt.AppendText("Fries \t\t" + txtFries.Text + Environment.NewLine);
            rctReceipt.AppendText("Steak \t\t" + txtSteak.Text + Environment.NewLine);
            rctReceipt.AppendText("Chicken \t\t" + txtChicken.Text + Environment.NewLine);
            rctReceipt.AppendText("Prigrolac \t\t" + txtPigrolac.Text + Environment.NewLine);
           
            rctReceipt.AppendText(Environment.NewLine);
            rctReceipt.AppendText("Drinks \t\t" + "Quantity\t" + "Price" + Environment.NewLine);
            rctReceipt.AppendText("Cock \t\t" + txtCock.Text + Environment.NewLine);
            rctReceipt.AppendText("Nestea \t\t" + txtNestea.Text + Environment.NewLine);
            rctReceipt.AppendText("Orange \t\t" + txtOrange.Text + Environment.NewLine);
            rctReceipt.AppendText("Sundae \t\t" + txtSundae.Text + Environment.NewLine);
            rctReceipt.AppendText("Tuba \t\t" + txtTuba.Text + Environment.NewLine);
            rctReceipt.AppendText("-------------------------------------------------------------------" + Environment.NewLine);
            rctReceipt.AppendText("Sub Total \t"+txtSub.Text + Environment.NewLine);
            rctReceipt.AppendText("VAT \t\t"+ txtVat.Text + Environment.NewLine);
            rctReceipt.AppendText("Total \t\t"+txtTotal.Text + Environment.NewLine);
            rctReceipt.AppendText(Environment.NewLine);
            rctReceipt.AppendText("Date \t"+lblDate.Text + Environment.NewLine);
            rctReceipt.AppendText("Time \t"+lblTime.Text + Environment.NewLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(panelFries.Enabled == true)
            {
                panelFries.Enabled = false;
            }
            else
            {
                panelFries.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true)
            {
                txtFries.Enabled = true;
            }else
            {
                txtFries.Enabled = false;
            }
        }

        private void rctReceipt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(panelSteak.Enabled == true)
            {
                panelSteak.Enabled = false;
            }else
            {
                panelSteak.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked == true)
            {
                txtSteak.Enabled = true;
            }else
            {
                txtSteak.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(panelChicken.Enabled == true)
            {
                panelChicken.Enabled = false;
            }else
            {
                panelChicken.Enabled = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox5.Checked == true)
            {
                txtChicken.Enabled = true;
            }else
            {
                txtChicken.Enabled = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox6.Checked == true)
            {
                txtPigrolac.Enabled = true;
            }else
            {
                txtPigrolac.Enabled = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox7.Checked == true)
            {
                txtCock.Enabled = true;
            }else
            {
                txtCock.Enabled = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox8.Checked == true)
            {
                txtNestea.Enabled = true;
            }else
            {
                txtNestea.Enabled = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox9.Checked == true)
            {
                txtOrange.Enabled = true;
            }else
            {
                txtOrange.Enabled = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox10.Checked == true)
            {
                txtOrange.Enabled = true;
            }
            else
            {
                txtOrange.Enabled = false;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox11.Checked == true)
            {
                txtTuba.Enabled = true;
            }else
            {
                txtTuba.Enabled = false;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            rctReceipt.Clear();
            txtSub.Text = "";
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int hamburger, fries, steak, chicken, pigrolac;
            hamburger = 30;
            fries = 45;
            steak = 50;
            chicken = 70;
            pigrolac = 15;

            hamburger = hamburger * (int.Parse(txtHamburger.Text));
            fries = fries * (int.Parse(txtFries.Text));
            steak = steak * (int.Parse(txtSteak.Text));
            chicken = chicken * (int.Parse(txtSteak.Text));
            pigrolac = pigrolac * (int.Parse(txtPigrolac.Text));

            int cock, nestea, orange, sundae, tuba;
            cock = 10;
            nestea = 15;
            orange = 10;
            sundae = 20;
            tuba = 5;

            cock = cock * (int.Parse(txtCock.Text));
            nestea = nestea * (int.Parse(txtNestea.Text));
            orange = orange * (int.Parse(txtOrange.Text));
            sundae = sundae * (int.Parse(txtSundae.Text));
            tuba = tuba * (int.Parse(txtTuba.Text));

            int sub = (fries + steak + chicken + pigrolac) + (cock + nestea + orange + sundae + tuba);
            txtSub.Text = sub.ToString();
            double vat = sub * .12;
            txtVat.Text = vat.ToString();
            double total = sub + vat;
            txtTotal.Text = total.ToString();
            
             
        }
    }
}
