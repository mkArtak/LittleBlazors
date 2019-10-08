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
    var data = toDataTable(chartData);

    // Instantiate and draw the chart.
    var chart = new google.visualization.PieChart(container);
    chart.draw(data, null);
}

function _drawLineChart(chartData, container) {
    var realData = toDataTable(chartData);

    var options = {
        title: chartData.title,
        curveType: 'function',
        legend: { position: 'bottom' }
    };

    var chart = new google.visualization.LineChart(container);
    chart.draw(realData, options);
}

function toDataTable(chartData) {
    var realData = new google.visualization.DataTable();

    debugLog(chartData);

    // Add columns
    for (var i in chartData.lines) {
        var lineType = toLineType(chartData.lines[i].type);
        realData.addColumn(lineType, i);
    }

    var allRows = new Array();
    //TODO: The below loop-spaghetti is terribe. Need to be optimized
    for (var r in chartData.lines) {
        for (var rowIndex in chartData.lines[r].data) {
            var rowData = new Array();

            for (var i in chartData.lines) {
                lineType = toLineType(chartData.lines[i].type);
                var converter = lineType == "datetime" ? (val) => new Date(val) : (val) => val;
                var cellValue = chartData.lines[i].data[rowIndex];
                cellValue = converter(cellValue);
                rowData.push(cellValue);
            }

            allRows.push(rowData);
        }

        break;
    }

    realData.addRows(allRows);

    return realData;
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