from SalesEmployee import SalesEmployee

class SalesManager(SalesEmployee):
    def __init__(self, id, firstName ,lastName ,email, contactNo , location ,birthdate , incentive , target , achievedTarget, basicSalary, hra, bonus):

        super().__init__(id, firstName, lastName, email,contactNo, location , birthdate , incentive , target , achievedTarget, basicSalary, hra) 

        self.bonus=bonus

    def doWork(self):
        print(f"{self.firstName } is managing the sales team and strategizing sales plans.") 

    def computePay(self):
        return super().computePay() + self.bonus