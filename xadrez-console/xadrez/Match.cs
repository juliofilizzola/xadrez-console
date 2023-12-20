using xadrez_console.board;

namespace xadrez_console.xadrez;

public class Match {
    public  Board Board { get; private set; } = new(8, 8);
    private int   _t             = 1;
    private Color _playerCurrent = Color.White;

    public void execut(Position origin, Position destiny) {
        var p = Board.RemoveParts(origin);
        p.incrementMovement();
        var PC = Board.RemoveParts(destiny);
        Board.IntroPart(p, destiny);
    }

    public void PlaceParts() {
        Board.IntroPart(new Pawns(Board, _playerCurrent), new PositionXadrez('a', 2).ToPosition());
        Board.IntroPart(new Pawns(Board, _playerCurrent), new PositionXadrez('b', 2).ToPosition());
        Board.IntroPart(new Pawns(Board, _playerCurrent), new PositionXadrez('c', 2).ToPosition());
        Board.IntroPart(new Pawns(Board, _playerCurrent), new PositionXadrez('d', 2).ToPosition());
        Board.IntroPart(new Pawns(Board, _playerCurrent), new PositionXadrez('e', 2).ToPosition());
        Board.IntroPart(new Pawns(Board, _playerCurrent), new PositionXadrez('f', 2).ToPosition());
        Board.IntroPart(new Pawns(Board, _playerCurrent), new PositionXadrez('g', 2).ToPosition());
        Board.IntroPart(new Pawns(Board, _playerCurrent), new PositionXadrez('h', 2).ToPosition());

        Board.IntroPart(new Rook(Board, _playerCurrent), new PositionXadrez('a', 1).ToPosition());
        Board.IntroPart(new Rook(Board, _playerCurrent), new PositionXadrez('h', 1).ToPosition());

        Board.IntroPart(new Knight(Board, _playerCurrent), new PositionXadrez('b', 1).ToPosition());
        Board.IntroPart(new Knight(Board, _playerCurrent), new PositionXadrez('g', 1).ToPosition());

        Board.IntroPart(new Bishop(Board, _playerCurrent), new PositionXadrez('c', 1).ToPosition());
        Board.IntroPart(new Bishop(Board, _playerCurrent), new PositionXadrez('f', 1).ToPosition());

        Board.IntroPart(new Queen(Board, _playerCurrent), new PositionXadrez('e', 1).ToPosition());
        Board.IntroPart(new King(Board, _playerCurrent), new PositionXadrez('d', 1).ToPosition());


        Board.IntroPart(new Pawns(Board, Color.Black), new PositionXadrez('a', 7).ToPosition());
        Board.IntroPart(new Pawns(Board, Color.Black), new PositionXadrez('b', 7).ToPosition());
        Board.IntroPart(new Pawns(Board, Color.Black), new PositionXadrez('c', 7).ToPosition());
        Board.IntroPart(new Pawns(Board, Color.Black), new PositionXadrez('d', 7).ToPosition());
        Board.IntroPart(new Pawns(Board, Color.Black), new PositionXadrez('e', 7).ToPosition());
        Board.IntroPart(new Pawns(Board, Color.Black), new PositionXadrez('f', 7).ToPosition());
        Board.IntroPart(new Pawns(Board, Color.Black), new PositionXadrez('g', 7).ToPosition());
        Board.IntroPart(new Pawns(Board, Color.Black), new PositionXadrez('h', 7).ToPosition());

        Board.IntroPart(new Rook(Board, Color.Black), new PositionXadrez('a', 8).ToPosition());
        Board.IntroPart(new Rook(Board, Color.Black), new PositionXadrez('h', 8).ToPosition());

        Board.IntroPart(new Knight(Board, Color.Black), new PositionXadrez('b', 8).ToPosition());
        Board.IntroPart(new Knight(Board, Color.Black), new PositionXadrez('g', 8).ToPosition());

        Board.IntroPart(new Bishop(Board, Color.Black), new PositionXadrez('c', 8).ToPosition());
        Board.IntroPart(new Bishop(Board, Color.Black), new PositionXadrez('f', 8).ToPosition());

        Board.IntroPart(new Queen(Board, Color.Black), new PositionXadrez('e', 8).ToPosition());
        Board.IntroPart(new King(Board, Color.Black), new PositionXadrez('d', 8).ToPosition());

    }
}