using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFGetStarted.AspNetCore.NewDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Vue2Spa.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProjectContext(
                serviceProvider.GetRequiredService<DbContextOptions<ProjectContext>>()))
            {
                // Look for any movies.
                if (context.CmsContent.Any())
                {
                    return;   // DB has been seeded
                }

                context.CmsContent.AddRange(
                    new CmsContent
                    {
                        Id = "about_daniel",
                        Content = @"Daniel<br/>
Age:22<br/>
Height: 180cm<br/>
Field of study: Software engineering<br/>
Favourite dish: Anything Italian<br/>
Favourite game: Overwatch<br/>
Favourite programming language: Emoji<br/>"
                    },

                    new CmsContent
                    {
                        Id = "about_harald",
                        Content = @"Harald<br/>
Age: 21<br/>
Height: 187cm<br/>
Field of study: Software engineering<br/>
Favourite dish: ""Bangers n' mash""<br/>
Favourite game: Mirror's Edge<br/>
Favourite programming language: Bitconnect<br/>",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
