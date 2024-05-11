using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using watchesASP.Api.Data;
using watchesASP.Api.Dtos;
using watchesASP.Api.Entities;
using watchesASP.Api.Mapping;

namespace watchesASP.Api.Endpoints
{
    public static class WatchesEndpoints
    {
        const string GetWatchEndpointName = "GetWatch";

        public static RouteGroupBuilder MapWatchesEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("watches")
                                   .WithParameterValidation();

            // GET /watches
            group.MapGet("/", async (watchesASPContext dbContext) =>
                await dbContext.Watches
                         .Include(watch => watch.MovType)
                         .Select(watch => watch.ToWatchSummaryDto())
                         .AsNoTracking()
                         .ToListAsync());

            // GET /watches/1
            group.MapGet("/{id}", async (int id, watchesASPContext dbContext) =>
            {
                Watch? watch = await dbContext.Watches.FindAsync(id);

                return watch is null ?
                    Results.NotFound() : Results.Ok(watch.ToWatchDetailsDto());
            })
            .WithName(GetWatchEndpointName);

            // POST /watches
            group.MapPost("/", async (CreateWatchDto newWatch, watchesASPContext dbContext) =>
            {
                Watch watch = newWatch.ToEntity();

                dbContext.Watches.Add(watch);
                await dbContext.SaveChangesAsync();

                return Results.CreatedAtRoute(
                    GetWatchEndpointName,
                    new { id = watch.Id },
                    watch.ToWatchDetailsDto());
            });

            // PUT /watch
            group.MapPut("/{id}", async (int id, UpdateWatchDto updatedWatch, watchesASPContext dbContext) =>
            {
                var existingWatch = await dbContext.Watches.FindAsync(id);

                if (existingWatch is null)
                {
                    return Results.NotFound();
                }

                dbContext.Entry(existingWatch)
                         .CurrentValues
                         .SetValues(updatedWatch.ToEntity(id));

                await dbContext.SaveChangesAsync();

                return Results.NoContent();
            });

            // DELETE /watches/1
            group.MapDelete("/{id}", async (int id, watchesASPContext dbContext) =>
            {
                await dbContext.Watches
                         .Where(watch => watch.Id == id)
                         .ExecuteDeleteAsync();

                return Results.NoContent();
            });

            return group;
        }

    }
}