#include <iostream>
using namespace std;

class Shape {
    public: 
    virtual void draw()=0; // pure virtual function
    virtual void display()=0; // pure virtual function

    virtual void show() {
        cout << "Showing a shape" << endl;
    }
};

class Circle: public Shape {
    public:
    void draw() {
        cout << "Drawing a circle" << endl;
    }
    void display() {
        cout << "Displaying a circle" << endl;
    }
};

int main(){
    Shape* shape = new Circle();
    shape->draw();
    shape->display();
    shape->show();

    delete shape;
    return 0;
}