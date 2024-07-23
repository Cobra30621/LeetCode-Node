namespace ConsoleApp1;

public class Sort
{
    
    
    // Dict 排序
    Dictionary<int, int> countMap = new Dictionary<int, int>();
    List<KeyValuePair<int, int>> sortedList = countMap.
        OrderBy(pair => pair.Value). // 先根據值進行排序
        ThenByDescending(pair => pair.Key).ToList(); // 如果值相同，再根據 Key 進行排序
    
}