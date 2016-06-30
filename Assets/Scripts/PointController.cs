using UnityEngine;
using System.Collections;

public static class PointController
{
    static int point = 0;
	// pointの取得
    public static int Point
    {
        get { return point; }
    }
    // pointは加算のみ可能
    public static void Add(int addPoint)
    {
        point += addPoint;
    }
    // pointの初期値化
    public static void Reset()
    {
        point = 0;
    }
}
