namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q141 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Certificates", "Pass", c => c.Boolean(nullable: false));
            AddColumn("dbo.Certificates", "Score", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Certificates", "Score");
            DropColumn("dbo.Certificates", "Pass");
        }
    }
}
