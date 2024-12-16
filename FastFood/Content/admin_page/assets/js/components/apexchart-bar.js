var colors = ["#1c84ee"],
    options = {
        chart: { height: 380, type: "bar", toolbar: { show: !1 } },
        plotOptions: { bar: { horizontal: !0 } },
        dataLabels: { enabled: !1 },
        series: [{ data: [455, 435, 410, 480, 530, 575, 685, 1345, 1165, 1075] }],
        colors: colors,
        xaxis: { categories: ["South Korea", "Canada", "United Kingdom", "Netherlands", "Italy", "France", "Japan", "United States", "China", "Germany"] },
        states: { hover: { filter: "none" } },
        grid: { borderColor: "#f1f3fa" },
    },
    chart = new ApexCharts(document.querySelector("#basic-bar"), options);
chart.render();
options = {
    chart: { height: 380, type: "bar", toolbar: { show: !1 } },
    plotOptions: { bar: { horizontal: !0, dataLabels: { position: "top" } } },
    dataLabels: { enabled: !0, offsetX: -6, style: { fontSize: "12px", colors: ["#fff"] } },
    colors: (colors = ["#1c84ee", "#4ecac2"]),
    stroke: { show: !0, width: 1, colors: ["#fff"] },
    series: [
        { name: "Series 1", data: [51, 30, 31, 50, 11, 42, 30] },
        { name: "Series 2", data: [46, 57, 43, 66, 24, 45, 23] },
    ],
    xaxis: { categories: [2016, 2017, 2018, 2019, 2021, 2022, 2023] },
    legend: { offsetY: 5 },
    states: { hover: { filter: "none" } },
    grid: { borderColor: "#f1f3fa", padding: { bottom: 5 } },
};
(chart = new ApexCharts(document.querySelector("#grouped-bar"), options)).render();
options = {
    chart: { height: 380, type: "bar", stacked: !0, toolbar: { show: !1 } },
    plotOptions: { bar: { horizontal: !0 } },
    stroke: { show: !1 },
    series: [
        { name: "Marine Sprite", data: [30, 17, 24, 37, 30, 29, 15] },
        { name: "Striking Calf", data: [11, 9, 7, 10, 8, 11, 6] },
        { name: "Tank Picture", data: [14, 19, 13, 11, 17, 13, 22] },
        { name: "Bucket Slope", data: [55, 34, 35, 54, 15, 45, 34] },
        { name: "Reborn Kid", data: [46, 57, 43, 39, 24, 45, 23] },
    ],
    xaxis: {
        categories: [2016, 2017, 2018, 2019, 2021, 2022, 2023],
        labels: {
            formatter: function (e) {
                return e + "K";
            },
        },
    },
    yaxis: { title: { text: void 0, colors: "#fff" } },
    colors: (colors = ["#1c84ee", "#4ecac2", "#22c55e", "#f9b931", "#ff6c2f"]),
    tooltip: {
        y: {
            formatter: function (e) {
                return e + "K";
            },
        },
    },
    fill: { opacity: 1 },
    states: { hover: { filter: "none" } },
    legend: { position: "top", horizontalAlign: "center", offsetY: 10 },
    grid: { borderColor: "#f1f3fa" },
};
(chart = new ApexCharts(document.querySelector("#stacked-bar"), options)).render();
options = {
    chart: { height: 380, type: "bar", stacked: !0, stackType: "100%", toolbar: { show: !1 } },
    plotOptions: { bar: { horizontal: !0 } },
    stroke: { width: 1, colors: ["#fff"] },
    series: [
        { name: "Marine Sprite", data: [30, 17, 24, 37, 30, 29, 15] },
        { name: "Striking Calf", data: [11, 9, 7, 10, 8, 11, 6] },
        { name: "Tank Picture", data: [14, 19, 13, 11, 17, 13, 22] },
        { name: "Bucket Slope", data: [55, 34, 35, 54, 15, 45, 34] },
        { name: "Reborn Kid", data: [46, 57, 43, 39, 24, 45, 23] },
    ],
    xaxis: { categories: [2008, 2009, 2010, 2011, 2012, 2013, 2014] },
    colors: (colors = ["#1c84ee", "#4ecac2", "#22c55e", "#f9b931", "#ff6c2f"]),
    tooltip: {
        y: {
            formatter: function (e) {
                return e + "K";
            },
        },
    },
    fill: { opacity: 1 },
    states: { hover: { filter: "none" } },
    legend: { position: "top", horizontalAlign: "center", offsetY: 10 },
    grid: { borderColor: "#f1f3fa", padding: { top: 0 } },
};
(chart = new ApexCharts(document.querySelector("#full-stacked-bar"), options)).render();
options = {
    chart: { height: 380, type: "bar", stacked: !0, toolbar: { show: !1 } },
    colors: (colors = ["#1c84ee", "#4ecac2"]),
    plotOptions: { bar: { horizontal: !0, barHeight: "80%" } },
    dataLabels: { enabled: !1 },
    stroke: { width: 1, colors: ["#fff"] },
    series: [
        { name: "Males", data: [0.75, 0.85, 0.96, 1.08, 1.7, 2.3, 3.1, 4, 4.1, 4.4, 4.2, 4.5, 4.3, 4.4, 4.7, 4.1, 3.7, 3.2] },
        { name: "Females", data: [-0.75, -0.85, -0.86, -0.98, -1.2, -2, -2.65, -3.5, -3.76, -4.02, -4.1, -4.2, -3.9, -3.8, -3.9, -3.2, -2.9, -2.6] },
    ],
    grid: { borderColor: "#f1f3fa", padding: { bottom: 5 } },
    yaxis: { min: -5, max: 5, title: {} },
    tooltip: {
        shared: !1,
        x: {
            formatter: function (e) {
                return e;
            },
        },
        y: {
            formatter: function (e) {
                return Math.abs(e) + "%";
            },
        },
    },
    xaxis: {
        categories: ["90+", "85-89", "80-84", "75-79", "70-74", "65-69", "60-64", "55-59", "50-54", "45-49", "40-44", "35-39", "30-34", "25-29", "20-24", "15-19", "10-14", "0-9"],
        title: { text: "Percent" },
        labels: {
            formatter: function (e) {
                return Math.abs(Math.round(e)) + "%";
            },
        },
    },
    legend: { offsetY: 7 },
};
(chart = new ApexCharts(document.querySelector("#negative-bar"), options)).render();
options = {
    series: [{ data: [380, 400, 418, 440, 500, 530, 580] }],
    chart: { type: "bar", height: 380, toolbar: { show: !1 } },
    annotations: {
        xaxis: [{ x: 500, borderColor: (colors = ["#f9b931"])[1], label: { borderColor: colors[1], style: { color: "#fff", background: colors[1] }, text: "X annotation" } }],
        yaxis: [{ y: "July", y2: "September", label: { text: "Y annotation" } }],
    },
    plotOptions: { bar: { horizontal: !0 } },
    dataLabels: { enabled: !0 },
    xaxis: { categories: ["Jul", "Aug", "Sept", "Oct", "Nov", "Dec", "Jan"] },
    colors: colors,
    grid: { xaxis: { lines: { show: !0 } } },
    yaxis: { reversed: !0, axisTicks: { show: !0 } },
};
(chart = new ApexCharts(document.querySelector("#reversed-bar"), options)).render();
options = {
    chart: { height: 380, type: "bar", stacked: !0, toolbar: { show: !1 }, shadow: { enabled: !0, blur: 1, opacity: 0.5 } },
    plotOptions: { bar: { horizontal: !0, barHeight: "60%" } },
    dataLabels: { enabled: !1 },
    stroke: { width: 0 },
    series: [
        { name: "Marine Sprite", data: [44, 55, 41, 37, 22, 43, 21] },
        { name: "Striking Calf", data: [53, 32, 33, 52, 13, 43, 32] },
        { name: "Tank Picture", data: [12, 17, 11, 9, 15, 11, 20] },
        { name: "Bucket Slope", data: [9, 7, 5, 8, 6, 9, 4] },
    ],
    xaxis: { categories: [2008, 2009, 2010, 2011, 2012, 2013, 2014] },
    yaxis: { title: { text: void 0 } },
    tooltip: {
        shared: !1,
        y: {
            formatter: function (e) {
                return e + "K";
            },
        },
    },
    colors: (colors = ["#1c84ee", "#22c55e", "#040505", "#4ecac2"]),
    fill: { type: "pattern", opacity: 1, pattern: { style: ["circles", "slantedLines", "verticalLines", "horizontalLines"] } },
    states: { hover: { filter: "none" } },
    legend: { position: "right" },
    grid: { borderColor: "#f1f3fa" },
    responsive: [{ breakpoint: 600, options: { legend: { show: !1 } } }],
};
(chart = new ApexCharts(document.querySelector("#pattern-bar"), options)).render();
var labels = Array.apply(null, { length: 39 }).map(function (e, t) {
    return t + 1;
}),
    options = {
        chart: { height: 450, type: "bar", toolbar: { show: !1 }, animations: { enabled: !1 } },
        plotOptions: { bar: { horizontal: !0, barHeight: "100%" } },
        dataLabels: { enabled: !1 },
        stroke: { colors: ["#fff"], width: 0.2 },
        series: [{ name: "coins", data: [2, 4, 3, 4, 3, 5, 5, 6.5, 6, 5, 4, 5, 8, 7, 7, 8, 8, 10, 9, 9, 12, 12, 11, 12, 13, 14, 16, 14, 15, 17, 19, 21] }],
        labels: labels,
        yaxis: { axisBorder: { show: !1 }, axisTicks: { show: !1 }, labels: { show: !1 }, title: { text: "Weight" } },
        grid: { position: "back", borderColor: "#f1f3fa" },
        fill: { type: "image", opacity: 0.87, image: { src: ["../../../assets/images/small/img-4.jpg"], width: 466, height: 406 } },
    };
