﻿using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField]
    float _updateInterval_ms = 500;

    [SerializeField]
    float _enemyRemovalDistance = 32;      // How far away Enemy must be from player before it is destroyed (Overworld only)


    Transform _enemiesContainer;
    float _enemyRemovalDistanceSq;


    void Start()
    {
        _enemiesContainer = GameObject.Find("Enemies").transform;
        _enemyRemovalDistanceSq = _enemyRemovalDistance * _enemyRemovalDistance;

        InvokeRepeating("Tick", 0, _updateInterval_ms * 0.001f);
    }


    void Tick()
    {
        foreach (EnemySpawnPoint sp in GetComponentsInChildren<EnemySpawnPoint>())
        {
            sp.DoUpdate();
        }

        Vector3 playerPos = CommonObjects.Player_C.Position;

        foreach (Transform child in _enemiesContainer)
        {
            Vector3 toPlayer = playerPos - child.position;
            float distToPlayerSqr = toPlayer.sqrMagnitude;
            if (distToPlayerSqr > _enemyRemovalDistanceSq)
            {
                Destroy(child.gameObject);
            }
        }
    }
}