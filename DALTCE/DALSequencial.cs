using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTCE
{
    public class DALSequencial
    {

        public void AdicionarSeq(List<SequencialGed> seq)
        {
            TCEREDXEntities db = new TCEREDXEntities();
            db.SequencialGeds.AddRange(seq);
            db.SaveChanges();

       
        }

        public List<SequencialGed> Filtrar(List<SequencialGed> seq)
        {

            var result = seq.AsEnumerable()

                   .GroupBy(x => new
                   {
                       Numero = x.Numero,
                       DV = x.DV,
                       Ano = x.Ano,
                       NomeArquivo = x.NomeArquivo,
                       Sequencial = x.Sequencial
                   });
       

        List<SequencialGed> lSeq = result as List<SequencialGed>;

            return lSeq;
        }
}


    }

