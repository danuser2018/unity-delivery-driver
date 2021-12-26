using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour {
    [SerializeField] private float steerSpeed;
    [SerializeField] private float slowSpeed;
    [SerializeField] private float boostSpeed;

    private bool boosted = false;

    public float getSteerSpeed() => steerSpeed;

    public float getMoveSpeed() {
        if (boosted) 
            return boostSpeed;
        else
            return slowSpeed;
    }    

    public void setBoosted(bool value) => boosted = value;

    public bool getBoosted() => boosted;
}
