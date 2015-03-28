(function () {

    'use strict';

    var module = angular.module('xenon.controllers');

    module.controller('orderListController', function ($rootScope, $location, orderDataSource) {
        
            var model = this;
            
            orderDataSource.filter({});
          
            model.onChange = function (e) {
                var grid = e.sender;
                $rootScope.lastSelectedDataItem = grid.dataItem(grid.select());
            },

            model.dataSource = orderDataSource;

            model.onDataBound = function (e) {
                // check if there was a row that was selected
                if ($rootScope.lastSelectedDataItem == null) {
                    return;
                }

                var view = this.dataSource.view(); // get all the rows

                for (var i = 0; i < view.length; i++) {
                    // iterate through rows
                    if (view[i].CustomerID == $rootScope.lastSelectedDataItem.CustomerID) {
                        // find row with the lastSelectedProductd
                        var grid = e.sender; // get the grid

                        grid.select(grid.table.find("tr[data-uid='" + view[i].uid + "']")); // set the selected row
                        break;
                    }
                }
            };
        });
})()
