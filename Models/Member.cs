using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryManagementSystem.Interfaces;
namespace LibraryManagementSystem.Models
{
    public class Member : ISearchable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        public Book[] BorrowedBooks { get; set; }
        public Member()
        {
            JoinDate = DateTime.Now;
            BorrowedBooks = new Book[10];
        }
        public virtual string GetInfo()
        {
            return $"ID: {Id} | Name: {Name} | Email: {Email}";
        }
        public bool MatchesQuery(string query)
        {
            query = query.ToLower();
            return Name.ToLower().Contains(query)
                || Email.ToLower().Contains(query);
        }
    }
}











