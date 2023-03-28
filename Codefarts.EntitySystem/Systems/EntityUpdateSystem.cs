
namespace Codefarts.EntitySystem.Systems;

public abstract class EntityUpdateSystem : EntitySystem, IUpdateSystem
{
    protected EntityUpdateSystem(AspectBuilder aspectBuilder) 
        : base(aspectBuilder)
    {
    }

    public abstract void Update( TimeSpan elapsedTime,TimeSpan totalTime);
}