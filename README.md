---

### :computer: Microservices-CQRS-Pattern

> :page_facing_up: This repository contains a sample project that demonstrates the implementation of the **Command Query Responsibility Segregation (CQRS)** pattern within a microservice architecture. The project is developed using C# :black_circle: and .NET :purple_circle:, showcasing two different approaches to CQRS.

### :card_file_box: Project Structure

> :building_construction: The project is designed with a clear separation of concerns, reflecting the principles of CQRS.

### 1\. :hammer_and_wrench: Manual CQRS Implementation

> :thinking: This section of the project provides a foundational understanding of the CQRS pattern by implementing it from scratch.

- :gear: **Commands**: Operations that change the state of the application (e.g., `CreateProductCommand`, `DeleteProductCommand`).
- :mag_right: **Queries**: Operations that retrieve data without changing the state (e.g., `GetAllProductsQuery`, `GetProductByIdQuery`).
- :robot: **Handlers**: Classes responsible for executing the logic of a specific Command or Query.

### 2\. :package: MediatR-based CQRS Implementation

> :rocket: For a more robust and scalable approach, the project also integrates the popular **MediatR** library. MediatR acts as an in-process mediator, decoupling the requests from their handlers.

- :inbox_tray: **Commands & Queries**: Defined as `IRequest<TResponse>` objects.
- :electric_plug: **Handlers**: Implement `IRequestHandler<TRequest, TResponse>` to handle the corresponding requests.

> :sparkles: This implementation simplifies the dependency injection and routing of requests to their respective handlers, making the codebase cleaner and more maintainable.
