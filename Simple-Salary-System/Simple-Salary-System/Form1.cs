using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Salary_System
{
    public partial class Form1 : Form
    {
        int SalaryPerHour = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateSalary_Click(object sender, EventArgs e)
        {
            
            
            if (cmbEducationDegree.SelectedIndex < 0)
            {
                MessageBox.Show("Please Choose An Educational Degree!!");
                return;
            }
            if (cmbEducationDegree.SelectedIndex == 0)
            {
                SalaryPerHour = 100000;

            }
            if (cmbEducationDegree.SelectedIndex == 1)
            {
                SalaryPerHour = 200000;

            }
            if (cmbEducationDegree.SelectedIndex == 2)
            {
                SalaryPerHour = 300000;


            }
            if (cmbEducationDegree.SelectedIndex == 3)
            {
                SalaryPerHour = 400000;

            }

            if (txtWorkHour.Text == "")
            {
                MessageBox.Show("Please Enter Work Hour!!");
                return;
            }
            int WorkHour = Convert.ToInt32(txtWorkHour.Text);
            int Salary = SalaryPerHour * WorkHour;
            txtSalary.Text = Salary.ToString() + "   IRT";
        }

        private void cmbEducationDegree_SelectedIndexChanged(object sender, EventArgs e)
        {   
            
            if (cmbEducationDegree.SelectedIndex == 0)
            {
                SalaryPerHour = 100000;
                lblSalaryPerHour.Text = SalaryPerHour.ToString();
            }
            if (cmbEducationDegree.SelectedIndex == 1)
            {
                SalaryPerHour = 200000;
                lblSalaryPerHour.Text = SalaryPerHour.ToString();

            }
            if (cmbEducationDegree.SelectedIndex == 2)
            {
                SalaryPerHour = 300000;
                lblSalaryPerHour.Text = SalaryPerHour.ToString();
            }
            if (cmbEducationDegree.SelectedIndex == 3)
            {
                SalaryPerHour = 400000;
                lblSalaryPerHour.Text = SalaryPerHour.ToString();
            }
        }
    }
}
