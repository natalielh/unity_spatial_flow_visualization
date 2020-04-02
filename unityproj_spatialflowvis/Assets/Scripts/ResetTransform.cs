using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTransform : MonoBehaviour {

    public Transform customPosTransform;
    public bool useCustomPos = false;

    public void ResetWorldTransform() {

        if (useCustomPos) { transform.position = customPosTransform.position; }
        else {transform.position = Vector3.zero;}


    }

    public void ResetLocalTransform() {

        if (useCustomPos) { transform.localPosition = customPosTransform.position; }
        else { transform.localPosition = Vector3.zero; }

    }

    public void SetParentToNull() {

        transform.SetParent(null);

    }

}
