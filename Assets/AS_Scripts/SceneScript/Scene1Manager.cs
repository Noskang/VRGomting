using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Scene1Manager : MonoBehaviour
{
    public float startdelay;
    public float speak1delay;
    public float choice1delay;
    public float postprocessdelay;
    public float speak2delay;
    public float choice2delay;
    public Animator animator;
    public AudioSource speak1;
    public AudioSource speak2;
    public AudioSource bgm1;
    public GameObject choice1;
    public GameObject choice2;
    public Volume postprocessing;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Start(startdelay));
    }

    public IEnumerator Start(float delay)
    {
        yield return new WaitForSeconds(delay);
        speak1.Play();
        StartCoroutine(Speak1dialog());
    }

    // Update is called once per frame

    public IEnumerator Speak1dialog()
    {
        yield return new WaitForSeconds(speak1delay);
        animator.SetInteger("Scene", 2);
        

        yield return new WaitForSeconds(0.01f);
        animator.SetInteger("Scene", 1);
        yield return new WaitForSeconds(choice1delay);
        choice1.SetActive(true);
    }

    public void YesbuttonClick()
    {
        choice1.SetActive(false);
        bgm1.Play();
        StartCoroutine(YesbuttonClick(postprocessdelay));
    }

    public IEnumerator YesbuttonClick(float delay)
    {
        yield return new WaitForSeconds(delay);
        postprocessing.enabled = !postprocessing.enabled;

    }


    public void Speak2()
    {
        animator.SetInteger("Scene", 3);
        
        
        speak2.Play();
        StartCoroutine(Speak2dialog());
    }

    public IEnumerator Speak2dialog()
    {
        while (speak2.isPlaying)
        {
            yield return null;
        }

        choice2.SetActive(true);

    }
}
