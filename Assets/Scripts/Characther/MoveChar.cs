using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChar : MonoBehaviour
{
    
    public GameObject p;
    [SerializeField] private TerrainSpawner terrainSpawner;
    bool ismoving;
    void Start()
    {
       ismoving = false;
    }
  
    void Update()
    {
        MovingChar();
    }

    private void MovingChar()

    {
        
        if (!ismoving)
        {
            float speed = 2f;
            transform.Translate(new Vector3(-speed*Time.deltaTime, 0, 0));

            if (Input.GetKeyDown(KeyCode.W))
            {
                ismoving = true;
                transform.Translate(new Vector3(-1, 0, 0));
            }

            else if  (Input.GetMouseButton(0))
            {
                    ismoving = true;
                if (Input.mousePosition.x > Screen.width / 2)
                    {     
                    transform.Translate(new Vector3(0, 0, speed*Time.deltaTime));
                    }
                    else
                 {
                    transform.Translate(new Vector3(0, 0, -speed*Time.deltaTime));
                  }
          
                }

                else if (Input.GetKeyDown(KeyCode.A))
            {
                transform.Translate(new Vector3(0, 0, -1));
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                transform.Translate(new Vector3(0, 0, 1));
            }
            ismoving = false;
        }
        terrainSpawner.CreateTerrain(false,transform.position);  
    }


  

    public void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.CompareTag("LogNew"))
        {
            Debug.LogError("de;ekcsa");
            transform.parent = colision.transform;
        }
        else
        {
            transform.parent = null;
        }
    }
      
}
