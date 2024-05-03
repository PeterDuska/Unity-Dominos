using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void PlayPlayer()
    {
        if (Session.Instance != null)
        {
            Session.Instance.mode = 0;
            Session.Instance.scorePlayers = new int[2] {0, 0};
        }
        SceneManager.LoadScene("SampleScene");
    }


    public void PlayEasy()
    {
        if (Session.Instance != null)
        {
            Session.Instance.mode = 1;
            Session.Instance.scorePlayers = new int[2] {0, 0};
        }
        SceneManager.LoadScene("BotScene");
    }

    public void PlayMedium()
    {
        if (Session.Instance != null)
        {
            Session.Instance.mode = 2;
            Session.Instance.scorePlayers = new int[2] {0, 0};
        }
        SceneManager.LoadScene("BotScene");
    }

    public void PlayHard()
    {
        if (Session.Instance != null)
        {
            Session.Instance.mode = 3;
            Session.Instance.scorePlayers = new int[2] {0, 0};
        }
        SceneManager.LoadScene("BotScene");
    }
}
