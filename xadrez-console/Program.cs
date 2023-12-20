using xadrez_console.board;
using xadrez_console.xadrez;

namespace xadrez_console;

internal abstract class Program {
    private static void Main() {
        try {
            Match match = new Match();
            while (!match.finished) {
                Console.Clear();
                Screen.ScreenBoard(match.Board);

                Console.Write("Origen:");
                var origin = Screen.ReadPosition().ToPosition();
                Console.Write("Destiny:");
                var destiny = Screen.ReadPosition().ToPosition();
                match.exec(origin, destiny);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}