(chart = new ApexCharts(document.querySelector("#image-fill-bar"), options)).render();
options = {
    chart: { height: 450, type: "bar", toolbar: { show: !1 } },
    plotOptions: { bar: { barHeight: "100%", distributed: !0, horizontal: !0, dataLabels: { position: "bottom" } } },
    colors: (colors = ["#1c84ee", "#53389f", "#7f56da", "#ff86c8", "#ef5f5f", "#ff6c2f", "#f9b931", "#22c55e", "#040505", "#4ecac2"]),
    dataLabels: {
        enabled: !0,
        textAnchor: "start",
        style: { colors: ["#fff"] },
        formatter: function (e, t) {
            return t.w.globals.labels[t.dataPointIndex] + ":  " + e;
        },
        offsetX: 0,
        dropShadow: { enabled: !1 },
    },
    series: [{ data: [400, 430, 448, 470, 540, 580, 690, 1100, 1200, 1380] }],
    stroke: { width: 0, colors: ["#fff"] },
    xaxis: { categories: ["South Korea", "Canada", "United Kingdom", "Netherlands", "Italy", "France", "Japan", "United States", "China", "India"] },
    yaxis: { labels: { show: !1 } },
    grid: { borderColor: "#f1f3fa" },
    tooltip: {
        theme: "dark",
        x: { show: !1 },
        y: {
            title: {
                formatter: function () {
                    return "";
                },
            },
        },
    },
};
(chart = new ApexCharts(document.querySelector("#datalables-bar"), options)).render();
options = {
    series: [
        {
            name: "Actual",
            data: [
                { x: "2017", y: 12, goals: [{ name: "Expected", value: 14, strokeWidth: 2, strokeDashArray: 2, strokeColor: (colors = ["#f9b931", "#22c55e"])[1] }] },
                { x: "2018", y: 44, goals: [{ name: "Expected", value: 54, strokeWidth: 5, strokeHeight: 10, strokeColor: colors[1] }] },
                { x: "2019", y: 54, goals: [{ name: "Expected", value: 52, strokeWidth: 10, strokeHeight: 0, strokeLineCap: "round", strokeColor: colors[1] }] },
                { x: "2020", y: 66, goals: [{ name: "Expected", value: 61, strokeWidth: 10, strokeHeight: 0, strokeLineCap: "round", strokeColor: colors[1] }] },
                { x: "2021", y: 81, goals: [{ name: "Expected", value: 66, strokeWidth: 10, strokeHeight: 0, strokeLineCap: "round", strokeColor: colors[1] }] },
                { x: "2022", y: 67, goals: [{ name: "Expected", value: 70, strokeWidth: 5, strokeHeight: 10, strokeColor: colors[1] }] },
            ],
        },
    ],
    chart: { height: 380, type: "bar", toolbar: { show: !1 } },
    plotOptions: { bar: { horizontal: !0 } },
    colors: colors,
    dataLabels: {
        dataLabels: {
            formatter: function (e, t) {
                t.w.config.series[t.seriesIndex].data[t.dataPointIndex].goals;
                return e;
            },
        },
    },
    legend: { show: !0, showForSingleSeries: !0, customLegendItems: ["Actual", "Expected"], markers: { fillColors: colors } },
};
(chart = new ApexCharts(document.querySelector("#bar-markers"), options)).render();
