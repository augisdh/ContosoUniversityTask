namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Room : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Person", "RoomNumber", c => c.Int(nullable: true));
            AddColumn("dbo.Person", "RoomTv", c => c.Boolean(nullable: false));
            AddColumn("dbo.Person", "RoomRefrigerator", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Person", "RoomNumber");
            DropColumn("dbo.Person", "RoomTv");
            DropColumn("dbo.Person", "RoomRefrigerator");
        }
    }
}
