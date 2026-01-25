const SalesEmployee = require("./SalesEmployee");
const IInterviewPanel = require("./Interfaces/IInterviewPanel");
const ITrainer = require("./Interfaces/ITrainer");
const IAuditable = require("./Interfaces/IAuditable");

class SalesManager extends SalesEmployee{
    constructor(
        id , firstName , lastName , email , contactNumber , location , birthDate ,incentive ,target , achievedTarget ,basicSalary , hra , bonus )

    {
        super(
              id, firstName, lastName, email,
            contactNumber, location, birthDate,
            incentive, target, achievedTarget,
            basicSalary, hra

        );
        this.bonus= bonus;

    }

    doWork(){
        console.log(`${this.firstName}is managing the sales team and strategy.`);
    }

    computePay() {
        return super.computePay() + this.bonus;
    }

    calculateBonus() {
    return this.bonus;
}

conductAppraisal() {
    console.log("Manager appraisal completed.");
}

approveLeave() {
    console.log("Leave approved by Sales Manager.");
}

takeInterview() {
    console.log("Sales Manager conducting interview.");
}

train() {
    console.log("Sales Manager training sales team.");
}

audit() {
    console.log("Sales Manager performing audit.");
}

}

module.exports = SalesManager;