using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.PlayerLoop.EarlyUpdate;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    private int score;


    public GameObject[] targetprefabs;
//    private int spawnRate = 1;

    public Slider musicVolume;
    public AudioSource soundTrack;

    public GameObject GameOverScreen;
    public GameObject PausedScreen;
    public GameObject TitleScreen;
    public GameObject InGameUI;
    public GameObject StupidGameUI;

    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
 //       StartCoroutine(SpawnRandomiser());
 //       score = 0;
 //       ScoreUpdate(0);
 //       scoreText.text = ("nah bruv");

        soundTrack = GameObject.Find("Main Camera").GetComponent<AudioSource>();

        GameOverScreen.SetActive(false);
        Time.timeScale = 0;
        PausedScreen.SetActive(false);
        InGameUI.SetActive(false);
        TitleScreen.SetActive(true);




    }

    // Update is called once per frame
    void Update()
    {
        ChangeVolume();

        if (Input.GetKeyDown(KeyCode.P) && isPaused == false)
        {
            Time.timeScale = 0;
            isPaused = true;
            PausedScreen.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.P) && isPaused == true)
        {
            Time.timeScale = 1;
            isPaused = false;
            PausedScreen.SetActive(false);
        }
    }

 //   IEnumerator SpawnRandomiser()
 //   {
//        while (true)
 //       {
//            yield return new WaitForSeconds(spawnRate);
//            int targetIndex = Random.Range(0, targetprefabs.Length);
//            Instantiate(targetprefabs[targetIndex]);

            
 //       }

 //   }


//    public void ScoreUpdate(int scoreToAdd)
//    {
//        score += scoreToAdd;
//        scoreText.text = ("Score: " + score);

//    }

    public void ChangeVolume()
    {
        soundTrack.volume = musicVolume.value;
    }
   
    public void GameOver()
    {
        GameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        TitleScreen.SetActive(false);
        Time.timeScale = 1;
        InGameUI.SetActive(true);
    }

    public void StupidMode()
    {
        TitleScreen.SetActive(false);
        Time.timeScale = 1;
        StupidGameUI.SetActive(true);

    }
}
