using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryManagementSystem.Models
{
    public class BorrowRecord
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public Member Member { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public BorrowRecord()
        {
            BorrowDate = DateTime.Now;
        }
        public bool IsLate()
        {
            if (ReturnDate == null)
            {
                double days = (DateTime.Now - BorrowDate).TotalDays;
                if (days > 14)
                {
                    return true;
                }
            }
            return false;
        }
    }
}