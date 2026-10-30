using SDL;
using System;
using System.Collections.Generic;
using System.Text;
using XMUI.Collision;

namespace XMUI
{
    public unsafe class XMUI
    {
        public static SDL_Renderer*[] commandLists = new SDL_Renderer*[32];

        public static SDL_Renderer* commandList;

        public static SDL_Renderer* nullrdr;

        public static AABB MouseAABB;

        public static void xmBindList(int listId)
        {
            commandList = commandLists[listId];
        }
        public static void xmClearList()
        {
            commandList = nullrdr;
        }
        public static void xmCreateList(int id, SDL_Window* window)
        {
            commandLists[id] = SDL3.SDL_CreateRenderer(window, "");
        }
    }
}
