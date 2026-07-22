# Lesson 8 — First Object-Oriented Application

> **Object-Oriented Programming (OOP) Handbook**
>
> **Project:** Bank Management System (Console-Based)

---

# 1. Introduction

After understanding why OOP exists and how Java supports it, it's time to build our first object-oriented application.

Instead of using simple examples like `Car` or `Student`, we'll build a small **Bank Management System**. Throughout this handbook, we'll continue enhancing this same project as we learn more OOP concepts.

---

# 2. Business Problem

A bank needs software to manage:

- Customers
- Bank Accounts
- Deposits
- Withdrawals
- Balance Enquiry

---

# 3. Identifying Real-World Objects

```text
               Bank
                 │
     ┌───────────┴───────────┐
     │                       │
 Customer               Bank Account
                             │
                  ┌──────────┴──────────┐
                  │                     │
              Deposit()            Withdraw()
```

Objects:

- Customer
- BankAccount
- Bank

---

# 4. Designing Classes

## Customer

Attributes:

- customerId
- name
- phone

Responsibilities:

- View details

---

## BankAccount

Attributes:

- accountNumber
- balance

Responsibilities:

- deposit()
- withdraw()
- displayBalance()

---

## Bank

Responsibilities:

- Manage customers
- Manage accounts

---

# 5. Project Structure

```text
BankManagement/

│
├── Customer.java
├── BankAccount.java
├── Bank.java
└── Main.java
```

---

# 6. Customer.java

```java
public class Customer {

    int customerId;
    String name;
    String phone;

    public Customer(int customerId, String name, String phone) {
        this.customerId = customerId;
        this.name = name;
        this.phone = phone;
    }

    public void displayCustomer() {
        System.out.println("Customer ID : " + customerId);
        System.out.println("Name        : " + name);
        System.out.println("Phone       : " + phone);
    }
}
```

---

# 7. BankAccount.java

```java
public class BankAccount {

    int accountNumber;
    double balance;

    public BankAccount(int accountNumber, double balance) {
        this.accountNumber = accountNumber;
        this.balance = balance;
    }

    public void deposit(double amount) {
        balance += amount;
    }

    public void withdraw(double amount) {

        if(balance >= amount)
            balance -= amount;
        else
            System.out.println("Insufficient Balance");
    }

    public void displayBalance() {
        System.out.println("Balance : " + balance);
    }
}
```

---

# 8. Main.java

```java
public class Main {

    public static void main(String[] args) {

        Customer customer =
            new Customer(101,"Alice","9876543210");

        BankAccount account =
            new BankAccount(1001,5000);

        customer.displayCustomer();

        account.deposit(2000);

        account.withdraw(1500);

        account.displayBalance();
    }
}
```

---

# 9. Program Flow

```text
Program Starts
      │
      ▼
Create Customer Object
      │
      ▼
Create Account Object
      │
      ▼
Deposit Money
      │
      ▼
Withdraw Money
      │
      ▼
Display Balance
      │
      ▼
Program Ends
```

---

# 10. OOP Concepts Used

| Concept | Usage |
|----------|-------|
| Class | Customer, BankAccount |
| Object | customer, account |
| Constructor | Initialize objects |
| Method | deposit(), withdraw() |
| State | balance, name |
| Behavior | deposit(), displayBalance() |

---

# 11. Future Improvements

As we progress through the handbook, we'll improve this application by adding:

- Encapsulation
- Inheritance
- Interfaces
- Abstract Classes
- Exception Handling
- Collections
- File Handling
- JDBC
- Hibernate
- Spring Boot
- REST APIs

---

# 12. Best Practices

- One class should represent one business entity.
- Keep responsibilities separate.
- Avoid writing all logic in `main()`.
- Use meaningful class and method names.

---

# 13. Interview Questions

1. How do you identify objects in a problem statement?
2. Why did we create separate classes?
3. What OOP concepts are already used in this project?
4. How can this application be improved using encapsulation?
5. How would you extend this project for a real bank?

---

# Summary

This lesson introduced a simple Bank Management System to demonstrate how real-world entities can be modeled as objects. We identified business entities, designed classes, created objects, and implemented basic behavior. This project will serve as the foundation for upcoming lessons, where additional OOP concepts and enterprise practices will be applied incrementally.
