class Employee {
  work() {
    console.log("Employee works");
  }
}

class Developer extends Employee {
  code() {
    console.log("Developer writes code");
  }
}


//Inheritance allows a class to inherit properties and methods from another class
//how can we achieve multiple inheritance in javascript?
//JavaScript does not support multiple inheritance using classes because a class can only extend one parent. However, JavaScript achieves multiple inheritance-like behavior using mixins and composition by combining multiple objects or behaviors into a single object. This avoids ambiguity and promotes flexible design.