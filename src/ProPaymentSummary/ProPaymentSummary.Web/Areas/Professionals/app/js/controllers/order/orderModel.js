(function () {

    'use strict';

    var module = angular.module('xenon.controllers');

    module.factory('orderModel', function () {
        return kendo.data.Model.define({
            id: "orderId",
            fields: {
                orderId: { type: "string", editable: false, nullable: false },
                orderNumber: { title: "Nro Orden", type: "string" },
                healthInsuranceProviderName: { title: "Pre Paga", type: "string" },
                patientName: { title: "Paciente", type: "string" },
                PatientDNI: { title: "DNI Paciente", type: "string" },
                attentionDate: { title: "Fecha Atención", type: "date", format:"{0:MM-dd-yyyy}"  }
            }
        });
    });
})();