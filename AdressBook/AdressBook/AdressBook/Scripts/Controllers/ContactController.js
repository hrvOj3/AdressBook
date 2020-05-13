class ContactController{ 

    getAllContacts() {
        $.ajax({
            type: 'GET',
            url: 'https://localhost:44346/api/contactapi/allcontacts',
            success: function (data) {
                var contacts = JSON.parse(data);
                return contacts;
            }
        });
    }

    getLastAddedContacts(numOfContacts) {
        $.ajax({
            type: 'POST',
            url: 'https://localhost:44346/api/contactapi/lastcontacts',
            data: numOfContacts, 
            success: function (data) {
                var contacts = JSON.parse(data);
                return contacts;
            }
        });
    }

    deleteContact() {
        $.ajax({
            type: 'GET',
            url: 'https://localhost:44346/api/contactapi/deletecontact',
            success: function (data) { 
                if (data == "OK") {
                    alert('Contact Updated ');
                    window.location.href = "/home";
                }
            }
        });
    }

    updateOrInsertContact() {
        $.ajax({
            type: 'GET',
            url: 'https://localhost:44346/api/contactapi/InsertOdUpdateContact',
            success: function (data) {
                if (data == "OK") {
                    alert('Contact Updated ');
                    window.location.href = "/home";
                }
            }
        });
    }
}