namespace ListaObjetos.Classe
{
    public class produto
    {
        public int Codigo { get; set; }
        
        public string Nome { get; set; }
        
        public float Preco { get; set; }
        
        public produto() {

        }

        public produto(int _Codigo, string  _Nome, float _preco){
            this.Codigo = _Codigo;
            this.Nome = _Nome;
            this.Preco = _preco;
        }
        
    }
}