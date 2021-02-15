using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Transition : SingletonMonoBehaviour<Transition>
{

    [SerializeField]
    private Material _transitionIn;
    [SerializeField]
    GameObject FadeCanvas;
    public void Awake()
    {

        if (this != Instance)
        {
            Destroy(this);
            return;
        }

        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(FadeCanvas);

       
    }
    void Start()
    {
        _transitionIn.SetFloat("_Alpha", 0);
    }
    private void Update()
    {
        
    }

    public void LoadLevel(string scene, float interval)
    {
        StartCoroutine(SceneTransition(scene, interval));
    }

    IEnumerator SceneTransition(string scene, float interval)
    {
        yield return Animate(_transitionIn, interval);
        SceneManager.LoadScene(scene);
        yield return AnimateIn(_transitionIn, interval);

    }
    IEnumerator BeginTransition()
    {
        yield return Animate(_transitionIn, 1.5f);
    }

    /// <summary>
    /// time秒かけてトランジションを行う
    /// </summary>
    /// <param name="time"></param>
    /// <returns></returns>
    IEnumerator Animate(Material material, float time)
    {
        GetComponent<Image>().material = material;
        float current = 0;
        while (current < time)
        {
            material.SetFloat("_Alpha", current / time);
            yield return new WaitForEndOfFrame();
            current += Time.deltaTime;
        }
        material.SetFloat("_Alpha", 1);
    }
    IEnumerator AnimateIn(Material material, float time)
    {
        GetComponent<Image>().material = material;
        float current = 0;
        while (current < time)
        {
            material.SetFloat("_Alpha", 1-current / time);
            yield return new WaitForEndOfFrame();
            current += Time.deltaTime;
        }
        material.SetFloat("_Alpha", 0);
    }
}