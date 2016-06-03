﻿namespace StarterProject.CustomConsoles
{
    using System;
    using SadConsole;
    using SadConsole.Consoles;
    using CustomConsole = SadConsole.Consoles.CustomConsole;
    using Microsoft.Xna.Framework;
    using SadConsole.Input;

    class CachedConsoleConsole : CustomConsole
    {
        CachedTextSurfaceRenderer cachedRenderer;
        ITextSurfaceRenderer oldRenderer;

        public CachedConsoleConsole()
            : base(80, 25)
        {
            IsVisible = false;
            FillWithRandomGarbage();

            cachedRenderer = new CachedTextSurfaceRenderer(Data);
            oldRenderer = _renderer;
        }

        public override bool ProcessKeyboard(KeyboardInfo info)
        {
            if (info.IsKeyReleased(Microsoft.Xna.Framework.Input.Keys.Space))
            {
                Renderer = _renderer == oldRenderer ? cachedRenderer : oldRenderer;
                Data.Tint = _renderer == oldRenderer ? Color.Transparent : Color.Black * 0.25f;
            }

            return false;
        }
    }
}