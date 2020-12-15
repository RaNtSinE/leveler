using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RuntimeGizmos;

public class chaneGizmoType : MonoBehaviour
{

    public TransformGizmo gizmo;
    public TransformType transformType = TransformType.Move;

    public void onClick()
    {
        gizmo.transformType = this.transformType;
    }
}
