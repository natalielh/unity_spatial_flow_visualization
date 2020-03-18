using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCityGrid : MonoBehaviour {

    public GameObject prefab;
    public float distance = 0.1f;
    public int num = 20;

    // Use this for initialization
    void Start()
    {
        SpawnGridPlane();

    }


    void SpawnGridPlane()
    {

        for (int i = 0; i < num+1; i++)
        {
            for (int j = 0; j < num+1; j++)
            {
                //PLANE X
                GameObject point2 = Instantiate(
                    prefab,
                    gameObject.transform,
                    false
                );
                point2.transform.localPosition = new Vector3(
                        (1 / transform.localScale.x) * ((-num/2 * distance) + (i * distance)),
                        0,
                        (1 / transform.localScale.z) * ((-num/2 * distance) + (j * distance))
                );

            }

        }

    }



}
