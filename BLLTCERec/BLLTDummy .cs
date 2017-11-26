using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALTCE;
namespace BLLTCERec
{
    public class BLLTDummy

    {
        public void Importar(string strFileName)
        {

            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(strFileName);

            List<TDummy> lst = new List<TDummy>();
            while ((line = file.ReadLine()) != null)
            {
                TDummy seq = Extrair(line);
                if (seq.um != "")

                    try
                    {

                      lst.Add(seq);
                          
                        
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                    finally
                    {

                        counter++;
                    }
            }
            DALTDummy dAL = new DALTDummy();
            var query = lst;
            dAL.AdicionarRange(lst);
   
          }


        private TDummy Extrair(string strLine)
        {
            TDummy sq = new TDummy();

            string[] sCampos = strLine.Split('|');

            string  snumero;
            if (strLine.Length == 0) return sq;
            snumero = strLine.Substring(0, 6);

            sq.um = sCampos[1];
            sq.dois = sCampos[2];
            sq.tres = sCampos[3];
            sq.quatro = sCampos[4];
            sq.cinco = sCampos[5];
            sq.seis = sCampos[6];
            sq.sete = sCampos[7];
            sq.oito = sCampos[8];
            sq.nove = sCampos[9];
            sq.dez = sCampos[10];
            sq.onze = sCampos[11];
            sq.doze = sCampos[12];
            //sq.treze = sCampos[13];
            return sq;
        }




    }
}
