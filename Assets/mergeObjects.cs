using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RuntimeGizmos;

public class mergeObjects : MonoBehaviour
{

    public TransformGizmo gizmo;
    public GameObject game;

    public void OnClick()
    {
        Debug.Log(gizmo);
        var root = Instantiate(game);
        root.transform.position = gizmo.targetRootsOrdered[0].position;

       for(int i = 0; i < gizmo.targetRootsOrdered.Count; i++)
        {
            gizmo.targetRootsOrdered[i].parent = root.transform;
        }

       
    }

}
