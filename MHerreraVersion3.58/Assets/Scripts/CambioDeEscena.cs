using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class CambioDeEscena : MonoBehaviour
{
    public string sceneToLoad;

    public void ChangeScene(XRBaseInteractor interactor)
    {
        SceneManager.LoadScene(sceneToLoad);
    }

}
