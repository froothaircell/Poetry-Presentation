using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstTitleTransition : MonoBehaviour
{

    public Animator transition;
    public float transitionTime = 3f;
    bool transComplete = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire3") && !transComplete)
        {
            StartCoroutine(TransitionCycle());
            transComplete = true;
        }
    }

    IEnumerator TransitionCycle()
    {
        transition.enabled = true;
        yield return new WaitForSeconds(transitionTime);
        FindObjectOfType<AudioManager>().PlaySound("Saloks of Sheikh Fareed");
        yield return new WaitForSeconds(1f);
        FindObjectOfType<AudioManager>().PlaySound("Dua Clip 2");
    }
}
