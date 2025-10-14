using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class PAYROLL_CLASS : Form
    {


        private double grossIncome = 0.0;
        private double basicIncome = 0.0;
        private double honorariumIncome = 0.0;
        private double otherIncome = 0.0;

        private double sssContrib = 0.0;
        private double philhealthContrib = 0.0;
        private const double PagibigContribFixed = 200.00; // As per PAYROLL_FUNCTION.cs
        private double incomeTaxContrib = 0.0;
        private double totalDeductions = 0.0;
        private double netIncome = 0.0;

        public PAYROLL_CLASS()
        {
            InitializeComponent();
            InitializeCustomSettings();
        }

        private void InitializeCustomSettings()
        {

            basicIncomeTxtBox.Enabled = false;
            hoIncomeTxtBox.Enabled = false;
            otIncomeTxtBox.Enabled = false;
            grossIncomeTxtBox.Enabled = false;
            netIncomeTxtBox.Enabled = false;
            totalDeductionTxtBox.Enabled = false;
            sssContribTxtBox.Enabled = false;
            philhealthContribTxtBox.Enabled = false;
            pagibigContribTxtBox.Enabled = false;
            incometaxContribTxtBox.Enabled = false;
        }

        // ----------------------------------------------------------------------------------
        // Event Handler for Gross Income Calculation (Equivalent to grossIncomeBtn_Click)
        // ----------------------------------------------------------------------------------
       
        
        

        private void grossIncomeBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 1. Get Input Values
                double basicRate = Convert.ToDouble(basicRatehrTxtBox.Text);
                double basicHours = Convert.ToDouble(basicHrTxtBox.Text);
                double honorariumRate = Convert.ToDouble(horateHrsTxtBox.Text);
                double honorariumHours = Convert.ToDouble(hoHrsTxtBox.Text);
                double otherRate = Convert.ToDouble(otRateTxtBox.Text);
                double otherHours = Convert.ToDouble(otHrsTxtBox.Text);

                // 2. Calculate Incomes
                basicIncome = basicRate * basicHours;
                honorariumIncome = honorariumRate * honorariumHours;
                otherIncome = otherRate * otherHours;
                grossIncome = basicIncome + honorariumIncome + otherIncome;

                // 3. Display Income Outputs
                grossIncomeTxtBox.Text = grossIncome.ToString("n2");
                basicIncomeTxtBox.Text = basicIncome.ToString("n2");
                hoIncomeTxtBox.Text = honorariumIncome.ToString("n2");
                otIncomeTxtBox.Text = otherIncome.ToString("n2");

                // 4. Calculate SSS Contribution (Simplified logic based on PAYROLL_FUNCTION)
                // Note: The original SSS contribution logic in PAYROLL_FUNCTION is very long 
                // and should ideally be placed in a separate helper function or configuration file.
                if (grossIncome >= 34750)
                    sssContrib = 5280.00;
                else if (grossIncome >= 5250)
                    sssContrib = 760.00 + (Math.Floor((grossIncome - 5250) / 500) * 75.00);
                else
                    sssContrib = 760.00; // Or the lowest bracket value

                // 5. Calculate PhilHealth Contribution (Using a flat 5% rate as per original code structure)
                // Note: PhilHealth rates/ceilings are complex and should be reviewed for accuracy.
                philhealthContrib = grossIncome * 0.05;
                if (philhealthContrib > 5000.00) // Assuming max contribution is 5,000 based on typical ceilings
                {
                    philhealthContrib = 5000.00;
                }

                // 6. Calculate Income Tax Contribution (Using Annualized TRAIN Law formula from PAYROLL_FUNCTION)
                double annualGross = grossIncome * 24; // Assuming 24 pay periods in a year
                if (annualGross <= 250000)
                {
                    incomeTaxContrib = 0.00;
                }
                else if (annualGross <= 400000)
                {
                    incomeTaxContrib = ((annualGross - 250000) * 0.15) / 24;
                }
                else if (annualGross <= 800000)
                {
                    incomeTaxContrib = (((annualGross - 400000) * 0.20) + 22500) / 24;
                }
                else if (annualGross <= 2000000)
                {
                    incomeTaxContrib = (((annualGross - 800000) * 0.25) + 102500) / 24;
                }
                else if (annualGross <= 8000000)
                {
                    incomeTaxContrib = (((annualGross - 2000000) * 0.30) + 402500) / 24;
                }
                else
                {
                    incomeTaxContrib = (((annualGross - 8000000) * 0.35) + 2202500) / 24;
                }


                // 7. Display Deduction Outputs
                sssContribTxtBox.Text = sssContrib.ToString("n2");
                philhealthContribTxtBox.Text = philhealthContrib.ToString("n2");
                pagibigContribTxtBox.Text = PagibigContribFixed.ToString("n2");
                incometaxContribTxtBox.Text = incomeTaxContrib.ToString("n2");

            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure all input fields for rates and hours contain valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get Loan/Other Deduction Inputs
                double sssLoan = Convert.ToDouble(sssLoanTxtBox.Text);
                double pagibigLoan = Convert.ToDouble(pagibigLoanTxtBox.Text);
                double facultyDeposit = Convert.ToDouble(facultyDepositsTxtBox.Text);
                double facultyLoan = Convert.ToDouble(facultysavingLoanTxtBox.Text);
                double salaryLoan = Convert.ToDouble(salaryLoanTxtBox.Text);
                double otherLoans = Convert.ToDouble(otherLoanTxtBox.Text);

                // 2. Sum Statutory Contributions (read from output fields)
                double statutoryDeductions = Convert.ToDouble(sssContribTxtBox.Text) +
                                             Convert.ToDouble(pagibigContribTxtBox.Text) +
                                             Convert.ToDouble(philhealthContribTxtBox.Text) +
                                             Convert.ToDouble(incometaxContribTxtBox.Text);

                // 3. Calculate Total Deductions
                totalDeductions = statutoryDeductions + sssLoan + pagibigLoan + facultyDeposit + facultyLoan + salaryLoan + otherLoans;

                // Read gross income to ensure consistency after calculation
                grossIncome = Convert.ToDouble(grossIncomeTxtBox.Text);

                // 4. Calculate Net Income
                netIncome = grossIncome - totalDeductions;

                // 5. Display Totals
                totalDeductionTxtBox.Text = totalDeductions.ToString("n2");
                netIncomeTxtBox.Text = netIncome.ToString("n2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please ensure all input fields for loans and deposits contain valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            PAYROLLSLIP print = new PAYROLLSLIP();

            // Populate via public properties (avoids accessing private controls)
            print.EmployeeCode = employeeNumberTxtBox.Text;
            print.EmployeeName = $"{firstNameTxtBox.Text} {middleNameTxtBox.Text} {surnameTxtBox.Text}";
            print.Department = departmentTxtBox.Text;
            print.CutOff = payDateTxtBox.Text;
            print.PayPeriod = payDateTxtBox.Text; // Duplicated in original code

            print.BasicPayHrs = basicHrTxtBox.Text;
            print.BasicPayIncome = basicIncomeTxtBox.Text;
            print.HonorariumHrs = horateHrsTxtBox.Text;
            print.HonorariumIncome = hoIncomeTxtBox.Text;
            print.OvertimeHrs = otHrsTxtBox.Text;
            print.OvertimeIncome = otIncomeTxtBox.Text;

            print.WithholdingTax = incometaxContribTxtBox.Text;
            print.SSS = sssContribTxtBox.Text;
            print.Pagibig = pagibigContribTxtBox.Text;
            print.Philhealth = philhealthContribTxtBox.Text;
            print.Wisp = "750"; // Hardcoded value from original code

            print.Earnings = grossIncomeTxtBox.Text;
            print.Deductions = totalDeductionTxtBox.Text;
            print.Overtime = otIncomeTxtBox.Text; // Duplicated but harmless

            print.Gross = grossIncomeTxtBox.Text;
            print.NetPay = netIncomeTxtBox.Text;

            print.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Clear all input text boxes
            basicRatehrTxtBox.Clear();
            basicHrTxtBox.Clear();
            horateHrsTxtBox.Clear();
            hoHrsTxtBox.Clear();
            otRateTxtBox.Clear();
            otHrsTxtBox.Clear();

            sssLoanTxtBox.Clear();
            pagibigLoanTxtBox.Clear();
            facultyDepositsTxtBox.Clear();
            facultysavingLoanTxtBox.Clear();
            salaryLoanTxtBox.Clear();
            otherLoanTxtBox.Clear();
            employeeNumberTxtBox.Clear();
            departmentTxtBox.Clear();
            firstNameTxtBox.Clear();
            middleNameTxtBox.Clear();
            surnameTxtBox.Clear();
            payDateTxtBox.Clear();

            // Clear all output text boxes
            basicIncomeTxtBox.Clear();
            hoIncomeTxtBox.Clear();
            otIncomeTxtBox.Clear();
            grossIncomeTxtBox.Clear();
            sssContribTxtBox.Clear();
            philhealthContribTxtBox.Clear();
            pagibigContribTxtBox.Clear();
            incometaxContribTxtBox.Clear();
            totalDeductionTxtBox.Clear();
            netIncomeTxtBox.Clear();


            // Reset class-level variables (optional but good practice)
            grossIncome = basicIncome = honorariumIncome = otherIncome = 0.0;
            sssContrib = philhealthContrib = incomeTaxContrib = totalDeductions = netIncome = 0.0;

            basicRatehrTxtBox.Focus(); // Changed focus to an input field
        }
    }
}