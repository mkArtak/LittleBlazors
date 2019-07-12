// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API
var loaded = false;

window.littleBlazors = {
    draw: function (container) {
        if (loaded) {
            drawChart(container);
        } else {
            google.charts.load('current', { packages: ['corechart'] });
            google.charts.setOnLoadCallback(() => {
                loaded = true;
                drawChart(container);
            });
        }
    }
};

function drawChart(container) {
    // Define the chart to be drawn.
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Element');
    data.addColumn('number', 'Percentage');
    data.addRows([
        ['Nitrogen', 0.78],
        ['Oxygen', 0.21],
        ['Other', 0.01]
    ]);

    // Instantiate and draw the chart.
    var chart = new google.visualization.PieChart(container);
    chart.draw(data, null);
}