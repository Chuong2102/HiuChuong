namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AnswerEntities", newName: "Answers");
            RenameTable(name: "dbo.LevelEntities", newName: "Levels");
            RenameTable(name: "dbo.UserEntities", newName: "Users");
            RenameTable(name: "dbo.AccountEntities", newName: "Accounts");
            RenameTable(name: "dbo.CompositionEntities", newName: "Compositions");
            RenameTable(name: "dbo.ExamEntities", newName: "Exams");
            RenameTable(name: "dbo.QuestionEntityAnswerEntities", newName: "QuestionEntityAnswers");
            RenameColumn(table: "dbo.QuestionEntityAnswers", name: "AnswerEntity_AnswerID", newName: "Answer_AnswerID");
            RenameIndex(table: "dbo.QuestionEntityAnswers", name: "IX_AnswerEntity_AnswerID", newName: "IX_Answer_AnswerID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.QuestionEntityAnswers", name: "IX_Answer_AnswerID", newName: "IX_AnswerEntity_AnswerID");
            RenameColumn(table: "dbo.QuestionEntityAnswers", name: "Answer_AnswerID", newName: "AnswerEntity_AnswerID");
            RenameTable(name: "dbo.QuestionEntityAnswers", newName: "QuestionEntityAnswerEntities");
            RenameTable(name: "dbo.Exams", newName: "ExamEntities");
            RenameTable(name: "dbo.Compositions", newName: "CompositionEntities");
            RenameTable(name: "dbo.Accounts", newName: "AccountEntities");
            RenameTable(name: "dbo.Users", newName: "UserEntities");
            RenameTable(name: "dbo.Levels", newName: "LevelEntities");
            RenameTable(name: "dbo.Answers", newName: "AnswerEntities");
        }
    }
}
