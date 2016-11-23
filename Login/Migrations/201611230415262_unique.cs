namespace Login.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unique : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "usuario", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Usuarios", "usuario", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Usuarios", new[] { "usuario" });
            AlterColumn("dbo.Usuarios", "usuario", c => c.String(nullable: false));
        }
    }
}
