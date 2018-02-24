using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text;

[System.Serializable]
public static class SceneName
{
	public const string TITLE = "Title";
	public const string SCENE1 = "Scene1";
	public const string SCENE2 = "Scene2";
	public const string SCENE3 = "Scene3";
}

public class SceneController : SingletonMono<SceneController>
{
	public GameObject m_loadScreen;

	AsyncOperation m_async;
	StringBuilder m_sceneName;

	public string activeSceneName { get { return SceneManager.GetActiveScene ().name; } }

	public bool IsPlaying { get; set; }
	public bool IsPlayScene { get { return activeSceneName.IndexOf ("Stage") >= 0; } }
	public bool NotSelectScene { get { return activeSceneName != "StageSelect"; } }

	public int stageNum{ get; set; }

	private void Start ()
	{
		m_sceneName = new StringBuilder ();
	}

	// Scene.Instanse.LoadSceneTest(SceneName.****)
	public void LoadScene (string sceneName)
	{
		m_sceneName.Length = 0;
		m_sceneName.Append (sceneName);
		StartCoroutine (LoadStart ());
	}

	public void ReloadScene() {
		m_sceneName.Length = 0;
		m_sceneName.Append (activeSceneName);
		StartCoroutine (LoadStart ());
	}

	IEnumerator LoadStart ()
	{
		IsPlaying = false;
		m_async = SceneManager.LoadSceneAsync (m_sceneName.ToString ());
		m_async.allowSceneActivation = false;
		yield return null/*FideIn*/;
		m_async.allowSceneActivation = true;
	}

	public void StageInit(){
		IsPlaying = true;
		var activeScene = SceneManager.GetActiveScene ();
		stageNum = activeScene.buildIndex - 2;
	}

}
