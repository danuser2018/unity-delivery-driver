using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBoosterAction : MonoBehaviour {

    private const string BOOSTER_TAG = "Booster";

    private Engine engine;

    void Start() {
        engine = GetComponent<Engine>();        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (isBooster(other)) {
            engine.setBoosted(true);
        }
    }

    private bool isBooster(Collider2D obj) {
        return obj.tag == BOOSTER_TAG;
    }
}
