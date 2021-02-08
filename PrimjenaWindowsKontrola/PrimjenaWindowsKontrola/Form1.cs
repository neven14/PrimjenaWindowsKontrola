using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimjenaWindowsKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text== "Notepad")
                {
                System.Diagnostics.Process.Start(@"C:\Windows\System32\Notepad.exe");
                }
            if(comboBox1.Text== "Paint")
            {
                System.Diagnostics.Process.Start(@"C:\Windows\System32\mspaint.exe");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxDescription.Clear();
            textBoxName.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
