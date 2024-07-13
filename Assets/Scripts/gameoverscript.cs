using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class gameoverscript : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(LoadNextLevel());
    }
        
    private IEnumerator LoadNextLevel()
    {
        yield return new WaitForSeconds(4);

        Application.LoadLevel(0);
    }
}