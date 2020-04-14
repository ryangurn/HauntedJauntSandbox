using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guidance : MonoBehaviour
{

    public GameObject exitBox;
    public GameObject player;

    Text m_text;

    float m_exitX, m_exitZ;

    void Start()
    {
        m_text = GetComponent<Text>();
        m_exitX = exitBox.transform.position[0];
        m_exitZ = exitBox.transform.position[2];
    }

    void Update()
    {
        string distanceToExit;
        int distance;
        float playerRotAngleRad, playerRotAngleDeg;
        float playerX = player.transform.position[0];
        float playerZ = player.transform.position[2];
        Vector2 playerRotNormalizedXZ = new Vector2();
        Vector2 playerToExitNormalizedXZ = new Vector2();
        float playerLook, angleToExit;

        
        distance = (int) Mathf.Sqrt(Mathf.Pow(m_exitX - playerX, 2) + Mathf.Pow(m_exitZ - playerZ, 2));
        distanceToExit = "Distance to exit: " + distance;

        playerRotAngleDeg = player.transform.rotation.eulerAngles[1];
        playerRotAngleRad = playerRotAngleDeg * Mathf.Deg2Rad;

        playerRotNormalizedXZ[0] = Mathf.Sin(playerRotAngleRad);
        playerRotNormalizedXZ[1] = Mathf.Cos(playerRotAngleRad);

        playerToExitNormalizedXZ[0] = m_exitX - playerX;
        playerToExitNormalizedXZ[1] = m_exitZ - playerZ;
        playerToExitNormalizedXZ.Normalize();


        playerLook = Mathf.Acos(playerRotNormalizedXZ[0] * playerToExitNormalizedXZ[0] + playerRotNormalizedXZ[1] * playerToExitNormalizedXZ[1]);


        angleToExit = (playerLook * Mathf.Rad2Deg);

        if (angleToExit <= 60)
        {
            m_text.text = distanceToExit + "\n" + "Hot";
        }
        else if (angleToExit <= 120)
        {
            m_text.text = distanceToExit + "\n" + "Warmer";
        }
        else
        {
            m_text.text = distanceToExit + "\n" + "Cold";
        }

    }
}
