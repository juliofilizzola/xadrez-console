﻿namespace xadrez_console.board;

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


    public Parts RemoveParts(Position p) {
        var aux = Part(p);
        if (aux == null) {
            return null;
        }

        aux.position            = null;
        Parts[p.Line, p.Column] = null;
        return aux;
    }
    public void IntroPart(Parts p, Position position) {
        if (ExistPart(position)) {
            throw new BoardExceptions("part already exists");
        }
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