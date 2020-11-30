using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public void MoveMain()
    {
        SceneManager.LoadScene("Main_game");
    }

    public void MoveStart()
    {
        SceneManager.LoadScene("start");

    }

}
