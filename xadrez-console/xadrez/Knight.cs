using xadrez_console.board;

namespace xadrez_console.xadrez;

public class Knight: Parts {
    public Knight(Board board, Color color) : base(board, color) {}
    public override string ToString() {
        return "KG";
    }
}