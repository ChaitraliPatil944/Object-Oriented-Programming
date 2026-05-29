#include <iostream>
using namespace std;

namespace HR {

    class Employee {
        private:
            string name;
            int id;

        public:
            Employee(string name, int id) {
                this->name = name;
                this->id = id;
            }
            string getName() {
                return name;
            }
            int getId() {
                return id;
            }
    };


    class SalesEmployee : public Employee {
        private:
            double salesTarget;

        public:
            SalesEmployee(string name, int id, double salesTarget) : Employee(name, id) {
                this->salesTarget = salesTarget;
            }
            double getSalesTarget() {
                return salesTarget;
            }
    };

    
    class SalesManager : public SalesEmployee {
        private:
            int teamSize;

        public:
            SalesManager(string name, int id, double salesTarget, int teamSize) : SalesEmployee(name, id, salesTarget) {
                this->teamSize = teamSize;
            }
            int getTeamSize() {
                return teamSize;
            }
    };


    class Department {
        public:
            void assignEmployee(Employee& employee, string department) {
                cout << "Assigning employee: " << employee.getName() << " to department: " << department << endl;
            }
    };

    int main() {
        SalesManager manager("Alice", 101, 50000.0, 5);
        Department hrDepartment;
        hrDepartment.assignEmployee(manager, "Sales");

        cout << "Manager Name: " << manager.getName() << endl;
        cout << "Manager ID: " << manager.getId() << endl;
        cout << "Sales Target: " << manager.getSalesTarget() << endl;
        cout << "Team Size: " << manager.getTeamSize() << endl;

        return 0;
    }
}