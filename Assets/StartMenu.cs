using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Start is called before the first frame update
   private FaderScript fader;

    private void Start() {
        fader = GetComponent<FaderScript>();
    }

    // Start is called before the first frame update
    public void StartGame()
    {

        fader.BeginFade(1);
        StartCoroutine(ChangeLevel(3));

    }

    // Update is called once per frame
    public void ExitGame()
    {
        Application.Quit();

    }

    private IEnumerator ChangeLevel(int time) {
        var a = 0;
        while (a<time) {
            a++;
            yield return new WaitForSeconds(1.0f);
        }
        SceneManager.LoadScene(1);
    }
    
}
