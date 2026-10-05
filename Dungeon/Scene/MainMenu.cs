using SharpEngine.Core;
using SharpEngine.Core.Widget;

public class MainMenu : Scene
{
    public MainMenu()
    {
        Label title_label = new()
        {
            Position = new(320, 120),
            Text = Globals.Title,

            FontSize = 30,
        };
        AddWidget(title_label);

        Button play_button = new()
        {
            Position = new(320, 320),
            Text = "Play",

            FontSize = 30,
        };
        play_button.Clicked += (_, _) => Window?.IndexCurrentScene = 1;
        AddWidget(play_button);
    }
}