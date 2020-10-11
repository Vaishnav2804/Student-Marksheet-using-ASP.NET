using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentMarksResultAnalysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblSemMarksheet_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label42_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void lblGNet_Click(object sender, EventArgs e)
        {

        }

        private void lblGMC_Click(object sender, EventArgs e)
        {

        }

        private void lblGMaths_Click(object sender, EventArgs e)
        {

        }

        private void lblGEnglish_Click(object sender, EventArgs e)
        {

        }

        private void lblGChem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3, num4, num5, Total, Obtain, p1, p2, p3, p4, p5, p6, Per;
            num1 = Convert.ToInt32(txtNet.Text);
            num2 = Convert.ToInt32(txtMobileComputing.Text);
            num3 = Convert.ToInt32(txtMaths.Text);
            num4 = Convert.ToInt32(txtEnglish.Text);
            num5 = Convert.ToInt32(txtChem.Text);

            Total = num1 + num2 + num3 + num4 + num5;
            lblPerTotal.Text = Total.ToString();

            int A;
            A = Convert.ToInt32(txtNet.Text);
            if(A>=80 && A <= 100)
                lblGNet.Text = "S";
            else if (A >= 70 && A <= 79)
                lblGNet.Text = "A";
            else if (A >= 60 && A <= 69)
                lblGNet.Text = "B";
            else if (A >= 50 && A <= 59)
                lblGNet.Text = "C";
            else 
                lblGNet.Text = "Fail";

            int B;
            B = Convert.ToInt32(txtMobileComputing.Text);
            if (B >= 80 && B <= 100)
                lblGMC.Text = "S";
            else if(B >= 70 && B <= 79)
                lblGMC.Text = "A";
            else if (B >= 60 && B <= 69)
                lblGMC.Text = "B";
            else if (B >= 50 && B <= 59)
                lblGMC.Text = "C";
            else
                lblGMC.Text = "Fail";

            int C;
            C = Convert.ToInt32(txtMaths.Text);
            if (C >= 80 && C <= 100)
                lblGMaths.Text = "S";
            else if (C >= 70 && C <= 79)
                lblGMaths.Text = "A";
            else if (C >= 60 && C <= 69)
                lblGMaths.Text = "B";
            else if (C >= 50 && C <= 59)
                lblGMaths.Text = "C";
            else
                lblGMaths.Text = "Fail";

            int D;
            D = Convert.ToInt32(txtEnglish.Text);
            if (D >= 80 && D <= 100)
                lblGEnglish.Text = "S";
            else if (D >= 70 && D <= 79)
                lblGEnglish.Text = "A";
            else if (D >= 60 && D <= 69)
                lblGEnglish.Text = "B";
            else if (D >= 50 && D <= 59)
                lblGEnglish.Text = "C";
            else
                lblGEnglish.Text = "Fail";

            int E;
            E = Convert.ToInt32(txtChem.Text);
            if (E >= 80 && E <= 100)
                lblGChem.Text = "S";
            else if (E >= 70 && E <= 79)
                lblGChem.Text = "A";
            else if (E >= 60 && E <= 69)
                lblGChem.Text = "B";
            else if (E >= 50 && E <= 59)
                lblGChem.Text = "C";
            else
                lblGChem.Text = "Fail";

            Total = Convert.ToInt32(lblPerTotal.Text);
            if (Total >= 380 && Total <= 500)
                lblGrade.Text = "S";
            else if (Total >= 220 && Total <=379 )
                lblGrade.Text = "A";
            else if (Total >= 160 && Total <= 219)
                lblGrade.Text = "B";
            else if (Total >= 100 && Total <= 159)
                lblGrade.Text = "C";
            else lblGrade.Text = "Fail";

            p1 = num1 * 100 / 100;
            lblPNet.Text = p1.ToString();
            p2 = num2 * 100 / 100;
            lblPMC.Text = p2.ToString();
            p3 = num3 * 100 / 100;
            lblPMaths.Text = p3.ToString();
            p4 = num4 * 100 / 100;
            lblPEnglish.Text = p4.ToString();
            p5 = num5 * 100 / 100;
            lblPChem.Text = p5.ToString();

            Per = Total / 6;
            lblPercentage.Text = Per.ToString();

            Per = Convert.ToInt32(lblPercentage.Text);
            if(Per >= 85 && Per <= 100)
            {
                lblGPA.Text = "4.0";
            }
            else if (Per >= 80 && Per <= 84)
            {
                lblGPA.Text = "3.7";
            }
            else if (Per >= 75 && Per <= 79)
            {
                lblGPA.Text = "3.3";
            }
            else if (Per >= 70 && Per <= 74)
            {
                lblGPA.Text = "3.0";
            }
            else if (Per >= 65 && Per <= 69)
            {
                lblGPA.Text = "2.7";
            }
            else if (Per >= 61 && Per <= 64)
            {
                lblGPA.Text = "2.3";
            }
            else if (Per >= 58 && Per <= 60)
            {
                lblGPA.Text = "2.0";
            }
            else if (Per >= 55 && Per <= 57)
            {
                lblGPA.Text = "1.7";
            }
            else if (Per >= 50 && Per <= 54)
            {
                lblGPA.Text = "1.0";
            }
            else if (Per >= 0 && Per <= 49)
            {
                lblGPA.Text = "0.0";
            }
        }
    }
}
