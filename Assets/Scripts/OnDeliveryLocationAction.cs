using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeliveryLocationAction : MonoBehaviour {

    private const string DELIVERY_LOCATION_TAG = "Delivery Location";

    private TrunkManager.Trunk trunk;
    private SpriteRenderer spriteRenderer;

    void Start() {
        trunk = GetComponent<TrunkManager>().trunk;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (isDeliveryLocation(other) && trunk.canDeliverPackage())
            deliverPackage();
    }

    private bool isDeliveryLocation(Collider2D obj) => obj.tag == DELIVERY_LOCATION_TAG;

    private void deliverPackage() {
        trunk.deliverPackage();
        spriteRenderer.color = trunk.getColor();
    }    
}
