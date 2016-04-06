using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoNamespace
{
    public class Meteo
    {
        public List<int> temperatures { get; set; }
        public List<int> pluges { get; set; }
        public List<int> vent { get; set; }


        public Meteo()
        {
            this.temperatures = new List<int>();
            this.pluges = new List<int>();
            this.vent = new List<int>();
        }

        /// <summary>
        /// Returns max temp 
        /// </summary>
        /// <returns></returns>
        public int MaxTemp()
        {
            int Max = int.MinValue;

            foreach (int T in temperatures)
            {
                if (T > Max)
                {
                    Max = T;
                }
            }
            return Max;
        }

        public bool alerta_incendi (int temp_mitja, int pluja_total, bool vent_fort)
        {
            if (temp_mitja > 25 && pluja_total < 10 && vent_fort == true)
            {
                return true;
            } else
            {
                return false;
            }                    
        }
    }
}
