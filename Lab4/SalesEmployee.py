from Employee import Employee

class SalesEmployee(Employee):
    def __init__(self, id, firstName ,lastName ,email, contactNo , location ,birthdate , incentive , target , achievedTarget, basicSalary, hra):

        super().__init__(id, firstName, lastName, email,contactNo, location , birthdate ) 

        self.incentive=incentive
        self.target=target
        self.achievedtarget=achievedTarget
        self.basicSalary=basicSalary
        self.hra=hra

    def doWork(self):
        print(f"{self.firstName } is selling products and meeting clients.") 

    def computePay(self):
        totalSalary =self.basicSalary + self.hra
        if self.achievedtarget >= self.target:
            totalSalary += self.incentive
        return totalSalary           
