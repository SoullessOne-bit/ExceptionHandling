// Estimated to take 30 minutes
// Tianna Vinson
// July 18, 2021
// GUI components for this project: 1 label, 1 textbox, 1 button
// Exception handling: try catch block, if-else statement

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandling
{
    public partial class Form1 : Form
    {
        //string str1;
        //int num1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // if ANYTHING in the try block does not work, the program will jump to the catch block
            string str = textBox1.Text;
            int result;
            // if able to parse, output the 'result' to result
            if (int.TryParse(str, out result))
            {
                MessageBox.Show("This is a valid integer");
            }
            else
            {
                MessageBox.Show("NOT a valid integer");
            }
            try
            {
                int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("CATCH - This is NOT a valid int");
            }
        }
    }
}

// I had already completed this project while we were in class on Wednesday, so I did not need to spend additional time on it after watching the
// video on the submission page. I found the video and class very helpful on these different exception methods. I learned that you could write
// an entire program in a try catch block. For my next project, it will be a good idea to begin brainstorming more methods learned in class
// I will apply to my final project. I have already begun thinking about the GUI components and error messages.