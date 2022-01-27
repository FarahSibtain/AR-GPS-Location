using ARLocation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowModel : MonoBehaviour
{
    [SerializeField]
    Transform GPSObj = null;

    [SerializeField]
    Text text = null;

    public void FindAndSetModelHierarchy(int count)
    {
        GameObject model = GameObject.Find("1");
        model.transform.SetParent(GPSObj);
        text.text = "Count: " + count;

        PlaceAtLocation placeAtLocation = GPSObj.gameObject.GetComponent<PlaceAtLocation>();
        placeAtLocation.enabled = true;
    }
}
