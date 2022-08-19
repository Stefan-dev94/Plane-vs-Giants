using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonShoot : MonoBehaviour
{
    public UnityEvent ButtonClick;

    private void Awake()
    {
        if(ButtonClick == null)
        {
            ButtonClick = new UnityEvent();
        }
    }
    private void OnMouseDrag()
    {
        ButtonClick.Invoke();
    }
    
}
