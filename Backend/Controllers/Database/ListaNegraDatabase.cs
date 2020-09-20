using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Controllers.Database
{
    public class ListaNegraDatabase
    {

        Models.lndbContext db = new Models.lndbContext();
        Utils.ListaNegraUtils converter = new Utils.ListaNegraUtils();

        public Models.TbListaNegra salvar(Models.Request.ListaNegraRequest reg){

            Models.TbListaNegra finalizado = converter.converterrequest(reg);

            db.TbListaNegra.Add(finalizado);
            db.SaveChanges();

            return finalizado;
        }                
    }
}