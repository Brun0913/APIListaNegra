using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ListaNegraController
    {

        Business.ListaNegraBusiness verificar = new Business.ListaNegraBusiness();
        Utils.ListaNegraUtils converter = new Utils.ListaNegraUtils();

        [HttpPost]
        public ActionResult<Models.Response.ListaNegraResponse> inserir(Models.Request.ListaNegraRequest reg)
        {
            try{
                Models.TbListaNegra arquivo = verificar.verificacao(reg);
                Models.Response.ListaNegraResponse concluido = converter.convertermodelo(arquivo);
                return concluido;
            }
            catch(System.Exception ex)
            {
                return new BadRequestObjectResult(
                    new Models.Response.ErrorResponse(ex.Message,404)
                );
            }
        }

        [HttpGet]
        public List<Models.Response.ListaNegraResponse> consultar()
        {
            Utils.ListaNegraUtils converter = new Utils.ListaNegraUtils();
            Models.lndbContext db = new Models.lndbContext();
            List<Models.TbListaNegra> ctx = db.TbListaNegra.ToList();

            List<Models.Response.ListaNegraResponse> x = new List<Models.Response.ListaNegraResponse>();

            foreach(Models.TbListaNegra item in ctx ){

                x.Add(converter.convertermodelo(item));
            }

            return x;
        }
    }
}