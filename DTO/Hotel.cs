﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Hotel
    {

        public int IdHotel { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public int Category { get; set; }

        public bool HasWifi { get; set; }

        public bool HasParking { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        public override string ToString()
        {
            return "Name:\t" + Name +
                "\nDescription:\t" + Description +
                "\nLocation:\t" + Location +
                "\nCategory:\t" + Category + " stars" +
                "\nHas Wifi:\t" + HasWifi +
                "\nHas Parking:\t" + HasParking +
                "\nPhone:\t" + Phone +
                "\nEmail:\t" + Email +
                "\nWebsite:\t" + Website;
        }
    }
}


