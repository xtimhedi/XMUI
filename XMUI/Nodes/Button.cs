using System;
using System.Collections.Generic;
using System.Text;
using XMUI.Collision;

namespace XMUI.Nodes
{
    public class Button : Control
    {
        private AABB _box;
        public override void Render(int currentList)
        {
            XMUI.xmBindList(currentList);

            // create the AABB (yes, we do this in the rendering)
            _box = AABB.CalculateFromVec2(Position, Size);
        }
    }
}
