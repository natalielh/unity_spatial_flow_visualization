using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMoverCol : MonoBehaviour {

    public GameObject targetObject;

    [Tooltip("0Mup 1Mdown 2MLeft 4MForward 5MBackward 6RRight 7RLeft 8grow 9shrink")]
    public int movementType = 0;

    public float moveInc = 0.05f;
    public float rotInc = 5.0f;
    public float scaleInc = 0.001f;


    void OnCollisionStay(Collision col) {

        if (col.transform.tag == "Player") {

            Debug.Log("movement sent! COLLIDED WITH: " + col);

            switch (movementType)
            {
                case 0:
                    MoveUp();
                    break;
                case 1:
                    MoveDown();
                    break;
                case 2:
                    MoveLeft();
                    break;
                case 3:
                    MoveRight();
                    break;
                case 4:
                    MoveForward();
                    break;
                case 5:
                    MoveBackward();
                    break;
                case 6:
                    RotRight();
                    break;
                case 7:
                    RotLeft();
                    break;
                case 8:
                    Grow();
                    break;
                case 9:
                    Shrink();
                    break;

            }

        }


    }
	


    public void MoveUp()
    {
        targetObject.transform.position = new Vector3(targetObject.transform.position.x, targetObject.transform.position.y + moveInc, targetObject.transform.position.z);
    }

    public void MoveDown()
    {
        targetObject.transform.position = new Vector3(targetObject.transform.position.x, targetObject.transform.position.y - moveInc, targetObject.transform.position.z);
    }

    public void MoveLeft()
    {
        targetObject.transform.position = new Vector3(targetObject.transform.position.x - moveInc, targetObject.transform.position.y, targetObject.transform.position.z);
    }

    public void MoveRight()
    {
        targetObject.transform.position = new Vector3(targetObject.transform.position.x + moveInc, targetObject.transform.position.y, targetObject.transform.position.z);
    }

    public void MoveForward()
    {
        targetObject.transform.position = new Vector3(targetObject.transform.position.x, targetObject.transform.position.y, targetObject.transform.position.z - moveInc);
    }

    public void MoveBackward()
    {
        targetObject.transform.position = new Vector3(targetObject.transform.position.x, targetObject.transform.position.y, targetObject.transform.position.z + moveInc);
    }

    public void RotRight()
    {
        //this.transform.rotation = new Vector3(this.transform.rotation.z, this.transform.rotation.y + rotInc, this.transform.rotation.z);
        Vector3 rot = new Vector3(targetObject.transform.rotation.z, targetObject.transform.rotation.y - rotInc, targetObject.transform.rotation.z);
        targetObject.transform.Rotate(rot);
    }

    public void RotLeft()
    {
        //this.transform.rotation = new Vector3(this.transform.rotation.z, this.transform.rotation.y - rotInc, this.transform.rotation.z);
        Vector3 rot = new Vector3(targetObject.transform.rotation.z, targetObject.transform.rotation.y + rotInc, targetObject.transform.rotation.z);
        targetObject.transform.Rotate(rot);
    }

    public void Grow()
    {
        //this.transform.localScale = this.transform.localScale + new Vector3(scaleInc, scaleInc, scaleInc);
        targetObject.transform.localScale += new Vector3(scaleInc, scaleInc, scaleInc);
    }

    public void Shrink()
    {
        //this.transform.localScale = this.transform.localScale - new Vector3(scaleInc, scaleInc, scaleInc);
        //this.transform.localScale = new Vector3(this.transform.scale.x, this.transform.scale.y - scaleInc, this.transform.scale.z);
        targetObject.transform.localScale -= new Vector3(scaleInc, scaleInc, scaleInc);
    }


}
