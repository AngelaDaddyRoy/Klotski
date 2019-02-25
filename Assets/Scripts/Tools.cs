using System;

public class Tools
{
    /// <summary>
    /// 产生随机不重复数组
    /// </summary>
    /// <param name="minValue"></param>
    /// <param name="maxValue"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    public static int[] GetRandomUnrepeatArray(int minValue, int maxValue, int count)
    {
        Random rnd = new Random();
        int length = maxValue - minValue + 1;
        byte[] keys = new byte[length];
        rnd.NextBytes(keys);
        int[] items = new int[length];
        for (int i = 0; i < length; i++)
        {
            items[i] = i + minValue;
        }
        Array.Sort(keys, items);
        int[] result = new int[count];
        Array.Copy(items, result, count);
        return result;
    }
}

