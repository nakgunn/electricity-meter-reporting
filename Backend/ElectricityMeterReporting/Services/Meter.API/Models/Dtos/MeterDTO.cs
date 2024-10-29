namespace Meter.API.Models.Dtos
{
    public class MeterDTO
    {
        public string SerialNumber { get; set; }
        public decimal LastIndex { get; set; }
        public DateTime LastIndexDate { get; set; }
        public decimal MeasurementVoltage { get; set; }
        public decimal MeasurementCurrent { get; set; }
    }
}
