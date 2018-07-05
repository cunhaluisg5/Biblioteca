using System.Collections;
using System.Collections.Generic;

namespace Biblioteca
{
    internal class LivroDao
    {
        private ArrayList lista = null;

        public LivroDao()
        {
            this.lista = new ArrayList();
        }

        public void adicionaLivro(Livro livro) {
            lista.Add(livro);
        }

        public Livro buscaLivro(string nome) {
            Livro li = null;
            for (int i = 0; i < lista.Count; i++) {
                if (lista[i].Equals(nome)) {
                    li = (Livro) lista[i];
                }
            }
            return li;
        }

        public ArrayList todosLivros() {
            return lista;
        }
    }
}