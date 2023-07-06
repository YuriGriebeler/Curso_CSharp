using MeuProjetoApi.BancoDados.Contexto;
using MeuProjetoApi.Models;

namespace MeuProjetoApi.BancoDados.Repositorios
{
    public class TimeRepositorio
    {
        public Time Adicionar(Time time)
        {
            using (var bancoDeDados = new MeuProjetoApiContexto())
            {
                bancoDeDados.TabelaTimes.Add(time);
                bancoDeDados.SaveChanges();
            }

            return time;
        }

        public Time Atualizar(Time time)
        {
            using (var bancoDeDados = new MeuProjetoApiContexto())
            {
                bancoDeDados.TabelaTimes.Update(time);
                bancoDeDados.SaveChanges();
            }

            return time;
        }

        public void Excluir(int id)
        {
            using (var bancoDeDados = new MeuProjetoApiContexto())
            {
                var time = bancoDeDados.TabelaTimes
                    .Where(time => time.Id == id)
                    .FirstOrDefault();

                if (time != null)
                {
                    bancoDeDados.Remove(time);
                    bancoDeDados.SaveChanges();
                }
            }
        }

        public Time ObterPorId(int id)
        {
            using (var bancoDeDados = new MeuProjetoApiContexto())
            {
                var time = bancoDeDados.TabelaTimes
                    .Where(time => time.Id == id)
                    .FirstOrDefault();

                return time;
            }
        }

        public List<Time> ObterTodos()
        {
            using (var bancoDeDados = new MeuProjetoApiContexto())
            {
                var listaTimes = bancoDeDados.TabelaTimes.ToList();
                return listaTimes;
            }
        }
    }
}
