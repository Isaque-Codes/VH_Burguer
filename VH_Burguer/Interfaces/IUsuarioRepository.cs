using VH_Burguer.Domains;

namespace VH_Burguer.Interfaces
{
    public interface IUsuarioRepository
    {
        List<Usuario> Listar();

        // Interrogação: Aceitar nulo
        Usuario? ObterPorId(int id);

        Usuario? ObterPorEmail(string email);

        bool EmailExiste(string emiail);

        void Adicionar(Usuario usuario);

        void Atualizar(Usuario usuario);

        void Remover(int id);
    }
}
