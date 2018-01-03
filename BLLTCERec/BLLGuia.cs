using DALTCE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLTCERec
{
    public class BLLGuia
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

        public static void DevolverGuia(string text)
        {
            try
            {
                DALGuia dalG = new DALGuia();
                dalG.DevolverGuia(text);
            }
            catch (Exception ex)
            {

            }
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
            bool dum;
            string[] sCampos = strLine.Split('|');
            Int16 zero = 0;

            string snumero;
            if (strLine.Length == 0) return sq;
            snumero = strLine.Substring(0, 6);

            sq.OrigemGuia = sCampos[0].Trim();
            sq.NumeroGuia = sCampos[1].Trim();
            sq.AnoGuia = Int16.Parse(sCampos[2].Trim());
            sq.Processo = sCampos[3].Trim();
            sq.DigProcesso = sCampos[4].Trim();
            sq.AnoProcesso = Int16.Parse(sCampos[5].Trim());
            sq.DestinoGuia = sCampos[6].Trim();
            sq.DataGuia = sCampos[7].Trim();
            sq.SeqGuia = sCampos[8].Trim();
            sq.ProcessoFilho = sCampos[9].Trim();
            sq.DigitoProcessoFilho = sCampos[10].Trim();

            Int16.TryParse(sCampos[11].Trim(), out zero);
            sq.AnoProcessoFilho = zero;
            
            //sq.treze = sCampos[13];
            return sq;
        }

        public Guia CarregarGuia(string numGuia)
        {
            try
            {
                DALGuia dalG = new DALGuia();
                return dalG.CarregarGuia(numGuia);
            }
            catch (Exception ex)
            { throw ex; }
        }

    }
}
