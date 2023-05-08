namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GroupQuestions", "Question_QuestionID", "dbo.Questions");
            DropIndex("dbo.GroupQuestions", new[] { "Question_QuestionID" });
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleID = c.Int(nullable: false),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.RoleID)
                .ForeignKey("dbo.Accounts", t => t.RoleID)
                .Index(t => t.RoleID);
            
            CreateTable(
                "dbo.GroupAnswers",
                c => new
                    {
                        GroupAnswerID = c.Int(nullable: false, identity: true),
                        GroupAnswerName = c.String(),
                    })
                .PrimaryKey(t => t.GroupAnswerID);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        SubjectID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.SubjectID);
            
            CreateTable(
                "dbo.GroupAnswerAnswers",
                c => new
                    {
                        GroupAnswer_GroupAnswerID = c.Int(nullable: false),
                        Answer_AnswerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.GroupAnswer_GroupAnswerID, t.Answer_AnswerID })
                .ForeignKey("dbo.GroupAnswers", t => t.GroupAnswer_GroupAnswerID, cascadeDelete: true)
                .ForeignKey("dbo.Answers", t => t.Answer_AnswerID, cascadeDelete: true)
                .Index(t => t.GroupAnswer_GroupAnswerID)
                .Index(t => t.Answer_AnswerID);
            
            AddColumn("dbo.Levels", "Subject_SubjectID", c => c.Int());
            AddColumn("dbo.Exams", "Subject_SubjectID", c => c.Int());
            CreateIndex("dbo.Levels", "Subject_SubjectID");
            CreateIndex("dbo.Exams", "Subject_SubjectID");
            AddForeignKey("dbo.Levels", "Subject_SubjectID", "dbo.Subjects", "SubjectID");
            AddForeignKey("dbo.Exams", "Subject_SubjectID", "dbo.Subjects", "SubjectID");
            DropTable("dbo.GroupQuestions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GroupQuestions",
                c => new
                    {
                        GroupQuestionID = c.Int(nullable: false, identity: true),
                        GroupQuestionName = c.String(),
                        Question_QuestionID = c.Int(),
                    })
                .PrimaryKey(t => t.GroupQuestionID);
            
            AddColumn("dbo.Levels", "User_UserID", c => c.Int());
            DropForeignKey("dbo.Exams", "Subject_SubjectID", "dbo.Subjects");
            DropForeignKey("dbo.Levels", "Subject_SubjectID", "dbo.Subjects");
            DropForeignKey("dbo.GroupAnswerAnswers", "Answer_AnswerID", "dbo.Answers");
            DropForeignKey("dbo.GroupAnswerAnswers", "GroupAnswer_GroupAnswerID", "dbo.GroupAnswers");
            DropForeignKey("dbo.Roles", "RoleID", "dbo.Accounts");
            DropIndex("dbo.GroupAnswerAnswers", new[] { "Answer_AnswerID" });
            DropIndex("dbo.GroupAnswerAnswers", new[] { "GroupAnswer_GroupAnswerID" });
            DropIndex("dbo.Exams", new[] { "Subject_SubjectID" });
            DropIndex("dbo.Levels", new[] { "Subject_SubjectID" });
            DropIndex("dbo.Roles", new[] { "RoleID" });
            DropColumn("dbo.Exams", "Subject_SubjectID");
            DropColumn("dbo.Levels", "Subject_SubjectID");
            DropTable("dbo.GroupAnswerAnswers");
            DropTable("dbo.Subjects");
            DropTable("dbo.GroupAnswers");
            DropTable("dbo.Roles");
            CreateIndex("dbo.GroupQuestions", "Question_QuestionID");
            CreateIndex("dbo.Levels", "User_UserID");
            AddForeignKey("dbo.GroupQuestions", "Question_QuestionID", "dbo.Questions", "QuestionID");
            AddForeignKey("dbo.Levels", "User_UserID", "dbo.Users", "UserID");
        }
    }
}
