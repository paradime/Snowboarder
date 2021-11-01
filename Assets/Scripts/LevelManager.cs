using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] protected float restartDelay = 2f;
    private void RestartScene()
    {
        SceneManager.LoadScene(0);
    }
}
