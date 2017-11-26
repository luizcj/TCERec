using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTCE
{
  public  class DALTDummy
    {
        public void AdicionarRange(List<TDummy> seq)
        {
            try
            {
                TCEREDXEntities db = new TCEREDXEntities();
                db.TDummies.AddRange(seq);

                db.SaveChanges();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public List<TDummy> Filtrar(List<TDummy> seq)
        {
            
//            List<TDummy> lSeq = result as List<TDummy>;
             
            return seq;
        }


    }
}
