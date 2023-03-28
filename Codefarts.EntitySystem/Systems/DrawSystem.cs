 
namespace Codefarts.EntitySystem.Systems;

public interface IDrawSystem : ISystem
{
    void Draw( TimeSpan elapsedTime,TimeSpan totalTime);
}

public abstract class DrawSystem : IDrawSystem
{
    public virtual void Dispose() { }
    public virtual void Initialize(World world) { }
    public abstract void Draw( TimeSpan elapsedTime,TimeSpan totalTime);
}