using System.Collections;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] float interactionDistance;

    private Camera cam;
    
    void Awake()
    {
        cam = Camera.main;
    }

    void Update()
    {
        PlayerRaycast();
    }

    private void PlayerRaycast()
    {
        RaycastHit hit;

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, interactionDistance))
        {
            BannerInteraction(hit);
        }
        Debug.DrawRay(cam.transform.position, cam.transform.forward * interactionDistance, Color.red);
    }
    private void BannerInteraction(RaycastHit hit)
    {
        if (hit.collider.gameObject.CompareTag("PlayInteraction"))
        {
            PlayableBanner banner = hit.collider.GetComponentInParent<PlayableBanner>();
            banner.PlayVideo();
        }
    }
}
