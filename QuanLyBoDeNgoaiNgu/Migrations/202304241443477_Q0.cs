namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnswerEntities",
                c => new
                    {
                        AnswerID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AnswerID);
            
            CreateTable(
                "dbo.QuestionEntities",
                c => new
                    {
                        QuestionID = c.Int(nullable: false, identity: true),
                        CorrectAnswerID = c.Int(nullable: false),
                        Level_LevelID = c.Int(),
                    })
                .PrimaryKey(t => t.QuestionID)
                .ForeignKey("dbo.LevelEntities", t => t.Level_LevelID)
                .Index(t => t.Level_LevelID);
            
            CreateTable(
                "dbo.LevelEntities",
                c => new
                    {
                        LevelID = c.Int(nullable: false, identity: true),
                        LevelName = c.Int(nullable: false),
                        LevelMaxScore = c.Int(nullable: false),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.LevelID)
                .ForeignKey("dbo.UserEntities", t => t.User_UserID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.UserEntities",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        StudentID = c.String(),
                        FullName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.AccountEntities",
                c => new
                    {
                        AccountID = c.Int(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AccountID)
                .ForeignKey("dbo.UserEntities", t => t.AccountID)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.CompositionEntities",
                c => new
                    {
                        CompositionID = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        CompositionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CompositionID);
            
            CreateTable(
                "dbo.ExamEntities",
                c => new
                    {
                        EntityID = c.Int(nullable: false, identity: true),
                        Score = c.Int(nullable: false),
                        Composition_CompositionID = c.Int(),
                        Level_LevelID = c.Int(),
                    })
                .PrimaryKey(t => t.EntityID)
                .ForeignKey("dbo.CompositionEntities", t => t.Composition_CompositionID)
                .ForeignKey("dbo.LevelEntities", t => t.Level_LevelID)
                .Index(t => t.Composition_CompositionID)
                .Index(t => t.Level_LevelID);
            
            CreateTable(
                "dbo.QuestionEntityAnswerEntities",
                c => new
                    {
                        QuestionEntity_QuestionID = c.Int(nullable: false),
                        AnswerEntity_AnswerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.QuestionEntity_QuestionID, t.AnswerEntity_AnswerID })
                .ForeignKey("dbo.QuestionEntities", t => t.QuestionEntity_QuestionID, cascadeDelete: true)
                .ForeignKey("dbo.AnswerEntities", t => t.AnswerEntity_AnswerID, cascadeDelete: true)
                .Index(t => t.QuestionEntity_QuestionID)
                .Index(t => t.AnswerEntity_AnswerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExamEntities", "Level_LevelID", "dbo.LevelEntities");
            DropForeignKey("dbo.ExamEntities", "Composition_CompositionID", "dbo.CompositionEntities");
            DropForeignKey("dbo.QuestionEntities", "Level_LevelID", "dbo.LevelEntities");
            DropForeignKey("dbo.LevelEntities", "User_UserID", "dbo.UserEntities");
            DropForeignKey("dbo.AccountEntities", "AccountID", "dbo.UserEntities");
            DropForeignKey("dbo.QuestionEntityAnswerEntities", "AnswerEntity_AnswerID", "dbo.AnswerEntities");
            DropForeignKey("dbo.QuestionEntityAnswerEntities", "QuestionEntity_QuestionID", "dbo.QuestionEntities");
            DropIndex("dbo.QuestionEntityAnswerEntities", new[] { "AnswerEntity_AnswerID" });
            DropIndex("dbo.QuestionEntityAnswerEntities", new[] { "QuestionEntity_QuestionID" });
            DropIndex("dbo.ExamEntities", new[] { "Level_LevelID" });
            DropIndex("dbo.ExamEntities", new[] { "Composition_CompositionID" });
            DropIndex("dbo.AccountEntities", new[] { "AccountID" });
            DropIndex("dbo.LevelEntities", new[] { "User_UserID" });
            DropIndex("dbo.QuestionEntities", new[] { "Level_LevelID" });
            DropTable("dbo.QuestionEntityAnswerEntities");
            DropTable("dbo.ExamEntities");
            DropTable("dbo.CompositionEntities");
            DropTable("dbo.AccountEntities");
            DropTable("dbo.UserEntities");
            DropTable("dbo.LevelEntities");
            DropTable("dbo.QuestionEntities");
            DropTable("dbo.AnswerEntities");
        }
    }
}
