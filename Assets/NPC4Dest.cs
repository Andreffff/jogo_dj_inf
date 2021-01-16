using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC4Dest : MonoBehaviour
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
                this.gameObject.transform.position = new Vector3(-1, 0, -23);
                pivotPoint = 5;
            }

            if (pivotPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(-64, 0, 6);
                pivotPoint = 4;
            }
            if (pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(-48, 0, 2);
                pivotPoint = 3;
            }
            if (pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(-23, 0, -14);
                pivotPoint = 2;
            }
            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(-31, 0, 21);
                pivotPoint = 1;
            }
        }
    }
}
