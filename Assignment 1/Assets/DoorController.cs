﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField]
    GameObject door;

    //bool isOpened = false;

    void OnTriggerEnter(Collider col)
    {
        //if (!isOpened)
        //{
        //    isOpened = true;
        //    door.transform.position += new Vector3(0, 7, 0);
        //}
        door.transform.position += new Vector3(0, 7, 0);
    }
}
