using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaControlador : MonoBehaviour
{

    public Animator animator;



    private void Awake()
    {
        //SetBool, GetBool, GetInt, SetTrigger, ResetTrigger
        animator.SetBool("Abrir", false);
    }




    public void AbrirCerrarPuerta()
    {
        //animator.SetBool("Abrir", !animator.GetBool("Abrir"));  <------- Manera reducida de cerrar o abrir la puerta

        animator.GetBool("Abrir"); //Valor actual: False
        bool Estado_Puerta = animator.GetBool("Abrir");
        if (Estado_Puerta == true)
        {
            animator.SetBool("Abrir", false);

        }
        else
        {
            animator.SetBool("Abrir", true);
        }
    }

}
