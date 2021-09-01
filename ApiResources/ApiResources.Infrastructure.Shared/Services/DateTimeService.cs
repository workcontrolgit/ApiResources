using ApiResources.Application.Interfaces;
using System;

namespace ApiResources.Infrastructure.Shared.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}