using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorardSpawner : MonoBehaviour
{

    [SerializeField] private GameObject board;
    [SerializeField] private Transform spawnpos;

    [SerializeField] private float minTime;
    [SerializeField] private float maxTime;


    public void Start()
    {
        StartCoroutine(BoardSpawner());
    }

    private IEnumerator BoardSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minTime,maxTime));
            Instantiate(board, spawnpos.position, Quaternion.identity);
        }
    }

}

