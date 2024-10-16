namespace ClubeDoLivro.Domain
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public Livro livro { get; set; }
        public Usuario DonoUsuario { get; set; }
        public Usuario SolicitanteUsuario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataPrevistaDevolucao { get; set; }
        public DateTime DataDevolucao { get; set; }
    }
}
