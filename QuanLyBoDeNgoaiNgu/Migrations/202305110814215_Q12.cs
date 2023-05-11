namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GroupAnswers", "Subject_SubjectID", c => c.Int());
            CreateIndex("dbo.GroupAnswers", "Subject_SubjectID");
            AddForeignKey("dbo.GroupAnswers", "Subject_SubjectID", "dbo.Subjects", "SubjectID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GroupAnswers", "Subject_SubjectID", "dbo.Subjects");
            DropIndex("dbo.GroupAnswers", new[] { "Subject_SubjectID" });
            DropColumn("dbo.GroupAnswers", "Subject_SubjectID");
        }
    }
}
