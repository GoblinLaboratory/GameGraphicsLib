﻿using System;
using System.Drawing;
using Color = Microsoft.Xna.Framework.Color;

namespace GameGraphicsLib.DrawableShapes
{
    [Serializable]
    public class DrawnRectangle : IDrawnShape
    {
        private const DrawnType _DrawnType = DrawnType.Shape;
        private const ShapeType _Shape = ShapeType.Rectangle;
        
        public string Name { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Size Size { get { return new Size(Width, Height); } set { Width = value.Width; Height = value.Height;} }
        public Color Color { get; set; }
        public float Thickness { get; set; }
        public DrawnType DrawnType { get { return _DrawnType; } set { } }
        public ShapeType Shape { get { return _Shape;} set { } }

        public DrawnRectangle Clone(string name)
        {
            
            return new DrawnRectangle
            {
                Name = name,
                X = X,
                Y = Y,
                Size = Size,
                Color = Color,
                Thickness = Thickness
            };
            
        }
    }
}