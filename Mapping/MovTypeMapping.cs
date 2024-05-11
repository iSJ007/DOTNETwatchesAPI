using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using watchesASP.Api.Dtos;

using watchesASP.Api.Entities;

namespace watchesASP.Api.Mapping
{
    public static class MovTypeMapping
    {
        public static MovTypeDto ToDto(this Watch watch)
        {
            return new MovTypeDto(watch.Id, watch.Name);
        }
    }
}