namespace GroceriesConnect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablePaymentOptions : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentOptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentMode = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PaymentOptions");
        }
    }
}
