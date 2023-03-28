 
namespace Codefarts.EntitySystem.Systems;

public abstract class EntityDrawSystem : EntitySystem, IDrawSystem
{
    protected EntityDrawSystem(AspectBuilder aspect)
        : base(aspect)
    {
    }

    public abstract void Draw( TimeSpan elapsedTime,TimeSpan totalTime);
}