﻿namespace xadrez_console.board;

public class Board {
    public  int     line   { get; set; }
    public  int     column { get; set; }
    private Part[,] part;

    public Board(int line, int column) {
        this.column = column;
        this.line   = line;
        part        = new Part[line, column];
    }
}