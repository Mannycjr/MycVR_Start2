using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class PlayerHand : MonoBehaviour
{
    public GameObject playerHandPrefab;
    public InputDeviceCharacteristics playerControllerCharacteristics;

    private InputDevice _playerDevice;
    private Animator _playerHandAnimator;
    
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
            _playerDevice = devices[0];

            GameObject newHand = Instantiate(playerHandPrefab, transform); // transform = parent's transform position
            _playerHandAnimator = newHand.GetComponent<Animator>(); // attach animator to new hand
        }

    }

    // Update is called once per frame
    void Update()
    {
        // Change Animate position or re-initialize
        if (_playerDevice.isValid)
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
        if (_playerDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue))
        {
            _playerHandAnimator.SetFloat("Trigger", triggerValue);
        }
        else
        {
            _playerHandAnimator.SetFloat("Trigger", 0);
        }

        if (_playerDevice.TryGetFeatureValue(CommonUsages.grip, out float gripValue))
        {
            _playerHandAnimator.SetFloat("Grip", gripValue);
        }
        else
        {
            _playerHandAnimator.SetFloat("Grip", 0);
        }

    }

}
