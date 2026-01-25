const Employee = require("./Employee");

class HRManager extends Employee {
    constructor(id, firstName, lastName, email, contact, location, birthDate) {
        super(id, firstName, lastName, email, contact, location, birthDate);
    }

    doWork() {
        console.log(`${this.firstName} is managing HR operations.`);
    }

    calculateBonus() {
        return 20000;
    }

    conductAppraisal() {
        console.log("HR Manager conducting appraisal.");
    }

    approveLeave() {
        console.log("Leave approved by HR Manager.");
    }

    takeInterview() {
        console.log("HR Manager taking interview.");
    }
}

module.exports = HRManager;
