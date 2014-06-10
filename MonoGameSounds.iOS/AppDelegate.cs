using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoGameSounds.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        private TestGame _game;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            _game = new TestGame();
            _game.Run();
			
            return true;
        }
    }
}

