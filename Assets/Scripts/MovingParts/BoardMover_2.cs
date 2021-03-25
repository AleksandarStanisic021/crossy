using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMover_2 : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject board;

    public void Start()
    {
        StartCoroutine(DestroyBoard());
    }




    void Update()
    {
        transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }

    IEnumerator DestroyBoard()
    {
        GameObject board_destroyable;
        board_destroyable = board;
        yield return new WaitForSeconds(20);
        Destroy(board_destroyable);
    }
}
