using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC7Dest : MonoBehaviour
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
                this.gameObject.transform.position = new Vector3(-2, 12, -34);
                pivotPoint = 5;
            }

            if (pivotPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(-22, 12, -34);
                pivotPoint = 4;
            }
            if (pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(-35, 12, -24);
                pivotPoint = 3;
            }
            if (pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(-59, 12, -10);
                pivotPoint = 2;
            }
            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(-45, 12, -67);
                pivotPoint = 1;
            }
        }
    }
}
