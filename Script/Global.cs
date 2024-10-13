using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_contact.Script
{
    internal static class Global
    {
        public static List<Groupe> listGroups = new List<Groupe>()
        {
            new Groupe("Amis"),
            new Groupe("Travail"),
            new Groupe("Famille")
        };
    }
}
