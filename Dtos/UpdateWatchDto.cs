using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace watchesASP.Api.Dtos
{
    public record class UpdateWatchDto(

        [StringLength(50)] string Name,
        int MovTypeId,
        decimal Price,
        [StringLength(50)] string Style,
        [StringLength(50)] string WaterResist,
        DateOnly ReleaseDate
    );
}



