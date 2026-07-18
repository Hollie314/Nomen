using Orpheus.Core.Orbital;
using UnityEngine;

namespace Orpheus.Core.FightSystem
{
    public abstract class Affliction <T> : ScriptableObject where T : OrbitalController<T>
    {
        private IAbilityCaster casterRef;
        private float duration;
        private float currentTime = 0f;
        [SerializeField] private FloatStats valueStatType;
        [SerializeField] private FloatStats affectStatType;
        [SerializeField] private AfflictionType afflictionType;

        public FloatStats ValueStatType => valueStatType;
        public FloatStats AffectStatType => affectStatType;
        public AfflictionType AfflictionType => afflictionType;

        public abstract void OnEnter(OrbitalController<T> orbitalController);

        public abstract void OnUpdate(OrbitalController<T> orbitalController, float time);

        public abstract void OnExit(OrbitalController<T> orbitalController, float time);

        protected virtual void SetDuration(float duration)
        {
            this.duration = duration;
        }

        public void SetCaster(IAbilityCaster casterRef)
        {
            this.casterRef = casterRef;
        }
        
    }
}