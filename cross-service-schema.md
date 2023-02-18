# Cross Service Schema

Cross-service dependencies can be identified by entities that contain a `{Value}Id` property without a corresponding **Navigation Property**.

The following lists entities have ties to entities in an external service.

## Enterprise

* `Organization` -> **Staffing** -> `Workflow`
* `Organization` -> **Staffing** -> `WorkflowT`
* `User` -> **Staffing** -> `Note`
* `User` -> **Staffing** -> `Process`
* `User` -> **Staffing** -> `Review`
* `User` -> **Staffing** -> `UserRole`

## Staffing

* `Note` -> **Enterprise** -> `User`
* `Process` -> **Enterprise** -> `User`
* `Review` -> **Enterprise** -> `User`
* `UserRole` -> **Enterprise** -> `User`
* `Workflow` -> **Enterprise** -> `Organization`
* `WorkflowT` -> **Enterprise** -> `Organization`