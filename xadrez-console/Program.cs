using xadrez_console.board;

namespace xadrez_console;

class Program {
    static void Main(String[] args) {
        Board b = new Board(8, 8);

        Screen.ScreenBoard(b);
        Console.ReadLine();
    }
}