using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousScript : MonoBehaviour
{
    //[SerializeField]
    public Texture2D cursor;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.ForceSoftware);
    }



}