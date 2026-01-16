using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float moveFB;
    private float moveLR;
    private float rotX;
    private float rotY;

    private Camera playerCam;
    private CharacterController cc;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cc = GetComponent<CharacterController>();
        playerCam = transform.GetChild(0).GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
