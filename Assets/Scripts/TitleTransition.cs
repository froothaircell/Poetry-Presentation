using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleTransition : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        transition.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(2))
        {
            StartCoroutine(TransitionOut());
        }
    }

    IEnumerator TransitionOut()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
    }
}
