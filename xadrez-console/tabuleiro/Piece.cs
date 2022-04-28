namespace tabuleiro
{
    internal class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int numberMoves { get; protected set; }
        public Chessboard cb { get; protected set; }
    }
}
