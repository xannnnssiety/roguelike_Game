using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame1()
    {
        SceneManager.LoadScene(1);
    }

    public void StartGame2()
    {
        SceneManager.LoadScene(2);
    }

    public void StartGame3()
    {
        SceneManager.LoadScene(3);
    }

    public void StartGame4()
    {
        SceneManager.LoadScene(4);
    }

    public void StartGameInf()
    {
        SceneManager.LoadScene(5);
    }

    public void StartGame6()
    {
        SceneManager.LoadScene(6);
    }
}
