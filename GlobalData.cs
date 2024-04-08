using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formation
{
    public static class GlobalData
    {
        public static List<Formateur> Formateurs { get; } = new List<Formateur>();
        static GlobalData()
        {
            
        }
       
        

    }
}
