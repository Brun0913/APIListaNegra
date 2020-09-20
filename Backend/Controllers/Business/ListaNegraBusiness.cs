using System;
using System.Collections;
using System.Collections.Generic;

namespace Backend.Controllers.Business
{
    public class ListaNegraBusiness
    {
        Database.ListaNegraDatabase salvar = new Database.ListaNegraDatabase();
        Utils.ListaNegraUtils converter = new Utils.ListaNegraUtils();
        
        public Models.TbListaNegra verificacao(Models.Request.ListaNegraRequest reg){

            if(string.IsNullOrEmpty(reg.Nome))
            throw new Exception("Nome obrigatorio");

            if(string.IsNullOrEmpty(reg.Motivo))
            throw new Exception("Motivo é obrigatorio");

            Models.TbListaNegra finalizado = salvar.salvar(reg);
            return finalizado;
        }
    }
}