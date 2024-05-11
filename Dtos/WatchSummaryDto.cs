using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace watchesASP.Api.Dtos
{
    public record class WatchSummaryDto(

        int Id,
        string Name,
        string MovType,
        decimal Price,

        string Style,
        string WaterResist,
        DateOnly ReleaseDate);

}