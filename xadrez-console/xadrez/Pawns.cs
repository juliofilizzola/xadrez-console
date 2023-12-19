using xadrez_console.board;

namespace xadrez_console.xadrez;

public class Pawns: Parts {
    public Pawns(Board board, Color color) : base(board, color) {}
    public override string ToString() {
        return "P";
    }
}