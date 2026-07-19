using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class PremiumMember : Member
    {
        public int MaxBorrowLimit { get; set; }
        public int LoanDays { get; set; }
        public PremiumMember()
        {
            MaxBorrowLimit = 10;
            LoanDays = 30;
        }
        public override string GetInfo()
        {
            return $"[Premium] {base.GetInfo()} | Max Borrow: {MaxBorrowLimit} | Loan Days: {LoanDays}";
        }
    }
}
