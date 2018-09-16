namespace Eye.Team.AcessoDadosEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CIDADES",
                c => new
                    {
                        CID_ID = c.Int(nullable: false, identity: true),
                        CID_NOME = c.String(nullable: false, maxLength: 100),
                        EST_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CID_ID)
                .ForeignKey("dbo.ESTADOS", t => t.EST_ID, cascadeDelete: true)
                .ForeignKey("dbo.TIMES", t => t.CID_ID)
                .Index(t => t.CID_ID)
                .Index(t => t.EST_ID);
            
            CreateTable(
                "dbo.ESTADOS",
                c => new
                    {
                        EST_ID = c.Int(nullable: false, identity: true),
                        EST_NOME = c.String(nullable: false, maxLength: 100),
                        EST_UF = c.String(nullable: false, maxLength: 2),
                    })
                .PrimaryKey(t => t.EST_ID);
            
            CreateTable(
                "dbo.JOGADORES",
                c => new
                    {
                        JOG_ID = c.Int(nullable: false, identity: true),
                        JOG_NOME = c.String(nullable: false, maxLength: 100),
                        JOG_IDADE = c.Int(nullable: false),
                        IdTime = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JOG_ID);
            
            CreateTable(
                "dbo.TIMES",
                c => new
                    {
                        TIM_ID = c.Int(nullable: false, identity: true),
                        TIM_NOME = c.String(nullable: false, maxLength: 100),
                        CID_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TIM_ID)
                .ForeignKey("dbo.JOGADORES", t => t.TIM_ID)
                .ForeignKey("dbo.JOGOS", t => t.TIM_ID)
                .Index(t => t.TIM_ID);
            
            CreateTable(
                "dbo.JOGOS",
                c => new
                    {
                        JOG_ID = c.Int(nullable: false, identity: true),
                        JOG_DATAJOGO = c.DateTime(nullable: false),
                        JOG_QTDEGOLTIME1 = c.Int(),
                        JOG_QTDEGOLTIME2 = c.Int(),
                        ID_TIME1 = c.Int(nullable: false),
                        ID_TIME2 = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JOG_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TIMES", "TIM_ID", "dbo.JOGOS");
            DropForeignKey("dbo.TIMES", "TIM_ID", "dbo.JOGADORES");
            DropForeignKey("dbo.CIDADES", "CID_ID", "dbo.TIMES");
            DropForeignKey("dbo.CIDADES", "EST_ID", "dbo.ESTADOS");
            DropIndex("dbo.TIMES", new[] { "TIM_ID" });
            DropIndex("dbo.CIDADES", new[] { "EST_ID" });
            DropIndex("dbo.CIDADES", new[] { "CID_ID" });
            DropTable("dbo.JOGOS");
            DropTable("dbo.TIMES");
            DropTable("dbo.JOGADORES");
            DropTable("dbo.ESTADOS");
            DropTable("dbo.CIDADES");
        }
    }
}
