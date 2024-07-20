
using BaseDeJogos.Data;
using BaseDeJogos.Model;
using Microsoft.EntityFrameworkCore;

namespace BaseDeJogos.Services

{
    public class JogoService : IJogoService
    {

        private readonly ApplicationDbContext _context;

        public JogoService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<JogoModel> AdicionarJogo(JogoModel jogo)
        {

            try
            {
                _context.Jogo.Add(jogo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível incluir no banco o jogo: {jogo}, Excessão: {ex}");
            }

            var listarJogos = _context.Jogo.ToList();

            return listarJogos;
        }

        public JogoModel AtualizarJogo(JogoModel jogo)
        {

            JogoModel encontrarJogo = _context.Jogo.FirstOrDefault(x => x.Id == jogo.Id);

            if (encontrarJogo == null)
            {
                throw new NullReferenceException("Jogo não encontrado. Por favor, insira um ID válido.");
            }

            try
            {
                _context.Entry(encontrarJogo).State = EntityState.Detached;
                _context.Jogo.Attach(jogo);
                _context.Entry(jogo).State = EntityState.Modified;

                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível remover do banco o jogo Exceção: {ex}");
               
            }

            return jogo;
        }

        public List<JogoModel> DeletarJogo(int id)
        {
            var jogo = _context.Jogo.FirstOrDefault(x => x.Id == id);

            if (jogo == null)
            {
                throw new NullReferenceException("Jogo não encontrado. Por favor, insira um ID válido.");
            }

            try
            {
                _context.Jogo.Remove(jogo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível remover do banco o jogo de ID: {id}, Exceção: {ex}");

            }

            var listarJogos = _context.Jogo.ToList();

            return listarJogos;
        }

        public List<JogoModel> ExibirJogos()
        {
            var listarJogos = _context.Jogo.ToList();

            return listarJogos;
        }

        public JogoModel ProcurarPorId(int id)
        {
            JogoModel listarJogo = _context.Jogo.FirstOrDefault(x => x.Id == id);

            if (listarJogo == null)
            {
                throw new NullReferenceException("Jogo não encontrado. Por favor, insira um ID válido.");
            }
            return listarJogo;

        }
    }

}

    

