using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneDirector : MonoBehaviour
{
    public void ToSceneChapter01()
    {
        SceneManager.LoadScene("EffectScene");
    }

    public void ToSceneChapter02()
    {
        SceneManager.LoadScene("exavator");
    }

    public void ToSceneChapter03()
    {
        SceneManager.LoadScene("oracle");
    }

    public void ToSceneChapter04()
    {
        SceneManager.LoadScene("SwipeCar");
    }

    public void ToSceneChapter05()
    {
        SceneManager.LoadScene("Arrow");
    }

    public void ToSceneChapter06()
    {
        SceneManager.LoadScene("GameSceneCat");
    }

    public void ToSceneChapter07()
    {
        SceneManager.LoadScene("GameSceneIgaguri");
    }
    public void ToSceneChapter08()
    {
        SceneManager.LoadScene("GameSceneApple");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
