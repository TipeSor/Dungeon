using SharpEngine.Core;
using SharpEngine.Core.Utils;

Window window = new(Globals.Width, Globals.Height, Globals.Title)
{
    BackgroundColor = Color.AliceBlue
};

window.AddScene(new MainMenu());
window.AddScene(new Game());

window.IndexCurrentScene = 0;

window.Run();