﻿using System;

namespace SpaceSim {
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (SpaceSim game = new SpaceSim())
                game.Run();
        }
    }
}
