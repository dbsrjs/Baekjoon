using System;

class Chess {
    static void Main() {
        var chess = new System.Collections.Generic.Dictionary<char, int> {
            {'K', 0}, {'k', 0},
            {'P', 1}, {'p', 1},
            {'N', 3}, {'n', 3},
            {'B', 3}, {'b', 3},
            {'R', 5}, {'r', 5},
            {'Q', 9}, {'q', 9}
        };

        int white = 0, black = 0;

        for (int i = 0; i < 8; i++) {
            string pieces = Console.ReadLine();
            foreach (char p in pieces) {
                if (p == '.') continue;

                if (char.IsUpper(p)) {
                    white += chess[p];
                } else {
                    black += chess[p];
                }
            }
        }

        Console.WriteLine(white - black);
    }
}
