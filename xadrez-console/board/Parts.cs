namespace xadrez_console.board;

public class Parts(Board board, Color color) {
    public Position position  { get; set; }
    public Color    color     { get; protected set; } = color;
    public int      qMovement { get; protected set; }
    public Board    board     { get; protected set; } = board;

    public void incrementMovement() {
        qMovement++;
    }
}