using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrunkManager : MonoBehaviour {

    [SerializeField] Color32 hasPackageColor;
    [SerializeField] Color32 noPackageColor;

    public Trunk trunk;

    void Awake() => trunk = new Trunk(hasPackageColor, noPackageColor);
}
