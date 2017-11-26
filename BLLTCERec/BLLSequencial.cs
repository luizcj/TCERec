using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALTCE;
namespace BLLTCERec
{
    public class BLLSequencial

    {
        public void ImportarSeq(string strFileName)
        {

            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(strFileName);

            List<SequencialGed> lst = new List<SequencialGed>();
            while ((line = file.ReadLine()) != null)
            {
                SequencialGed seq = ExtrairSeq(line);
                if (seq.Numero != 0)

                    try
                    {

                      lst.Add(seq);
                          
                        
                    }
                    catch (Exception ex)
                    {

                    }

                    finally
                    {

                        counter++;
                    }
            }
            DALSequencial dALSequencial = new DALSequencial();
            var query = lst
    .GroupBy(x => x.Numero | x.Ano | x.DV,  
             (k, g) => g.Aggregate((a, x) => (x.Sequencial > a.Sequencial) ? x : a));

            List<SequencialGed> lst1 = new List<SequencialGed>(query);
             dALSequencial.AdicionarSeq(lst1);
          }


        private SequencialGed ExtrairSeq(string strLine)
        {
            SequencialGed sq = new SequencialGed();

            int numero;
            if (strLine.Length == 0) return sq;
            bool num = int.TryParse(strLine.Substring(0, 6), out numero);
            if (!num) return sq;

            sq.Numero = numero;
            sq.DV = int.Parse(strLine.Substring(12, 1));
            sq.Ano = int.Parse(strLine.Substring(24, 4));
            sq.NomeArquivo = strLine.Substring(36, 50);
            sq.Sequencial = int.Parse(strLine.Substring(86, strLine.Length - 86));

            return sq;
        }




    }
}
