namespace xadrez_console.board;

public class Board {
    public  int     line   { get; set; }
    public  int     column { get; set; }
    private Parts[,] parts;

    public Board(int line, int column) {
        this.column = column;
        this.line   = line;
        parts        = new Parts[line, column];
    }

    public Parts part(int line, int column) {
        return parts[line, column];
    }
}