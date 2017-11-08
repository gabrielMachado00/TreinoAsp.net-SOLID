namespace ProjetoCrm.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjetoCrm1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        nm_cliente = c.String(nullable: false, maxLength: 150, unicode: false),
                        cnpj = c.Int(nullable: false),
                        cpf = c.Int(nullable: false),
                        telefone = c.Int(nullable: false),
                        endereco = c.String(nullable: false, maxLength: 100, unicode: false),
                        estado = c.String(nullable: false, maxLength: 100, unicode: false),
                        cep = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        qtd_venda = c.Int(nullable: false),
                        dt_venda = c.DateTime(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        FuncionarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cliente", t => t.ClienteId)
                .ForeignKey("dbo.Funcionario", t => t.FuncionarioId)
                .Index(t => t.ClienteId)
                .Index(t => t.FuncionarioId);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        FuncionarioId = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        cargo = c.String(nullable: false, maxLength: 100, unicode: false),
                        cpf = c.Int(nullable: false),
                        email = c.String(nullable: false, maxLength: 100, unicode: false),
                        dt_admissao = c.DateTime(nullable: false),
                        dt_demissao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FuncionarioId);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        nome = c.String(nullable: false, maxLength: 150, unicode: false),
                        preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        qtd_estoque = c.Int(nullable: false),
                        EstoqueId = c.Int(nullable: false),
                        venda_Id = c.Int(),
                    })
                .PrimaryKey(t => t.ProdutoId)
                .ForeignKey("dbo.Estoque", t => t.EstoqueId)
                .ForeignKey("dbo.Vendas", t => t.venda_Id)
                .Index(t => t.EstoqueId)
                .Index(t => t.venda_Id);
            
            CreateTable(
                "dbo.Estoque",
                c => new
                    {
                        EstoqueId = c.Int(nullable: false, identity: true),
                        qtd_estoque = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EstoqueId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, unicode: false),
                        Email = c.String(nullable: false, maxLength: 256, unicode: false),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(maxLength: 100, unicode: false),
                        SecurityStamp = c.String(maxLength: 100, unicode: false),
                        PhoneNumber = c.String(maxLength: 100, unicode: false),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProdutoVenda",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false),
                        VendaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProdutoId, t.VendaId })
                .ForeignKey("dbo.Produto", t => t.ProdutoId)
                .ForeignKey("dbo.Vendas", t => t.VendaId)
                .Index(t => t.ProdutoId)
                .Index(t => t.VendaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produto", "venda_Id", "dbo.Vendas");
            DropForeignKey("dbo.ProdutoVenda", "VendaId", "dbo.Vendas");
            DropForeignKey("dbo.ProdutoVenda", "ProdutoId", "dbo.Produto");
            DropForeignKey("dbo.Produto", "EstoqueId", "dbo.Estoque");
            DropForeignKey("dbo.Vendas", "FuncionarioId", "dbo.Funcionario");
            DropForeignKey("dbo.Vendas", "ClienteId", "dbo.Cliente");
            DropIndex("dbo.ProdutoVenda", new[] { "VendaId" });
            DropIndex("dbo.ProdutoVenda", new[] { "ProdutoId" });
            DropIndex("dbo.Produto", new[] { "venda_Id" });
            DropIndex("dbo.Produto", new[] { "EstoqueId" });
            DropIndex("dbo.Vendas", new[] { "FuncionarioId" });
            DropIndex("dbo.Vendas", new[] { "ClienteId" });
            DropTable("dbo.ProdutoVenda");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Estoque");
            DropTable("dbo.Produto");
            DropTable("dbo.Funcionario");
            DropTable("dbo.Vendas");
            DropTable("dbo.Cliente");
        }
    }
}
