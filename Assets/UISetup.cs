using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class UISetup : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI refKeyText;

    private void Awake()
    {
        BaseInteractModule.showPrompt += DisplayPrompt;
        BaseInteractModule.hidePrompt += HidePrompt;

        refKeyText.text = (new InputMap().Player.Interact.bindings[0].effectivePath).Split("/")[^1].ToUpper();
    }

    private void DisplayPrompt()
    {
        refKeyText.enabled = true;
    }

    private void HidePrompt()
    {
        refKeyText.enabled = false;
    }
}
