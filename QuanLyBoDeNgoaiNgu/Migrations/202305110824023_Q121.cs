namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q121 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GroupQuestions", "Subject_SubjectID", c => c.Int());
            CreateIndex("dbo.GroupQuestions", "Subject_SubjectID");
            AddForeignKey("dbo.GroupQuestions", "Subject_SubjectID", "dbo.Subjects", "SubjectID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GroupQuestions", "Subject_SubjectID", "dbo.Subjects");
            DropIndex("dbo.GroupQuestions", new[] { "Subject_SubjectID" });
            DropColumn("dbo.GroupQuestions", "Subject_SubjectID");
        }
    }
}
