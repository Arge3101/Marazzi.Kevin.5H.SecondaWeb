using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Marazzi.Kevin._5H.SecondaWeb.Models
{
    public class CreatePost
    {
        public IFormFile MyCsv { get;set;}
        public string Descrizione { get;set;}
    }
}