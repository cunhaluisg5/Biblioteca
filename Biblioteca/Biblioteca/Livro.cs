using System;
using System.Collections;

namespace Biblioteca
{
    internal class Livro
    {
        private string nome;
        private string ano;
        private string genero;
        private string autor;
        private int paginas;
        private int quantidade;
        private double valor;

        public Livro(string nome, string ano, string genero, string autor, int paginas, int quantidade, double valor)
        {
            this.nome = nome;
            this.ano = ano;
            this.genero = genero;
            this.autor = autor;
            this.paginas = paginas;
            this.quantidade = quantidade;
            this.valor = valor;
        }

        public static explicit operator Livro(ArrayList v)
        {
            throw new NotImplementedException();
        }

        public string toString() {
            string str = "";
            str += "\nNome: " + nome;
            str += "\nAno: " + ano;
            str += "\nGênero: " + genero;
            str += "\nAutor: " + autor;
            str += "\nPáginas: " + paginas;
            str += "\nQuantidade: " + quantidade;
            str += "\nValor: " + valor;
            return str;
        }

        public bool validaLivro() {
            bool valida = false;
            return !nome.Equals("") &&
                   !ano.Equals("  /  /    ") &&
                   !genero.Equals("") &&
                   !autor.Equals("") &&
                   paginas > 0 &&
                   quantidade > 0 &&
                   valor > 0;
        }

        public void setNome(string nome) {
            this.nome = nome;
        }

        public string getNome() {
            return nome;
        }

        public void setAno(string ano)
        {
            this.ano = ano;
        }

        public string getAno()
        {
            return ano;
        }

        public void setGenero(string genero)
        {
            this.genero = genero;
        }

        public string getGenero()
        {
            return genero;
        }

        public void setAutor(string autor)
        {
            this.autor = autor;
        }

        public string getAutor()
        {
            return autor;
        }

        public void setPaginas(int paginas)
        {
            this.paginas = paginas;
        }

        public int getPaginas()
        {
            return paginas;
        }

        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }

        public int getQuantidade()
        {
            return quantidade;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public double getValor()
        {
            return valor;
        }
    }
}