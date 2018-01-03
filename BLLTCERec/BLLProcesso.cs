using DALTCE;
using System;
using System.Collections.Generic;

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

        public static List<Processo> CarregarProcessos(string text)
        {
             DALProcesso dalP = new DALProcesso();
            return dalP.CarregarPRocessos(text);
            
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

            try
            {
                Processo sq = new Processo();
                Int16 zero = 0;
                string[] sCampos = strLine.Split('|');

                string snumero;
                if (strLine.Length == 0) return sq;
                snumero = strLine.Substring(0, 6);

                sq.OrigemGuia = sCampos[0].Trim();
                sq.NumeroGuia = sCampos[1].Trim();
                sq.AnoGuia = Int16.Parse(sCampos[2].Trim());
                sq.NProcesso = sCampos[3].Trim();
                sq.DigProcesso = sCampos[4].Trim();
                sq.AnoProcesso = Int16.Parse(sCampos[5].Trim());
                sq.DestinoGuia = sCampos[6].Trim();
                sq.DataGuia = sCampos[7].Trim();
                sq.SeqGuia = ObterSequencial(sq).ToString();
                sq.ProcessoFilho = sCampos[9].Trim();
                sq.DigitoProcessoFilho = sCampos[10].Trim();

                Int16.TryParse(sCampos[11].Trim(), out zero);
                sq.AnoProcessoFilho = zero;

                //sq.treze = sCampos[13];
                return sq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private int ObterSequencial(Processo seq)
        {
            try
            {

                DALProcesso dALProcesso = new DALProcesso();
               return dALProcesso.ObterSequencial(seq);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ConferirProcesso(Processo p)
        {
            try
            { 

            DALProcesso dALProcesso = new DALProcesso();
            dALProcesso.ConferirProcesso(p);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void AtualizarProcessoCriado(Processo p)
        {
            try
            {

                DALProcesso dALProcesso = new DALProcesso();
                dALProcesso.DigitalizarProcesso(p);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void DigitalizarProcesso(Processo p)
        {
            try
            {

                DALProcesso dALProcesso = new DALProcesso();
                dALProcesso.DigitalizarProcesso(p);
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

    }

}

