# Notes

## Standardized Services

Instead of trying to build disparate systems for each module individually, identify common systems and standardize their implementations. Similar to the staffing decentralization effort, consider how other processes can be made dynamic yet standardized (i.e. - transfers, change tracking, action tracking, inventory, etc.).

### Staffing

Staffing will provide standardized processes for:

* Initial acquisition / approval
* Lifecycle management
* Assist with accountability management
    * Provides the authoritative approvals that facilitate lifecycle management
* Assist with generation of associated data (metadata aggregation)
    * In addition to the records generated from staffing, provides documentation as part of an [`Approved` token](https://github.com/JaimeStill/decentralized-staffing/issues/15).

## Module Concepts

Modules exist to provide the following common features:

* Definition of the shape of a small network of related data constrained to a domain context
* Initial capability development of authoritative domain data
* Accountability management
    * This can potentially be outsourced to a standardized service
* Lifecycle management
* Metadata aggregation
* Risk / trend analysis
* Data collection

### Module Responsibilities

* Object creation
* Data association
* Manage internally interactive functionality (only relies on generating data pertaining to the internal schema)
* Routing objects to standardized services that facilitate their functionality externally (relies on an external service to manage standardized processes)

## Action Records

Transient records that capture an interaction as it was at that point in time. That way, if there are changes pertaining to the nature of a relationship (i.e. - an item is moved to a different organization) or the property of an item, the historical context can be preserved. This will ease the cognitive burden of always having to consider how changes will affect the state of data over time.

## Localized Staffing

Instead of having a separate, internal proposal and approval process, leverage staffing with internal workflows (workflows with processes that only include the origin organization). This will facilitate internal pre-acquisition / pre-approval processes once the development phase (business development, not software development) is complete. Staffing doesn't have to involve the entire organizational hierarchy.