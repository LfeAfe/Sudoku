using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Classi
{
    public class Cella
    {
        public int? contenuto { get; set; }
        public bool modificabile { get; private set; }

        public Cella(int? contenuto, bool modificabile)
        {
            this.contenuto = contenuto;
            this.modificabile = modificabile;
        }
    }
}
