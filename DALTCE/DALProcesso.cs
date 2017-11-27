using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTCE
{
  public  class DALProcesso
    {
        public void AdicionarRange(List<Processo> seq)
        {
            try
            {
                TCEREDXEntities db = new TCEREDXEntities();
                db.Processoes.AddRange(seq);

                db.SaveChanges();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public List<Processo> Filtrar(List<Processo> seq)
        {
            
//            List<TDummy> lSeq = result as List<TDummy>;
             
            return seq;
        }


    }
}
