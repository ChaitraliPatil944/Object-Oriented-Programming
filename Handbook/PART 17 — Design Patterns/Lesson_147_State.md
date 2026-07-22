# Lesson 147 — State Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **State Pattern** is a behavioral design pattern that allows an object to **change its behavior when its internal state changes**.

Instead of using large conditional statements, each state is represented by a separate class.

---

# 2. Problem

Consider an order processing system.

Without the State pattern:

```text
if(state == PENDING)
if(state == PAID)
if(state == SHIPPED)
if(state == DELIVERED)
```

As more states are added, the code becomes harder to maintain.

---

# 3. Solution

Encapsulate each state into its own class.

```text
Context
   │
State
├── Pending
├── Paid
├── Shipped
└── Delivered
```

The context delegates behavior to the current state.

---

# 4. Participants

- Context
- State Interface
- Concrete States
- Client

---

# 5. Structure

```text
Client
   │
Context
   │
Current State
```

---

# 6. Example

### State Interface

```java
interface OrderState {
    void process();
}
```

### Concrete States

```java
class PendingState implements OrderState {

    public void process() {
        System.out.println("Order Pending");
    }
}

class ShippedState implements OrderState {

    public void process() {
        System.out.println("Order Shipped");
    }
}
```

### Context

```java
class Order {

    private OrderState state;

    void setState(OrderState state) {
        this.state = state;
    }

    void processOrder() {
        state.process();
    }
}
```

### Client

```java
Order order = new Order();

order.setState(new PendingState());
order.processOrder();

order.setState(new ShippedState());
order.processOrder();
```

---

# 7. How It Works

```text
Client
   │
Context
   │
Current State
   │
Execute Behavior
```

Changing the state object changes the context's behavior.

---

# 8. Advantages

- Eliminates complex conditional logic
- Easy to add new states
- Improves readability
- Promotes the Open/Closed Principle

---

# 9. Disadvantages

- More classes
- State transitions require careful design

Because replacing one giant `switch` statement with several tiny classes somehow makes everyone's life easier. Against all odds, it usually does.

---

# 10. Real-World Uses

- ATM machines
- Traffic light controllers
- Order management systems
- Media players
- Game character states

---

# 11. State vs Strategy

| State | Strategy |
|-------|----------|
| Behavior depends on internal state | Behavior chosen by client |
| State changes automatically | Strategy selected explicitly |

---

# 12. State vs Command

| State | Command |
|-------|---------|
| Represents current condition | Represents an action |
| Changes behavior | Executes a request |

---

# 13. Best Practices

- Keep each state focused on one responsibility.
- Store transition logic carefully.
- Avoid excessive state classes for trivial systems.
- Use the pattern when behavior changes frequently with state.

---

# 14. Interview Questions

1. What problem does the State pattern solve?
2. State vs Strategy?
3. Why avoid large conditional statements?
4. When should the State pattern be used?
5. Give real-world examples.

---

# 15. Quick Revision

```text
State Pattern

✔ State-Based Behavior
✔ Eliminates if-else Chains
✔ Easy Extension
✔ Better Maintainability

Flow

Client
   │
Context
   │
State
```

---

# 16. Summary

The State pattern allows an object to alter its behavior by delegating work to separate state objects. It replaces large conditional statements with polymorphism, making applications easier to extend, maintain, and understand when behavior depends on changing internal states.
