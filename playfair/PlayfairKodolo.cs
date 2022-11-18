using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace playfair
{
    internal class PlayfairKodolo
    {
        public char[,] KulcsTabla { get; set; } = new char[5, 5];

        public string KodbolBetupar(string betupar)
        {
            if (Index(betupar[0]).S == Index(betupar[1]).S) return 
                    $"{KulcsTabla[Index(betupar[0]).S, Index(betupar[0]).O == 4 ? 0 : Index(betupar[0]).O + 1]}" +
                    $"{KulcsTabla[Index(betupar[1]).S, Index(betupar[1]).O == 4 ? 0 : Index(betupar[1]).O + 1]}";
            else if (Index(betupar[0]).O == Index(betupar[1]).O) return
                    $"{KulcsTabla[Index(betupar[0]).S == 4 ? 0 : Index(betupar[0]).S + 1, Index(betupar[0]).O]}" +
                    $"{KulcsTabla[Index(betupar[1]).S == 4 ? 0 : Index(betupar[1]).S + 1, Index(betupar[1]).O]}";
            else return
                    $"{KulcsTabla[Index(betupar[0]).S, Index(betupar[1]).O]}" +
                    $"{KulcsTabla[Index(betupar[1]).S, Index(betupar[0]).O]}";
        }


        public int SorIndex(char c)
        {
            for (int s = 0; s < KulcsTabla.GetLength(0); s++)
                for (int o = 0; o < KulcsTabla.GetLength(1); o++)
                    if (KulcsTabla[s, o] == c) return s;
            return -1;
        }
        public int OszlopIndex(char c)
        {
            for (int s = 0; s < KulcsTabla.GetLength(0); s++)
                for (int o = 0; o < KulcsTabla.GetLength(1); o++)
                    if (KulcsTabla[s, o] == c) return o;
            return -1;
        }
        public (int S, int O) Index(char c)
        {
            for (int s = 0; s < KulcsTabla.GetLength(0); s++)
                for (int o = 0; o < KulcsTabla.GetLength(1); o++)
                    if (KulcsTabla[s, o] == c) return new(s, o);
            return new(-1, -1);
        }

        public PlayfairKodolo(string fileNev)
        {
            using StreamReader sr = new($"..\\..\\..\\RES\\{fileNev}");
            int sorIndex = 0;
            while (!sr.EndOfStream)
            {
                string fileSor = sr.ReadLine();
                for (int oszlopIndex = 0; oszlopIndex < fileSor.Length; oszlopIndex++)
                {
                    KulcsTabla[sorIndex, oszlopIndex] = fileSor[oszlopIndex];
                }
                sorIndex++;
            }
        }
    }
}
