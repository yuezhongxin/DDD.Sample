namespace DDD.Sample.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTeacherId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "TeacherId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "TeacherId");
        }
    }
}
