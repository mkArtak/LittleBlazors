// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API

window.littleBlazors = {
    init: function (container) {
        console.log('Initializing charts to be drown in container: ' + container);
        google.charts.load('current', { packages: ['corechart'] });
        google.charts.setOnLoadCallback(() => drawChart(container));
    }
};

function drawChart(containerName) {
    console.log('drawing charts in container: ' + containerName);

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
    var chart = new google.visualization.PieChart(document.getElementById(containerName));
    chart.draw(data, null);
}