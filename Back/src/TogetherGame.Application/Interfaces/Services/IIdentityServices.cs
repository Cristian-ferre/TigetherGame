using TogetherGame.Application.DTOs.Request;
using TogetherGame.Application.DTOs.Response;

namespace TogetherGame.Application.Interfaces.Services
{
    public class IdentityServices
    {
        //Crio dois metodos
        Task<UsuarioCadastroResponse> CadastrarUsuario(UsuarioCadastroRequest usuarioCadastro);
        Task<UsuarioLoginResponse> Login(UsuarioLoginRequest usuarioLogin);
    }
}