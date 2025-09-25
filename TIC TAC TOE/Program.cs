using System.ComponentModel.Design;

namespace TIC_TAC_TOE
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("TIC TAC TOE\nTryck på valfri knapp för att starta spelet!");
            Console.ReadLine();
            Console.WriteLine($"Spelare 1 = X och Spelare 2 = O");

            Console.Clear();




            string[] board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            bool player1 = true;





            while (true)
            {


                if (player1)
                {
                    Console.WriteLine("player 1 (X) tur");
                }
                else
                {
                    Console.WriteLine("player 2 (O) tur");
                }

                SpelRitning();


                string välj = Console.ReadLine();


                if (board.Contains(välj) && välj != "X" && välj != "O")
                {
                    int play = Convert.ToInt32(välj) - 1;


                    if (player1)
                    {
                        board[play] = "X";
                    }
                    else
                    {
                        board[play] = "O";
                    }

                }
                else
                {
                    Console.WriteLine("Ogiltigt val, Försök igen!");
                    continue;
                }

                if (player1)
                {
                    player1 = false;
                }
                else
                {
                    player1 = true;
                }

            }

            void SpelRitning()
            {

                Console.WriteLine($"|  {board[0]}  |  {board[1]}  |  {board[2]} |");
                Console.WriteLine("|----------------|");
                Console.WriteLine($"|  {board[3]}  |  {board[4]}  |  {board[5]} |");
                Console.WriteLine("|----------------|");
                Console.WriteLine($"|  {board[6]}  |  {board[7]}  |  {board[8]} |");
            }



        }



    }
}
