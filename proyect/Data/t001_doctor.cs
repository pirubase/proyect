using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace proyect.Data
{
    public class t001_doctor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public  ObjectId f001_id { get; set; }

        public required string f001_nombre { get; set; }
        public required string f001_email { get; set; }
        public required string f001_password { get; set; }
    }
}
