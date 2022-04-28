using tabuleiro;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Chessboard cb = new Chessboard(8, 8);

            Screen.ShowScreen(cb);
        }
    }
}