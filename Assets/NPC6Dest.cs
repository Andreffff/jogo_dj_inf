using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC6Dest : MonoBehaviour
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
                this.gameObject.transform.position = new Vector3(5, 12, -61);
                pivotPoint = 5;
            }

            if (pivotPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(51, 12, -41);
                pivotPoint = 4;
            }
            if (pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(58, 12, -20);
                pivotPoint = 3;
            }
            if (pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(58, 12, -11);
                pivotPoint = 2;
            }
            if (pivotPoint == 0)
            {
                this.gameObject.transform.position = new Vector3(32, 12, -26);
                pivotPoint = 1;
            }
        }
    }
}
