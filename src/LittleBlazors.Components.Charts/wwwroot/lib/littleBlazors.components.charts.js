// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API
var loaded = false;

window.littleBlazors = {
    draw: function (chartData, container) {
        if (loaded) {
            drawChart(container);
        } else {
            google.charts.load('current', { packages: ['corechart'] });
            google.charts.setOnLoadCallback(() => {
                loaded = true;
                drawChart(chartData, container);
            });
        }
    }
};

function drawChart(chartData, container) {
    // Define the chart to be drawn.
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Element');
    data.addColumn('number', 'Percentage');

    for (var i in chartData) {
        data.addRows([[i, chartData[i]]]);
    }

    // Instantiate and draw the chart.
    var chart = new google.visualization.PieChart(container);
    chart.draw(data, null);
}