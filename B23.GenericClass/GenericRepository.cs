using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B23.GenericClass
{
    public class GenericRepository<T> where T : class
    {
        public List<T> Getir()
        {
            List<T> liste = new List<T>();

            return liste;
        }


        public List<T> Ekle(T model)
        {
            List<T> listem = new List<T>();
            listem.Add(model);
            return listem;

        }



    }
}




