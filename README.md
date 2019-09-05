# LittleBlazors

The LittleBlazors library is essentially a wrapper around the [Google Charts](https://developers.google.com/chart/) library, to make it simple for Blazor developers to use charts in their Blazor apps.
I've just started on this journey and plan to slowly cover all the charts.
So far I have a very light support of `Pie Chart` and `Line Chart`, which you can use as follows as follows in your components:

** Line Chart usage sample**
```razor
@using LittleBlazors.Components.Charts.Model.LineChartModel;

@{
    var data = new LinearChartData() { Title = "Sample chart" }
           .SetBaseLine("x", new double[] { 12, 13, 14, 15, 73 })
           .AddLine("y", new double[] { 34, 35, 1, 34, 63 })
           .AddLine("count", new double[] { 43, 23, 45, 1, 93 });
}

<h1>LineChart sample</h1>

<LittleBlazors.Components.Charts.LineChart Data="data" />
```

This will result in the following chart:
![Line chart sample](https://user-images.githubusercontent.com/7347708/61272148-46036180-a75b-11e9-9510-bb78cd9eeb85.png)

You can experiment with the Line-Chart more using the `LittleBlazors.TestHost` project, which has a page which essentially simulates this:
![](https://user-images.githubusercontent.com/7347708/61682492-b879c180-acc6-11e9-99f4-4dcd0dd05743.gif)

**Pie Chart usage sample**
```razor
@{
    var data1 = new Dictionary<string, double>() { { "hi", 1.0 }, { "bye", 23 } };
}

<LittleBlazors.Components.Charts.PieChart Data="data1" />
```

And you'll get the following chart for this one:
![Pie Chart](https://user-images.githubusercontent.com/7347708/61272104-2ec47400-a75b-11e9-9b18-c7d5680ba218.png)