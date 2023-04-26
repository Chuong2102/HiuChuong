namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.QuestionEntities", newName: "Questions");
            RenameTable(name: "dbo.QuestionEntityAnswers", newName: "QuestionAnswers");
            RenameColumn(table: "dbo.QuestionAnswers", name: "QuestionEntity_QuestionID", newName: "Question_QuestionID");
            RenameIndex(table: "dbo.QuestionAnswers", name: "IX_QuestionEntity_QuestionID", newName: "IX_Question_QuestionID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.QuestionAnswers", name: "IX_Question_QuestionID", newName: "IX_QuestionEntity_QuestionID");
            RenameColumn(table: "dbo.QuestionAnswers", name: "Question_QuestionID", newName: "QuestionEntity_QuestionID");
            RenameTable(name: "dbo.QuestionAnswers", newName: "QuestionEntityAnswers");
            RenameTable(name: "dbo.Questions", newName: "QuestionEntities");
        }
    }
}
