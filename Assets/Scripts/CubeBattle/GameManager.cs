using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public Text textScore;
    public Text textLife;
    public Button buttonRestart;
    public static GameManager instance = null;

    void Start()
    {
        instance = this;

        GameObject canvas = GameObject.Find("Canvas");
        foreach(Transform t in canvas.transform.GetComponentInChildren<Transform>())
        {
            if(t.name.CompareTo("text_score") == 0)
                textScore = t.GetComponent<Text>();

            if(t.name.CompareTo("text_life") == 0)
                textLife = t.GetComponent<Text>();

            if(t.name.CompareTo("button_restart") == 0)
                buttonRestart = t.GetComponent<Button>();
        }

        buttonRestart.onClick.AddListener(delegate(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1;
        });
    }

    public void Restart()
    {
        Time.timeScale = 0;
        buttonRestart.gameObject.SetActive(true);
    }

    public void ChangeScore(int x)
    {
        score += x;
        textScore.text = "分数 " + score;
    }

    public void ChangeLife(int life)
    {
        textLife.text = "生命 " + life;
    }
}
