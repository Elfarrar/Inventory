using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Model
{
    public abstract class Entity
    {
        [Key]
        public Guid Id { get; set; }

        public bool IsDeleted { get; set; } = false;

        [JsonIgnore]
        public List<Audit>? Audit { get; set; } = new List<Audit>();

        [JsonIgnore]
        [NotMapped]
        public string? SerializedObject { get; set; }

        public override bool Equals(object? obj)
        {
            var compareTo = obj as Entity;
            if (ReferenceEquals(null, compareTo)) return false;
            if (ReferenceEquals(this, compareTo)) return true;

            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            var rand = new Random();
            return (GetType().GetHashCode() * rand.Next(1, 1000) + Id.GetHashCode());
        }

        public override string ToString()
        {
            return $"{GetType().Name} [Id={Id}]";
        }
    }
}
