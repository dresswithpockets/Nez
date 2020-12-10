using Microsoft.Xna.Framework;
using Nez.PhysicsShapes;

namespace Nez
{
    public class OffsetPolygon : Polygon
    {
        public Vector2 Offset { get; set; }

        public OffsetPolygon(Vector2[] points, Vector2 offset) : base(points)
        {
            Offset = offset;
        }
        
        public OffsetPolygon(Vector2[] points) : base(points)
        {
        }

        public OffsetPolygon(int vertCount, float radius) : base(vertCount, radius)
        {
        }
    }
}