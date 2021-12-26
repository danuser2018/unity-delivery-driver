using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPackageAction : MonoBehaviour {

    private const string PACKAGE_TAG = "Package";

    [SerializeField] float secsToDestroy;

    private TrunkManager.Trunk trunk;
    private SpriteRenderer spriteRenderer;

    void Start() {
        trunk = GetComponent<TrunkManager>().trunk;
        spriteRenderer = GetComponent<SpriteRenderer>();
    } 

    void OnTriggerEnter2D(Collider2D other) {
        if (isPackage(other) && trunk.canPickUpPackage()) {
            pickUpPackage();
            destroyPackage(other);
        }
    }

    private bool isPackage(Collider2D obj) => obj.tag == PACKAGE_TAG;

    private void pickUpPackage() {
        trunk.pickUpPackage();
        spriteRenderer.color = trunk.getColor();
    }    

    private void destroyPackage(Collider2D package) => Destroy(package.gameObject, secsToDestroy);
}
