#include <iostream>
using namespace std;

namespace Drawing {
class Shape {
    public: 
    virtual void draw()=0; // pure virtual function
    virtual void display()=0; // pure virtual function

    virtual void show() {
        cout << "Showing a shape" << endl;  // virtual function with implementation
    }
};

class Circle: public Shape {
    public:
    void draw() {                                            // overriding the pure virtual function
        cout << "Drawing a circle" << endl;
    }
    void display() {
        cout << "Displaying a circle" << endl;
    }
};
}

int main(){
    Drawing::Shape* shape = new Drawing::Circle();   // creating a Circle object but using a Shape pointer
    shape->draw();                
    shape->display();
    shape->show();

    delete shape;
    return 0;
}