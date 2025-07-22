﻿using my_books.Data.Models;

namespace my_books.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange( new Book()
                    {
                        Title = "1st Book Title",
                        Description = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now,
                        Rate = 4,
                        Genre = "Biography",
                        //Author = "First Author",
                        CoverUrl = "https.....",
                        DateAdded = DateTime.Now.AddDays(-10),
                    }, new Book()
                    {
                        Title = "2nd Book Title",
                        Description = "2nd Book Description",
                        IsRead = false,
                        Genre = "Biography",
                        //Author = "Second Author",
                        CoverUrl = "https.....",
                        DateAdded = DateTime.Now.AddDays(-7),
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
