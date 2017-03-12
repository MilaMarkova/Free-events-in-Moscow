using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free_events_in_Moscow
{
    class Event
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        //дд.мм.гггг
        private string _date;
        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        //чч:мм
        private string _time;
        public string Time
        {
            get { return _time; }
            set { _time = value; }
        }

        private string _location;
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public Event(string title, string type, string date, string time, string location, string description)
        {
            _title = title;
            _date = date;
            _time = time;
            _location = location;
            _type = type;
            _description = description;
        }
    }
}
