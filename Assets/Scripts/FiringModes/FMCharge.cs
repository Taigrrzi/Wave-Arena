using UnityEngine;

namespace FiringModes
{
    public class FMCharge : MonoBehaviour, IFiringMode
    {
        private Weapon weapon;
        private float chargeTime;
        private bool autoRelease;
        private bool earlyRelease;
        private float currentCharge;

        public FMCharge FMChargeInit(Weapon weapon, float chargeTime, bool earlyRelease, bool autoRelease)
        {
            this.weapon = weapon;
            this.chargeTime = chargeTime;
            this.autoRelease = autoRelease;
            this.earlyRelease = earlyRelease;
            return this;
        }
        
        public void FirePressed()
        {
            
        }

        public void FireDown()
        {
            currentCharge += Time.deltaTime;
            if (currentCharge >= chargeTime)
            {
                if (autoRelease)
                {
                    weapon.Shoot();
                    currentCharge = 0;
                }
            }
        }

        public void FireReleased()
        {
            if (currentCharge >= chargeTime)
            {
                weapon.Shoot();
            } else if (earlyRelease)
            {
                //Do something to nerf damage
                weapon.Shoot();
            }

            currentCharge = 0;
        }
        
    }
}