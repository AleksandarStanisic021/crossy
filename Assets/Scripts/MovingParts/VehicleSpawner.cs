using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
 
    [SerializeField] private GameObject vehicle;
    [SerializeField] private Transform spawnpos;

    [SerializeField] private float minTime;
    [SerializeField] private float maxTime;

    public void Start()
    {
       
        
        StartCoroutine(VSpawner());
    }

    private IEnumerator VSpawner()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            Instantiate(vehicle, spawnpos.position, Quaternion.identity);
        }
    }

}
