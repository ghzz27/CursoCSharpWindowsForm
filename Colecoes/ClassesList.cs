using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CursoCSharpWindowsForm.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            nome = nome;
            Preco = preco;
        }
    }
    public class ClassesList
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Throne", 49.90);
            var carrinho = new List<Produto>();
            carrinho.Add(livro);
            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.90),
                new Produto("8ª Temporada Game of Thrones", 99.90),
                new Produto("Poster", 10.00)
            };
            carrinho.AddRange(combo);

            MessageBox.Show($"Quantidade de produto: {carrinho.Count}",
                "Classe List",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            StringBuilder carrinhoString = new StringBuilder();
            foreach (var produto in carrinho)
            {
                carrinhoString.AppendLine($"- {produto.Nome} : " +
                    $"R$ {produto.Preco:F2}");
            }
            MessageBox.Show($"Produto do Carrinho:\n {carrinhoString}",
              "Coleções - Lista",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);
        }
    }
}
