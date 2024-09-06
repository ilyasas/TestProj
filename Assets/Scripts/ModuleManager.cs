using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleManager : MonoBehaviour
{
    private BaseMoveModule[] moveModules;
    private BaseInteractModule[] interactModules;
   
    void Awake()
    {
        moveModules = GetComponents<BaseMoveModule>();
        interactModules = GetComponents<BaseInteractModule>();
    }

    public void Move(Vector2 dir)
    {
        foreach (BaseMoveModule mod in moveModules)
        {
            if (mod.enabled)
            {
                mod.Move(dir);
            }
        }
    }    
    
    public void Interact()
    {
        foreach (BaseInteractModule mod in interactModules)
        {
            if (mod.enabled)
            {
                mod.Interact(mod.FindInteractable());
            }
        }
    }
}
