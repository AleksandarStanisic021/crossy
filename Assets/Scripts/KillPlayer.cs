using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Im dead");
            Destroy(collision.gameObject);
            GameEnd();
        }
    }

    public void GameEnd()
    {
       SceneManager.LoadScene(0);
    }
}
