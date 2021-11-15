using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (checkBox1.CheckState == CheckState.Unchecked && checkBox2.CheckState == CheckState.Unchecked && checkBox3.CheckState == CheckState.Unchecked && checkBox4.CheckState == CheckState.Checked)
                n++;
            if (checkBox5.CheckState == CheckState.Checked && checkBox6.CheckState == CheckState.Unchecked && checkBox7.CheckState == CheckState.Unchecked && checkBox8.CheckState == CheckState.Unchecked)
                n++;
            if (checkBox9.CheckState == CheckState.Unchecked && checkBox10.CheckState == CheckState.Unchecked && checkBox11.CheckState == CheckState.Unchecked && checkBox12.CheckState == CheckState.Checked)
                n++;
            if (checkBox13.CheckState == CheckState.Checked && checkBox14.CheckState == CheckState.Unchecked && checkBox15.CheckState == CheckState.Unchecked && checkBox16.CheckState == CheckState.Unchecked)
                n++;
            if (checkBox17.CheckState == CheckState.Checked && checkBox18.CheckState == CheckState.Unchecked && checkBox19.CheckState == CheckState.Unchecked && checkBox20.CheckState == CheckState.Unchecked)
                n++;
            if (checkBox21.CheckState == CheckState.Checked && checkBox22.CheckState == CheckState.Unchecked && checkBox23.CheckState == CheckState.Unchecked && checkBox24.CheckState == CheckState.Unchecked)
                n++;
            if (checkBox25.CheckState == CheckState.Unchecked && checkBox26.CheckState == CheckState.Unchecked && checkBox27.CheckState == CheckState.Checked && checkBox28.CheckState == CheckState.Unchecked)
                n++;
            if (checkBox29.CheckState == CheckState.Unchecked && checkBox30.CheckState == CheckState.Checked && checkBox31.CheckState == CheckState.Unchecked && checkBox32.CheckState == CheckState.Unchecked)
                n++;
            if (checkBox33.CheckState == CheckState.Checked && checkBox34.CheckState == CheckState.Unchecked && checkBox35.CheckState == CheckState.Unchecked && checkBox36.CheckState == CheckState.Unchecked)
                n++;
            if (checkBox37.CheckState == CheckState.Checked && checkBox38.CheckState == CheckState.Unchecked && checkBox39.CheckState == CheckState.Unchecked && checkBox40.CheckState == CheckState.Unchecked)
                n++;

            if (n >= 8)
                MessageBox.Show("Felicitari! Iti cunosti foarte bine tara. Ai raspuns corect la " + n.ToString() + " din 10 intrebari.");
            else if( n >= 5 && n < 8)
                MessageBox.Show("Bravo! Iti cunosti bine tara. Ai raspuns corect la " + n.ToString() + " din 10 intrebari.");
            else if(n < 5)
                MessageBox.Show("Of! :( Din pacate trebuie sa inveti mai multe lucruri despre tara ta. Ai raspuns corect la " + n.ToString() + " din 10 intrebari.");

            MessageBox.Show("Raspunsurile corecte sunt: d,a,d,a,a,a,c,b,a,a");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
