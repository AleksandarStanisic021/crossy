using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehRew : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject veh;


    public void Start()
    {
        StartCoroutine(DestroyVeh());
    }

    void Update()
    {
        transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
    }

    IEnumerator DestroyVeh()
    {
        GameObject car;
        car = veh;
        yield return new WaitForSeconds(12);
        Destroy(car);
    }
}