using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALTCE
{
  public  class DALGuia
    {
        public void AdicionarRange(List<Guia> seq)
        {
            try
            {
                TCEREDXEntities db = new TCEREDXEntities();
                db.Guias.AddRange(seq);
                db.SaveChanges();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public List<Guia> Filtrar(List<Guia> seq)
        {
            
//            List<TDummy> lSeq = result as List<TDummy>;
            return seq;
        }

        public void DevolverGuia(string text)
        {

            try
            {
                TCEREDXEntities db = new TCEREDXEntities();
                List<Guia> guiaResult = (from g in db.Guias where g.NumeroGuia == text select g).ToList();
                foreach (Guia g in guiaResult)
                {
                    g.Devolvido = true;
                }

                List<Processo> proResult = (from g in db.Processoes where g.NumeroGuia == text select g).ToList();

                foreach (Processo g in proResult)
                {
                    g.Devolvido = true;
                }

                db.SaveChanges();
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Guia CarregarGuia(String numGuia)
        {try
            { 

            TCEREDXEntities db = new TCEREDXEntities();
           Guia guiaResult = (from g in db.Guias where g.NumeroGuia == numGuia select g).Single();

            return guiaResult;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal void ProcessarGuia(Processo p)
        {

                try
                {
                    TCEREDXEntities db = new TCEREDXEntities();
                    List<Guia> guiaResult = (from g in db.Guias where g.NumeroGuia == p.NumeroGuia && p.AnoGuia == g.AnoGuia select g).ToList();
                    foreach (Guia g in guiaResult)
                    {
                        g.Processado = true;
                    }
                   
                    db.SaveChanges();
                }

                catch (Exception ex)
                {
                    throw ex;
                }

        }

        internal void DigitalizarGuia(Processo p)
        {

            try
            {
                TCEREDXEntities db = new TCEREDXEntities();
                List<Guia> guiaResult = (from g in db.Guias where g.NumeroGuia == p.NumeroGuia && p.AnoGuia == g.AnoGuia select g).ToList();
                foreach (Guia g in guiaResult)
                {
                    g.Digitalizado = true;
                }

                db.SaveChanges();
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
