namespace xadrez_console.board;

public class Board(int line, int column) {
    public           int      Line   { get; set; } = line;
    public           int      Column { get; set; } = column;
    private  Parts[,] Parts = new Parts[line, column];

    public Parts Part(int linePart, int columnPart) {
        return Parts[linePart, columnPart];
    }

    public Parts Part(Position p) {
        return Parts[p.Line, p.Column];
    }

    public bool ExistPart(Position p) {
        PositionException(p);
        return Part(p) != null;
    }

    public void IntroPart(Parts p, Position position) {
        Parts[position.Line, position.Column] = p;
        p.position                            = position;
    }

    public bool ValidPosition(Position p) {
        return p.Line >= 0 && p.Line < Line && p.Column >= 0 && p.Column < Column;
    }

    public void PositionException(Position p) {
        if (!ValidPosition(p)) {
            throw new BoardExceptions("Position invalid");
        }
    }
}