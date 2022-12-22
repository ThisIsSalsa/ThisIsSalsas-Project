using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty GripAnimationAction;
    public Animator HandAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float triggerValue = pinchAnimationAction.action.ReadValue<float>();
       HandAnimator.SetFloat("Trigger",triggerValue);

       float GripValue = GripAnimationAction.action.ReadValue<float>();
       HandAnimator.SetFloat("Grip",GripValue);
      
    }
}
