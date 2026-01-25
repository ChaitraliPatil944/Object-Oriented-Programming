from abc import ABC, abstractmethod

class Employee(ABC):
    def __init__(self, id , firstName, lastName, email, contactNo, location, birthdate):
        self.id=id
        self.firstName=firstName
        self.lastName=lastName
        self.email=email
        self.contactNo=contactNo
        self.location=location
        self.birthdate=birthdate

    @abstractmethod
    def doWork(self):
        pass

    def computePay():
        return 0
    def __str__(self):
        return f"Employee[ID={self.id}, Name={self.firstName} {self.lastName}, Email={self.email}, ContactNo={self.contactNo}, Location={self.location}, Birthdate={self.birthdate}]"    



