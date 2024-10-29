using Meter.API.Controllers;
using Meter.API.Models;
using Meter.API.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Meter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeterController : ControllerBase
    {
        readonly MeterDbContext _context;
        public MeterController(MeterDbContext context)
        {
            _context = context;
        }

        [HttpGet()]
        public async Task<IActionResult> GetList()
        {
            var entities = await _context.Meters.ToListAsync();
            var list = entities.Select(e => new MeterDTO()
            {
                LastIndex = e.LastIndex,
                LastIndexDate = e.LastIndexDate,
                MeasurementCurrent = e.MeasurementCurrent,
                MeasurementVoltage = e.MeasurementVoltage,
                SerialNumber = e.SerialNumber,
            }).ToList();
            return Ok(list);
        }

        [HttpGet("Update-meter-values")]
        public async Task<IActionResult> UpdateMeterValues()
        {
            Random random = new Random();
            var meters = await _context.Meters.ToListAsync();
            foreach (var meter in meters)
            {
                meter.LastIndexDate = DateTime.Now;
                var randomIndex = (decimal)(random.NextDouble() * (50 - 1) + 1);
                var randomDiff = (decimal)(random.NextDouble() * 10);
                meter.LastIndex += randomIndex;
                meter.MeasurementVoltage += randomDiff;
                meter.MeasurementCurrent += randomDiff;
            }
            await _context.SaveChangesAsync();
            return Ok();
        }
    }

}

