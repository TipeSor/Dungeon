using SharpEngine.Core.Component;
using SharpEngine.Core.Entity;
using SharpEngine.Core.Manager;

public class Player : Entity
{
    public TransformComponent Transform { get; private init; }

    public Player()
    {
        Transform = AddComponent(new TransformComponent());

        AddComponent(new ControlComponent());
    }

    public override void Update(float delta)
    {
        base.Update(delta);
        float scroll = InputManager.GetMouseWheelMove();
        if (scroll > 0) Scene?.Window?.CameraManager.Zoom *= 2;
        if (scroll < 0) Scene?.Window?.CameraManager.Zoom /= 2;
    }
}