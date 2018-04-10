using ResistenciaBR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResistenciaBR.Services
{
    public class HeroiService
    {
        public string BgRaridade(Heroi heroi)
        {
            switch (heroi.Raridade)
            {
                case 7:
                    return "#009900";
                case 6:
                case 5:
                    return "#FFB90F";
                default:
                    return "#FF0000";
            };
        }

        public string BgEquipamento(Heroi heroi)
        {
            switch (heroi.Equipamento)
            {
                case "XII":
                case "XI":
                case "X":
                    return "#009900";
                case "IX":
                case "VIII":
                    return "#FFB90F";
                default:
                    return "#FF0000";
            };
        }

        public string BgNivel(Heroi heroi)
        {
            switch (heroi.Nivel)
            {
                case 85:
                    return "#009900";
                default:
                    return "#FF0000";
            };
        }


        
    }
}