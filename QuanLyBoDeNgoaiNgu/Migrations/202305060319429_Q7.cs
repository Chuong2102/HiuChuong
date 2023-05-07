namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Certificates",
                c => new
                    {
                        CertificateID = c.Int(nullable: false, identity: true),
                        Level_LevelID = c.Int(),
                        Subject_SubjectID = c.Int(),
                        User_UserID = c.Int(),
                    })
                .PrimaryKey(t => t.CertificateID)
                .ForeignKey("dbo.Levels", t => t.Level_LevelID)
                .ForeignKey("dbo.Subjects", t => t.Subject_SubjectID)
                .ForeignKey("dbo.Users", t => t.User_UserID)
                .Index(t => t.Level_LevelID)
                .Index(t => t.Subject_SubjectID)
                .Index(t => t.User_UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Certificates", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.Certificates", "Subject_SubjectID", "dbo.Subjects");
            DropForeignKey("dbo.Certificates", "Level_LevelID", "dbo.Levels");
            DropIndex("dbo.Certificates", new[] { "User_UserID" });
            DropIndex("dbo.Certificates", new[] { "Subject_SubjectID" });
            DropIndex("dbo.Certificates", new[] { "Level_LevelID" });
            DropTable("dbo.Certificates");
        }
    }
}
