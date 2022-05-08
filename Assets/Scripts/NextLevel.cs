using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public float timeToChangeLevel;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("Tocó el goal");
            StartCoroutine("ChangeToNextLevel");
        }
    }


    IEnumerator ChangeToNextLevel()
    {
        yield return new WaitForSeconds(timeToChangeLevel);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Next Level");
    }
}
