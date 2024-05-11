using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace watchesASP.Api.Dtos
{
    public record class CreateWatchDto(

        [Required][StringLength(50)] string Name,
        int MovTypeId,
        decimal Price,
        [Required][StringLength(50)] string Style,
        [Required][StringLength(50)] string WaterResist,
        DateOnly ReleaseDate
    );
}
