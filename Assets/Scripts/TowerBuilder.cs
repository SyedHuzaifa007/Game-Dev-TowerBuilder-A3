using UnityEngine;
using TMPro;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private GameObject blockPrefab;
    [SerializeField] private float spawnOffset = 1f;
    [SerializeField] private float swayForce = 1f;
    [SerializeField] private float maxTiltAngle = 30f;
    [SerializeField] private TextMeshProUGUI scoreText;

    private Transform lastBlock;
    private int score = 0;
    private bool isGameOver = false;

   void Update()
{
    if (isGameOver) return;

    if (Input.GetMouseButtonDown(0))
    {
        HandleInput(Input.mousePosition);
    }
    else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
    {
        HandleInput(Input.GetTouch(0).position);
    }

    CheckTilt();
}


    void HandleInput(Vector2 screenPos)
    {
        Ray ray = Camera.main.ScreenPointToRay(screenPos);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            SpawnBlock(hit.point);
        }
    }

    void SpawnBlock(Vector3 position)
    {
        Vector3 spawnPos = position + Vector3.up * spawnOffset;
        GameObject block = Instantiate(blockPrefab, spawnPos, Quaternion.identity);
        RandomizeBlock(block);
        lastBlock = block.transform;
        score++;
        UpdateScoreText();
    }

    void RandomizeBlock(GameObject block)
    {
        float scaleX = Random.Range(0.8f, 1.2f);
        float scaleZ = Random.Range(0.8f, 1.2f);
        block.transform.localScale = new Vector3(scaleX, 1f, scaleZ);
        block.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    void CheckTilt()
    {
        if (!lastBlock) return;

        float angle = Vector3.Angle(Vector3.up, lastBlock.up);
        if (angle > maxTiltAngle)
        {
            isGameOver = true;
            Debug.Log("Game Over! Score: " + score);
            Time.timeScale = 0.3f;
            Invoke(nameof(ResetGame), 2f);
        }
    }

    void ResetGame()
    {
        foreach (var obj in GameObject.FindGameObjectsWithTag("Block"))
        {
            Destroy(obj);
        }

        score = 0;
        UpdateScoreText();
        Time.timeScale = 1f;
        isGameOver = false;
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }

    public void ReplayGame() => ResetGame();
}
