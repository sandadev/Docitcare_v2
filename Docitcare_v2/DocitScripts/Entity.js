$(document).ready(function () {
    EntityList();
    createentity();
});

function EntityList() {
    $("#tblEntity").DataTable({
        ajax: {
            url: GeteEntityList,
            dataSrc: "",
        },
        columns: [
            {
                data: "EntityId",
            },
            {
                data: "HospitalName"
            },
            {
                data: "HolderFirstName",
            },
            {
                data: "HolderLastName"
            },
            {
                data: "ContactPersonName"
            },
            {
                data: "ContactPersonPhoneNumber"
            },
          
            {
                data: "EntityId",
                render: function (data, type, entity) {
                    return "<a href='/Entity/Edit/" + entity.EntityId + "'class='btn btn-secondary btn-block role='button'>Edit</a>";
                }
            },
        ],
        error: function (errMsg) {
            console.log(errMsg);
        },
        failure: function (errMsg) {
            console.log("failure");
        }

    });

}

function createentity() {
    $("#btnCreate").click(function () {
        var entity = {
            HolderFirstName: $('#txtFirstName').val(),
            HolderLastName: $('#txtLastName').val(),
            HospitalName: $('#txtHospitalName').val(),
            Email: $('#txtEmail').val(),
            HospitalContactNumber1: $('#txtTelephoneNumber1').val(),
            HospitalContactNumber2: $('#txtTelephoneNumber2').val(),
            ContactPersonName: $('#txtContactPersonName').val(),
            ContactPersonPhoneNumber: $('#txtContactPersonNumber').val(),
            Address: $('#txtAddress').val(),
            MobileNumber: $('#txtMobileNumber').val(),
            EstablishedYear: $('#txtEstablishedYear').val(),
            RegisteredDate: $('#txtCreatedDate').val(),
            /*Branches: $('#txtBranches').tagsinput('items')*/
            Branches: $('#txtBranches').val()
        }
        $.ajax({
            cache: false,
            type: "POST",
            url: CreateEntity,
            dataType: "json",
            data: { entity: entity },
            success: function (data) {

            },
            error: function (errMsg) {
                console.log("error");
            },
            failure: function (errMsg) {
                console.log("failure");
            }
        });
    });
}

function editEntity() {
    $.ajax({
        cache: false,
        type: "GET",
        url: CreateEntity,
        dataType: "json",
        data: { entity: entity },
        success: function (data) {

        },
        error: function (errMsg) {
            console.log("error");
        },
        failure: function (errMsg) {
            console.log("failure");
        }
    });
}