using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderController : MonoBehaviour
{
    public Light pointLightGreen;

    private void OnTriggerEnter(Collider obj)
    {
        SaveManager save = FindObjectOfType<SaveManager>();

        if (obj.tag == "PlayerController" && pointLightGreen.enabled == true)
        {
            save.IncreaseError("No pases la cebra cuando el semáforo está en verde para los carros bro");
        }
    }
}
