# Lesson 156 — Controller Layer

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

The **Controller Layer** is the entry point of an enterprise application. It receives client requests, validates input, delegates work to the **Service Layer**, and returns responses.

In Spring Boot, controllers are commonly annotated with `@RestController` or `@Controller`.

The controller should remain **thin**, containing little or no business logic.

---

# 2. Why Use a Controller Layer?

Without controllers:

- Request handling becomes scattered.
- Business logic may mix with HTTP handling.
- Applications become difficult to maintain.

The controller separates presentation concerns from business logic.

---

# 3. Architecture

```text
Client
  │
HTTP Request
  │
Controller
  │
Service
  │
Repository
  │
Database
```

Each layer has a specific responsibility.

---

# 4. Responsibilities

A controller typically:

- Accepts HTTP requests
- Maps URLs to methods
- Validates input
- Calls service methods
- Returns HTTP responses

It should **not** implement business rules or access repositories directly.

---

# 5. Basic Controller Example

```java
@RestController
@RequestMapping("/users")
public class UserController {

    private final UserService service;

    public UserController(UserService service) {
        this.service = service;
    }

    @GetMapping("/{id}")
    public User getUser(@PathVariable Long id) {
        return service.findById(id);
    }
}
```

The controller delegates work to the service layer.

---

# 6. Common Annotations

| Annotation | Purpose |
|------------|---------|
| `@RestController` | REST controller |
| `@Controller` | MVC controller |
| `@RequestMapping` | Base URL mapping |
| `@GetMapping` | Handle GET requests |
| `@PostMapping` | Handle POST requests |
| `@PutMapping` | Handle PUT requests |
| `@DeleteMapping` | Handle DELETE requests |
| `@PathVariable` | Read URL parameter |
| `@RequestParam` | Read query parameter |
| `@RequestBody` | Read request body |

---

# 7. Request Flow

```text
HTTP Request
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
      │
      ▼
HTTP Response
```

---

# 8. Using DTOs

Controllers commonly exchange DTOs instead of entities.

```java
@PostMapping
public UserResponseDTO create(
        @RequestBody UserRequestDTO dto) {

    return service.create(dto);
}
```

This improves security and API design.

---

# 9. Best Practices

- Keep controllers small.
- Delegate business logic to services.
- Validate incoming requests.
- Return appropriate HTTP status codes.
- Use DTOs for request and response objects.

---

# 10. Common Mistakes

❌ Writing business logic inside controllers.

❌ Accessing repositories directly.

❌ Returning entities with sensitive fields.

❌ Creating overly large controllers. Every extra responsibility quietly applies for permanent residency.

---

# 11. Advantages

- Clear separation of concerns
- Easier testing
- Better maintainability
- Cleaner REST APIs
- Improved readability

---

# 12. Controller vs Service

| Controller | Service |
|------------|---------|
| Handles HTTP | Implements business logic |
| Receives requests | Coordinates operations |
| Returns responses | Uses repositories |

---

# 13. Interview Questions

1. What is the purpose of the Controller Layer?
2. What is the difference between `@Controller` and `@RestController`?
3. Why should controllers remain thin?
4. Why are DTOs commonly used in controllers?
5. Controller vs Service?

---

# 14. Quick Revision

```text
Controller Layer
│
├── HTTP Requests
├── URL Mapping
├── Validation
├── Calls Service
└── Returns Response
```

---

# 15. Interview Cheat Sheet

```text
Controller Layer

✔ Entry Point
✔ @RestController
✔ Handles HTTP
✔ Uses DTOs

Responsibilities

Receive Requests
Call Services
Return Responses
```

---

# 16. Summary

The Controller Layer serves as the interface between clients and the application. It receives HTTP requests, validates input, delegates processing to the Service Layer, and returns appropriate responses. By keeping controllers focused on request handling and moving business logic into services, enterprise Java applications achieve clean architecture, better maintainability, and improved testability.
