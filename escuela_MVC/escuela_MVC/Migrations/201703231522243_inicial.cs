namespace escuela_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnos",
                c => new
                    {
                        pkAlumno = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        sApellido = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        sGrupo = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        sImage = c.String(nullable: false, maxLength: 50, storeType: "nvarchar"),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkAlumno);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Alumnos");
        }
    }
}
