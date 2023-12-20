using xadrez_console.board;
using xadrez_console.xadrez;

namespace xadrez_console;

internal abstract class Program {
    private static void Main() {
        try {
            var b = new Board(8, 8);

            b.IntroPart(new King(b, Color.Black), new Position(0, 0));
            b.IntroPart(new Bishop(b, Color.Blue), new Position(1, 98));
            b.IntroPart(new King(b, Color.Yellow), new Position(3, 0));

            Screen.ScreenBoard(b);
        } catch (BoardExceptions e) {
            Console.WriteLine(e);
        }
        Console.ReadLine();
    }
}