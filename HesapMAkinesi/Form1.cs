using System;

namespace HesapMAkinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string name { get; set; }
        public string lastname { get; set; }
        public int dateTime { get; set; }
        public string email { get; set; }

        public bool isFull()
        {

            if (name == null || name.Length == 0 || lastname==null|| lastname.Length == 0 
                || email == null || email.Length == 0 || textBox6.Text == null || textBox6.Text.Length == 0)
            {
                string messagee = "Lütfen yukarýdaki bilgilerinizi tam doldurun";
                MessageBox.Show(messagee);
                return false;
                
            }
            return true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
            textBox4.Text = null;

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lastname = textBox2.Text; 
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            email = textBox3.Text;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

            //textBox6.Text = (DateTime.Now.Subtract(dateTimePicker1.Value).TotalDays / 365).ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            double yas = 0;
            yas = (DateTime.Now.Subtract(dateTimePicker1.Value).TotalDays / 365);

            int someInt = Convert.ToInt32(yas);

            textBox6.Text = someInt.ToString();
         
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged_2(object sender, EventArgs e)
        {
            
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }



        public int firstInt = 0;
        public int islem = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (isFull() == true)
            {
                if(textBox4.Text != null && textBox4.Text.Length != 0)
                {
                    islem = 1;
                    firstInt = Convert.ToInt32(textBox4.Text);
                    textBox4.Text = null;
                    return;
                }
                string messagee = "Lütfen hesaplanacak deðerleri giriniz";
                MessageBox.Show(messagee);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (isFull() == true)
            {
                if (textBox4.Text != null && textBox4.Text.Length != 0)
                {
                    islem = 2;
                    firstInt = Convert.ToInt32(textBox4.Text);
                    textBox4.Text = null;
                    return;
                }
                string messagee = "Lütfen hesaplanacak deðerleri giriniz";
                MessageBox.Show(messagee);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (isFull() == true)
            {
                if (textBox4.Text != null && textBox4.Text.Length != 0)
                {
                    islem = 3;
                    firstInt = Convert.ToInt32(textBox4.Text);
                    textBox4.Text = null;
                    return;
                }
                string messagee = "Lütfen hesaplanacak deðerleri giriniz" ;
                MessageBox.Show(messagee);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (isFull() == true)
            {
                if (textBox4.Text != null && textBox4.Text.Length != 0)
                {
                    islem = 4;
                    firstInt = Convert.ToInt32(textBox4.Text);
                    textBox4.Text = null;
                    return;
                }
                string messagee = "Lütfen hesaplanacak deðerleri giriniz";
                MessageBox.Show(messagee);
            }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (isFull() == true)
            {
                if (textBox4.Text != null && textBox4.Text.Length != 0)
                {
                    if (islem == 1)
                    {
                        textBox5.Text = (firstInt + Convert.ToInt32(textBox4.Text)).ToString();
                    }
                    else if (islem == 2)
                    {
                        textBox5.Text = (firstInt - Convert.ToInt32(textBox4.Text)).ToString();
                    }
                    else if (islem == 3)
                    {
                        textBox5.Text = (firstInt * Convert.ToInt32(textBox4.Text)).ToString();
                    }
                    else if (islem == 4)
                    {
                        textBox5.Text = (firstInt / Convert.ToInt32(textBox4.Text)).ToString();
                    }
                    textBox4.Text = null;
                }
            }

            
        }
        private void button16_Click(object sender, EventArgs e)
        {
            
            
                firstInt = 0;
                textBox4.Text = null;
                textBox5.Text = null;
            
        }






        private void button5_Click(object sender, EventArgs e)
        {
            if(isFull() == true)
            {
                textBox4.Text += "1";
            }
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (isFull() == true)
            {
                textBox4.Text += "2";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (isFull() == true)
            {
                textBox4.Text += "3";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (isFull() == true)
            {
                textBox4.Text += "4";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (isFull() == true)
            {
                textBox4.Text += "9";
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (isFull() == true)
            {
                textBox4.Text += "0";
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (isFull() == true)
            {
                textBox4.Text += "7";
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (isFull() == true)
            {
                textBox4.Text += "8";
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            if (isFull() == true)
            {
                textBox4.Text += "5";
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (isFull() == true)
            {
                textBox4.Text += "6";
            }
        }




        private void label5_Click(object sender, EventArgs e)
        {

        }

        
    }
}