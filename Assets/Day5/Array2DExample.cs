using UnityEngine;

public class Array2DExample : MonoBehaviour
{
    private void Start()
    {
        // 2차원 배열 ( 다차원 배열)
        // 게임 개발에서 2차원 배열은 주로 타일 기반 게임에서 사용
        //ex) 체스, 3match 퍼즐게임, 맵, 인벤토리
        // 표 형태의 데이터를 표현하는 데 많이 사용

        int[,] enemyHealths = new int[2, 3];
        enemyHealths[0, 0] = 31;
        enemyHealths[0, 1] = 28;
        enemyHealths[0, 2] = 45;
        enemyHealths[1, 0] = 31;
        enemyHealths[1, 1] = 56;
        enemyHealths[1, 2] = 68;
        Debug.Log(enemyHealths[1, 1]);

        for (int col = 0; col < enemyHealths.Length; col++)
        {
            for (int row = 0; enemyHealths.Length > row; row++)
            {
                Debug.Log($"enemyHealths[{col}][{row}]: {enemyHealths[col, row]}");
            }
        }

        for (int row = 0; row < enemyHealths.Length; row++)
        {
            for (int col = 0; enemyHealths.Length > col; col++)
            {
                Debug.Log($"enemyHealths[{col}][{row}]: {enemyHealths[col, row]}");
            }
        }

        // 행 -> 열 순서로 하는 것과 열 -> 행 순서로 하는 것에는 조그마한 차이가 있다.
        // 배열을 행 우선 방식으로 저장하기 때문에 차이가 있다.
        // 행 -> 열의 경우 1, 2, 3, 4, 5, 6 ... 순서대로 하는 반면,
        // 열 -> 행의 경우 1, 4, 7, 2, 5, 8 ... 순으로 진행하기 때문에
    }
}
