using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerHand : MonoBehaviour
{
    public GameObject playerHandPrefab;
    public InputDeviceCharacteristics playerControllerCharacteristics;

    private InputDevice playerDevice;
    
    // Start is called before the first frame update
    void Start()
    {
        InitializePlayerHand();
    }

    void InitializePlayerHand()
    {
        //check for our controller's characteristics
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(playerControllerCharacteristics, devices);

        //If Device identified, Instantiate a Hand
        if (devices.Count > 0)
        {
            playerDevice = devices[0];

            GameObject newHand = Instantiate(playerHandPrefab, transform); // transform = parent's transform position
        }

    }

    // Update is called once per frame
    void Update()
    {
        // Change Animate position or re-initialize
        if (playerDevice.isValid)
        {
            UpdatePlayerHand();
        } 
        else
        {
            InitializePlayerHand();
        }
    }

    void UpdatePlayerHand()
    {
        if (playerDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            Debug.Log("Trigger Value =" + triggerValue);
        }
        else
        {
            Debug.Log("Trigger not Active");
        }

        if (playerDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            Debug.Log("Grip Value =" + gripValue);
        }
        else
        {
            Debug.Log("Grip not Active");
        }

    }

}
