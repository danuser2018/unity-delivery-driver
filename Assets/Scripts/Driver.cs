using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour {

    private const string STEER_AXIS_NAME = "Horizontal";
    private const string MOVE_AXIS_NAME = "Vertical";
    
    private Engine engine;

    void Start() => engine = GetComponent<EngineManager>().engine;

    void Update() {
        rotate();
        translate();
    }

    private void rotate() => transform.Rotate(0, 0, calculateSteerAmount());

    private void translate() => transform.Translate(0, calculateMoveAmount(), 0);

    private float calculateSteerAmount() => byDeltaTime(-Input.GetAxis(STEER_AXIS_NAME) * engine.getSteerSpeed());

    private float calculateMoveAmount() => byDeltaTime(Input.GetAxis(MOVE_AXIS_NAME) * engine.getMoveSpeed());

    private float byDeltaTime(float value) => value * Time.deltaTime;
}
