namespace EatOnline4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Baskets",
                c => new
                    {
                        BasketID = c.Int(nullable: false, identity: true),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.BasketID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmPassword = c.String(),
                        Role_RoleID = c.Int(),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Roles", t => t.Role_RoleID)
                .Index(t => t.Role_RoleID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RoleID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                        Dish_DishID = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryID)
                .ForeignKey("dbo.Dishes", t => t.Dish_DishID)
                .Index(t => t.Dish_DishID);
            
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        DishID = c.Int(nullable: false, identity: true),
                        DishName = c.String(nullable: false),
                        Description = c.String(),
                        Ingredients = c.String(),
                        Price = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Calorific = c.Int(nullable: false),
                        PreparationTime = c.Int(nullable: false),
                        Availability = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DishID);
            
            CreateTable(
                "dbo.ContactDatas",
                c => new
                    {
                        ContactDataID = c.Int(nullable: false, identity: true),
                        City = c.String(nullable: false),
                        Street = c.String(nullable: false),
                        FlatNumber = c.Int(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContactDataID);
            
            CreateTable(
                "dbo.OrderDishes",
                c => new
                    {
                        OrderDishID = c.Int(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        Basket_BasketID = c.Int(),
                        Dish_DishID = c.Int(),
                        Order_OrderID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderDishID)
                .ForeignKey("dbo.Baskets", t => t.Basket_BasketID)
                .ForeignKey("dbo.Dishes", t => t.Dish_DishID)
                .ForeignKey("dbo.Orders", t => t.Order_OrderID)
                .Index(t => t.Basket_BasketID)
                .Index(t => t.Dish_DishID)
                .Index(t => t.Order_OrderID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        State = c.String(nullable: false),
                        OderDate = c.DateTime(nullable: false),
                        ContactData_ContactDataID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.ContactDatas", t => t.ContactData_ContactDataID)
                .Index(t => t.ContactData_ContactDataID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDishes", "Order_OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "ContactData_ContactDataID", "dbo.ContactDatas");
            DropForeignKey("dbo.OrderDishes", "Dish_DishID", "dbo.Dishes");
            DropForeignKey("dbo.OrderDishes", "Basket_BasketID", "dbo.Baskets");
            DropForeignKey("dbo.Categories", "Dish_DishID", "dbo.Dishes");
            DropForeignKey("dbo.Users", "Role_RoleID", "dbo.Roles");
            DropForeignKey("dbo.Baskets", "User_UserID", "dbo.Users");
            DropIndex("dbo.Orders", new[] { "ContactData_ContactDataID" });
            DropIndex("dbo.OrderDishes", new[] { "Order_OrderID" });
            DropIndex("dbo.OrderDishes", new[] { "Dish_DishID" });
            DropIndex("dbo.OrderDishes", new[] { "Basket_BasketID" });
            DropIndex("dbo.Categories", new[] { "Dish_DishID" });
            DropIndex("dbo.Users", new[] { "Role_RoleID" });
            DropIndex("dbo.Baskets", new[] { "User_UserID" });
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDishes");
            DropTable("dbo.ContactDatas");
            DropTable("dbo.Dishes");
            DropTable("dbo.Categories");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Baskets");
        }
    }
}
