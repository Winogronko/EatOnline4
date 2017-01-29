using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EatOnline4.Models
{
    public class EatOnline4Context : DbContext
    {
        public EatOnline4Context()
            : base("name=EatOnline4Context")
        {
        }

        public static EatOnline4Context Create() { return new EatOnline4Context(); }

        public System.Data.Entity.DbSet<EatOnline4.Models.Basket> Baskets { get; set; }

        public System.Data.Entity.DbSet<EatOnline4.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<EatOnline4.Models.ContactData> ContactDatas { get; set; }

        public System.Data.Entity.DbSet<EatOnline4.Models.Dish> Dishes { get; set; }

        public System.Data.Entity.DbSet<EatOnline4.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<EatOnline4.Models.OrderDish> OrderDishes { get; set; }

        public System.Data.Entity.DbSet<EatOnline4.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<EatOnline4.Models.Role> Roles { get; set; }
    }
}