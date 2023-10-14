using UnityEngine;

public class SlideUI : MonoBehaviour
{
    private bool isSlidingUp = false;
    private bool isSlidingDown = false;
    private RectTransform rectTransform;
    private Vector2 targetPositionUp = Vector2.zero;
    private Vector2 targetPositionDown;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        // Set the target position for sliding down (adjust the Y value as needed)
        targetPositionDown = new Vector2(0f, -1200f);
    }

    void Update()
    {
        if (isSlidingUp)
        {
            SlideUp();
        }
        else if (isSlidingDown)
        {
            SlideDown();
        }
    }

    void SlideUp()
    {
        rectTransform.anchoredPosition = Vector2.Lerp(rectTransform.anchoredPosition, targetPositionUp, Time.deltaTime * 10f);

        // Check if the UI is close enough to the target position
        if (Vector2.Distance(rectTransform.anchoredPosition, targetPositionUp) < 0.1f)
        {
            isSlidingUp = false;
        }
    }

    void SlideDown()
    {
        rectTransform.anchoredPosition = Vector2.Lerp(rectTransform.anchoredPosition, targetPositionDown, Time.deltaTime * 10f);

        // Check if the UI is close enough to the target position
        if (Vector2.Distance(rectTransform.anchoredPosition, targetPositionDown) < 0.1f)
        {
            isSlidingDown = false;
        }
    }

    public void SlideUpButtonClicked()
    {
        if (!isSlidingUp && !isSlidingDown)
        {
            isSlidingUp = true;
        }
    }

    public void SlideDownButtonClicked()
    {
        if (!isSlidingUp && !isSlidingDown)
        {
            isSlidingDown = true;
        }
    }
}