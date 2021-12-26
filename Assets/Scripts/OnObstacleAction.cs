using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnObstacleAction : MonoBehaviour {
    private Engine engine;

    void Start() => engine = GetComponent<Engine>();        

    void OnCollisionEnter2D(Collision2D other) => engine.setBoosted(false);
}
