using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeliveryLocationAction : MonoBehaviour {

    private const string DELIVERY_LOCATION_TAG = "Delivery Location";

    private Trunk trunk;

    void Start() {
        trunk = GetComponent<Trunk>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (isDeliveryLocation(other) && canDeliverPackage()) {
            deliverPackage();
        }
    }

    private bool isDeliveryLocation(Collider2D obj) {
        return obj.tag == DELIVERY_LOCATION_TAG;
    }

    private bool canDeliverPackage() {
        return trunk.hasPackage();
    }

    private void deliverPackage() {
        trunk.deliverPackage();
    }
}
