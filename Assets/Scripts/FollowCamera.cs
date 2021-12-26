using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

    private readonly Vector3 CAMERA_OFFSET = new Vector3(0, 0, -10);

    [SerializeField] GameObject objectToFollow;

    void LateUpdate() => transform.position = getObjectToFollowPosition() + CAMERA_OFFSET;

    private Vector3 getObjectToFollowPosition() => objectToFollow.transform.position;
}    
