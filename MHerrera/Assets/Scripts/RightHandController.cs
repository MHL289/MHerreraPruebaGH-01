using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class RightHandController : MonoBehaviour
{

    //estado de la palanaca
    public InputActionReference JoyStick_North_Reference;
    //Grab
    [Space(20)]
    public XRRayInteractor xrRayInteractor_grab;
    public ActionBasedController actionBasedController_grab;
    public LineRenderer lineRenderer_grab; 
    public XRInteractorLineVisual xrInteractorLineVisual_grab;
    //rIGTH cONTROLLER Teleport
    [Space(20)]
    public XRRayInteractor xrRayInteractor_teleport;
    public ActionBasedController actionBasedController_teleport;
    public LineRenderer lineRenderer_teleport;
    public XRInteractorLineVisual xrInteractorLineVisual_teleport;
  
   
    //Métodos

    private void JoyStickArribaPresionado(InputAction.CallbackContext context)
    {
            xrRayInteractor_grab.enabled=false;
            xrRayInteractor_teleport.enabled = true;
        xrInteractorLineVisual_teleport.enabled = true;
    }
    private void JoyStickArribaLiberado(InputAction.CallbackContext context) 
    {
        xrRayInteractor_grab.enabled = true;
        xrRayInteractor_teleport.enabled = false;
        xrInteractorLineVisual_teleport.enabled = false;
    }

    private void OnEnable()
    {
        JoyStick_North_Reference.action.performed += JoyStickArribaPresionado;
        JoyStick_North_Reference.action.canceled += JoyStickArribaLiberado;
    }



    private void OnDisable()
    {
        JoyStick_North_Reference.action.performed -= JoyStickArribaPresionado;
        JoyStick_North_Reference.action.canceled -= JoyStickArribaLiberado;
    }

}
