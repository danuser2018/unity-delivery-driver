using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine {
    private readonly float steerSpeed;
    private readonly float slowSpeed;
    private readonly float boostSpeed;
    private bool boosted;

    public Engine(float steerSpeed, float slowSpeed, float boostSpeed) {
        this.steerSpeed = steerSpeed;
        this.slowSpeed = slowSpeed;
        this.boostSpeed = boostSpeed;
        this.boosted = false;
    }

    public float getSteerSpeed() => steerSpeed;

    public float getMoveSpeed() {
        if (boosted) 
            return boostSpeed;
        else
            return slowSpeed;
    }    

    public void activateBoost() => boosted = true;
    public void deactivateBoost() => boosted = false;
}
