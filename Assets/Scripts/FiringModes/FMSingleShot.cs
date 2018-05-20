using UnityEngine;

namespace FiringModes
{
    public class SingleShot : IFiringMode
    {
        private readonly Weapon weapon;
        private float shotDelay;
        private float lastShot;

        public SingleShot(Weapon weapon, float shotDelay)
        {
            this.weapon = weapon;
            this.shotDelay = shotDelay;
            lastShot = 0;
        }
        
        public void FirePressed()
        {
            if (Time.time - shotDelay > lastShot)
            {    
                weapon.Shoot();
                lastShot = Time.time;
            }
        }

        public void FireDown(){}
        public void FireReleased(){}
        
    }
}