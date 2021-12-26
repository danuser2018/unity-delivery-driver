using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnObstacleAction : MonoBehaviour {

    private EngineManager.Engine engine;

    void Start() => engine = GetComponent<EngineManager>().engine;        

    void OnCollisionEnter2D(Collision2D other) => engine.setBoosted(false);
}
