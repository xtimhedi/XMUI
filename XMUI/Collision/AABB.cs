using SDL;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace XMUI.Collision
{
    public class AABB
    {
        int x;
        int y;
        int w;
        int h;

        public AABB(int x, int y, int w, int h)
        {
            (this.x, this.y, this.w, this.h) = (x, y, w, h);
        } 

        public bool Intersects(AABB otherAabb)
        {
            return (
                x < otherAabb.x + otherAabb.w &&
                x + w > otherAabb.x &&
                y < otherAabb.y + otherAabb.h &&
                y + h > otherAabb.y);
        }

        public SDL_Rect ToRect()
        {
            return new SDL_Rect { x = x, y = y, w = w, h = h };
        }

        public static AABB CalculateFromVec2(Vector2 pos, Vector2 size)
        {
            return new AABB((int)pos.X, (int)pos.Y, (int)size.X, (int)size.Y);
        }
    }
}
