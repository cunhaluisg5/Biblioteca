namespace Biblioteca
{
    internal class Usuario
    {
        private string nome;
        private string senha;

        public Usuario()
        {
            this.nome = "admin";
            this.senha = "admin";
        }

        public void setNome(string nome) {
            this.nome = nome;
        }

        public string getNome() {
            return nome;
        }

        public void setSenha(string senha) {
            this.senha = senha;
        }

        public string getSenha() {
            return senha;
        }

        public bool verificaNome(string nome) {
            bool verifica = false;
            if (nome.Length == 5) {
                verifica = true;
            }
            return verifica;
        }

        public bool verificaSenha(string senha) {
            bool verifica = false;
            if (senha.Length == 5) {
                verifica = true;
            }
            return verifica;
        }

        public bool verificaLogin(string nome, string senha) {
            bool verifica = false;
            if ((nome.ToLower().Equals("admin")) && (senha.ToLower().Equals("admin"))) {
                verifica = true;
            }
            return verifica;
        }
    }
}