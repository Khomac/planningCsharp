using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningFor24hProjects
{
    class CustomDictionary<string, string> : Dictionary<string, string>
    {
                CustomDictionary<string, string> openCalendarButtonText = new CustomDictionary<string, string>();

                openCalendarButtonText.Add("PL", "Wczytaj kalendarz");
                openCalendarButtonText.Add("EN", "Load calendar");
        
                string chosenLanguage = "PL"; //tutaj wtawie wartosc z pola wyboru


    }
}
