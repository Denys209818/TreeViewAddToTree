using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreeViewProject.Entities;
using TreeViewProject.Models;

namespace TreeViewProject.Services
{
    public static class DbSeeder
    {
        public static void SeedAll(EFContext context) 
        {
            SeedCategories(context);
        }

        private static void SeedCategories(EFContext context) 
        {
            if (context.categories.Count() == 0) 
            {
                string UrlSlug = "сars";
                SeedParent(context, "Легкові автомобілі", UrlSlug);
                SeedChild(context, "BMW", "bmw-cars", UrlSlug);
                SeedChild(context, "Mercedes", "mercedes-cars", UrlSlug);
                SeedChild(context, "Opel", "opel-cars", UrlSlug);
                SeedChild(context, "Opel Astra", "opel-astra-cars", "opel-cars");
                SeedChild(context, "Opel Vectra", "opel-vectra-cars", "opel-cars");

                UrlSlug = "trucks";
                SeedParent(context, "Вантажні автомобілі", UrlSlug);
                SeedChild(context, "MAN", "man-trucks", UrlSlug);
                SeedChild(context, "Mercedes", "mercedes-trucks", UrlSlug);
                SeedChild(context, "Ford", "ford-trucks", UrlSlug);

            }
        }

        private static void SeedParent(EFContext context, string name, string urlSlug) 
        {
            context.categories.Add(new TreeViewElement { 
                Name = name,
                UrlSlug = urlSlug,
                ParentId = null
            });

            context.SaveChanges();
        }

        private static void SeedChild(EFContext context, string name, string urlSlug, string parentUrlSlug) 
        {
            TreeViewElement el = context.categories.FirstOrDefault(x => x.UrlSlug == parentUrlSlug);
            if (el != null) 
            {
                context.categories.Add(new TreeViewElement { 
                Name = name,
                UrlSlug = urlSlug,
                ParentId = el.Id
                });

                context.SaveChanges();
            }
        }
    }
}
