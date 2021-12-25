using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trunk : MonoBehaviour {

    [SerializeField] Color32 hasPackageColor;
    [SerializeField] Color32 noPackageColor;

    private SpriteRenderer spriteRenderer;
    private bool packageStored = false;

    void Start() => spriteRenderer = GetComponent<SpriteRenderer>();

    public bool hasPackage() => packageStored;

    public void pickUpPackage() {
        packageStored = true;
        spriteRenderer.color = hasPackageColor;
    }

    public void deliverPackage() {
        packageStored = false;
        spriteRenderer.color = noPackageColor;
    }
}
