using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    private float spawnz = -186f;
    public GameObject[] prefabs;
    private float RoadLength = 186f;
    private int amountOfRoads = 3;

    private List<GameObject> roadList;
    private Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        roadList = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        for (int i = 0; i < amountOfRoads; i++)
            SpawnRoad(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.z > (spawnz - amountOfRoads * RoadLength))
        {
            SpawnRoad(0);
            DeleteRoad();
        }
    }

    void SpawnRoad(int prefabIndex)
    {
        GameObject go;
        go = Instantiate(prefabs[prefabIndex]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * (spawnz - 186);
        spawnz += RoadLength;

        roadList.Add(go);
    }

    void DeleteRoad()
    {
        Destroy(roadList[0]);
        roadList.RemoveAt(0);
    }
}
