using System;
using System.Linq;

using NewsArticles.Models;

namespace NewsArticles.Data
{
    public static class DbInitializer
    {
        public static void Initialize(NewsArticlesContext context)
        {
            context.Database.EnsureCreated();

            if (context.Articles.Any()) return;
            var articles = new Article[]
            {
                new Article{
                    Title="Why demand for in-store contactless payments is here to stay",
                    Description="The demand for in-store contact less payment technology has increased over the past two years. Learn more about this growing trend and how you can leverage it.",
                    ReadTime=4,
                    ImageURL="/img/Article1001.png"
                },
                new Article{
                    Title="7 ways to increase ecommerce sales",
                    Description="Increase ecommerce sales with these 6 ideas to improve your customers' online payment experience.",
                    ReadTime=6,
                    ImageURL="/img/Article1002.png"
                },
                new Article{
                    Title="How technology empowers businesses to prepare for the future of commerce",
                    Description="The future of ecommerce is ever changing. Learn how our future-forward commerce technology keeps businesses at the forefront and remove complexity.",
                    ReadTime=5,
                    ImageURL="/img/Article1003.png"
                }
            };
            foreach (Article a in articles)
            {
                context.Articles.Add(a);
            }
            context.SaveChanges();
        }
    }
}
