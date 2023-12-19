using xadrez_console.board;

namespace xadrez_console.xadrez;

public class Queen : Parts {
    public Queen(Board board, Color color) : base(board, color) {}
    public override string ToString() {
        return "Q";
    }
}