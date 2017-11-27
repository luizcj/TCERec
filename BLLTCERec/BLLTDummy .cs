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
        public void ImportarGenerico(string strFileName)
        {
            BLLGuia bLLG = new BLLGuia();
            BLLProcesso bLLP = new BLLProcesso();
            DALTDummy dAL = new DALTDummy();
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(strFileName);

            List<TDummy> lst = new List<TDummy>();
            List<Guia> lstGuia = new List<Guia>();
            List<Processo> lstProcesso = new List<Processo>();

            while ((line = file.ReadLine()) != null)
            {
                TDummy seq = Extrair(line);
                counter++;

                lst.Add(seq);

                if (!lstGuia.Exists(x=>x.NumeroGuia == seq.dois))
                {
                    lstGuia.Add(bLLG.Extrair(line));
                }
                if (bLLP.VerificarProcesso(seq))
                {
                    lstProcesso.Add(bLLP.Extrair(line));
                }

            }

            try
            {
              //  dAL.AdicionarRange(lst);
             //   bLLG.AdicionarRange(lstGuia);
                bLLP.AdicionarRange(lstProcesso);
            }
            catch (Exception ex)
            { throw ex; }

        }


        public void Importar(string strFileName)
        {
            DALTDummy dAL = new DALTDummy();

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

            var query = lst;
            dAL.AdicionarRange(lst);


        }


        public TDummy Extrair(string strLine)
        {
            TDummy sq = new TDummy();

            string[] sCampos = strLine.Split('|');

            string snumero;
            if (strLine.Length == 0) return sq;
            snumero = strLine.Substring(0, 6);

            
            sq.um = sCampos[0];
            sq.dois = sCampos[1];
            sq.tres = sCampos[2];
            sq.quatro = sCampos[3];
            sq.cinco = sCampos[4];
            sq.seis = sCampos[5];
            sq.sete = sCampos[6];
            sq.oito = sCampos[7];
            sq.nove = sCampos[8];
            sq.dez = sCampos[9];
            sq.onze = sCampos[10];
            sq.doze = sCampos[11];
            sq.treze = sCampos[12];
            return sq;
        }




    }
}
