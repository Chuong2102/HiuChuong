namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Answers", "Text", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Answers", "Text");
        }
    }
}
