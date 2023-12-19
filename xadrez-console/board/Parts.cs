namespace xadrez_console.board;

public class Parts {
    public Position position  { get; set; }
    public Color    color       { get; protected set; }
    public int      qMovement { get; protected set; }
    public Board    board     { get; protected set; }

    public Parts(Board board, Color color) {
        this.board    = board;
        this.color    = color;
    }
}