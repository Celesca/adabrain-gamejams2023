using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    // Reference to the PlayableDirector component on the timeline GameObject
    public PlayableDirector playableDirector;

    private void Start()
    {
        // Register a callback method to be called when the timeline is finished
        playableDirector.stopped += OnTimelineFinished;
    }

    // Method called when the timeline is finished
    private void OnTimelineFinished(PlayableDirector aDirector)
    {
        // Check if the finished director is the one we're interested in
        if (aDirector == playableDirector)
        {
            // Load the next scene
            LoadNextScene();
        }
    }

    // Method to load the next scene
    private void LoadNextScene()
    {
        // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Load the next scene (you can customize this logic based on your scene setup)
        SceneManager.LoadSceneAsync(2);
    }
}