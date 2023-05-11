namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q122 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Compositions", "Level_LevelID", c => c.Int());
            AddColumn("dbo.Compositions", "Subject_SubjectID", c => c.Int());
            CreateIndex("dbo.Compositions", "Level_LevelID");
            CreateIndex("dbo.Compositions", "Subject_SubjectID");
            AddForeignKey("dbo.Compositions", "Level_LevelID", "dbo.Levels", "LevelID");
            AddForeignKey("dbo.Compositions", "Subject_SubjectID", "dbo.Subjects", "SubjectID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Compositions", "Subject_SubjectID", "dbo.Subjects");
            DropForeignKey("dbo.Compositions", "Level_LevelID", "dbo.Levels");
            DropIndex("dbo.Compositions", new[] { "Subject_SubjectID" });
            DropIndex("dbo.Compositions", new[] { "Level_LevelID" });
            DropColumn("dbo.Compositions", "Subject_SubjectID");
            DropColumn("dbo.Compositions", "Level_LevelID");
        }
    }
}
