using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerDeath : MonoBehaviour
{
    public Player player;


    public AudioSource DeathSound;
    public GameObject LevelMusic;
    public GameObject CamFollow;
    public GameObject ThePlayer;

    public Lives Lives;

    private void OnTriggerEnter(Collider col)
    {
        // Decrease the global lives count
        Lives.LIVES -= 1;
        // Deactivate level music
        LevelMusic.SetActive(false);

        // Play death sound
        DeathSound.Play();

        // Disable the camera follow script
        CamFollow.GetComponent<CameraFollow>().enabled = false;

        // Disable player control and character components

        ThePlayer.GetComponent<CapsuleCollider>().enabled = false;

        // Reduce the player's scale
        ThePlayer.transform.localScale -= new Vector3(0.0f, 0.7f, 0.0f);

        // Start the coroutine to wait and transition to Game Over
        StartCoroutine(WaitAndGoToGameOver());
    }

    private IEnumerator WaitAndGoToGameOver()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(3);

        // Load the Game Over scene
        SceneManager.LoadScene("GameOverScene");
    }
}