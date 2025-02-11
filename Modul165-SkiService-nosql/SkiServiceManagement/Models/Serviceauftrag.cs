using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SkiServiceManagement.Models
{
    public class Serviceauftrag
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Kundename {get; set;}
        public string Email {get; set;}
        public string Telefon {get; set;}
        public string Priorität {get; set;}
        public string Dienstleistung {get; set;}

        [BsonRepresentation(BsonType.String)]
        public string Auftragstatus  {get; set;}

    }
    public enum Auftragstatus
    {
        offen,
        InArbeit,
        Abgeschlossen
    }
}