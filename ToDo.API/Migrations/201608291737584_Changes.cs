namespace ToDo.API.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoLists", "Name", c => c.String(nullable: false));
            DropColumn("dbo.ToDoLists", "Item");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ToDoLists", "Item", c => c.String(nullable: false));
            DropColumn("dbo.ToDoLists", "Name");
        }
    }
}
