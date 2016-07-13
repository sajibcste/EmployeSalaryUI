using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeSalaryUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Employee aEmployee;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EmployeSaveButton_Click(object sender, EventArgs e)
        {
            aEmployee = new Employee(IdtextBox.Text, NameTextBox.Text, EmaillTextBox.Text);
         double   Basic = Convert.ToDouble(BasicTextBox.Text);
         double medicalAmount = Convert.ToDouble(MedicalTextBox.Text);
         double ConvenceAmount= Convert.ToDouble(ConveryanceTextBox.Text);
         Salary aSalary = new Salary(Basic, medicalAmount, ConvenceAmount);
         aEmployee.EmployeeSalary = aSalary;
            MessageBox.Show("CREATED");
        }

        private void SalaryShowButton_Click(object sender, EventArgs e)
        {
            noOFincrementTextBox.Text = aEmployee.EmployeeSalary.NoOfIncrement.ToString();
           mainBasicTextBox.Text = aEmployee.EmployeeSalary.Basic1.ToString();
           
            mainMedicalTextBox.Text = aEmployee.EmployeeSalary.GetMedicalAmount().ToString();
            mainConveryanceTextBox.Text = aEmployee.EmployeeSalary.GetConveryanceAmount().ToString();
            totalTextBox.Text = aEmployee.EmployeeSalary.GetTotal().ToString();
        }

        private void IncrementButton_Click(object sender, EventArgs e)
        {
            double BasicPercentegeToBeIncrease = Convert.ToDouble(increaseTextBox.Text);


            aEmployee.EmployeeSalary.incrementAmount(BasicPercentegeToBeIncrease);

        }
    }
}
