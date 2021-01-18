using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HoroscopoWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HoroscopoController : Controller
    {
        [HttpGet]
        public string horoscopoget(int dia, int mes)
        {
            if (dia > 31 || dia < 1)
            {
                return "error";
            }

            if (mes < 1 || mes > 12)
            {
                return "error";
            }
            if ((dia >= 21 && mes == 1) || (dia <= 19 && mes == 2))
            { 
                return "Acuarius: encontraras gozo en un acuarius de pera"; 
            }
            if ((dia >= 20 && mes == 2) || (dia <= 20 && mes == 3))
            { 
               return "Piscis: cuiadau con los amigos suchas"; 
            }
            if ((dia >= 21 && mes == 3) || (dia <= 20 && mes == 4))
            { 
                return "Aries: Encontraras el amor"; 
            }
            if ((dia >= 21 && mes == 4) || (dia <= 20 && mes == 5))
            { 
                return "Tauro: ojo al chaeque con los alacranes"; 
            }
            if ((dia >= 21 && mes == 5) || (dia <= 21 && mes == 6))
            { 
                return "Geminis: feliz jueves"; 
            }
            if ((dia >= 22 && mes == 6) || (dia <= 22 && mes == 7))
            { 
                return "Cancer: tendras exito en tus planes"; 
            }
            if ((dia >= 23 && mes == 7) || (dia <= 23 && mes == 8))
            { 
                return "Leo: encontras gozo en tu trabajo"; 
            }
            if ((dia >= 24 && mes == 8) || (dia <= 22 && mes == 9))
            { 
                return "Virgo: vas a conocer a una persona importante kdiceeee"; 
            }
            if ((dia >= 23 && mes == 9) || (dia <= 22 && mes == 10))
            { 
                return "Libra: nuevas oportunidades se te presentaran, no las tomes..."; 
            }
            if ((dia >= 23 && mes == 10) || (dia <= 22 && mes == 11))
            { 
                return "Escorpion: sos el signo mas poderoso, vamos que se puede"; 
            }
            if ((dia >= 23 && mes == 11) || (dia <= 21 && mes == 12))
            { 
                return "Sagitario: Nunca confies en un Camargo"; 
            }
            if ((dia >= 22 && mes == 12) || (dia <= 20 && mes == 1))
            { 
                return "Capricornio: vas a ser fachero el resto del año"; 
            }
            return "";
        }
        public string horoscopopost(int dia, int mes)
        {
            if (dia > 31 || dia < 1)
            {
                return "error";
            }

            if (mes < 1 || mes > 12)
            {
                return "error";
            }
            if ((dia >= 21 && mes == 1) || (dia <= 19 && mes == 2))
            {
                return "Acuarius: encontraras gozo en un acuarius de pera" ; 
            }
            if ((dia >= 20 && mes == 2) || (dia <= 20 && mes == 3))
            {
                return "Piscis: cuiadau con los amigos suchas";
            }
            if ((dia >= 21 && mes == 3) || (dia <= 20 && mes == 4))
            {
                return "Aries: Encontraras el amor";
            }
            if ((dia >= 21 && mes == 4) || (dia <= 20 && mes == 5))
            {
                return "Tauro: ojo al chaeque con los alacranes";
            }
            if ((dia >= 21 && mes == 5) || (dia <= 21 && mes == 6))
            {
                return "Geminis: feliz jueves";
            }
            if ((dia >= 22 && mes == 6) || (dia <= 22 && mes == 7))
            {
                return "Cancer: tendras exito en tus planes";
            }
            if ((dia >= 23 && mes == 7) || (dia <= 23 && mes == 8))
            {
                return "Leo: encontras gozo en tu trabajo";
            }
            if ((dia >= 24 && mes == 8) || (dia <= 22 && mes == 9))
            {
                return "Virgo: vas a conocer a una persona importante kdiceeee";
            }
            if ((dia >= 23 && mes == 9) || (dia <= 22 && mes == 10))
            {
                return "Libra: nuevas oportunidades se te presentaran, no las tomes...";
            }
            if ((dia >= 23 && mes == 10) || (dia <= 22 && mes == 11))
            {
                return "Escorpion: sos el signo mas poderoso, vamos que se puede";
            }
            if ((dia >= 23 && mes == 11) || (dia <= 21 && mes == 12))
            {
                return "Sagitario: Nunca confies en un Camargo";
            }
            if ((dia >= 22 && mes == 12) || (dia <= 20 && mes == 1))
            {
                return "Capricornio: vas a ser fachero el resto del año";
            }
            return "";
        }
    }
}
