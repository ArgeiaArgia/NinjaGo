using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlackScene : MonoBehaviour
{
    public Image blackScne;
    public GameObject gOver;
    public GameObject retry;
    public GameObject finalScore;

    void Start()
    {
        blackScne = GetComponent<Image>();
    }

    void Update()
    {
    }
    IEnumerator FadeIn()
    {
        blackScne.color += new Color(0f, 0f, 0f, 0.3f);
        yield return new WaitForSecondsRealtime(0.2f);
        blackScne.color += new Color(0f, 0f, 0f, 0.3f);
        yield return new WaitForSecondsRealtime(0.2f);
        blackScne.color += new Color(0f, 0f, 0f, 0.3f);
        yield return new WaitForSecondsRealtime(0.2f);
        blackScne.color += new Color(0f, 0f, 0f, 0.1f);
        gOver.gameObject.SetActive(true);
        retry.gameObject.SetActive(true);
        finalScore.gameObject.SetActive(true);
    }
    public void FadeInStart()
    {
        StartCoroutine(FadeIn()); //수정해야함 
    }
}
