using xadrez_console.board;
using xadrez_console.xadrez;

namespace xadrez_console;

internal abstract class Program {
    private static void Main() {
        var po = new PositionXadrez('h', 1);
        Console.WriteLine(po);
        Console.WriteLine(po.ToPosition());


        try {
            var b = new Match();
            b.PlaceParts();
            Screen.ScreenBoard(b.Board);
        } catch (BoardExceptions e) {
            Console.WriteLine(e);
        }
        Console.ReadLine();
    }
}