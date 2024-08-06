using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;


namespace CodeAlpha_Project_BookLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateOnly BorrowTime { get; set; }
        public bool IsReturned { get; set; }

        public string UserId { get; set; }

        public Book()
        {

        }
    }

}
