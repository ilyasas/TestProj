using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,Camera.main.transform.rotation.eulerAngles.y,0);
    }
}
