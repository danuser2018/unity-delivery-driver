using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineManager : MonoBehaviour {

    [SerializeField] private float steerSpeed;
    [SerializeField] private float slowSpeed;
    [SerializeField] private float boostSpeed;

    public Engine engine;

    void Awake() => engine = new Engine(steerSpeed, slowSpeed, boostSpeed);
}
