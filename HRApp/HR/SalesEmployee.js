//child class
const Employee = require("./Employee");
const IAppraisable = require("./Interfaces/IAppraisable");

class SalesEmployee extends Employee {
    constructor(
        id, firstName, lastName, email, contactNumber, location, birthDate, incentive, target, achievedTarget,
        basicSalary ,hra
    )  {

        //super means call employee constructor first 
        super(id, firstName, lastName, email, contactNumber, location, birthDate);
        this.incentive = incentive;
        this.target = target;
        this.achievedTarget = achievedTarget;
        this.basicSalary = basicSalary;
        this.hra = hra;
    }

   

    doWork() {
        console.log(`${this.firstName} is selling products and meeting clients.`);
    }

    computepay() {
         let totalSalary = this.basicSalary + this.hra;
            if (this.achievedTarget >= this.target) {   
                totalSalary += this.incentive;
            }       
        return totalSalary;
    }

    }
module.exports = SalesEmployee;
