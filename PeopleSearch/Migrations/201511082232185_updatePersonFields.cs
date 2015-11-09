namespace PeopleSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatePersonFields : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE dbo.People DROP CONSTRAINT DF__People__Phone__21B6055D");
            AddColumn("dbo.People", "Interests", c => c.String());
            AlterColumn("dbo.People", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "Phone", c => c.Int(nullable: false));
            DropColumn("dbo.People", "Interests");
        }
    }
}
