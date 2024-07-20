using BaseDeJogos.Model;

namespace BaseDeJogos.Services
{
    public interface IJogoService
    {
        JogoModel ProcurarPorId(int id);
        List<JogoModel> ExibirJogos();
        List<JogoModel> AdicionarJogo(JogoModel jogo);
        List<JogoModel> DeletarJogo(int id);
        JogoModel AtualizarJogo(JogoModel jogo);
    }
}
