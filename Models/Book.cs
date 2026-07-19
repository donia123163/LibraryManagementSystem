using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryManagementSystem.Interfaces;
namespace LibraryManagementSystem.Models
{
    public class Book : LibraryItem, ISearchable
    {
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }
        public Book()
        {
            IsAvailable = true;
        }
        public override string GetInfo()
        {
            return $"ID: {Id} | {Title} | {Author} | {Year} | {Genre} | {(IsAvailable ? "Available" : "Borrowed")}";
        }
        public bool MatchesQuery(string query)
        {
            query = query.ToLower();
            return Title.ToLower().Contains(query)
                || Author.ToLower().Contains(query)
                || Genre.ToLower().Contains(query);
        }
    }
}
