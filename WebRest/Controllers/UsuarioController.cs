using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebRest.Models;

namespace WebRest.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        private static List<usuarioModel> listaUsuarios = new List<usuarioModel>();

        [AcceptVerbs("POST")]
        [Route("CadastrarUsuario")]
        public string CadastrarUsuario(usuarioModel usuario)
        {

            listaUsuarios.Add(usuario);

            return "Usuário cadastrado com sucesso!";
        }

        [AcceptVerbs("PUT")]
        [Route("AlterarUsuario")]
        public string AlterarUsuario(usuarioModel usuario)
        {

            listaUsuarios.Where(n => n.Senha == usuario.Senha)
                         .Select(s =>
                         {
                             s.Senha= usuario.Senha;
                             s.Email = usuario.Email;
                             s.Nome = usuario.Nome;

                             return s;

                         }).ToList();



            return "Usuário alterado com sucesso!";
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluirUsuario/{codigo}")]
        public string ExcluirUsuario(int codigo)
        {

            usuarioModel usuario = listaUsuarios.Where(n => n.Senha == codigo)
                                                .Select(n => n)
                                                .First();

            listaUsuarios.Remove(usuario);

            return "Registro excluido com sucesso!";
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarioPorCodigo/{codigo}")]
        public usuarioModel ConsultarUsuarioPorCodigo(int codigo)
        {

            usuarioModel usuario = listaUsuarios.Where(n => n.Senha== codigo)
                                                .Select(n => n)
                                                .FirstOrDefault();

            return usuario;
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarios")]
        public List<usuarioModel> ConsultarUsuarios()
        {
            return listaUsuarios;
        }
    }
}
