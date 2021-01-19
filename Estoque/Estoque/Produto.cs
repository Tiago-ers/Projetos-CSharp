using System.Globalization;

namespace Estoque
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        // Método to string com sobreposição
        public override string ToString()
        {
            return "Produto " + Nome + ", Valor unitário $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade 
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
