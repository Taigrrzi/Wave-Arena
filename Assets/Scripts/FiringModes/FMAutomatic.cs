using UnityEngine;

namespace FiringModes
{
    public class FMAutomatic : MonoBehaviour, IFiringMode
    {
        private Weapon weapon;
        private float shotDelay;
        private float lastShot;

        public FMAutomatic FMAutomaticInit(Weapon weapon, float shotDelay)
        {
            this.weapon = weapon;
            this.shotDelay = shotDelay;
            lastShot = 0;
            return this;
        }
        
        public void FirePressed()
        {
            
        }

        public void FireDown()
        {
            if (Time.time - shotDelay > lastShot)
            {    
                weapon.Shoot();
                lastShot = Time.time;
            }
        }
        
        public void FireReleased(){}
        
    }
}