namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExamQuestions",
                c => new
                    {
                        Exam_EntityID = c.Int(nullable: false),
                        Question_QuestionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Exam_EntityID, t.Question_QuestionID })
                .ForeignKey("dbo.Exams", t => t.Exam_EntityID, cascadeDelete: true)
                .ForeignKey("dbo.Questions", t => t.Question_QuestionID, cascadeDelete: true)
                .Index(t => t.Exam_EntityID)
                .Index(t => t.Question_QuestionID);
            
            AddColumn("dbo.Questions", "Subject_SubjectID", c => c.Int());
            CreateIndex("dbo.Questions", "Subject_SubjectID");
            AddForeignKey("dbo.Questions", "Subject_SubjectID", "dbo.Subjects", "SubjectID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "Subject_SubjectID", "dbo.Subjects");
            DropForeignKey("dbo.ExamQuestions", "Question_QuestionID", "dbo.Questions");
            DropForeignKey("dbo.ExamQuestions", "Exam_EntityID", "dbo.Exams");
            DropIndex("dbo.ExamQuestions", new[] { "Question_QuestionID" });
            DropIndex("dbo.ExamQuestions", new[] { "Exam_EntityID" });
            DropIndex("dbo.Questions", new[] { "Subject_SubjectID" });
            DropColumn("dbo.Questions", "Subject_SubjectID");
            DropTable("dbo.ExamQuestions");
        }
    }
}
