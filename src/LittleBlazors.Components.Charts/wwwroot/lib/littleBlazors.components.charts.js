// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API
var loaded = false;

window.littleBlazors = {
    drawPie: function (chartData, container) {
        initialize(() => _drawPieChart(chartData, container));
    }
};

function initialize(call) {
    if (loaded) {
        call();
    } else {
        google.charts.load('current', { packages: ['corechart'] });
        google.charts.setOnLoadCallback(() => {
            loaded = true;
            call();
        });
    }
}

function _drawPieChart(chartData, container) {
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