using tabuleiro;
namespace xadrez_console
{
    internal class Screen
    {
        public static void ShowScreen(Chessboard cb)
        {
            for (int i = 0; i < cb.lines; i++)
            {
                for (int j = 0; j < cb.columns; j++)
                {
                    if (cb.piece(i, j) != null)
                    {
                        Console.Write($"{cb.piece(i, j)} ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
