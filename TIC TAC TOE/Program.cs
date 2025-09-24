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

            
            
                             
                SpelRitning();


            
            
           
        }
        private static void SpelRitning()
        {
            

            string[] board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            bool player1 = true;

            while (true)
            {
                if (player1)
                    Console.WriteLine("Player 1 tur");
                else
                    Console.WriteLine("Player 2 tur");    
                string välj = Console.ReadLine();
                
                if(board.Contains(välj) 

            }

            Console.WriteLine($"|  {board[0]}  |  {board[1]}  |  {board[2]} |");
            Console.WriteLine("|----------------|");
            Console.WriteLine($"|  {board[3]}  |  {board[4]}  |  {board[5]} |");
            Console.WriteLine("|----------------|");
            Console.WriteLine($"|  {board[6]}  |  {board[7]}  |  {board[8]} |");
            
            
            
            



        }
    }
}
