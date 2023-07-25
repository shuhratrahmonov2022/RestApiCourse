using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Contracts.Responses
{
    public class MoviesResponses
    {
        public required IEnumerable<MovieResponse> Item { get; init; } = Enumerable.Empty<MovieResponse>();
    }
}
