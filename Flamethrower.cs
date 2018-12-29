namespace VRTK
{
    using UnityEngine;

    public class Flamethrower : VRTK_InteractableObject
    {
        public ParticleSystem flameParticles;
        public BlowTorch Torch;

        public override void StartUsing(VRTK_InteractUse currentUsingObject)
        {
            base.StartUsing(currentUsingObject);
            flameParticles.Play();
            Torch.Laser.enabled = true;
        }

        public override void StopUsing(VRTK_InteractUse previousUsingObject = null, bool resetUsingObjectState = true)
        {
            base.StopUsing(previousUsingObject, resetUsingObjectState);
            flameParticles.Pause();
            flameParticles.Clear();
            Torch.Laser.enabled = false;
        }
    }
}