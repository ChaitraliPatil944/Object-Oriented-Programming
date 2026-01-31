//parent class

class Employee{
    constructor( id, firstName , lastName , email , contactNumber , location , birthDate )
      {   //abtract class Employee .You cannot create plain Employee
        if (new.target === Employee) {
            throw new Error("Cannot instantiate abstract class Employee directly.");
    }
        this.id =id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
        this.contactNumber = contactNumber;
        this.location = location;
        this.birthDate = birthDate;
    }
// Abstract method.
//"Every employee must work — but I don't know HOW.
//Subclasses must define it."
    doWork(){
        throw new Error("Method 'doWork()' must be implemented by derived classes.");
    }
//Employee provides a default, but child classes can override.
    computePay(){
        return 0;
    }

    toString(){

        //gives runtime type salesEmployee, salesmanger.
        return `Employee [${this.constructor.name}]     
        Id: ${this.id},
        Name: ${this.firstName} ${this.lastName},
        Email: ${this.email},
        Location: ${this.location}`;
    }
}

module.exports = Employee;
