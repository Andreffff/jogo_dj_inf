using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC5Dest : MonoBehaviour
{
   
    public int pivotPoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "NPC")
        {
            if (pivotPoint == 5)
            {
                pivotPoint = 0;
            }
            if (pivotPoint == 4)
            {
                this.gameObject.transform.position = new Vector3(-30, 0, -17);
                pivotPoint = 5;
            }

            if (pivotPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(50, 0, -16);
                pivotPoint = 4;
            }
            if (pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(-50, 0, -16);
                pivotPoint = 3;
            }
            if (pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(-45, 0, -16);
                pivotPoint = 2;
            }
            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(43, 0, -7);
                pivotPoint = 1;
            }
        }
    }
}
