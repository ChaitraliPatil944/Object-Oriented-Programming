# include <iostream>
using namespace std;
namespace Transflower{

    class IPresentable {
        public:
            virtual void present() = 0; // pure virtual function
    };

    class IWorkable {
        public:
            virtual void work() = 0; // pure virtual function
    };

    class IComparable {
        public:
            virtual int compareTo(IComparable& other) = 0; // pure virtual function
    };

    // Multiple Inheritance: Mentor class inherits from both IPresentable and Workable interfaces

    class Mentor : public IPresentable, public IWorkable, public IComparable {
        public:
            void present() override {
                cout << "Mentor is presenting a topic." << endl;
            }

            void work() override {
                cout << "Mentor is working on a project." << endl;
            }
            int compareTo(IComparable& other) override {
                // For demonstration, we will just return 0 to indicate equality
                return 0;
            }
    };

}

int main() {
    Transflower::Mentor mentor;
    Transflower::Mentor mentor2;
    mentor.present();
    mentor.work();
    mentor2.present();
    mentor2.work();
    int result=mentor.compareTo(mentor2); // Comparing mentor with mentor2
    if(result == 0) {
        cout << "Mentor and Mentor2 are considered not to be equal." << endl;
    } else {
        cout << "Mentor and Mentor2 are  equal." << endl;
    }

    return 0;
}