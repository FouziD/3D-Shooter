using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public NavMeshAgent agent;
    public float squareOfMovement = 50f;
    private float xMin;
    private float zMin;
    private float xMax;
    private float zMax;
    private float xPosition;
    private float yPosition;
    private float zPosition;
    public float closeEnough = 2f;
    


    // Start is called before the first frame update
    void Start()
    {
        xMin = -squareOfMovement;
        zMin = -squareOfMovement;
        xMax = squareOfMovement;
        zMax = squareOfMovement;
        newLocation();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, new Vector3(xPosition, yPosition, zPosition))<= closeEnough)
        {
            newLocation();
        }
    }

    public void newLocation()
    {
        xPosition = Random.Range(xMin, xMax);
        yPosition = transform.position.y;
        zPosition  = Random.Range(zMin, zMax);
        agent.SetDestination(new Vector3(xPosition, yPosition, zPosition));
    }

}
