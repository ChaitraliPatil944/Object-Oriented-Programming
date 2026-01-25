const SalesEmployee = require("./HR/SalesEmployee")
const SalesManager = require("./HR/SalesManager")
const SalesManager = require("./HR/SalesManager");
const SalesEmployee = require("./HR/SalesEmployee");
const HRManager = require("./HR/HRManager");







let emp1 = new SalesEmployee(
    1, "Chaitrali", "Patil", "Chait@gmail.com", "123456789","Pune" ,
    new Date(1995, 4, 12),
    1000, 5000,20000,
    100000, 120000
);

let emp2 = new SalesManager(
    2, "Sai", "Jagdale" , "Sai@gamil.com", "231456478","Pune", 
    new Date(1995, 4, 12),
    10000,3000,20000,100000,120000

);

emp1.doWork();
emp2.doWork();

console.log(emp1.toString());
console.log("Salary:", emp1.computepay());

console.log(emp2.toString());
console.log("Salary:", emp2.computepay());

