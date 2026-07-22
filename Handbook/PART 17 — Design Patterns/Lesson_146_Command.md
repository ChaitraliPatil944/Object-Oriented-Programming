# Lesson 146 — Command Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Command Pattern** is a behavioral design pattern that **encapsulates a request as an object**.

This separates the object that invokes an operation from the object that performs it.

---

# 2. Problem

A remote control should work with TVs, fans, lights, and other devices.

Without Command:

```text
Button
  │
if TV
if Fan
if Light
```

Adding new devices requires changing button logic.

---

# 3. Solution

Represent every request as a command object.

```text
Button
   │
Command
   │
Receiver
```

---

# 4. Participants

- Command
- Concrete Command
- Receiver
- Invoker
- Client

---

# 5. Structure

```text
Client
  │
Command
  │
Invoker
  │
Receiver
```

---

# 6. Example

### Command

```java
interface Command{
    void execute();
}
```

### Receiver

```java
class Light{
    void on(){
        System.out.println("Light ON");
    }
}
```

### Concrete Command

```java
class LightOnCommand implements Command{

    private Light light;

    LightOnCommand(Light light){
        this.light=light;
    }

    public void execute(){
        light.on();
    }
}
```

### Invoker

```java
class Remote{

    private Command command;

    void setCommand(Command command){
        this.command=command;
    }

    void pressButton(){
        command.execute();
    }
}
```

### Client

```java
Light light=new Light();
Remote remote=new Remote();

remote.setCommand(new LightOnCommand(light));
remote.pressButton();
```

---

# 7. How It Works

```text
Client
  │
Creates Command
  │
Invoker
  │
execute()
  │
Receiver
```

---

# 8. Advantages

- Loose coupling
- Easy to add new commands
- Supports undo/redo
- Supports queues and scheduling
- Improves extensibility

---

# 9. Disadvantages

- More classes
- Slightly more complex design

Because pressing a single button now requires four objects to agree on reality.

---

# 10. Real-World Uses

- GUI buttons
- Menu actions
- Undo/Redo systems
- Job schedulers
- Task queues

---

# 11. Command vs Strategy

| Command | Strategy |
|---------|----------|
| Encapsulates request | Encapsulates algorithm |
| Focuses on action | Focuses on implementation |

---

# 12. Command vs Observer

| Command | Observer |
|---------|----------|
| Executes one request | Broadcasts notifications |
| Invoked explicitly | Triggered by events |

---

# 13. Best Practices

- Keep commands focused on one action.
- Store receiver inside the command.
- Use for undoable operations.
- Avoid placing business logic in the invoker.

---

# 14. Interview Questions

1. What problem does the Command pattern solve?
2. What are the participants?
3. Command vs Strategy?
4. Why is Command useful for undo?
5. Give real-world examples.

---

# 15. Quick Revision

```text
Command Pattern

✔ Encapsulates Requests
✔ Loose Coupling
✔ Undo/Redo
✔ Scheduling

Flow

Invoker
  │
Command
  │
Receiver
```

---

# 16. Summary

The Command pattern encapsulates requests as objects, allowing clients to parameterize actions, queue operations, support undo functionality, and decouple senders from receivers. It is widely used in user interfaces, automation systems, and enterprise applications.
