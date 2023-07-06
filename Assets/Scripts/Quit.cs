using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{

public GameObject sair;
private bool ligado=false;

public void FimDaGameplay ()
    {
       Application.Quit();
    }
void Update()
{
    if (Input.GetButtonDown("Cancel") && ligado==false)
    {
        sair.SetActive(true);
        ligado=true;
    }
     if (Input.GetButtonDown("Cancel") && ligado==true)
    {
        sair.SetActive(false);
        ligado=false;
    }
    
}
}
