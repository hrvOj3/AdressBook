class ContactGroupController {    

    getAllContactGroups() {
        $.ajax({
            type: 'GET',
            url: 'https://localhost:44346/api/contactapi/allcontactgroups',
            success: function (data) {
                var contactGroups = JSON.parse(data);
                return contactGroups;
            }
        });
    }

    deleteContactGroup() {
        $.ajax({
            type: 'POST',
            data: Contact,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            url: 'https://localhost:44346/api/contactapi/deletecontactgroup',
            success: function (data) {
                if (data == "OK") {
                    alert('Contact Group Delete ');
                    window.location.href = "/home";
                }
            }
        });
    }

    updateOrInsertContactGroup() {
        $.ajax({
            type: 'POST',
            data: Contact,
            url: 'https://localhost:44346/api/contactapi/insertorupdatecontactgroup',
            success: function (data) {
                if (data == "OK") {
                    alert('Contact Group Updated ');
                    window.location.href = "/home";
                }
            }
        });
    }
}