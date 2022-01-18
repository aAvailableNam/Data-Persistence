using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highScoreTable : MonoBehaviour
{
    [SerializeField] Transform entryTemplate;
    float templateHeight = 30;
    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 0; i < 5; i++)
        {
            Transform entryTransform = Instantiate(entryTemplate);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
            entryTransform.gameObject.SetActive(true);

            int rank = i + 1;
            string rankString;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
