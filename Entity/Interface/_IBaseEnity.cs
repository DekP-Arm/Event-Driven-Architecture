using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Entity;

public interface IBaseEntity
{
    Guid Id { get; set; }
    DateTime CreatedUTC { get; set; }
    DateTime UpdatedUTC { get; set; }
    bool IsActive { get; set; } 
}