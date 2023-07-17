using System.Collections;
using System.Reflection;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.Video;
using YoutubePlayer;

public class PlayableBanner : MonoBehaviour
{
    [SerializeField] private string youtubeLink;
    [SerializeField] private GameObject screenLight;
    [SerializeField] private GameObject playGO;
    [SerializeField] private GameObject loadingGO;

    private RawImage banner;

    private VideoPlayer videoPlayer;
    private YoutubePlayer.YoutubePlayer youtubePlayer;

    private RenderTextureReset renderReset;
    
    private PlayableBanner[] playableBanners;
    private bool isPlaying;

    private readonly string youtubeThumbPrefix = "https://img.youtube.com/vi/";
    private readonly string hdSuffix = "/maxresdefault.jpg";
    private readonly string sdSuffix = "/0.jpg";

    private void Awake()
    {
        InitializeComponents();
     
        StartCoroutine(GetThumbnail(hdSuffix));
    }

    private void InitializeComponents()
    {
        banner = GetComponentInChildren<RawImage>();

        playableBanners = FindObjectsOfType<PlayableBanner>();

        renderReset = FindObjectOfType<RenderTextureReset>();
     
        videoPlayer = FindObjectOfType<VideoPlayer>();
        youtubePlayer = videoPlayer.GetComponent<YoutubePlayer.YoutubePlayer>();
    }

    public IEnumerator GetThumbnail(string suffix)
    {
        string youtubeId = youtubeLink.Substring(youtubeLink.LastIndexOf("v=") + 2);

        string url = youtubeThumbPrefix + youtubeId + suffix;

        UnityWebRequest youtubeRequest = UnityWebRequestTexture.GetTexture(url);

        yield return youtubeRequest.SendWebRequest();

        if (youtubeRequest.result != UnityWebRequest.Result.Success)
        {
            if (suffix != hdSuffix)
            {
                Debug.Log(youtubeRequest.error);
                yield break;
            }

            StartCoroutine(GetThumbnail(sdSuffix));
        }
        else
        {
            banner.texture = ((DownloadHandlerTexture)youtubeRequest.downloadHandler).texture;
        }
    }


    public async void PlayVideo()
    {
        if (isPlaying)
            return;

        foreach (PlayableBanner banner in playableBanners)
        {
            banner.ResetVideoSettings();
        }

        renderReset.ClearOutRenderTexture();

        isPlaying = true;
        loadingGO.SetActive(true);
        playGO.SetActive(false);

        await youtubePlayer.PlayVideoAsync(youtubeLink);

        screenLight.SetActive(true);
        loadingGO.SetActive(false);
        playGO.SetActive(true);
    }

    private void ResetVideoSettings()
    {
        isPlaying = false;
        playGO.SetActive(true);
        screenLight.SetActive(false);

        if (videoPlayer.isPlaying)
            videoPlayer.Stop();
    }
}
