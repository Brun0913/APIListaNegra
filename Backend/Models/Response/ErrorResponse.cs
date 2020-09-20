using System;
using System.Collections;

namespace Backend.Models.Response
{
    public class ErrorResponse
    {
        public int cod{get;set;}
        public string erro{get;set;}

        public ErrorResponse(string ex,int cod){

            this.cod = cod;
            this.erro = ex;
        }
    }
}