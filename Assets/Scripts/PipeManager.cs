using System.Collections.Generic;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    public static PipeManager Instance;

    [SerializeField] private List<GameObject> levelsPrefabs;
    [SerializeField] private GameObject terrainPrefab;

    private List<GameObject> pipes;
    private List<GameObject> toRemove;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    
        pipes = new List<GameObject>();
        toRemove = new List<GameObject>();

        pipes.Add(Instantiate(terrainPrefab, new Vector3(0.0f, 77.0f, 0.0f), Quaternion.identity));
        SpawnPipe(new Vector3(0.0f, 0.0f, 0.0f));

    }

    void Update()
    {
        for (int i = 0; i < pipes.Count; ++i)
        {
            if (pipes[i].transform.position.y > 400)
            { 
                toRemove.Add(pipes[i]);
            }
        }

        for (int i = 0; i < toRemove.Count; ++i)
        {
            Destroy(pipes[i]);
            pipes.Remove(toRemove[i]);
        }
        toRemove.Clear();
    }

    public void SpawnPipe(Vector3 position)
    {
        int index = Random.Range(0, levelsPrefabs.Count);
        pipes.Add(Instantiate(levelsPrefabs[index], position, Quaternion.Euler(new Vector3(0.0f, Random.Range(0.0f, 360.0f), 0.0f))));
    }

}
