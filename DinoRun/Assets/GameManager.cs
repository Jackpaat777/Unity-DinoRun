using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Level(int score)
    {
        // 초기 스피드는 -5
        int defaultSpeed = -5;
        // score가 100이 늘어날때마다 증가스피드는 -1씩 늘어남
        int increSpeed = (score * -1) / 100;

        // 증가스피드의 최대값은 -5
        if (increSpeed < -5)
            increSpeed = -5;

        // 스피드는 -5 ~ -10까지 설정됨
        return defaultSpeed + increSpeed;
    }
}
