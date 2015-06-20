using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanningFor24hProjects
{
    class Translation //klasa w ktorej wpisane sa wszystkie teksty znajdujace sie na elementach aplikacji - odpalajac metode z tej klasy odpowiadajaca odpowiedniemu elementowi
        //(co dzieje sie automatycznie przy ladowaniu nowe4go okna albo zmianie jezyka) dostajemy string w odpowiednim jezyku - a w docelowym obie3kcie 
        //zmieniamy wartosc argumentu Tekst danego elementu
    {
        public static string chosenLanguage = "EN";

/* model wpisu kalendarza
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string>  = new Dictionary<string, string>()
            {
                {"PL", ""},
                {"EN", ""},
                {"FR", ""}
            };

            public static string ()
            {
                return [chosenLanguage];
            }

            */

//Slownik dla BaseWindow
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string> openCalendarButtonText = new Dictionary<string, string>()
            {
                {"PL", "Wczytaj kalendarz"},
                {"EN", "Load calendar"},
                {"FR", "Ouvrir le calendrier"}
            };

            public static string openCalendarButton()
            {
                return openCalendarButtonText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string>  dateChoiceButtonText= new Dictionary<string, string>()
            {
                {"PL", "Wybierz datę"},
                {"EN", "Chose date"},
                {"FR", "Choisi la date"}
            };

            public static string dateChoiceButton()
            {
                return dateChoiceButtonText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string> languageLabelText = new Dictionary<string, string>()
            {
                {"PL", "Język"},
                {"EN", "Language"},
                {"FR", "Longue"}
            };

            public static string languageLabel()
            {
                return languageLabelText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string> calendarModeLabelText = new Dictionary<string, string>()
            {
                {"PL", "Zakres kalendarza"},
                {"EN", "Calendar type"},
                {"FR", "Mode du calendrier"}
            };

            public static string calendarModeLabel()
            {
                return calendarModeLabelText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string> workModeLabelText = new Dictionary<string, string>()
            {
                {"PL", "Tryb pracy"},
                {"EN", "Work mode"},
                {"FR", "Mode du travail"}
            };

            public static string workModeLabel()
            {
                return workModeLabelText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string>  chosenDateLabelText = new Dictionary<string, string>()
            {
                {"PL", "Aktualnie wybrana data: \n\t"+BaseForm.chosenDateText},
                {"EN", "Actually chosen date: \n\t"+BaseForm.chosenDateText},
                {"FR", "La date choisi: \n\t"+BaseForm.chosenDateText}
            };

            public static string chosenDateLabel()
            {
                return chosenDateLabelText[chosenLanguage];
            }


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string> modifyEmplListButtonText = new Dictionary<string, string>()
            {
                {"PL", "Zmodyfikuj listę pracowników"},
                {"EN", "Modify employee list"},
                {"FR", "Modifie la liste des employees"}
            };

            public static string modifyEmplListButton()
            {
                return modifyEmplListButtonText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string> baseWindowText = new Dictionary<string, string>()
            {
                {"PL", "Ustawienia"},
                {"EN", "Settings"},
                {"FR", "Parametres"}
            };

            public static string baseWindow()
            {
                return baseWindowText[chosenLanguage];
            }
            

//Slownik dla CalendarWindow
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static Dictionary<string, string> shiftTypeText = new Dictionary<string, string>()
        {
            {"PL", "Rodzaj zmiany"},
            {"EN", "Shifts type"},
            {"FR", "Type du shifte"}
        };

        public static string shiftType()
        {
            return shiftTypeText[chosenLanguage];
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static Dictionary<string, string> nameAndSurnameText = new Dictionary<string, string>()
        {
            {"PL", "Imię i Nazwisko"},
            {"EN", "Name and Surname"},
            {"FR", "Prenom et Nom"}
        };

        public static string nameAndSurname()
        {
            return nameAndSurnameText[chosenLanguage];
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static Dictionary<string, string[]> dayOfWeekText = new Dictionary<string, string[]>()
        {
            {"PL", new string[] {"Nd", "Pn", "Wt", "Śr", "Czw", "Pt", "Sb"}},
            {"EN", new string[] {"Su", "Mo", "Tu", "We", "Th", "Fr", "Sa"}},
            {"FR", new string[] {"Dim", "Lun", "Mar", "Mer", "Jeu", "Ven", "Sam"}}
        };

        public static string dayOfWeek(int day)
        {
            return dayOfWeekText[chosenLanguage][day];
        }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        static Dictionary<string, string> nightRadioButtonText = new Dictionary<string, string>()
            {
                {"PL", "Noc"},
                {"EN", "Night"},
                {"FR", "Nuit"}
            };

            public static string nightRadioButton()
            {
                return nightRadioButtonText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
         static Dictionary<string, string> dayRadioButtonText = new Dictionary<string, string>()
            {
                {"PL", "Dzień"},
                {"EN", "Day"},
                {"FR", "Jour"}
            };

            public static string dayRadioButton()
            {
                return dayRadioButtonText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
             static Dictionary<string, string> holidayRadioButtonText = new Dictionary<string, string>()
            {
                {"PL", "Urlop"},
                {"EN", "Holiday"},
                {"FR", "Congee"}
            };

            public static string holidayRadioButton()
            {
                return holidayRadioButtonText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
             static Dictionary<string, string> sicknessRadioButtonText = new Dictionary<string, string>()
            {
                {"PL", "L4"},
                {"EN", "Sick leave"},
                {"FR", "Arret maladie"}
            };

            public static string sicknessRadioButton()
            {
                return sicknessRadioButtonText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
             static Dictionary<string, string> emptyRadioButtonText = new Dictionary<string, string>()
            {
                {"PL", "Pusto"},
                {"EN", "Empty"},
                {"FR", "Vide"}
            };

            public static string emptyRadioButton()
            {
                return emptyRadioButtonText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
             static Dictionary<string, string> createCalendarButtonText = new Dictionary<string, string>()
            {
                {"PL", "Wypełnij kalendarz automatycznie"},
                {"EN", "Fill the calendar automatically"},
                {"FR", "Rempli le calendrier automatiquement"}
            };

            public static string createCalendarButton()
            {
                return createCalendarButtonText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string> clearAllCalendarButtonText = new Dictionary<string, string>()
            {
                {"PL", "Wyczyść wszystkie pola"},
                {"EN", "Clear all fields"},
                {"FR", "Vide tous les champs"}
            };

            public static string clearAllCalendarButton()
            {
                return clearAllCalendarButtonText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string> clearAutomaticCalendarButtonText = new Dictionary<string, string>()
            {
                {"PL", "Wyczyść pola wypełnione automatycznie"},
                {"EN", "Clear automatically filled fields"},
                {"FR", "Vide les champs remplis automatiquement"}
            };

            public static string clearAutomaticCalendarButton()
            {
                return clearAutomaticCalendarButtonText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string> hoursNumberLabelText = new Dictionary<string, string>()
            {
                {"PL", "Długość zmiany"},
                {"EN", "Shift lenght"},
                {"FR", "Longueur du shift"}
            };

            public static string hoursNumberLabel()
            {
                return hoursNumberLabelText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string> calendarWindowText = new Dictionary<string, string>()
            {
                {"PL", "Okno kalendarza"},
                {"EN", "Calendar Window"},
                {"FR", "Fenetre du calendrier"}
            };

            public static string calendarWindow()
            {
                return calendarWindowText[chosenLanguage];
            }

//slownik dla monthChoiceWindow
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string[]> monthNameTable = new Dictionary<string, string[]>()
            {
                {"PL", new string[] {"Styczeń", "Luty", "Marzec", "Kwiecień", "Maj", "Czerwiec", "Lipiec", "Sierpień", "Wrzesień", "Październik", "Listopad", "Grudzień"}},
                {"EN", new string[] {"January", "February", "Mars", "April", "May", "June", "July", "August", "September", "October", "November", "December"}},
                {"FR", new string[] {"Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre"}},
            };

            public static string monthName(int month)
            {
                return monthNameTable[chosenLanguage][month];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string> monthChoiceFormText = new Dictionary<string, string>()
            {
                {"PL", "Okno wyboru daty"},
                {"EN", "Date choice window"},
                {"FR", "Le fenetre du choix de la date"}
            };

            public static string monthChoiceForm()
            {
                return monthChoiceFormText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string> saveAndCloseButtonText = new Dictionary<string, string>()
            {
                {"PL", "Zapisz i zamknij"},
                {"EN", "Save and close"},
                {"FR", "Enregistre et ferme"}
            };

            public static string saveAndCloseButton()
            {
                return saveAndCloseButtonText[chosenLanguage];
            }

//slownik dla emplListWindow
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string> emplListWindowText = new Dictionary<string, string>()
            {
                {"PL", "Lista pracowników"},
                {"EN", "Employees list"},
                {"FR", "Liste de employees"}
            };

            public static string emplListWindow()
            {
                return emplListWindowText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string> delateEmplButtonText = new Dictionary<string, string>()
            {
                {"PL", "Usuń zaznaczony wpis"},
                {"EN", "Delate choised position"},
                {"FR", "Supprime la position choisi"}
            };

            public static string delateEmplButton()
            {
                return delateEmplButtonText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string> addEmplButtonText  = new Dictionary<string, string>()
            {
                {"PL", "Dodaj nowego pracownika"},
                {"EN", "Add new Employee"},
                {"FR", "Ajoute le nouveau employee"}
            };

            public static string addEmplButton()
            {
                return addEmplButtonText[chosenLanguage];
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            static Dictionary<string, string>  modifyEmplButtonText = new Dictionary<string, string>()
            {
                {"PL", "Modyfikuj zaznaczony wpis"},
                {"EN", "Modify choised position"},
                {"FR", "Modifie la position choisi"}
            };

            public static string modifyEmplButton()
            {
                return modifyEmplButtonText[chosenLanguage];
            }

    }
}
