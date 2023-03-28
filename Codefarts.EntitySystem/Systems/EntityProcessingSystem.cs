
namespace Codefarts.EntitySystem.Systems;

public abstract class EntityProcessingSystem : EntityUpdateSystem
{
    protected EntityProcessingSystem(AspectBuilder aspectBuilder)
        : base(aspectBuilder)
    {
    }

    public override void Update( TimeSpan elapsedTime,TimeSpan totalTime)
    {
        Begin();

        foreach (var entityId in ActiveEntities)
            Process(  elapsedTime, totalTime, entityId);

        End();
    }

    public virtual void Begin() { }
    public abstract void Process( TimeSpan elapsedTime,TimeSpan totalTime, int entityId);
    public virtual void End() { }
}