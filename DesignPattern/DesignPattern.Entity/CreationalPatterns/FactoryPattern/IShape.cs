using System.Drawing;

namespace DesignPattern.Entity.CreationalPatterns.FactoryPattern
{
    public interface IShape
    {
        double Area();
        Bitmap GetImage();
    }
}