using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    private EnemyMovement m_EnemyMovement;
    private Transform player;

    public float attackRange = 10f;

    public Material defaultMaterial;
    public Material attackMaterial;
    private Renderer rend;

    private bool foundPlayer;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        m_EnemyMovement = GetComponent<EnemyMovement>();
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.position) <= attackRange)
        {
            rend.sharedMaterial = attackMaterial;
            m_EnemyMovement.agent.SetDestination(player.position);
            foundPlayer = true;
        }else if (foundPlayer)
        {
            rend.sharedMaterial = defaultMaterial;
            m_EnemyMovement.newLocation();
            foundPlayer = false;
        }
        
    }
}
