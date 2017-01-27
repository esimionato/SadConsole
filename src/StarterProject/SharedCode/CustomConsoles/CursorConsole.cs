﻿using Microsoft.Xna.Framework;

using Console = SadConsole.Console;

namespace StarterProject.CustomConsoles
{
    class CursorConsole: Console
    {
        public CursorConsole()
            : base(80, 25)
        {
            // This console demonstrates the virtual cursor.
            VirtualCursor.IsVisible = true;
            VirtualCursor.Position = new Point(0, 2);
            UseKeyboard = true;

            // Print some intro text
            Print(0, 0, "This console can be typed on. Use the arrow keys to move the cursor.");
            Print(0, 2, "Use the F1 key to cycle the active console.");

            IsVisible = false;
        }
    }
}
