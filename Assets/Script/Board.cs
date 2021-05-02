using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{

    public GameObject Plane;
    public GameObject[,] Planes;

    void Start()
    {
        Planes = new GameObject[8, 8];

        for(int x = 0; x < 8; x++)
        {
            for (int y = 0; y < 8; y++)
            {
                Planes[x, y] = Instantiate(Plane);
                Planes[x, y].transform.position = new Vector3(x-3.5f, 0f, y-3.5f);
                Planes[x, y].transform.SetParent(this.gameObject.transform);
            }
        }
    }
}
