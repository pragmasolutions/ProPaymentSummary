(function () {

    'use strict';

    var module = angular.module('xenon.controllers');

    module.factory('orderDataSource', function (orderModel) {
        var crudServiceBaseUrl = "/odata/orders";

        return new kendo.data.DataSource({
            type: "odata",
            transport: {
                read: {
                    async: false,
                    url: crudServiceBaseUrl,
                    dataType: "json"
                },
                parameterMap: function (data) {
                var d = kendo.data.transports.odata.parameterMap(data);
                delete d.$inlinecount;
                d.$count = true;

                if (d.$filter) {
                    // substringof('xYz',WorkUnitCode)  needs to 
                    // change to contains(WorkUnitCode,'06')
                    if (d.$filter.substring(0, 12) == 'substringof(') {
                        var parms = d.$filter.substring(12, d.$filter.length - 1).split(',');
                        d.$filter = 'contains({0},{1})'.format(parms[1],parms[0]);
                    }
                }

                return d;
            }
            },
            batch: false,
            serverPaging: true,
            serverSorting: true,
            serverFiltering: true,
            pageSize: 10,
            schema: {
                data: function (data) { return data.value; },
                total: function (data) { return data["odata.count"]; },
                model: orderModel
            },
            error: function (e) {
                alert(e.xhr.responseText);
            }
        });
    });
})()

