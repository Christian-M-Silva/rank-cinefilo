using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class MoviesWithUserId : Movies
    {
        public Guid UserId { get; set; }
    }
}
