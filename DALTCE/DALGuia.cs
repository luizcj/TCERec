using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTCE
{
  public  class DALGuia
    {
        public void AdicionarRange(List<Guia> seq)
        {
            try
            {
                TCEREDXEntities db = new TCEREDXEntities();
                db.Guias.AddRange(seq);

                db.SaveChanges();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public List<Guia> Filtrar(List<Guia> seq)
        {
            
//            List<TDummy> lSeq = result as List<TDummy>;
             
            return seq;
        }


    }
}
