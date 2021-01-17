using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC8Dest : MonoBehaviour
{
    public int pivotPoint;

    void OnTriggerEnter(Collider other)
    {
        if (pivotPoint == 2)
        {
            this.gameObject.transform.position = new Vector3(0, 17, -60);
            pivotPoint = 0;
        }
        if (pivotPoint == 1)
        {
            this.gameObject.transform.position = new Vector3(0, 17, -41);
            pivotPoint = 2;
        }
        if (pivotPoint == 0)
        {
            this.gameObject.transform.position = new Vector3(0, 17, -21);
            pivotPoint = 1;
        }
    }

}
