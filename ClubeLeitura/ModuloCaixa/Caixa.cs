
namespace ClubeLeitura.ModuloCaixa
{
    public class Caixa
    {
        private string cor;
        private string etiqueta;
        private int numero;

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        public string Etiqueta
        {
            get { return etiqueta; }
            set { etiqueta = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public Caixa(string cor, string etiqueta, int numero)
        {
            this.cor = cor;
            this.etiqueta = etiqueta;
            this.numero = numero;
        }

    }
}
