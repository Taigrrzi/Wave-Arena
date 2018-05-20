using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public string displayName;
    public string displayDescription;
    public int initialHealth;
    public enum aiStates {};

    public int currentHealth;
    public int initialState;

    // Use this for initialization
    void Start () {
        currentHealth = initialHealth;
    }
	
	// Update is called once per frame
	void Update () {
        UpdateState();
	}

    public virtual void EnterState() //Call when entering an AI State
    {

    }

    public virtual void UpdateState() //Call every frame
    {

    }

    public virtual void ExitState() //Call when entering an AI State
    {

    }

    public virtual void Die() //Call when this enemy dies
    {

    }

    public virtual void TakeDamage(int amount) //Call when this enemy takes damage
    {
        this.currentHealth -= amount;
        if (currentHealth <= 0) {
            this.Die();
        }
    }
}
