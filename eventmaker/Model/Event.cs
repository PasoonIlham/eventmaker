using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventmaker.Model
{
    class Event
    {
        #region instanceFields 
        private int id;
        private string name;
        private string description;
        private string place;
        private DateTime dateTime;
        #endregion

        #region constructor
        public Event(int Id, string Name, string Description, string Place, DateTime Datetime)
        {
            id = Id;
            name = Name;
            description = Description;
            place = Place;
            dateTime = Datetime;

        }
        #endregion

        #region properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Place
        {
            get { return place; }
            set { place = value; }
        }

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
        #endregion

        #region Tostring
        public override string ToString()
        {
            return $"{nameof(id)}: {id}, {nameof(name)}: {name}, {nameof(description)}: {description}, {nameof(place)}: {place}, {nameof(dateTime)}: {dateTime}";
        }
        #endregion
    }
}
