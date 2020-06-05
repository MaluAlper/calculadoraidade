using System;

namespace calculadoraidade

//Calcule a sua idade em dias.
{
    class Program
    {
        static void Main(string[] args)
        {  
            
            

            Console.Write("Digite sua data de nascimento:");
            DateTime nascimento=Convert.ToDateTime(Console.ReadLine());
            DateTime agora = DateTime.Now;
            TimeSpan DiasDeVida= agora - nascimento;
            int dias= DiasDeVida.Days;
            Console.WriteLine($"Você tem: " + dias+ " dias de vida");

    }
}
}