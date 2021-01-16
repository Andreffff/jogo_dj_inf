using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC2Dest : MonoBehaviour
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
                this.gameObject.transform.position = new Vector3(-20, 0, -17);
                pivotPoint = 5;
            }

            if (pivotPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(-20, 0, -5);
                pivotPoint = 4;
            }
            if (pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(37, 0, -2);
                pivotPoint = 3;
            }
            if (pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(45, 0, 4);
                pivotPoint = 2;
            }
            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(20, 0, 4);
                pivotPoint = 1;
            }
        }
    }
}
