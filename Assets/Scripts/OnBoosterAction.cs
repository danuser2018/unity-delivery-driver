using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBoosterAction : MonoBehaviour {

    private const string BOOSTER_TAG = "Booster";

    private EngineManager.Engine engine;

    void Start() => engine = GetComponent<EngineManager>().engine;

    void OnTriggerEnter2D(Collider2D other) {
        if (isBooster(other)) 
            engine.setBoosted(true);
    }

    private bool isBooster(Collider2D obj) => obj.tag == BOOSTER_TAG;
}
