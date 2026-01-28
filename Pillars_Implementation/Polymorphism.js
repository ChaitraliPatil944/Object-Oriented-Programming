class Shape {
  draw() {
    console.log("Drawing shape");
  }
}

class Circle extends Shape {
  draw() {
    console.log("Drawing circle");
  }
}

let s = new Circle();
s.draw();   // Drawing circle
//Polymorphism allows methods to do different things based on the object it is acting upon
//In JavaScript, polymorphism is mainly achieved through method overriding and duck typing.
//Method overriding occurs when a subclass provides a specific implementation of a method that is already defined in its superclass.
//Duck typing is a concept where the type or class of an object is determined by the methods and properties it has, rather than its actual class.