using xadrez_console.board;

namespace xadrez_console;

public class Screen {
    public static void ScreenBoard(Board board) {
        for (var i = 0; i < board.Line; i++) {
            Console.Write(8 - i + " ");
            for (var j = 0; j < board.Column; j++) {
                var part = board.Part(i, j);
                if (part == null) {
                    Console.Write("- ");
                }
                else {
                    PrintPart(part);
                    Console.Write(" ");
                }

            }
            Console.WriteLine();
        }
        Console.WriteLine("  a b c d e f g h");
    }

    private static void PrintPart(Parts parts) {
        var aux = Console.ForegroundColor;
        Console.ForegroundColor = ReplaceConsoleColor(parts.color);
        Console.Write(parts);
        Console.ForegroundColor = aux;
    }

    private static ConsoleColor ReplaceConsoleColor(Color color) {
        return color switch {
            Color.White  => ConsoleColor.White,
            Color.Black  => ConsoleColor.Black,
            Color.Blue   => ConsoleColor.Blue,
            Color.Red    => ConsoleColor.Red,
            Color.Green  => ConsoleColor.Green,
            Color.Orange => ConsoleColor.DarkRed,
            Color.Yellow => ConsoleColor.Yellow,
            _            => ConsoleColor.White
        };
    }
}