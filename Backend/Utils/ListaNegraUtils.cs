using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Utils
{
    public class ListaNegraUtils
    {
        public Models.TbListaNegra converterrequest(Models.Request.ListaNegraRequest modelo)
        {
            Models.TbListaNegra ctx = new Models.TbListaNegra();

            ctx.NmPessoa = modelo.Nome;
            ctx.DsMotivo = modelo.Motivo;

            return ctx;
        }

        public Models.Response.ListaNegraResponse convertermodelo(Models.TbListaNegra modelo)
        {
            Models.Response.ListaNegraResponse ctx = new Models.Response.ListaNegraResponse();
            
            ctx.id = modelo.IdListaNegra;
            ctx.Nome = modelo.NmPessoa;
            ctx.Motivo = modelo.DsMotivo;
            ctx.inclusao = modelo.DtInclusao;

            return ctx;
        }

        public Models.TbListaNegra converterresponse(Models.Response.ListaNegraResponse modelo)
        {
            Models.TbListaNegra ctx = new Models.TbListaNegra();

            ctx.IdListaNegra = modelo.id;
            ctx.NmPessoa = modelo.Nome;
            ctx.DsMotivo = modelo.Motivo;
            ctx.DtInclusao = modelo.inclusao;

            return ctx;
        }
    }
}