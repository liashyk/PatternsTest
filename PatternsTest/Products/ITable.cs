namespace PatternsTest.Products
{
    internal interface ITable
    {
        bool HasLegs { get; }
        double Height { get; }
        bool IsOval { get; }
        double Length { get; }
        double Width { get; }
    }
}