using xadrez_console.board;
using xadrez_console.xadrez;

namespace xadrez_console;

class Program {
    static void Main(String[] args) {
        Board b = new Board(8, 8);

        b.IntroPart(new King(b, Color.black), new Position(0, 0));
        b.IntroPart(new King(b, Color.blue), new Position(2, 0));
        b.IntroPart(new King(b, Color.yellow), new Position(3, 0));

        Screen.ScreenBoard(b);
        Console.ReadLine();
    }
}