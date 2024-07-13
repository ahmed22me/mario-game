using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu : MonoBehaviour
{
    public void StartGame()
    {
        Application.LoadLevel(1);
    }

    //public void OpenSettings()
    //{
    //    // Implement settings logic here
    //}

    public void ExitGame()
    {
        Application.Quit();
    }
}
