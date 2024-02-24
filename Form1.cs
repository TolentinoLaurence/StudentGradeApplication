using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double SI, IT, QT, TN, PC;
            string Total, MSG;

            SI = int.Parse(txtSI.Text);
            IT = int.Parse(txtIT.Text);
            QT = int.Parse(txtQT.Text);
            TN = int.Parse(txtTN.Text);
            PC = int.Parse(txtPC.Text);

            double total = (SI + IT + QT + TN + PC) / 5;
            txtTotal.Text = total.ToString();

            if (total > 75)
            {
                string msg = ("Keep it up");
                txtMessage.Text = msg;
            } 
            else if (total < 75) {
                string msg = ("Lumayas ka na");
                txtMessage.Text = msg;
            } else {
                string msg = ("Invalid Input...");
                txtMessage.Text = msg;
            }

        }
    }
}
