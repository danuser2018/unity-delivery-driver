using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPackageAction : MonoBehaviour {

    private const string PACKAGE_TAG = "Package";

    [SerializeField] float secsToDestroy;

    private Trunk trunk;

    void Start() {
        trunk = GetComponent<Trunk>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (isPackage(other) && canPickUpPackage()) {
            pickUpPackage();
            destroyPackage(other);
        }
    }

    private bool isPackage(Collider2D obj) {
        return obj.tag == PACKAGE_TAG;
    }

    private bool canPickUpPackage() {
        return !trunk.hasPackage();
    }

    private void pickUpPackage() {
        trunk.pickUpPackage();
    }

    private void destroyPackage(Collider2D package) {
        Destroy(package.gameObject, secsToDestroy);
    }
}
