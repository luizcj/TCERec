using DALTCE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLTCERec
{
    public class BLLProcesso
    {
        public void Importar(string strFileName)
        {

            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(strFileName);

            List<Processo> lst = new List<Processo>();
            while ((line = file.ReadLine()) != null)
            {
                Processo seq = Extrair(line);
                if (seq.NProcesso != "")

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
            DALProcesso dAL = new DALProcesso();
            var query = lst;
            dAL.AdicionarRange(lst);

        }


        public void AdicionarRange(List<Processo> seq)
        {
            try
            {
                DALProcesso dalP = new DALProcesso();
                dalP.AdicionarRange(seq);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        internal bool VerificarProcesso(TDummy seq)
        {
            return (seq.cinco != "");
        }

        public Processo Extrair(string strLine)
        {
            Processo sq = new Processo();
            Int16 zero = 0;
            string[] sCampos = strLine.Split('|');

            string snumero;
            if (strLine.Length == 0) return sq;
            snumero = strLine.Substring(0, 6);

            sq.OrigemGuia = sCampos[0];
            sq.NumeroGuia = sCampos[1];
            sq.AnoGuia = Int16.Parse(sCampos[2]);
            sq.NProcesso = sCampos[3];
            sq.DigProcesso = sCampos[4];
            sq.AnoProcesso = Int16.Parse(sCampos[5]);
            sq.DestinoGuia = sCampos[6];
            sq.DataGuia = sCampos[7];
            sq.SeqGuia = sCampos[8];
            sq.ProcessoFilho = sCampos[9];
            sq.DigitoProcessoFilho = sCampos[10];

            Int16.TryParse(sCampos[11], out zero);
            sq.AnoProcessoFilho = zero;

            //sq.treze = sCampos[13];
            return sq;
        }




    }

}

