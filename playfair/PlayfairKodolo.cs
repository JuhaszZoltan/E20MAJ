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

        public string KodbolBetupar(string bp)
        {
            if (Index(bp[0]).S == Index(bp[1]).S) return 
                    $"{KulcsTabla[Index(bp[0]).S, Index(bp[0]).O == 4 ? 0 : Index(bp[0]).O + 1]}" +
                    $"{KulcsTabla[Index(bp[1]).S, Index(bp[1]).O == 4 ? 0 : Index(bp[1]).O + 1]}";
            else if (Index(bp[0]).O == Index(bp[1]).O) return
                    $"{KulcsTabla[Index(bp[0]).S == 4 ? 0 : Index(bp[0]).S + 1, Index(bp[0]).O]}" +
                    $"{KulcsTabla[Index(bp[1]).S == 4 ? 0 : Index(bp[1]).S + 1, Index(bp[1]).O]}";
            else return
                    $"{KulcsTabla[Index(bp[0]).S, Index(bp[1]).O]}" +
                    $"{KulcsTabla[Index(bp[1]).S, Index(bp[0]).O]}";
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
            int si = 0;
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                for (int oi = 0; oi < sor.Length; oi++)
                    KulcsTabla[si, oi] = sor[oi];
                si++;
            }
        }
    }
}
