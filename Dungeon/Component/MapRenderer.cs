using System.Numerics;

using SharpEngine.Core.Component;
using SharpEngine.Core.Manager;
using SharpEngine.Core.Math;
using SharpEngine.Core.Renderer;
using SharpEngine.Core.Utils;

public class MapRenderer : Component
{
    public required int TileSize { get; set; }

    public override void Draw()
    {
        if (Entity?.Scene?.Window is not { } window) return;
        if (window.CameraManager is not { } cameraManager) return;

        Vec2 mouse = InputManager.GetMousePosition();

        Matrix3x2.Invert(cameraManager.Transform, out var invert);
        mouse = Vector2.Transform(mouse, invert);

        mouse.X = float.Floor(mouse.X / TileSize) * TileSize;
        mouse.Y = float.Floor(mouse.Y / TileSize) * TileSize;

        SERender.DrawRectangleLines(new(mouse.X, mouse.Y, TileSize, TileSize), 4, Color.Red, InstructionSource.Entity, 1);
    }
}