using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    
    // Use this for initialization
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        InitGame();
    }

    void InitGame()
    {
        //SetupScene(level);
    }

    public void GameOver()
    {
        //
    }

    // Update is called once per frame
    void Update()
    {

    }
}
