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

        public List<Processo> CarregarPRocessos(string text)
        {
            TCEREDXEntities db = new TCEREDXEntities();

            var lista = db.Processoes.AsEnumerable();

            List<Processo> result = db.Processoes.AsEnumerable().Where(x => x.NumeroGuia.Contains(text) ).ToList();

       
            return result.ToList();

        }


        public void ConferirProcesso(Processo p)
        {
            
            try
            {
                TCEREDXEntities db = new TCEREDXEntities();
             
                var proResult = (from g in db.Processoes where g.NumeroGuia == p.NumeroGuia && g.NProcesso == p.NProcesso && g.AnoProcesso == p.AnoProcesso select g).ToList().AsEnumerable();

                foreach (Processo g in proResult)
                {
                    g.Processado = true;
                }

                var pro2Result = (from g in db.Processoes where g.NumeroGuia == p.NumeroGuia && g.NProcesso == p.NProcesso && g.AnoProcesso == p.AnoProcesso select g).ToList().Count();

                if (pro2Result == 0)
                {
                    DALGuia guia = new DALGuia();
                    guia.ProcessarGuia(p);

                }

                db.SaveChanges();



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
                TCEREDXEntities db = new TCEREDXEntities();

                var proResult = (from g in db.Processoes where g.NumeroGuia == p.NumeroGuia && g.NProcesso == p.NProcesso && g.AnoProcesso == p.AnoProcesso select g).ToList().AsEnumerable();

                foreach (Processo g in proResult)
                {
                    g.Digitalizado = true;
                    g.PastaDestino = p.PastaDestino;
                }

                var pro2Result = (from g in db.Processoes where g.NumeroGuia == p.NumeroGuia && g.NProcesso == p.NProcesso && g.AnoProcesso == p.AnoProcesso select g).ToList().Count();

                if (pro2Result == 0)
                {
                    DALGuia guia = new DALGuia();
                    guia.DigitalizarGuia(p);

                }

                db.SaveChanges();



            }

            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int ObterSequencial(Processo p)
        {
            TCEREDXEntities db = new TCEREDXEntities();

            int proResult = (from g in db.SequencialGeds where  g.Numero.ToString() == p.NProcesso && g.Ano == p.AnoProcesso select g.Sequencial).Max();


            if (proResult == 0) InserirSequencial(p);
            else
            {
                 AtualizarSequencial(p, proResult);
            }

            proResult = proResult + 1;
            
            return proResult;
            
        }

        private void AtualizarSequencial(Processo p, int Seq)
        {

            TCEREDXEntities db = new TCEREDXEntities();

            var proResult = (from g in db.SequencialGeds where g.Numero.ToString() == p.NProcesso && g.Ano == p.AnoProcesso select g);

            foreach (SequencialGed seq in proResult)
            {
                seq.Sequencial = seq.Sequencial + 1;                
            }

            db.SaveChanges();


        }

        private void InserirSequencial(Processo p)
        {

            DALSequencial sq = new DALSequencial();

            SequencialGed sequencial = new SequencialGed();
            sequencial.Ano = p.AnoProcesso;
            sequencial.DV = Int32.Parse(p.DigProcesso);
            sequencial.Numero = Int32.Parse(p.NProcesso);
            sequencial.Sequencial = 1;

            List<SequencialGed> dSeq = new List<SequencialGed>();
            dSeq.Add(sequencial);
            
            
        }
    }
}
