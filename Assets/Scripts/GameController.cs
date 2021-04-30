using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private int totalClues;
    private int collectedClues;
    // Start is called before the first frame update
    void Start()
    {
        totalClues = 5;
        collectedClues = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (collectedClues == totalClues || Input.GetKeyDown(KeyCode.P))
        {
            StartCoroutine(EndGame());
        }
    }

    public void CollectClue()
    {
        collectedClues++;
        Debug.Log("Clue collected: " + collectedClues + " / " + totalClues);
    }

    public int GetNumCollectedClues()
    {
        return collectedClues;
    }

    IEnumerator EndGame()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene("Decision");
    }
}
