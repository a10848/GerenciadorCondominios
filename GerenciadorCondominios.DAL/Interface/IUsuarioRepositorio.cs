using GerenciadorCondominios.BLL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Interface
{
    public interface IUsuarioRepositorio : IRepositorioGenerico<User>
    {
        int VerificarSeExisteRegistro();

        Task LogarUsuario(User usuario, bool lembrar);
        Task<IdentityResult> CriarUsuario(User usuario, string senha);
        Task IncluirUsuarioEmFuncao(User usuario, string funcao);
    }
}
