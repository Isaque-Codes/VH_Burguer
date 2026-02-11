using System.Security.Cryptography;
using System.Text;
using VH_Burguer.Domains;
using VH_Burguer.DTOs;
using VH_Burguer.Exceptions;
using VH_Burguer.Interfaces;

namespace VHBurguer.Applications.Services
{
    public class UsuarioService
    {
        private readonly IUsuarioRepository _repository;

        // injeção de dependências
        public UsuarioService(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        // Private porque não é regra de negócio, somente um método auxiliar para converter a entidade em DTO
        private static LerUsuarioDto LerDto(Usuario usuario) // Gera DTO sem senha do usuário
        {
            LerUsuarioDto lerUsuario = new LerUsuarioDto
            {
                UsuarioID = usuario.UsuarioID,
                Nome = usuario.Nome,
                Email = usuario.Email,
                StatusUsuario = usuario.StatusUsuario ?? true // Garante status ativo ao usuário
            };

            return lerUsuario;
        }

        public List<LerUsuarioDto> Listar()
        {
            List<Usuario> usuarios = _repository.Listar();

            List<LerUsuarioDto> usuariosDto = usuarios
                .Select(usuarioBanco => LerDto(usuarioBanco)) // SELECT que percorre cada Usuario e LerDto(usuario)
                .ToList(); // Devolve uma lista de DTOs

            return usuariosDto;
        }

        private static void ValidarEmail(string email)
        {
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                throw new DomainException("Email inválido.");
            }
        }

        private static byte[] HashSenha(string senha)
        {
            if (string.IsNullOrWhiteSpace(senha))
            {
                throw new DomainException("A senha é obrigatória.");
            }

            using var sha256 = SHA256.Create(); // Gera hash e devolve em byte
            return sha256.ComputeHash(Encoding.UTF8.GetBytes(senha));
        }

        public LerUsuarioDto ObterPorId(int id)
        {
            Usuario usuario = _repository.ObterPorId(id);

            if (usuario == null)
            {
                throw new DomainException("Usuário não existe");
            }

            return LerDto(usuario); // Se existir usuário, converte para DTO e o devolve
        }

        public LerUsuarioDto ObterPorEmail(string email)
        {
            Usuario usuario = _repository.ObterPorEmail(email);

            if (usuario == null)
            {
                throw new DomainException("Usuário não existe");
            }

            return LerDto(usuario); // Se existir usuário, converte para DTO e o devolve
        }
    }
}