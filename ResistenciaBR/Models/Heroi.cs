using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResistenciaBR.Models
{
    public class Heroi
    {
        public string Nome { get; set; }
        public int Raridade { get; set; }
        public int Nivel { get; set; }
        public string Equipamento { get; set; }
        public string Poder { get; set; }
        public string Progresso { get; set; }
    }
}