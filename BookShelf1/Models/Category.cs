using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookShelf1.Models
{
    public class Category
    {
        [Key]   
        public int ID { get; set; }
        public string name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
                     //^^^ Navigation property

    }
}