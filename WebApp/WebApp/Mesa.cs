using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp
{
    public class Mesa
    {
        public string Modelo { get; set; }

        public string Color { get; set; }
    }

    public class Inicial
    {
        public void main()
        {
            var mesa1 = new Mesa
            {
                Color = "Marron",
                Modelo = "Redonda"
            };

            var mesa2 = new Mesa
            {
                Modelo = "Cuadrada",
                Color = "Amarilla"
            };
        }
        
        
    }
}
