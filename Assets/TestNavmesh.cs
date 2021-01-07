using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TestNavmesh : MonoBehaviour
{

    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(new Vector3(0, 0.5f, 26));
            }

    // Update is called once per frame
    void Update()
    {
        
    }
}
