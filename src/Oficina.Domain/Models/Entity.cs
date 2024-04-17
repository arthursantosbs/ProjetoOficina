using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oficina.Domain.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public override bool Equals(object? obj)
        {
            var compareCom = obj as Entity;
            if(ReferenceEquals(this, compareCom)) return true;  
            if(ReferenceEquals(null, compareCom)) return false;  
            return Id.Equals(compareCom.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if(ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;
            if(ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;
            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }
    }
}