# Lesson 153 — DTOs (Data Transfer Objects)

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

A **DTO (Data Transfer Object)** is a simple object used to transfer data between different layers of an application or between systems.

DTOs contain only the data required for communication and generally do **not** contain business logic.

In enterprise applications, DTOs are commonly used between:

- Controller ↔ Service
- Service ↔ Client
- Microservices
- REST APIs

---

# 2. Why Use DTOs?

Returning entities directly can:

- Expose sensitive fields
- Increase network payload
- Couple API contracts to database models

DTOs solve these problems by exposing only the required data.

---

# 3. Entity vs DTO

| Entity | DTO |
|--------|-----|
| Represents database model | Represents transferred data |
| Contains business rules | Contains only data |
| Managed by ORM | Not managed by ORM |
| May include relationships | Usually flattened |

---

# 4. Example Entity

```java
class User {

    private Long id;
    private String name;
    private String password;
    private String email;
}
```

Returning this entity exposes the password.

---

# 5. Example DTO

```java
class UserDTO {

    private Long id;
    private String name;
    private String email;
}
```

Only the required fields are transferred.

---

# 6. Mapping Entity to DTO

```java
UserDTO dto = new UserDTO();

dto.setId(user.getId());
dto.setName(user.getName());
dto.setEmail(user.getEmail());
```

Libraries like **MapStruct** and **ModelMapper** can automate mapping.

---

# 7. DTO Flow

```text
Database
   │
   ▼
Entity
   │
Service
   │
   ▼
DTO
   │
Controller
   │
   ▼
Client
```

---

# 8. Types of DTOs

- Request DTO
- Response DTO
- Summary DTO
- Detail DTO

Each serves a different communication purpose.

---

# 9. Benefits

- Better security
- Reduced payload size
- Loose coupling
- Stable API contracts
- Easier versioning

---

# 10. Best Practices

- Keep DTOs simple.
- Avoid business logic.
- Create separate request and response DTOs.
- Validate request DTOs.
- Use mapper classes for conversions.

---

# 11. Common Mistakes

❌ Returning entities directly from controllers.

❌ Adding business logic to DTOs.

❌ Reusing one DTO for unrelated APIs.

❌ Exposing confidential information.

---

# 12. Interview Questions

1. What is a DTO?
2. Why are DTOs used instead of entities?
3. What is DTO mapping?
4. What are request and response DTOs?
5. Name popular DTO mapping libraries.

---

# 13. Quick Revision

```text
DTO
│
├── Data Only
├── No Business Logic
├── Entity ↔ DTO Mapping
└── API Communication
```

---

# 14. Interview Cheat Sheet

```text
DTO

✔ Data Transfer Object
✔ No Business Logic
✔ Improves Security
✔ Reduces Payload

Used Between

Controller
Service
Client
```

---

# 15. Summary

Data Transfer Objects (DTOs) are lightweight objects used to transfer data between application layers and external clients. They help protect sensitive information, reduce network traffic, and decouple API models from persistence models. By separating entities from DTOs and using dedicated mapping, enterprise applications become more secure, maintainable, and flexible.
