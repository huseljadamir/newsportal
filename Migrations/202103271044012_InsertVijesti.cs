namespace Vijesti.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertVijesti : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT VIJESTS ON");
            Sql("INSERT INTO VIJESTS (ID, NAZIV, NASLOV, SADRZAJ) VALUES(1, 'PRVA', 'Prva Vijest', 'Lorem ipsum dolor sit')");
            Sql("INSERT INTO VIJESTS (ID, NAZIV, NASLOV, SADRZAJ) VALUES(2, 'DRUGA', 'Druga Vijest', 'Lorem ipsum dolor sit')");
            Sql("INSERT INTO VIJESTS (ID, NAZIV, NASLOV, SADRZAJ) VALUES(3, 'TREÆA', 'Treæa Vijest', 'Lorem ipsum dolor sit')");
            Sql("INSERT INTO VIJESTS (ID, NAZIV, NASLOV, SADRZAJ) VALUES(4, 'ÈETVRTA', 'Èetvrta Vijest', 'Lorem ipsum dolor sit')");
            Sql("INSERT INTO VIJESTS (ID, NAZIV, NASLOV, SADRZAJ) VALUES(5, 'PETA', 'Peta Vijest', 'Lorem ipsum dolor sit')");
        }
        
        public override void Down()
        {
        }
    }
}
