// This file is to show how a library package may provide JavaScript interop features
// wrapped in a .NET API
var loaded = false;

window.littleBlazors = {
    drawPieChart: function (chartData, container) {
        initialize(() => _drawPieChart(chartData, container));
    },

    drawLineChart: function (chartData, container) {
        initialize(() => _drawLineChart(chartData, container));
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

function _drawLineChart(chartData, container) {
    var realData = new google.visualization.DataTable();

    debugLog(chartData);

    // Add columns
    realData.addColumn(toLineType(chartData.baseLineData.type), chartData.baseLineData.LineName);
    for (var i in chartData.lines) {
        var lineType = toLineType(chartData.lines[i].type);
        realData.addColumn(lineType, i);
    }

    var allRows = new Array();
    var rowIndex = 0;
    for (var r in chartData.baseLineData.data) {
        var rowData = new Array();
        rowData.push(chartData.baseLineData.data[r]);

        for (var i in chartData.lines) {
            rowData.push(chartData.lines[i].data[rowIndex]);
        }
        allRows.push(rowData);
        rowIndex++;
    }

    realData.addRows(allRows);

    var options = {
        title: chartData.title,
        curveType: 'function',
        legend: { position: 'bottom' }
    };

    var chart = new google.visualization.LineChart(container);
    chart.draw(realData, options);
}

function toLineType(chartDataType) {
    var result;
    switch (chartDataType) {
        case 0: // string
            result = "string";
            break;

        case 1: // number
            result = "number";
            break;

        case 2:
            result = "boolean";
            break;

        case 3:
            result = "date";
            break;

        case 4:
            result = "datetime";
            break;

        case 5:
            result = "timeofday";
            break;

        default:
            throw "Unkonwn type";
    }

    return result;
}

function debugLog(obj) {
    console.log(JSON.stringify(obj));
}