using System.Collections;
using UnityEngine;

namespace FiringModes
{
    public class FMBurstFire : MonoBehaviour, IFiringMode
    {
        private Weapon weapon;
        private float shotDelay;
        private float lastShot;
        private int burstSize;
        private float burstDelay;


        //Because this requires a coroutine, it must be initialised with AddComponent<FMBurstFire>:
        //firingMode = gameObject.AddComponent<FMBurstFire>().FMBurstFireInit(this,0.5f,3,0.1f);
        public FMBurstFire FMBurstFireInit(Weapon weapon, float shotDelay, int burstSize, float burstDelay)
        {
            this.weapon = weapon;
            this.shotDelay = shotDelay;
            this.burstSize = burstSize;
            this.burstDelay = burstDelay;
            lastShot = 0;
            return this;
        }
        
        public void FirePressed()
        {
            if (Time.time - shotDelay > lastShot)
            {
                StartCoroutine(BurstCoroutine());
                lastShot = Time.time;
            }
        }

        public void FireDown(){}
        public void FireReleased(){}

        private IEnumerator BurstCoroutine()
        {
            int i = 0;
            while (i < burstSize)
            {
                i++;
                weapon.Shoot();
                yield return new WaitForSeconds(burstDelay);
            }
        }
        
    }
}