using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StartAnimation");
    }

    IEnumerator StartAnimation()
    {
        yield return new WaitForSeconds(1f);
        animator.SetBool("isStarted", true);
        yield return null;
    }

    public void GoToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
