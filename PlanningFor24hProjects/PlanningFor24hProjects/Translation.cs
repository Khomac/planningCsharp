using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningFor24hProjects
{
    class Translation
    {
        public static string chosenLanguage = "EN";

        static Dictionary<string, string> shiftTypeDict = new Dictionary<string, string>()
        {
            {"PL", "Rodzaj zmiany"},
            {"EN", "Shifts type"},
            {"FR", "Type du shifte"}
        };

        public static string shiftType()
        {
            return shiftTypeDict[chosenLanguage];
        }

        static Dictionary<string, string> nameAndSurnameDict = new Dictionary<string, string>()
        {
            {"PL", "Imię i Nazwisko"},
            {"EN", "Name and Surname"},
            {"FR", "blablabla"}
        };

        public static string nameAndSurname()
        {
            return nameAndSurnameDict[chosenLanguage];
        }

        static Dictionary<string, string[]> dayOfWeekDict = new Dictionary<string, string[]>()
        {
            {"PL", new string[] {"Nd", "Pn", "Wt", "Śr", "Czw", "Pt", "Sb"}},
            {"EN", new string[] {"Su", "Mo", "Tu", "We", "Th", "Fr", "Sa"}},
            {"FR", new string[] {"Nd", "Pn", "Wt", "Śr", "Czw", "Pt", "Sb"}}
        };

        public static string dayOfWeek(int day)
        {
            return dayOfWeekDict[chosenLanguage][day];
        }
    }
}
