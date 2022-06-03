using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayArea : MonoBehaviour
{
    public static PlayArea Instance;

    void Awake()
    {
        Instance = this;
    }

    [SerializeField] BoxCollider collider; 


    public Vector3 GetRandomPosition()
    {
        Vector3 center = collider.center + transform.position;

        float minX = center.x - collider.size.x / 2f;
        float maxX = center.x + collider.size.x / 2f;

        float minY = center.y - collider.size.y / 2f;
        float maxY = center.y + collider.size.y / 2f;

        float minZ = center.z - collider.size.z / 2f;
        float maxZ = center.z + collider.size.z / 2f;

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        float randomZ = Random.Range(minZ, maxZ);

        Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);

        return randomPosition;
    }
}
