﻿using xadrez_console.board;

namespace xadrez_console.xadrez;

public class PositionXadrez(char column, int line) {
    public char Column { get; set; } = column;
    public int  Line   { get; set; } = line;

    public Position ToPosition() {
        return new Position(8 - Line, column - 'a');
    }
    public override string ToString() {
        return "" + Line + Column;
    }
}