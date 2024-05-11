using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using watchesASP.Api.Data;
using watchesASP.Api.Dtos;
using watchesASP.Api.Entities;
using watchesASP.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace watchesASP.Api.Endpoints
{
    public static class MovTypeEndpoints
    {
        public static RouteGroupBuilder MapMovTypeEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("movtypes");

            group.MapGet("/", async (watchesASPContext dbContext) =>
                await dbContext.Watches
                               .Select(movtype => movtype.ToDto())
                               .AsNoTracking()
                               .ToListAsync());

            return group;
        }
    }
}