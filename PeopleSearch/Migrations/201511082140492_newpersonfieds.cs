namespace PeopleSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newpersonfieds : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Phone", c => c.Int(nullable: false));
            AddColumn("dbo.People", "Email", c => c.String());
            AddColumn("dbo.People", "Income", c => c.Int(nullable: false));
            AddColumn("dbo.People", "Employer", c => c.String());
            AlterColumn("dbo.People", "FirstName", c => c.String(maxLength: 35));
            AlterColumn("dbo.People", "LastName", c => c.String(maxLength: 35));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "LastName", c => c.String());
            AlterColumn("dbo.People", "FirstName", c => c.String());
            DropColumn("dbo.People", "Employer");
            DropColumn("dbo.People", "Income");
            DropColumn("dbo.People", "Email");
            DropColumn("dbo.People", "Phone");
        }
    }
}
