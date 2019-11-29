using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGrid : MonoBehaviour {

    //public GameObject inputHandler;
    public GameObject prefab;

    public GameObject xParent;
    public GameObject yParent;
    public GameObject zParent;
    public GameObject axesParent;

    public Material matX;
    public Material matY;
    public Material matZ;
    public Material mat1;

    public float distance = 0.1f;

    // Use this for initialization
    void Start() {
        SpawnXPlane();
        SpawnYPlane();
        SpawnZPlane();
        SpawnAxes();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            ToggleXPlane();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            ToggleYPlane();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            ToggleZPlane();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            ToggleAxes();
        }
    }

    void SpawnXPlane() {

        for (int i = 0; i < 21; i++)
        {
            for (int j = 0; j < 21; j++)
            {
                //PLANE X
                GameObject point2 = Instantiate(
                    prefab,
                    xParent.gameObject.transform,
                    false
                );
                point2.transform.localPosition = new Vector3(
                        0,
                        (1 / xParent.transform.localScale.y) * ((-10f * distance) + (i * distance)),
                        (1 / xParent.transform.localScale.z) * ((-10f * distance) + (j * distance))
                );
                point2.GetComponent<Renderer>().material = matX;

            }

        }


    }

    void SpawnYPlane() {
        for (int i = 0; i < 21; i++)
        {
            for (int j = 0; j < 21; j++)
            {
                //PLANE Y
                GameObject point3 = Instantiate(
                    prefab,
                    yParent.gameObject.transform,
                    false
                );
                point3.transform.localPosition = new Vector3(
                        (1 / yParent.transform.localScale.x) * ((-10f * distance) + (i * distance)),
                        0,
                        (1 / yParent.transform.localScale.z) * ((-10f * distance) + (j * distance))
                );
                point3.GetComponent<Renderer>().material = matY;

            }

        }


    }

    void SpawnZPlane()
    {
        for (int i = 0; i < 21; i++)
        {
            for (int j = 0; j < 21; j++)
            {
                //PLANE Z
                GameObject point1 = Instantiate(
                    prefab,
                    zParent.gameObject.transform,
                    false
                );
                point1.transform.localPosition = new Vector3(
                        (1 / zParent.transform.localScale.x) * ((-10f * distance) + (i * distance)),
                        (1 / zParent.transform.localScale.y) * ((-10f * distance) + (j * distance)),
                        0
                );
                point1.GetComponent<Renderer>().material = matZ;

            }

        }


    }

    void SpawnAxes()
    {
        for (int i = 0; i<21; i++)
        {
            //AXES DOTS X
            GameObject point4 = Instantiate(
                prefab,
                axesParent.gameObject.transform,
                false
            );
            point4.transform.localPosition = new Vector3(
                    (1 / axesParent.transform.localScale.x) * ((-10f * distance) + (i * distance)),
                    0,
                    0
            );

            //AXES DOTS Y
            GameObject point5 = Instantiate(
                prefab,
                axesParent.gameObject.transform,
                false
            );
            point5.transform.localPosition = new Vector3(
                    0,
                    (1 / axesParent.transform.localScale.x) * ((-10f * distance) + (i * distance)),
                    0
            );

            //AXES DOTS Z
            GameObject point6 = Instantiate(
                prefab,
                axesParent.gameObject.transform,
                false
            );
            point6.transform.localPosition = new Vector3(
                    0,
                    0,
                    (1 / axesParent.transform.localScale.x) * ((-10f * distance) + (i * distance))
            );

            point4.GetComponent<Renderer>().material = mat1;
            point5.GetComponent<Renderer>().material = mat1;
            point6.GetComponent<Renderer>().material = mat1;
        }
    }



    public void ToggleXPlane()
    {
        if (xParent.activeSelf == true)
        {
                xParent.SetActive(false);
        }
        else
        {
                xParent.SetActive(true);
        }
    }

    public void ToggleYPlane()
    {
        if (yParent.activeSelf == true)
        {
            yParent.SetActive(false);
        }
        else
        {
            yParent.SetActive(true);
        }
    }

    public void ToggleZPlane()
    {
        if (zParent.activeSelf == true)
        {
            zParent.SetActive(false);
        }
        else
        {
            zParent.SetActive(true);
        }
    }

    public void ToggleAxes()
    {
        if (axesParent.activeSelf == true)
        {
            axesParent.SetActive(false);
        }
        else
        {
            axesParent.SetActive(true);
        }
    }




}
