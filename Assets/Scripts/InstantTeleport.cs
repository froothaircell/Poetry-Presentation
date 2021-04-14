using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantTeleport : MonoBehaviour
{
    public GameObject player;
    public Transform destinationTransform;
    public GameObject UIElement;
    public float transitionTime = 2f;
    public string audioClip;
    bool isComplete = false;
    //Vector3 teleportDestination = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // teleportDestination = destinationTransform.position - Vector3.one;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && !isComplete)
        {
            //Debug.Log("this happens");
            //player.transform.position = destinationTransform.transform.position;
            StartCoroutine(TeleportAndTransition());
            isComplete = true;
        }
    }

    IEnumerator TeleportAndTransition()
    {
        UIElement.SetActive(true);
        yield return new WaitForSeconds(transitionTime);
        player.transform.position = destinationTransform.transform.position;
        if(audioClip != "none")
        {
            FindObjectOfType<AudioManager>().PlaySound(audioClip);
        }
    }

}
