namespace MVCBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedDateTimeToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Blogs", "Timestamp", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Blogs", "Timestamp", c => c.DateTime(nullable: false));
        }
    }
}
