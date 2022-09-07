namespace Exercitii_laborator_16_part2.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;


        public override string ToString() => $"{Name} {Address}";
    }
}