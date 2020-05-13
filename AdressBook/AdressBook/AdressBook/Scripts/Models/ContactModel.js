class ContactModel {
    Id
    Title
    Name 
    Surname
    Organization
    Email
    PhoneNumbers

    constructor() {
        this.Title = null;
        this.Name = null;
        this.Surname = null;
        this.Organization = null;
        this.Email = null;
        this.PhoneNumbers = null;
    }

    constructor(title, name, surname, organization, email, phoneNumbers) {
        this.Title = title;
        this.Name = name;
        this.Surname = surname;
        this.Organization = organization;
        this.Email = email;
        this.PhoneNumbers = phoneNumbers;
    }

}