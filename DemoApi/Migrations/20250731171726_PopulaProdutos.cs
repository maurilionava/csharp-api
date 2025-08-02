using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoApi.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // ===== PRODUTOS (CategoriaId = 1 - Eletrônicos) =====
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Smartphone X100','Tela 6.5\", 128GB, 6GB RAM',1599.90,'imagens/produtos/smartphone-x100.png',25,GETDATE(),1);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Notebook Pro 14','Ryzen 7, 16GB, 512GB SSD',4299.00,'imagens/produtos/notebook-pro-14.png',12,GETDATE(),1);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Fone Bluetooth A7','ANC, 40h bateria',349.50,'imagens/produtos/fone-a7.png',60,GETDATE(),1);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Monitor 27\" QHD','IPS, 75Hz, 99% sRGB',1199.99,'imagens/produtos/monitor-27-qhd.png',18,GETDATE(),1);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Teclado Mecânico K60','Switch red, ABNT2',289.00,'imagens/produtos/teclado-k60.png',45,GETDATE(),1);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Mouse Gamer G5','12.000 DPI, 6 botões',149.90,'imagens/produtos/mouse-g5.png',70,GETDATE(),1);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('SSD NVMe 1TB','Leitura 3500MB/s',429.90,'imagens/produtos/ssd-nvme-1tb.png',34,GETDATE(),1);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Roteador AX3000','Wi-Fi 6, Dual Band',499.00,'imagens/produtos/roteador-ax3000.png',27,GETDATE(),1);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Power Bank 20.000mAh','PD 22.5W, 2 USB + Type-C',179.90,'imagens/produtos/powerbank-20000.png',80,GETDATE(),1);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Webcam FHD C920','1080p, microfone estéreo',239.00,'imagens/produtos/webcam-c920.png',33,GETDATE(),1);");

            // ===== PRODUTOS (CategoriaId = 2 - Livros) =====
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Clean Code','Robert C. Martin, 464p',129.90,'imagens/produtos/livro-clean-code.png',40,GETDATE(),2);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Domain-Driven Design','Eric Evans, 560p',199.00,'imagens/produtos/livro-ddd.png',22,GETDATE(),2);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Design Patterns','GoF, 395p',169.50,'imagens/produtos/livro-design-patterns.png',28,GETDATE(),2);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Refactoring','Martin Fowler, 448p',189.90,'imagens/produtos/livro-refactoring.png',19,GETDATE(),2);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Algoritmos','Sedgewick & Wayne, 992p',159.00,'imagens/produtos/livro-algoritmos.png',24,GETDATE(),2);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('You Don’t Know JS','Kyle Simpson (série)',99.90,'imagens/produtos/livro-ydkjs.png',35,GETDATE(),2);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('C# In Depth','Jon Skeet, 528p',179.00,'imagens/produtos/livro-csharp-in-depth.png',21,GETDATE(),2);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('SQL Antipatterns','Bill Karwin, 328p',124.90,'imagens/produtos/livro-sql-antipatterns.png',26,GETDATE(),2);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('The Pragmatic Programmer','Andrew Hunt, 352p',139.00,'imagens/produtos/livro-pragmatic.png',29,GETDATE(),2);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Cracking the Coding Interview','Gayle McDowell, 706p',149.90,'imagens/produtos/livro-cci.png',31,GETDATE(),2);");

            // ===== PRODUTOS (CategoriaId = 3 - Games) =====
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Controle Sem Fio GX','PC/Console, USB-C',279.00,'imagens/produtos/controle-gx.png',44,GETDATE(),3);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Headset Gamer H3','7.1, over-ear',319.90,'imagens/produtos/headset-h3.png',37,GETDATE(),3);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Cadeira Gamer Raptor','Ajustes 3D, até 150kg',899.00,'imagens/produtos/cadeira-raptor.png',9,GETDATE(),3);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Mousepad XL','90x40cm, base emborrachada',69.90,'imagens/produtos/mousepad-xl.png',72,GETDATE(),3);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Teclado Low Profile','Switch brown, RGB',349.00,'imagens/produtos/teclado-low.png',15,GETDATE(),3);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Volante GT','Force feedback, pedal',1399.00,'imagens/produtos/volante-gt.png',6,GETDATE(),3);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Placa de Vídeo 8GB','GDDR6, 128-bit',1299.90,'imagens/produtos/gpu-8gb.png',11,GETDATE(),3);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Console Portátil P1','Emuladores, 128GB',799.00,'imagens/produtos/console-portatil-p1.png',14,GETDATE(),3);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Suporte Headset','Alumínio, base RGB',89.90,'imagens/produtos/suporte-headset.png',53,GETDATE(),3);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Cabo HDMI 2.1 3m','4K120/8K60, eARC',79.00,'imagens/produtos/hdmi-21-3m.png',66,GETDATE(),3);");

            // ===== PRODUTOS (CategoriaId = 4 - Casa e Cozinha) =====
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Air Fryer 4L','Cesta antiaderente, 1500W',399.00,'imagens/produtos/airfryer-4l.png',20,GETDATE(),4);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Liquidificador Turbo','800W, copo 2L',229.90,'imagens/produtos/liquidificador-turbo.png',32,GETDATE(),4);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Jogo de Panelas 5pçs','Revestimento cerâmico',499.90,'imagens/produtos/panelas-5pcs.png',13,GETDATE(),4);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Cafeteira Express','15 bar, porta-filtro',899.00,'imagens/produtos/cafeteira-express.png',7,GETDATE(),4);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Aspirador Vertical','Sem fio, 40min',649.00,'imagens/produtos/aspirador-vertical.png',16,GETDATE(),4);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Jogo de Copos 12pçs','Vidro temperado',79.90,'imagens/produtos/copos-12pcs.png',58,GETDATE(),4);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Conjunto Facas 6pçs','Aço inox, suporte',129.00,'imagens/produtos/facas-6pcs.png',41,GETDATE(),4);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Tábua de Corte','Bambu, 35x25cm',54.90,'imagens/produtos/tabua-bambu.png',73,GETDATE(),4);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Organizador de Gaveta','Expansível, 7 divisórias',69.90,'imagens/produtos/organizador-gaveta.png',64,GETDATE(),4);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Kit Sobremesa 10pçs','Tigelas + colheres',99.00,'imagens/produtos/kit-sobremesa.png',36,GETDATE(),4);");

            // ===== PRODUTOS (CategoriaId = 5 - Esportes) =====
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Tênis de Corrida R1','Amortecimento, pisada neutra',349.90,'imagens/produtos/tenis-r1.png',28,GETDATE(),5);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Camiseta Dry Fit','Manga curta, unissex',69.90,'imagens/produtos/camiseta-dry.png',90,GETDATE(),5);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Garrafa Térmica 750ml','Aço inox, vácuo',119.00,'imagens/produtos/garrafa-750.png',52,GETDATE(),5);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Bola de Futebol Pro','Tamanho 5, costurada',139.90,'imagens/produtos/bola-futebol.png',34,GETDATE(),5);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Shorts Esportivo','Tecido leve, bolso',79.00,'imagens/produtos/shorts-esportivo.png',63,GETDATE(),5);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Corda de Pular Pro','Rolamento, regulável',59.90,'imagens/produtos/corda-pro.png',85,GETDATE(),5);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Mochila Esportiva 25L','Compartimentos múltiplos',189.00,'imagens/produtos/mochila-25l.png',22,GETDATE(),5);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Kit Halteres 10kg','Par de 5kg, ferro fundido',229.90,'imagens/produtos/halteres-10kg.png',17,GETDATE(),5);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Tapete de Yoga','6mm, antiderrapante',99.90,'imagens/produtos/tapete-yoga.png',48,GETDATE(),5);");
            migrationBuilder.Sql("INSERT INTO PRODUTOS(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) VALUES('Bermuda Ciclismo','Forro em gel, compressão',159.00,'imagens/produtos/bermuda-ciclismo.png',26,GETDATE(),5);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM PRODUTOS;");
        }
    }
}
