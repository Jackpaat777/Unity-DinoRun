using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Level(int score)
    {
        // �ʱ� ���ǵ�� -5
        int defaultSpeed = -5;
        // score�� 100�� �þ������ �������ǵ�� -1�� �þ
        int increSpeed = (score * -1) / 100;

        // �������ǵ��� �ִ밪�� -5
        if (increSpeed < -5)
            increSpeed = -5;

        // ���ǵ�� -5 ~ -10���� ������
        return defaultSpeed + increSpeed;
    }
}
