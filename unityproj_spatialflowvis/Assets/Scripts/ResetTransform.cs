using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTransform : MonoBehaviour {

    public void ResetWorldTransform() {
        transform.position = Vector3.zero;

    }

    public void ResetLocalTransform() {
        transform.localPosition = Vector3.zero;

    }

}
