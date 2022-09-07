using System.Text;

namespace Exercitii_laborator_16_part2.Models
{
    public class Autovehicle
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string VIN { get; set; } = null!;
        public int ManufactureDate { get; set; }
        public Manufacturer Manufacturer { get; set; } = null!;


        public override string ToString() => $"ID: {Id}. {Name}, manufactured in {ManufactureDate}. VIN: {VIN}";
    }
}
