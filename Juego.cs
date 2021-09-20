using System;

namespace JuegoBowling
{
    public class Juego
    {
        public static int[,] ArrayPinosTirados = new int[12, 2];
        public static int contador = 0;
        public static int contador2 = 0;

        public static void Tirar(int pinos)
        {

            ArrayPinosTirados[contador, contador2] = pinos;
            if (contador2 == 1)
            {
                contador = contador + 1;
            }
            contador2 = 1 - contador2;
        }
        public static int Score()
        {
            int scoreTotal = 0;
          
            for (int i = 0; i < 10; i++)
            {
                int scoreParcial = ArrayPinosTirados[i, 0] + ArrayPinosTirados[i, 1];               
                if (scoreParcial == 10)
                {
                    scoreParcial = scoreParcial + ArrayPinosTirados[i + 1, 0] + ArrayPinosTirados[i + 1, 1];

                    if (ArrayPinosTirados[i, 0] == 10)
                    {
                        scoreParcial = scoreParcial + ArrayPinosTirados[i + 2, 0] + ArrayPinosTirados[i + 2, 1];
                    }
                }   
                scoreTotal = scoreTotal + scoreParcial;                
            }
            contador = 0;
            contador2 = 0;
            return scoreTotal;            
        }

    }
}
