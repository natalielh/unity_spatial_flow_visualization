using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTransform : MonoBehaviour {

    public Transform customPosTransform;
    public bool useCustomPos = false;
    public bool resetRotation = false;

    public void ResetWorldTransform() {

        if (useCustomPos) { transform.position = customPosTransform.position; }
        else {transform.position = Vector3.zero;}

        if (resetRotation) { transform.localRotation = Quaternion.identity; }

    }

    public void ResetLocalTransform() {

        if (useCustomPos) { transform.localPosition = customPosTransform.position; }
        else { transform.localPosition = Vector3.zero; }

        if (resetRotation) { transform.localRotation = Quaternion.identity; }

    }

    public void SetParentToNull() {

        transform.SetParent(null);

    }

}
