using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALTCE;

namespace BLLTCERec
{
    public class BLLGuia_

    {
        public bool VerificarGuia(TDummy seq)
        {

            return (seq.cinco.Length == 0);

        }

        public void Importar(string strFileName)
        {

            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(strFileName);

            List<Guia> lst = new List<Guia>();
            while ((line = file.ReadLine()) != null)
            {
                Guia seq = Extrair(line);
                if (seq.Processo != "")

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
            DALGuia dAL = new DALGuia();
            var query = lst;
            dAL.AdicionarRange(lst);
   
          }

        public void AdicionarRange(List<Guia> seq)
        {
            try
            {
                DALGuia dalG = new DALGuia();
                dalG.AdicionarRange(seq);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public Guia Extrair(string strLine)
        {
            Guia sq = new Guia();

            string[] sCampos = strLine.Split('|');

            string  snumero;
            if (strLine.Length == 0) return sq;
            snumero = strLine.Substring(0, 6);

            sq.OrigemGuia = sCampos[1];
            sq.NumeroGuia = sCampos[2];
            sq.AnoGuia = short.Parse(sCampos[3]);
            sq.Processo = sCampos[4];
            sq.DigProcesso = sCampos[5];
            sq.AnoProcesso = short.Parse(sCampos[6]);
            sq.DestinoGuia = sCampos[7];
            sq.DataGuia = sCampos[8];
            sq.SeqGuia = sCampos[9];
            sq.ProcessoFilho = sCampos[10];
            sq.DigitoProcessoFilho = sCampos[11];
            sq.AnoProcessoFilho = short.Parse(sCampos[12]);
            //sq.treze = sCampos[13];
            return sq;
        }




    }
}
