#include<iostream>
using namespace std;

namespace Membership{
    
    class User{
        private:
            string name;
            int age;

        public:
            User(string name, int age) {
                this->name = name;
                this->age = age;
            }
            string getName() {
                return name;
            }
            int getAge() {
                return age;
            }
            void setName(string name) {
                this->name = name;
            }
             void setAge(int age) {
                this->age = age;
            }

    };

    class Role{

        public:
            void assignRole(User& user, string role) {
                cout << "Assigning role: " << role << " to user: " << user.getName() << endl;
            }

    };

}


namespace Evaluation{

    class PerformanceMonitor {
        public:
            void evaluate(string employeeName) {
                cout << "Evaluating performance of: " << employeeName << endl;
            }
    };

    class FeedbackManager {
        public:
            void provideFeedback(string employeeName, string feedback) {
                cout << "Providing feedback to: " << employeeName << " - " << feedback << endl;
            }
    };
}

int main() {


//Fully qualified names to access classes and functions from different namespaces
Membership::User user1("Alice", 30);
Membership::Role roleManager;

Evaluation::PerformanceMonitor monitor;
Evaluation::FeedbackManager manager;
    return 0;
}