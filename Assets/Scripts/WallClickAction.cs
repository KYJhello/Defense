using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.SearchService;

public class WallClickAction : MonoBehaviour, IPointerClickHandler
{
    GameObject Door;
    //NavMeshObstacle nav;
    Vector3 doorPosition;

    private void Awake()
    {
        //nav = GetComponent<NavMeshObstacle>();
        Door = GameObject.FindGameObjectWithTag("Gate");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            //nav.enabled = false;

            doorPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Door.transform.position = doorPosition;// * Time.deltaTime * doorSpeed);
            Debug.Log("Left Clicked");
            //nav.enabled = true;
        }
        else if (eventData.button == PointerEventData.InputButton.Right)
        {
            //nav.enabled = false;
            doorPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + 3);
            Door.transform.position = doorPosition;// * Time.deltaTime * doorSpeed);

            Debug.Log("Right Clicked");
            //nav.enabled= true;
        }
    }
}
