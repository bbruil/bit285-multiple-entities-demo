namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using IndyBooks.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<IndyBooks.Models.BookstoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "IndyBooks.Models.BookstoreDbContext";
        }

        protected override void Seed(IndyBooks.Models.BookstoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Books.AddOrUpdate(b => b.BookID,
                new Book()
                {
                    BookID = 1,
                    Title = "Pride and Prejudice",
                    AuthorID = 1,
                    Price = 9.99M
                },
                new Book()
                {
                    BookID = 2,
                    Title = "Northanger Abbey",
                    AuthorID = 1,
                    Price = 12.95M
                },
                new Book()
                {
                    BookID = 3,
                    Title = "David Copperfield",
                    AuthorID =2,
                    Price = 15.00M
                },
                new Book()
                {
                    BookID = 4,
                    Title = "The Wizard of EarthSea",
                    AuthorID =2,
                    Price = 8.95M
                },
                new Book()
                {
                    BookID = 5,
                    Title = "The Tombs of Atuan",
                    AuthorID = 2,
                    Price = 7.95M
                },
                new Book()
                {
                    BookID = 6,
                    Title = "The Farthest Shore",
                    AuthorID = 3,
                    Price = 9.95M

                });
            //TODO: Add several Author records
            context.Authors.AddOrUpdate(b => b.AuthorID,
                new Author()
                {
                    AuthorID = 1,
                    AuthorName = "Dr.Suess",
                    AuthorAddress = "123 HAPPY STREET",



                },
                new Author()
                {
                    AuthorID = 2,
                    AuthorName = "JK Rawling",
                    AuthorAddress = "243 Hogwarts Lane",
                },
                 new Author()
                 {
                     AuthorID = 3,
                     AuthorName = "Steven King",
                     AuthorAddress = "254 Cugo Court E",
                 });

            //TODO: Add several Member records
            context.Members.AddOrUpdate(b => b.MemberID,
                new Member()
                {
                    MemberID = 1,
                    MemberAddress = "25343 My Dead End",
                    LengthOfMembership = 7
                },
                new Member()
                {
                    MemberID = 2,
                    MemberAddress = "777 harry potter drive",
                    LengthOfMembership = 2
                },
                      new Member()
                      {
                          MemberID = 3,
                          MemberAddress = "15423 Happy Street",
                          LengthOfMembership = 3
                      });

            //TODO: Add additional Purchase records
            context.Purchases.AddOrUpdate(p => p.PurchaseID,
                new Purchase()
                {
                    PurchaseID = 1,
                    Amount = 10.00M,
                    BookID = 6,
                    MemberID= 3
                    
                    
                    //TODO: Add the MemberID value
                });

        }
    }
}
