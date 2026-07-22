# Lesson 145 — Observer Design Pattern

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Observer Pattern** is a behavioral design pattern where **one object (Subject)** automatically notifies **multiple dependent objects (Observers)** whenever its state changes.

It establishes a **one-to-many relationship** between objects.

---

# 2. Problem

Consider a weather station.

When the temperature changes, multiple displays must update.

Without Observer:

```text
Weather Station

Display 1
Display 2
Display 3
```

The weather station must manually update every display, creating tight coupling.

---

# 3. Solution

Use observers.

```text
Subject
   │
Observers
 ├── Mobile App
 ├── LCD Display
 └── Website
```

Whenever the subject changes, all registered observers are notified automatically.

---

# 4. Participants

- Subject
- Concrete Subject
- Observer
- Concrete Observer

---

# 5. Structure

```text
Client
   │
Subject
   │
Notify()
   │
Observers
```

---

# 6. Example

### Observer

```java
interface Observer {
    void update(String message);
}
```

### Subject

```java
interface Subject {
    void addObserver(Observer o);
    void removeObserver(Observer o);
    void notifyObservers();
}
```

### Concrete Subject

```java
class NewsAgency implements Subject {

    private List<Observer> observers = new ArrayList<>();
    private String news;

    public void addObserver(Observer o){
        observers.add(o);
    }

    public void removeObserver(Observer o){
        observers.remove(o);
    }

    public void notifyObservers(){
        for(Observer o : observers){
            o.update(news);
        }
    }

    void setNews(String news){
        this.news = news;
        notifyObservers();
    }
}
```

### Concrete Observer

```java
class NewsChannel implements Observer {

    public void update(String message){
        System.out.println("Breaking News: " + message);
    }
}
```

### Client

```java
NewsAgency agency = new NewsAgency();
agency.addObserver(new NewsChannel());

agency.setNews("Java 25 Released");
```

---

# 7. How It Works

```text
Subject State Changes
        │
 notifyObservers()
        │
 Observer 1
 Observer 2
 Observer 3
```

Every registered observer receives the update.

---

# 8. Advantages

- Loose coupling
- Automatic notifications
- Easy to add or remove observers
- Supports event-driven programming

---

# 9. Disadvantages

- Notification order may vary
- Too many observers can reduce performance
- Debugging notification chains can be difficult

Because one tiny update somehow wakes thirty listeners that all insist they urgently needed to know about it.

---

# 10. Real-World Uses

- GUI event listeners
- Stock market updates
- Chat applications
- Notification systems
- Java Event Model

---

# 11. Observer vs Publisher-Subscriber

| Observer | Publisher-Subscriber |
|----------|----------------------|
| Direct relationship | Usually uses a message broker |
| Same process | Can work across distributed systems |

---

# 12. Observer vs Strategy

| Observer | Strategy |
|----------|----------|
| Event notification | Algorithm selection |
| One-to-many | One chosen behavior |

---

# 13. Best Practices

- Register only interested observers.
- Remove unused observers to avoid memory leaks.
- Keep observer updates lightweight.
- Use asynchronous notifications when appropriate.

---

# 14. Interview Questions

1. What problem does the Observer pattern solve?
2. Observer vs Publisher-Subscriber?
3. Why is Observer loosely coupled?
4. Where is Observer used in Java?
5. Give real-world examples.

---

# 15. Quick Revision

```text
Observer Pattern

✔ One-to-Many
✔ Event Notification
✔ Loose Coupling
✔ Automatic Updates

Flow

Subject
   │
Notify()
   │
Observers
```

---

# 16. Summary

The Observer pattern defines a one-to-many dependency between objects so that when one object's state changes, all dependent objects are notified automatically. It is widely used in event-driven systems, user interfaces, and notification frameworks to promote loose coupling and extensibility.
