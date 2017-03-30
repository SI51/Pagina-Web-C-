namespace escuela_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioImage : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Alumnos", "sImage", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Alumnos", "sImage", c => c.String(nullable: false, maxLength: 50, storeType: "nvarchar"));
        }
    }
}
