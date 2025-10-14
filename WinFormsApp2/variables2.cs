using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    // A class to hold payroll-related variables, constants, or types.
    public class variables2
    {
        

        public double BasicRate { get; set; }
        public double BasicHours { get; set; }
        public double HonorariumRate { get; set; }
        public double HonorariumHours { get; set; }
        public double OtherRate { get; set; } 

    
        public double BasicIncome { get; set; }
        public double HonorariumIncome { get; set; }
        public double OtherIncome { get; set; }
        public double GrossIncome { get; set; }

      

        public double SSSContrib { get; set; }
        public const double PagibigContribFixed = 200.00; 
        public double PhilhealthContrib { get; set; }
        public double IncomeTaxContrib { get; set; }

        
        public double SSSLoan { get; set; }
        public double PagibigLoan { get; set; }
        public double FacultyDeposit { get; set; }
        public double FacultyLoan { get; set; } 
        public double SalaryLoan { get; set; }
        public double OtherLoans { get; set; }

      
        public double TotalDeductions { get; set; }
        public double NetIncome { get; set; }
    }
}