using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject objFinish;
    public GameObject objFail;

    public bool Dead;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Finish();
        }
    }

    void Finish()
    {
        objFinish.SetActive(true);
        Time.timeScale = 0;
    }

    public void GameOver()
    {
        objFail.SetActive(true);
        Time.timeScale = 0;
    }

    public void pindahScene(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
}
