namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Levels", "LevelName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Levels", "LevelName", c => c.Int(nullable: false));
        }
    }
}
