using xadrez_console.board;

namespace xadrez_console.xadrez;

public class Knight(Board board, Color color) : Parts(board, color) {
    public override string ToString() {
        return "C";
    }
}