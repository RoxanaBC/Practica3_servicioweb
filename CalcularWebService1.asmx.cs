using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using static CalcularWS.Calcular;

namespace CalcularWS
{
    /// <summary>
    /// Descripción breve de CalcularWebService1  
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class CalcularWebService1 : System.Web.Services.WebService
    {

       
        [WebMethod]
        public double Cuadrado(double lado)
        {
            return lado * lado;
        }

        [WebMethod]
        public double Triangulo(double basee,double altura)
        {
            return (basee * altura) / 2;
        }
        

        [WebMethod]
        public double Circulo(double radio)
        {
            return Math.PI * radio * radio;
        }
    }
}
