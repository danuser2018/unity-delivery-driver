using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trunk {
    private readonly Color32 hasPackageColor;
    private readonly Color32 noPackageColor;
    private bool packageStored;

    public Trunk(Color32 hasPackageColor, Color32 noPackageColor) {
        this.hasPackageColor = hasPackageColor;
        this.noPackageColor = noPackageColor;
        this.packageStored = false;
    }

    public bool canPickUpPackage() => !packageStored;
    public void pickUpPackage() => packageStored = true;

    public bool canDeliverPackage() => packageStored;
    public void deliverPackage() => packageStored = false;

    public Color32 getColor() {
        if (packageStored)
            return hasPackageColor;
        else
            return noPackageColor;
    }
}
