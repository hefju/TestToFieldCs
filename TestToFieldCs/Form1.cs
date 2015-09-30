using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestToFieldCs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = richTextBox1.Text.Trim().Replace("\r\n", ""); ;
            //var output = richTextBox2.Text;
            ChangeToField(input);
        }

        private void ChangeToField(string input)
        {
          
            var items = input.Split(new string[]{"、"}, StringSplitOptions.RemoveEmptyEntries); //input.Split('、');
            int count = 0;
            foreach (var item in items)
            {
                if (item == "") continue;
                var line = item + " nvarchar(20),";
                richTextBox2.AppendText(line );
                count++;
                if (count % 3 == 0 )//&& count>0)
                    richTextBox2.AppendText(Environment.NewLine);
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
        }
    }
}
