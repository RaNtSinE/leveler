using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addCube : MonoBehaviour
{

    public GameObject spawnObject;
    
    public void AddObject()
    {
        Instantiate(spawnObject);    
    }
}
