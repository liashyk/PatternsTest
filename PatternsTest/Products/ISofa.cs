namespace PatternsTest.Products
{
    internal interface ISofa
    {
        double Height { get; }
        double Width { get; }

        bool HasLegs { get; }
        string SitOn();
    }
}
