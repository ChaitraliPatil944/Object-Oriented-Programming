from SalesEmployee import SalesEmployee
from SalesManager import SalesManager
from datetime import date


emp1 = SalesEmployee(
                 1, "Amit", "Sharma", "amit@company.com",
                 "9999999999", "Mumbai",
                date(1995, 5, 12),
                1000, 5000, 20000,
                100000, 120000
                )


emp2 = SalesManager(
                2, "Neha", "Patil", "neha@company.com",
                "8888888888", "Pune",
                date(1990, 3, 22),
                1500, 7000, 30000,
                200000, 250000, 10000
            )


# Polymorphism
emp1.doWork()
emp2.doWork()

print(emp1)
print("Salary:", emp1.computePay())


print(emp2)
print("Salary:", emp2.computePay())