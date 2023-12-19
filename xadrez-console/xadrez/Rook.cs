using xadrez_console.board;

namespace xadrez_console.xadrez;

public class Rook: Parts {
    public Rook(Board board, Color color) : base(board, color){}
    public override string ToString() {
        return "R";
    }
}