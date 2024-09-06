using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using TMPro;

public abstract class BaseInteractModule : MonoBehaviour
{
    [SerializeField] float radius;
    private bool isPrompt;
    public static event Action showPrompt;
    public static event Action hidePrompt;

    public abstract void Interact(GameObject obj);

    public virtual GameObject FindInteractable()
    {
        Collider[] hitResult = Physics.OverlapSphere(transform.position, radius, LayerMask.GetMask("Interactable"));
        if (hitResult.Length > 0)
        {
            return hitResult[0].gameObject;
        }
        else return null;
    }

    private void FixedUpdate()
    {
        if(FindInteractable()!=null)
        {
            if(isPrompt == false)
            {
                showPrompt?.Invoke();
                isPrompt = true;
            }               
        }
        else
        {
            if (isPrompt == true)
            {
                hidePrompt?.Invoke();
                isPrompt = false;
            }
        }
    }
}
