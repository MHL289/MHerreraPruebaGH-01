using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CambiarColor : MonoBehaviour
{
    private Renderer rend;

    public Color nuevoColor = Color.green;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    public void AlSeleccionar(BaseInteractionEventArgs args)
    {
        if (rend != null)
        {
            rend.material.color = nuevoColor;
        }
        
    }
  
       
    

}
