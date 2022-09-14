using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapScript : MonoBehaviour
{
    public Transform XR_Rig;

    void LateUpdate()
    {
        Vector3 newPosition = XR_Rig.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        transform.rotation = Quaternion.Euler(90f, XR_Rig.eulerAngles.y, 0f);
    }

}
