using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventmaker.Model
{
    class EventCatalogSingleton
    {
        private static EventCatalogSingleton _instance = new EventCatalogSingleton(); //laver en ny instance af klassen selv.

        public static EventCatalogSingleton Instance //returnere instansen af klassen eller opretter en instans af klassen. 
        {
            get { return _instance ?? (_instance = new EventCatalogSingleton()); }
        }
        
        private ObservableCollection<Event> _events;

        public ObservableCollection<Event> Events { get; set; }

        public EventCatalogSingleton()
        {
            Events = new ObservableCollection<Event>();
            LoadTestContent();
        }
        //
        private void LoadTestContent() // Laver nogle test events som bliver loaded i konstruktøren. 
        {
            Events.Add(new Event(1, "Birthday", "Birthday Event", "Maglegårdsvej 2", new DateTime(2019, 2, 3, 10, 00, 00)));
            Events.Add(new Event(2, "Eksamen", "SWC Eksamen", "Maglegårdsvej 2", new DateTime(2019, 5, 7, 7, 45, 00)));
            Events.Add(new Event(3, "Bryllup", "Maher's bryllup", "Vapnagård 11", new DateTime(2019, 7, 10, 9, 30, 00)));
        }

        public void AddEvent(Event ev) // Tilføjer et event som er oprettet i forvejen. 
        {
            Events.Add(ev);
        }

        public void LoadEventAsync()
        {

        }

        public void Add(int id, string name, string description, string place, DateTime dateTime) // Tilføjer et nyt event til collectionen. 
        {
            Events.Add(new Event(id, name, description, place, dateTime));
        }
    }
}
