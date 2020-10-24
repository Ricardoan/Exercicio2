using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http;
using WebRest.Models;

namespace WebRest.Controllers
{
    public class PatrimonioController : ApiController
    {
        private static List<PatrimonioModel> listaPatrimonio = new List<PatrimonioModel>();

        [AcceptVerbs("POST")]
        [Route("CadastrarUsuario")]
        public string CadastrarUsuario(PatrimonioModel usuario)
        {

            listaPatrimonio.Add(usuario);

            return "Usuário cadastrado com sucesso!";
        }

        [AcceptVerbs("PUT")]
        [Route("AlterarUsuario")]
        public string AlterarUsuario(PatrimonioModel usuario)
        {

            listaPatrimonio.Where(n => n.MarcaId == usuario.MarcaId)
                         .Select(s =>
                         {
                             s.Descricao = usuario.Descricao;
                             s.N_Tombo = usuario.N_Tombo;
                             s.Nome = usuario.Nome;

                             return s;

                         }).ToList();



            return "Usuário alterado com sucesso!";
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluirUsuario/{codigo}")]
        public string ExcluirUsuario(int codigo)
        {

           PatrimonioModel usuario = listaPatrimonio.Where(n => n.MarcaId == codigo)
                                                .Select(n => n)
                                                .First();

            listaPatrimonio.Remove(usuario);

            return "Registro excluido com sucesso!";
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarioPorCodigo/{codigo}")]
        public PatrimonioModel ConsultarUsuarioPorCodigo( int codigo)
        {
        PatrimonioModel usuario = listaPatrimonio.Where(n => n.MarcaId == codigo)
                                                .Select(n => n)
                                                .FirstOrDefault();

            return usuario;
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarios")]
        public List<PatrimonioModel> ConsultarUsuarios()
        {
            return listaPatrimonio;
        }
    }
}
