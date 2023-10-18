using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upravljanjeIznimkamaForms
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                int godRod = Convert.ToInt32(textBoxUnos.Text);

                textBoxIspis.Text = godRod.ToString();

                textBoxUnos.Clear();
            }

            catch (Exception greska)
            {
                DialogResult odabir = MessageBox.Show("Molim vas da upišete broj! \n Da li želite izbrisati svoj unos?", "POGREŠAN UNOS!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                switch (odabir)
                {
                    case DialogResult.Yes:
                        textBoxUnos.Clear();
                        break;

                    case DialogResult.No:
                        break;
                }

                textBoxUnos.Select();
            }
        }
    }
}
