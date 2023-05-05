namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q5 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroupQuestions",
                c => new
                    {
                        GroupQuestionID = c.Int(nullable: false, identity: true),
                        GroupQuestionName = c.String(),
                        Question_QuestionID = c.Int(),
                    })
                .PrimaryKey(t => t.GroupQuestionID)
                .ForeignKey("dbo.Questions", t => t.Question_QuestionID)
                .Index(t => t.Question_QuestionID);
            
            AddColumn("dbo.Questions", "Text", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GroupQuestions", "Question_QuestionID", "dbo.Questions");
            DropIndex("dbo.GroupQuestions", new[] { "Question_QuestionID" });
            DropColumn("dbo.Questions", "Text");
            DropTable("dbo.GroupQuestions");
        }
    }
}
