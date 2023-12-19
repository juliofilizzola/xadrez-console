using xadrez_console.board;

namespace xadrez_console.xadrez;

public class King : Parts {
    public King(Board board, Color color) : base(board, color) {}
    public override string ToString() {
        return "K";
    }
}