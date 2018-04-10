namespace ResistenciaBR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tips : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tips", "Categoria", c => c.String(nullable: false));
            AlterColumn("dbo.Tips", "Titulo", c => c.String(nullable: false));
            AlterColumn("dbo.Tips", "Texto", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tips", "Texto", c => c.String());
            AlterColumn("dbo.Tips", "Titulo", c => c.String());
            AlterColumn("dbo.Tips", "Categoria", c => c.String());
        }
    }
}
