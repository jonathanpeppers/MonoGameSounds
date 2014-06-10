using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;

namespace MonoGameSounds.iOS
{
    public class TestGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SoundEffectInstance _sound;
        private TimeSpan _lastTime;

        public TestGame()
        {
            _graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";

            _graphics.IsFullScreen = true;
            _graphics.SupportedOrientations = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight;
        }

        protected override void LoadContent()
        {
            //NOTE: if you load chaingun_xnb (an XNB of the exact same file at lowest quality), it works fine

            var sound = Content.Load<SoundEffect>("chaingun_mp3");
            _sound = sound.CreateInstance();
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Red);

            if (gameTime.TotalGameTime - _lastTime > TimeSpan.FromSeconds(2))
            {
                _lastTime = gameTime.TotalGameTime;

                _sound.Play();
            }
        }
    }
}

