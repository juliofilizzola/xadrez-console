using xadrez_console.board;

namespace xadrez_console.xadrez;

public class Bishop : Parts{
    public Bishop(Board board, Color color) : base(board, color) {}
    public override string ToString() {
        return "B";
    }
}