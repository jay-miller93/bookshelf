using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace BookShelf1.Models
{
    public class Book
    {
        [Key] //primary key
        public int ID { get; set; } //when you are building a model in c# you will always need an ID
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }

        [ForeignKey("Category")] //ForeignKey establishes a relationship with another class or table
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
                     //^^Navigation Property


    }
}