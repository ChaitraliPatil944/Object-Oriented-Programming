# Lesson 83 — MVC (Model-View-Controller) Architecture

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**MVC (Model-View-Controller)** is one of the most popular architectural patterns used to build desktop, web, and enterprise applications.

It separates an application into three independent components:

- Model
- View
- Controller

This separation improves maintainability, scalability, and testability.

Popular frameworks using MVC include:

- Spring MVC
- ASP.NET MVC
- Ruby on Rails
- Laravel

---

# 2. What is MVC?

MVC divides application responsibilities into three parts.

```text
User
 │
 ▼
View
 │
 ▼
Controller
 │
 ▼
Model
 │
 ▼
Database
```

Each component has a clearly defined responsibility.

---

# 3. MVC Components

## Model

Responsibilities:

- Business logic
- Application data
- Validation
- Database interaction

Example:

```java
class User {
    private int id;
    private String name;
}
```

---

## View

Responsibilities:

- Display data
- User interface
- Receive user input

Examples:

- HTML
- JSP
- Thymeleaf
- React (front-end)

---

## Controller

Responsibilities:

- Handle requests
- Process user input
- Call business services
- Return responses

Example:

```java
@RestController
class UserController {

    @GetMapping("/users")
    public String getUsers() {
        return "Users";
    }
}
```

---

# 4. Request Flow

```text
User
 │
 ▼
View
 │
 ▼
Controller
 │
 ▼
Service
 │
 ▼
Repository
 │
 ▼
Database
```

Response flows back through the same path.

---

# 5. Spring MVC Example

```text
Browser
   │
HTTP Request
   ▼
Controller
   │
Service
   │
Repository
   │
Database
   ▲
Repository
   ▲
Service
   ▲
Controller
   ▲
HTTP Response
   ▲
Browser
```

---

# 6. Advantages

- Separation of Concerns
- Reusable components
- Easier testing
- Better maintainability
- Parallel development
- Cleaner architecture

---

# 7. MVC vs Layered Architecture

| MVC | Layered Architecture |
|-----|----------------------|
| UI architectural pattern | Overall application architecture |
| Model, View, Controller | Controller, Service, Repository, Database |
| Focuses on request handling | Focuses on application organization |
| Often used with layered architecture | Can internally use MVC |

---

# 8. Best Practices

- Keep controllers lightweight.
- Place business logic in services.
- Keep models focused on data.
- Avoid database access directly from controllers.

---

# 9. Common Mistakes

❌ Business logic inside views.

❌ SQL queries inside controllers.

❌ Fat controllers.

❌ Mixing UI and business logic.

---

# 10. Interview Questions

1. What is MVC?
2. Explain Model, View, and Controller.
3. Difference between MVC and Layered Architecture?
4. Why should controllers remain thin?
5. How does Spring MVC work?

---

# 11. Quick Revision

```text
MVC
│
├── Model
│   ├── Data
│   └── Business Logic
│
├── View
│   ├── UI
│   └── Display
│
└── Controller
    ├── Request Handling
    └── Coordinates Model & View
```

---

# 12. Interview Cheat Sheet

```text
User
 │
 ▼
View
 │
 ▼
Controller
 │
 ▼
Model
 │
 ▼
Database

Response follows the reverse path.
```

---

# 13. Summary

MVC (Model-View-Controller) is an architectural pattern that separates user interface, business logic, and request handling into independent components. By clearly separating responsibilities, MVC improves maintainability, scalability, testability, and team productivity. Enterprise frameworks such as Spring MVC and ASP.NET MVC rely on this pattern to build robust, maintainable web applications.
