using xadrez_console.board;
using xadrez_console.xadrez;

namespace xadrez_console;

internal abstract class Program {
    private static void Main() {
        var b = new Board(8, 8);

        b.IntroPart(new King(b, Color.Black), new Position(0, 0));
        b.IntroPart(new King(b, Color.Blue), new Position(2, 0));
        b.IntroPart(new King(b, Color.Yellow), new Position(3, 0));

        Screen.ScreenBoard(b);
        Console.ReadLine();
    }
}