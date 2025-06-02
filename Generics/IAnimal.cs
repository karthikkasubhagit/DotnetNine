namespace Generics
{
    public interface IAnimal
    {
        decimal Height { get; }
        decimal Weight { get; }
        bool HasFur { get; }
    }

    public record Dog(decimal Height, decimal Weight) : IAnimal
    {
       public bool HasFur => true;
    }
    public record Cat(decimal Height, decimal Weight, bool HasFur) : IAnimal;

    public record GoldFish(decimal Height, decimal Weight) : IAnimal
    {
        public bool HasFur => false;
    }

}
