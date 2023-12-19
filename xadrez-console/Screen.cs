using xadrez_console.board;

namespace xadrez_console;

public class Screen {
    public static void ScreenBoard(Board board) {
        for (var i = 0; i < board.line; i++) {
            for (var j = 0; j < board.column; j++) {
                var part = board.Part(i, j);
                if (part == null) {
                    Console.Write("- ");
                }
                else {
                    Console.Write(part + " ");
                }

            }
            Console.WriteLine();
        }
    }
}