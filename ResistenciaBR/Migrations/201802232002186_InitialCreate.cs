namespace ResistenciaBR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tips",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Categoria = c.String(),
                        Titulo = c.String(),
                        Texto = c.String(),
                        Autor = c.String(),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tips");
        }
    }
}
