using WebApi.DBOperations;
using WebApi.Entities;

namespace Tests.WebApi.UnitTests.TestSetup
{
    public static class Authors
    {
        public static void AddAuthors(this BookStoreDbContext context)
        {
            context.Authors.AddRange(
                    new Author 
                    {
                        Name = "onur",
                        Surname = "özdemir",
                        Birthdate = new DateTime(1994,01,01),
                        BookId = 1

                    
                    },
                    new Author 
                    {
                        Name = "enes",
                        Surname = "özdemir",
                        Birthdate = new DateTime(1999,12,15),
                        BookId = 2
                        
                    },
                    new Author 
                    {
                        Name = "burak",
                        Surname = "yıldız",
                        Birthdate = new DateTime(1995,02,22),
                        BookId = 3
                        
                    }

                );  
        }
    }
}