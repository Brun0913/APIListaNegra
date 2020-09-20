using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Backend.Models.Response
{
    public class ListaNegraResponse
    {
        public int id{get;set;}
        public string Nome{get;set;}
        public string Motivo{get;set;}
        public DateTime? inclusao{get;set;}
    }
}