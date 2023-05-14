namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q14 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ExamQuestions", "Exam_EntityID", "dbo.Exams");
            RenameColumn(table: "dbo.ExamQuestions", name: "Exam_EntityID", newName: "Exam_ExamID");
            RenameIndex(table: "dbo.ExamQuestions", name: "IX_Exam_EntityID", newName: "IX_Exam_ExamID");
            DropPrimaryKey("dbo.Exams");
            DropColumn("dbo.Exams", "EntityID");
            AddColumn("dbo.Exams", "ExamID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Exams", "user_UserID", c => c.Int());
            AddPrimaryKey("dbo.Exams", "ExamID");
            CreateIndex("dbo.Exams", "user_UserID");
            AddForeignKey("dbo.Exams", "user_UserID", "dbo.Users", "UserID");
            AddForeignKey("dbo.ExamQuestions", "Exam_ExamID", "dbo.Exams", "ExamID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exams", "EntityID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.ExamQuestions", "Exam_ExamID", "dbo.Exams");
            DropForeignKey("dbo.Exams", "user_UserID", "dbo.Users");
            DropIndex("dbo.Exams", new[] { "user_UserID" });
            DropPrimaryKey("dbo.Exams");
            DropColumn("dbo.Exams", "user_UserID");
            DropColumn("dbo.Exams", "ExamID");
            AddPrimaryKey("dbo.Exams", "EntityID");
            RenameIndex(table: "dbo.ExamQuestions", name: "IX_Exam_ExamID", newName: "IX_Exam_EntityID");
            RenameColumn(table: "dbo.ExamQuestions", name: "Exam_ExamID", newName: "Exam_EntityID");
            AddForeignKey("dbo.ExamQuestions", "Exam_EntityID", "dbo.Exams", "EntityID", cascadeDelete: true);
        }
    }
}
