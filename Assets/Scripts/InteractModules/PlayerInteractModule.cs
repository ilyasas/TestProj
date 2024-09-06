using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractModule : BaseInteractModule
{
    public override void Interact(GameObject obj)
    {
        Debug.Log(obj);
        if (obj!=null)
        {
            Destroy(obj);
        }
    }
}
