using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox1.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string odabir = comboBox1.SelectedItem.ToString();

            if (odabir == "Notepad")
            {
                System.Diagnostics.Process.Start(@"C:\Windows\System32\Notepad.exe");
            }
            else
            {
                System.Diagnostics.Process.Start(@"C:\Windows\System32\mspaint.exe");
            }
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons gumbi = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon ikona = MessageBoxIcon.Information;
            DialogResult rezultat = MessageBox.Show("Odaberite neki gumb.", "Obavijest", gumbi, ikona);
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxButtons gumbi = MessageBoxButtons.YesNo;
            MessageBoxIcon ikona = MessageBoxIcon.Information;
            DialogResult rezultat = MessageBox.Show("Da li ste sigurni da želite zatvoriti aplikaciju?", "Potvrda", gumbi, ikona);
            switch (rezultat)
            {
                case DialogResult.Yes: Application.Exit(); break;

                case DialogResult.No: break;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2.opis = OpisPrograma.Text;
            Form2.ime = ImePrograma.Text;
            
        }
    }
}
