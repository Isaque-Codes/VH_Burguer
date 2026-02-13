using System.Security.Cryptography;
using System.Text;
using VH_Burguer.Domains;
using VH_Burguer.DTOs.UsuarioDTO;
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
                throw new DomainException("E-mail inválido.");
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

        public LerUsuarioDto Adicionar(CriarUsuarioDto usuarioDTO)
        {
            ValidarEmail(usuarioDTO.Email);

            if (_repository.EmailExiste(usuarioDTO.Email))
            {
                throw new DomainException("Este e-mail já cadastrado.");
            }

            Usuario usuario = new Usuario
            {
                Nome = usuarioDTO.Nome,
                Email = usuarioDTO.Email,
                Senha = HashSenha(usuarioDTO.Senha),
                StatusUsuario = true // Define o status do usuário como ativo por padrão
            };

            _repository.Adicionar(usuario);

            return LerDto(usuario);
        }

        public LerUsuarioDto Atualizar(int id, CriarUsuarioDto usuarioDto)
        {
            ValidarEmail(usuarioDto.Email);

            Usuario usuarioBanco = _repository.ObterPorId(id);

            if (usuarioBanco == null)
            {
                throw new DomainException("Usuário não existe");
            }

            ValidarEmail(usuarioDto.Email);

            Usuario usuarioComMesmoEmail = _repository.ObterPorEmail(usuarioDto.Email);

            if (usuarioComMesmoEmail != null && usuarioComMesmoEmail.UsuarioID != id)
            {
                throw new DomainException("Já existe um usuário com este e-mail.");
            }

            // Substitui as informações do banco (usuarioBanco) pelas de usuarioDto
            usuarioBanco.Nome = usuarioDto.Nome;
            usuarioBanco.Email = usuarioDto.Email;
            usuarioBanco.Senha = HashSenha(usuarioDto.Senha);

            _repository.Atualizar(usuarioBanco);

            return LerDto(usuarioBanco);
        }

        public void Remover(int id)
        {
            Usuario usuario = _repository.ObterPorId(id);

            if (usuario == null)
            {
                throw new DomainException("Usuário não existe");
            }

            _repository.Remover(id);
        }
    }
}