using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Scene1Manager : MonoBehaviour
{

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
        speak1.Play();
        StartCoroutine(Speak1dialog());
    }

    // Update is called once per frame

    public IEnumerator Speak1dialog()
    {
        
        while(speak1.isPlaying)
        {
            yield return null;
        }
        animator.SetInteger("Scene", 2);
        choice1.SetActive(true);

        yield return new WaitForSeconds(0.05f);

        animator.SetInteger("Scene", 1);
    }

    public void Speak2()
    {
        animator.SetInteger("Scene", 3);
        choice1.SetActive(false);
        postprocessing.enabled = !postprocessing.enabled;
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
