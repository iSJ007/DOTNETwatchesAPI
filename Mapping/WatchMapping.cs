using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using watchesASP.Api.Dtos;

using watchesASP.Api.Entities;


namespace watchesASP.Api.Mapping
{
    public static class WatchMapping
    {
        public static Watch ToEntity(this CreateWatchDto watch)
        {
            return new Watch()
            {
                Name = watch.Name,
                MovTypeId = watch.MovTypeId,
                Price = watch.Price,
                ReleaseDate = watch.ReleaseDate,
                Style = watch.Style,
                WaterResist = watch.WaterResist
            };
        }

        public static Watch ToEntity(this UpdateWatchDto watch, int id)
        {
            return new Watch()
            {
                Id = id,
                Name = watch.Name,
                MovTypeId = watch.MovTypeId,
                Price = watch.Price,
                ReleaseDate = watch.ReleaseDate,
                Style = watch.Style,
                WaterResist = watch.WaterResist

            };
        }

        public static WatchSummaryDto ToWatchSummaryDto(this Watch watch)
        {
            return new(
                watch.Id,
                watch.Name,
                watch.MovType!.Name,
                watch.Price,
                watch.Style,
                watch.WaterResist,
                watch.ReleaseDate
            );
        }

        public static WatchDetailsDto ToWatchDetailsDto(this Watch watch)
        {
            return new(
                watch.Id,
                watch.Name,
                watch.MovTypeId,
                watch.Price,
                watch.Style,
                watch.WaterResist,
                watch.ReleaseDate
            );
        }
    }
}
