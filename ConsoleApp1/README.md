# 筆記





## 常用語法

- [substring()的用法——c#](https://blog.csdn.net/zibinghanmo/article/details/40824191)



## 資料結構

### PriorityQueue

```csharp
var minQueue = new PriorityQueue<int,int>(Comparer<int>.Create((a,b)=>a-b));
var maxQueue = new PriorityQueue<int,int>(Comparer<int>.Create((a,b)=>b-a));

minQueue.EnQueue(nums[0]);
maxQueue.EnQueue(nums[0]);

https://learn.microsoft.com/zh-tw/dotnet/api/system.collections.generic.priorityqueue-2?view=net-8.0


```
