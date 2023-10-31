using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadOnePlayer()
    {
        SceneManager.LoadScene("ballNormal1");
    }

    public void loadTwoPlayer()
    {
        SceneManager.LoadScene("ballNormal2");
    }
    public void loadSpecial()
    {
        SceneManager.LoadScene("ball");
    }
}
