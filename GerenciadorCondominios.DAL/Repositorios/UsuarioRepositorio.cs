using GerenciadorCondominios.BLL.Models;
using GerenciadorCondominios.DAL.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Repositorios
{
    public class UsuarioRepositorio : RepositorioGenerico<User>, IUsuarioRepositorio
    {
        private readonly Context _contexto;
        private readonly UserManager<User> _gerenciadorUsuarios;
        private readonly SignInManager<User> _gerenciadorLogin;
        
        public UsuarioRepositorio(Context contexto, UserManager<User> gerenciadorUsuario, SignInManager<User> gerenciadorLogin) : base(contexto)
        {
            _contexto = contexto;
            _gerenciadorUsuarios = gerenciadorUsuario;
            _gerenciadorLogin = gerenciadorLogin;
        }

        public async Task<IdentityResult> CriarUsuario(User usuario, string senha)
        {
            try
            {
                return await _gerenciadorUsuarios.CreateAsync(usuario, senha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task IncluirUsuarioEmFuncao(User usuario, string funcao)
        {
            try
            {
                await _gerenciadorUsuarios.AddToRoleAsync(usuario, funcao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task LogarUsuario(User usuario, bool lembrar)
        {
            try
            {
                await _gerenciadorLogin.SignInAsync(usuario, lembrar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int VerificarSeExisteRegistro()
        {
            try
            {
                return _contexto.Users.Count();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
