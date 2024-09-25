using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Artist
    {
        public Artist() { }
        [Key]
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        // public string? BirthPlace { get; set; }
        public Gender? Gender { get; set; }
        public byte[] ArtistPhoto { get; set; }
        public int Age { get; set; }
        //public Nationality? Nationality { get; set; }
        //public Profession Profession { get; set; }
        public string SortDescription { get; set; }
        public string LongDescription { get; set; }
        //public string? Awards { get; set; }
        // public string? Debut { get; set; }
        public string CurrentLocation { get; set; }
        public Country? Country { get; set; }
        public bool ShowInFront { get; set; }
        public int? ShowInFrontOrder
        {
            get; set;
        }

        public bool Active { get; set; }



    }
    public enum Gender
    {
        Male=1,
        Female=2
    }

    public enum Country
    {
        Norway=1,
        Oslo=2,
        UK=3,US=4,Canada=5
    }

    public enum Profession
    {
        Musician=1,
        Dancer=2,
        painter=3,Singer=4,Director=5,Actor=6
    }

    public enum Relationship
    {
        Single=1,
        Married=2,
        InRelation=3,
        Complicated=4
    }

    public class MasterInfo
    {
        public int id { get; set; }
        public string value { get; set; }
    }
}
