using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject cursor;
    private void Start()
    {
        Instantiate(cursor, new Vector3(0, 0, 0), Quaternion.identity);
        Debug.Log("Awake");
    }
}


