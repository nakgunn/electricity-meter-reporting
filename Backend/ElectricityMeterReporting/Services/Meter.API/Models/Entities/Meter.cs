namespace Meter.API.Models.Entities
{
    public class Meter
    {
        public Guid Id { get; set; }
        private string _serialNumber;
        public string SerialNumber
        {
            get => _serialNumber;
            set
            {
                if (value.Length == 8)
                    _serialNumber = value;
                else
                    throw new ArgumentException("SerialNumber must be exactly 8 characters long.");
            }
        }
        public decimal LastIndex { get; set; }
        public DateTime LastIndexDate { get; set; }
        public decimal MeasurementVoltage { get; set; }
        public decimal MeasurementCurrent { get; set; }
    }
}
