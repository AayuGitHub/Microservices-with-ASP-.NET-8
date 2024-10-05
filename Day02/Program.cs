// Domain-Driven Design (DDD) and Bounded Contexts

// --> Focuses on core business domain.
// --> It's align the design of the system with the business needs by modeling the domain itself in software.

// Core Concepts of DDD:

// 1. Domain: Subject area that business is focused on. For Example. for an eCommerce Store: domain can be: Product, Order and Customer.

// 2. SubDomain: Smaller, Micro Subjects like Payment, shipping and Inventory Management.

// 3. Ubiquitous Language: Shared Language between developers and domain experts that both can understand. This is used to define entities, events and operations.

// 4. Entities and Value Objects: 
// --> Entities: Objects that have unique ids and life cycles.
// --> Value Objects: Objects that represent value without an identity.

// 5. Repositories: Acts as gateways to access the aggregates from a persistence layer, like a database. The idea to abstract the infrastructure concerns from the business logic. e.g. an OrderRepository would be responsible for loading and saving Order aggregates.

// 6. Domain Events: When something important happens within the domain that other parts of the system care might care about, a domain event is raised. These events represent things like "OrderPlaced" or "PaymentProcessed" and can be used to trigger actions within other microservices.


