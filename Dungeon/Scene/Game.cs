using SharpEngine.Core;
using SharpEngine.Core.Utils;

public class Game : Scene
{
    public Map Map { get; set; }
    public Player Player { get; set; }

    public Game()
    {
        Player = AddEntity(new Player());
        Map = AddEntity(new Map());
    }

    public override void OpenScene()
    {
        base.OpenScene();
        if (Window is null) return;

        Window.CameraManager.FollowEntity = Player;
        Window.CameraManager.Position = Player.Transform.Position;
        Window.CameraManager.Mode = CameraMode.Follow;
    }
}