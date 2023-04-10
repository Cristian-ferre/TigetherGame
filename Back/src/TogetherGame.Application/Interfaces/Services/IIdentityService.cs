using System;
using System.Collections.Generic;

using TogetherGame.Application.DTOs.Request;
using TogetherGame.Application.DTOs.Response;

namespace TogetherGame.Application.Interfaces.Services
{
    public interface IIdentityService
    {
        Task<UsuarioCadastroResponse> CadastrarUsuario(UsuarioCadastroRequest usuarioCadastro);
        Task<UsuarioLoginResponse> Login(UsuarioLoginRequest usuarioLogin);
    }
}