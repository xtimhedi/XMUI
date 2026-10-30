using SDL;
using System;
using System.Collections.Generic;
using System.Text;
using XMUI.Nodes;
using static SDL.SDL3;
using static XMUI.XMUI;

namespace XMUI
{
    public unsafe class AppForm : Node
    {
        public async Task StartRendering(int globalListId)
        {
            // create the window and shit
            SDL_Window* Window = SDL_CreateWindow("XMUI", 800, 600, 0);
            xmCreateList(globalListId, Window);

            Setup(globalListId);

            SDL_Event e;

            bool m_frameOpen = true;


            while (m_frameOpen) {
                while (SDL_PollEvent(&e))
                {
                    switch (e.type)
                    {
                        case (uint)SDL_EventType.SDL_EVENT_QUIT:
                            m_frameOpen = false;
                            break;

                        case (uint)SDL_EventType.SDL_EVENT_KEY_DOWN:
                            if (e.key.key == SDL_Keycode.SDLK_ESCAPE)
                            {
                                m_frameOpen = false;
                            }
                            break;
                    }
                }

                float mX;
                float mY;
                SDL_GetMouseState(&mX, &mY);

                XMUI.MouseAABB = new Collision.AABB((int)mX, (int)mY, 1, 1);
                xmBindList(globalListId);
                SDL_RenderClear(commandList);
                SDL_RenderPresent(commandList);
            }
        }

        public virtual void Setup(int globalListId) { }
    }
}
