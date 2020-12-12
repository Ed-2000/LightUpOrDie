using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SomeMath : MonoBehaviour
{
    //метод, который создает список случайных и неповторимых (в пределах списка) индексов
    public static List<int> CreateRandomUniqueIndexes(int numberOfIndexesInList, int min, int max)
    {
        if (min < max && numberOfIndexesInList <= max - min)
        {
            List<int> list = new List<int>();

            //заполним спиок числами от min(включительно) до max(исключительно)
            for (int i = min; i < max; i++)
            {
                list.Add(i);
            }

            //удаляем случайные елементы из списка пока его длинна не будет равна numberOfIndexesInList
            while (list.Count > numberOfIndexesInList)
            {
                var number = UnityEngine.Random.Range(0, list.Count);
                list.RemoveAt(number);
            }

            return list;
        }
        else
        {
            return null;
        }
    }
    
    //метод, который тасует список (алгоритм Фишера-Йейтса)
    public static List<T> ShuffleList<T>(List<T> list)
    {
        System.Random rand = new System.Random();

        for (int i = list.Count - 1; i >= 1; i--)
        {
            int j = rand.Next(i + 1);

            T tmp = list[j];
            list[j] = list[i];
            list[i] = tmp;
        }

        return list;
    }

    //метод, который возвращает случайную позицию из указаной области
    public static Vector3 GetRandomPosition(float maxX, float maxY, float maxZ, float minX, float minY, float minZ)
    {
        Vector3 res = new Vector3();

        res.x = UnityEngine.Random.Range(minX, maxX);
        res.y = UnityEngine.Random.Range(minY, maxY);
        res.z = UnityEngine.Random.Range(minZ, maxZ);

        return res;
    }

    //метод для реализации кривой Безъе
    public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
    {
        t = Mathf.Clamp01(t);
        float oneMinusT = 1f - t;

        Vector3 res = oneMinusT * oneMinusT * oneMinusT * p0
                    + 3f * oneMinusT * oneMinusT * t * p1
                    + 3f * oneMinusT * t * t * p2
                    + t * t * t * p3;

        return res;
    }
}