namespace QuanLyBoDeNgoaiNgu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Q9 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Roles", new[] { "RoleID" });
            //RenameColumn(table: "dbo.Accounts", name: "RoleID", newName: "Role_RoleID");
            DropPrimaryKey("dbo.Roles");
            AlterColumn("dbo.Roles", "RoleID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Roles", "RoleID");
            CreateIndex("dbo.Accounts", "Role_RoleID");
            AddForeignKey("dbo.Accounts", "Role_RoleID", "dbo.Roles", "RoleID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "Role_RoleID", "dbo.Roles");
            DropIndex("dbo.Accounts", new[] { "Role_RoleID" });
            DropPrimaryKey("dbo.Roles");
            AlterColumn("dbo.Roles", "RoleID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Roles", "RoleID");
            //RenameColumn(table: "dbo.Accounts", name: "Role_RoleID", newName: "RoleID");
            CreateIndex("dbo.Roles", "RoleID");
        }
    }
}
