using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Room
    {
        public int IdRoom { get; set; }

        public int Number { get; set; }

        public string Description { get; set; }

        public int Type { get; set; }

        public decimal Price { get; set; }

        public bool HasTV { get; set; }

        public bool HasHairDryer { get; set; }

        public int IdHotel { get; set; }

       /* public List<string> Pictures = new List<string>();

        public void setPictures(List<string> Pictures)
        {
            this.Pictures = Pictures;
        }*/

       /* public string displayPictures()
        {
            string pictures = "";

            foreach (string p in Pictures)
            {
                pictures += p + "\n";
            }

            return pictures;
        }*/
        
        public override string ToString()
        {
            return 
                "Number: \t" + Number + "\n" +
                "Description\t: " + Description + "\n" +
                "Type:\t" + Type + " lit(s) \n" +
                "Price:\t" + Price + "\n" +
                "Has TV:\t" + HasTV + "\n" +
                "Has HairDryer:\t" + HasHairDryer + "\n"/* +
                "Pictures:\t" + displayPictures() + "\n"*/;
        }
    }
}
