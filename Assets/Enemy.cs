using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Unity.Entities;

public class Enemy : MonoBehaviour
{
    public Transform playerPosition;
}


class EnemySystem : ComponentSystem
{
    struct EnemyComponents
    {
        public Enemy enemy;
        public NavMeshAgent agent;
    }
    protected override void OnUpdate()
    {
        foreach (var e in GetEntities<EnemyComponents>())
        {
            e.agent.SetDestination(e.enemy.playerPosition.position);
        }
    }
}