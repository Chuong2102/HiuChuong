namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroupQuestions",
                c => new
                    {
                        GroupQuestionID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.GroupQuestionID);
            
            AddColumn("dbo.Questions", "GroupQuestion_GroupQuestionID", c => c.Int());
            CreateIndex("dbo.Questions", "GroupQuestion_GroupQuestionID");
            AddForeignKey("dbo.Questions", "GroupQuestion_GroupQuestionID", "dbo.GroupQuestions", "GroupQuestionID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Questions", "GroupQuestion_GroupQuestionID", "dbo.GroupQuestions");
            DropIndex("dbo.Questions", new[] { "GroupQuestion_GroupQuestionID" });
            DropColumn("dbo.Questions", "GroupQuestion_GroupQuestionID");
            DropTable("dbo.GroupQuestions");
        }
    }
}
