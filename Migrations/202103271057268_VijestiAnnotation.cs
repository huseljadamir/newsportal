namespace Vijesti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VijestiAnnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vijests", "Naziv", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Vijests", "Naslov", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Vijests", "Sadrzaj", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vijests", "Sadrzaj", c => c.String());
            AlterColumn("dbo.Vijests", "Naslov", c => c.String());
            AlterColumn("dbo.Vijests", "Naziv", c => c.String());
        }
    }
}
