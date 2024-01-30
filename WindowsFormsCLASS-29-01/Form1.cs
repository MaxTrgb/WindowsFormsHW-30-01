using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsCLASS_29_01
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

        private void button2_Click(object sender, EventArgs e)
        {
            string str1 = textBox3.Text;
            string str2 = textBox4.Text;

            int numOne = Int32.Parse(str1);
            int numTwo = Int32.Parse(str2);

            int res = numOne + numTwo;

            label6.Text = res.ToString();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str1 = textBox3.Text;
            string str2 = textBox4.Text;

            int numOne = Int32.Parse(str1);
            int numTwo = Int32.Parse(str2);

            int res = numOne - numTwo;

            label6.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str1 = textBox3.Text;
            string str2 = textBox4.Text;

            int numOne = Int32.Parse(str1);
            int numTwo = Int32.Parse(str2);

            int res = numOne * numTwo;

            label6.Text = res.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str1 = textBox3.Text;
            string str2 = textBox4.Text;

            int numOne = Int32.Parse(str1);
            int numTwo = Int32.Parse(str2);

            int res = numOne / numTwo;

            label6.Text = res.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str = textBox5.Text;
            int input = Int32.Parse(str);
            int res = (input * 9 / 5) + 32;

            label8.Text = res.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string str = textBox6.Text;
            int input = Int32.Parse(str);
            int res = (input - 32) * 5 / 9;

            label10.Text = res.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string input = textBox7.Text;

            Dictionary<string, string> words = new Dictionary<string, string>();
            words.Add("apple", "яблуко");
            words.Add("book", "книга");
            words.Add("pen", "ручка");
            words.Add("car", "автомобіль");

            string res = words[input];

            label12.Text = res.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string input = textBox7.Text;

            Dictionary<string, string> words = new Dictionary<string, string>();
            words.Add("apple", "яблуко - фрукт що росте на яблуні");
            words.Add("book", "книга - багато слів разом");
            words.Add("pen", "ручка - штука щоб писати чорнилом");
            words.Add("car", "автомобіль - засіб пересування");

            string res = words[input];

            label12.Text = res.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                char[] password = new char[10];
                Random rnd = new Random();

                if (checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
                {
                    for (int i = 0; i < password.Length; i++)
                    {
                        char randomChar = (char)rnd.Next('a', 'z' + 1);
                        password[i] = randomChar;
                    }
                    label13.Text = new string(password);
                }
                else if (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked)
                {
                    for (int i = 0; i < password.Length; i += 2)
                    {
                        password[i] = (char)rnd.Next('a', 'z' + 1);
                        if (i + 1 < password.Length) password[i + 1] = (char)rnd.Next('0', '9' + 1);
                    }
                    label13.Text = new string(password);
                }
                else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    for (int i = 0; i < password.Length; i += 3)
                    {
                        password[i] = (char)rnd.Next('a', 'z' + 1);
                        if (i + 1 < password.Length) password[i + 1] = (char)rnd.Next('0', '9' + 1);
                        if (i + 2 < password.Length) password[i + 2] = (char)rnd.Next('!', '=' + 1);
                    }
                    label13.Text = new string(password);
                }
                else if (!checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked)
                {
                    for (int i = 0; i < password.Length; i++)
                    {
                        password[i] = (char)rnd.Next('0', '9' + 1);
                    }
                    label13.Text = new string(password);
                }
                else if (!checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked)
                {
                    for (int i = 0; i < password.Length; i++)
                    {
                        password[i] = (char)rnd.Next('!', '=' + 1);
                    }
                    label13.Text = new string(password);
                }
            }
            else
            {
                char[] password = new char[20];
                Random rnd = new Random();

                if (checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
                {
                    for (int i = 0; i < password.Length; i++)
                    {
                        password[i] = (char)rnd.Next('a', 'z' + 1);
                    }
                    label13.Text = new string(password);
                }
                else if (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked)
                {
                    for (int i = 0; i < password.Length; i += 2)
                    {
                        password[i] = (char)rnd.Next('a', 'z' + 1);
                        if (i + 1 < password.Length) password[i + 1] = (char)rnd.Next('0', '9' + 1);
                    }
                    label13.Text = new string(password);
                }
                else if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
                {
                    for (int i = 0; i < password.Length; i += 3)
                    {
                        if (i < password.Length) password[i] = (char)rnd.Next('a', 'z' + 1);
                        if (i + 1 < password.Length) password[i + 1] = (char)rnd.Next('0', '9' + 1);
                        if (i + 2 < password.Length) password[i + 2] = (char)rnd.Next('!', '=' + 1);
                    }
                    label13.Text = new string(password);
                }

                else if (!checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked)
                {
                    for (int i = 0; i < password.Length; i++)
                    {
                        password[i] = (char)rnd.Next('0', '9' + 1);
                    }
                    label13.Text = new string(password);
                }
                else if (!checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked)
                {
                    for (int i = 0; i < password.Length; i++)
                    {
                        password[i] = (char)rnd.Next('!', '=' + 1);
                    }
                    label13.Text = new string(password);
                }
                else if (checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked)
                {
                    for (int i = 0; i < password.Length; i += 2)
                    {
                        password[i] = (char)rnd.Next('a', 'z' + 1);
                        if (i + 1 < password.Length) password[i + 1] = (char)rnd.Next('!', '=' + 1);
                    }
                    label13.Text = new string(password);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
