using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStore.Models
{
    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "War and peace", Author = "L.Tolstoy", Price = 220 });
            db.Books.Add(new Book { Name = "Otzi i deti", Author = "I.Turgenev", Price = 190 });
            db.Books.Add(new Book { Name = "Chayka", Author = "Checkov", Price = 100 });
            base.Seed(db);
        }
    }
}