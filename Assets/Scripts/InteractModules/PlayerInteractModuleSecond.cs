using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractModuleSecond : BaseInteractModule
{
    [SerializeField] ParticleSystem particle;

    public override void Interact(GameObject obj)
    {
        if (obj != null)
        {
            Instantiate(particle, obj.transform.position, Quaternion.identity);
        }
    }
}
