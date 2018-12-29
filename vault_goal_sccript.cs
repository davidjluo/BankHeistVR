namespace VRTK
{
    using UnityEngine;

    public class vault_goal_sccript : VRTK_InteractableObject
    {
        public vault_alarm_master vam;

        public override void StartUsing(VRTK_InteractUse currentUsingObject)
        {
            vam.grabGoal();
        }
    }
}