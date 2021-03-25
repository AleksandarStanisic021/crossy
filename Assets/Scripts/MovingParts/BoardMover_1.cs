using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMover_1 : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] GameObject board;
    




    void Update()
    {
        transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime);
    }

    IEnumerator DestroyBoard()
    {
        GameObject board_destroyable;
        board_destroyable = board;
        yield return new WaitForSeconds(12);
        Destroy(board_destroyable);
    }
}
