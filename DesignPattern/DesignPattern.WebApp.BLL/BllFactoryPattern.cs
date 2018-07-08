using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using DesignPattern.WebApp.Entity;
using DesignPattern.WebApp.Interfaces;

namespace DesignPattern.WebApp.BLL
{
    public class BllFactoryPattern : IBllFactoryPattern
    {
        public VmShapeTypes GetShapeTypes()
        {
            return new VmShapeTypes
            {
                ShapeTypes = new List<VmShapeType>
                {
                    new VmShapeType()
                    {
                        Id = (int) DesignPattern.Entity.CreationalPatterns.FactoryPattern.ShapeType.Rectangle,
                        Name = DesignPattern.Entity.CreationalPatterns.FactoryPattern.ShapeType.Rectangle.ToString()
                    },
                    new VmShapeType()
                    {
                        Id = (int) DesignPattern.Entity.CreationalPatterns.FactoryPattern.ShapeType.Sqaure,
                        Name = DesignPattern.Entity.CreationalPatterns.FactoryPattern.ShapeType.Sqaure.ToString()
                    },
                    new VmShapeType()
                    {
                        Id = (int) DesignPattern.Entity.CreationalPatterns.FactoryPattern.ShapeType.Circle,
                        Name = DesignPattern.Entity.CreationalPatterns.FactoryPattern.ShapeType.Circle.ToString()
                    },
                }
            };
        }

        public string GetShape(int shapeType)
        {
            var shape = DesignPattern.BLL.CreationalPatterns.FactoryPattern.ShapeFactory.CreateShape((DesignPattern.Entity.CreationalPatterns.FactoryPattern.ShapeType) shapeType);
            var stream = new MemoryStream();
            shape.GetImage().Save(stream, ImageFormat.Jpeg);
                
            return Convert.ToBase64String(stream.ToArray());
        }
    }
}