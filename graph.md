# Graph API

Provides a flexible cross-service API interface.

## Demonstration

> Be sure to refer to the [Setup](./readme.md#setup) section to ensure you have all of the pre-requisites. Additionally, run the seed task for both the Enterprise and Staffing projects.

1. Run the `enterprise-server-run` task to start the Enterprise service.

2. Verify it is running by navigating to http://localhost:5000/swagger:

    ![image](https://user-images.githubusercontent.com/14102723/230669699-bb94c045-0ca1-48a9-8789-872cf1153053.png)

3. Run the `staffing-server-run` task to start the Staffing service.

4. Verify it is running by navigating to http://localhost:5001/swagger:

    ![image](https://user-images.githubusercontent.com/14102723/230670513-be67dd67-1087-4fa7-877b-f37e11488ff6.png)

5. Execute http://localhost:5001/graph/ to get the Staffing's own graph endpoint ID:

    ```
    "0b3b2860-3185-4f8e-bf4d-a1d5615c174f"
    ```

6. Execute http://localhost:5001/graph/enterprise/ to get the graph ID for the Enterprise graph endpoint:

    ```
    "1021f8cf-e30f-40bf-95f9-b7d51c5c8126"
    ```

7. Execute http://localhost:5001/graph/enterprise/getOrganizations to get the organizations available from the Enterprise graph endpoint:

    ```json
    [
      {
        "id": 1,
        "name": "Adventureworks"
      }
    ]
    ```

## Base Graph API

**Soc.Api.Graph - Base Graph API**  

* [`Endpoint.cs`](./src/lib/Soc.Api/Graph/Endpoint.cs) - The name and base URL of a remote graph endpoint.

* [`Graph.cs`](./src/lib/Soc.Api/Graph/Graph.cs) - The graph ID of the current project and a collection of graph endpoints the project interacts with.

* [`GraphService.cs`](./src/lib/Soc.Api/Graph/GraphService.cs) - A service for extracting the graph configuration (pulled from an injected `IConfiguration` instance) and exposing its details through method calls.

* [`GraphControllerBase.cs`](./src/lib/Soc.Api/Graph/GraphControllerBase.cs) - A base controller class exposing graph endpoint functionality to remote consumers.

* [`GraphClient.cs`](./src/lib/Soc.Api/Graph/GraphClient.cs) - A base class for allowing a remote consumer to interface with a graph endpoint API.

## Enterprise API

The following infrastructure illustrates defining functionality for a publicly-exposed graph endpoint.

* [`appsettings.json`](./src/enterprise/server/Enterprise.Api/appsettings.json#L9) - The `"Graph"` object is used to populate the [`Graph`](./src/lib/Soc.Api/Graph/Graph.cs) details for a registered [`GraphService`](./src/lib/Soc.Api/Graph/GraphService.cs).

* [`GraphController.cs`](./src/enterprise/server/Enterprise.Api/Controllers/GraphController.cs) - Inherits from [`GraphControllerBase`](./src/lib/Soc.Api/Graph/GraphControllerBase.cs) and exposes additional functionality through additional internal services injected into its constructor (see [`OrganizationService`](./src/enterprise/server/Enterprise.Services/OrganizationService.cs)).

* [`EnterpriseGraph.cs`](./src/lib/Soc.Enterprise/EnterpriseGraph.cs) - Defined in the [`Soc.Enterprise`](./src/lib/Soc.Enterprise/) contract library (which defines the public-facing API for the Enterprise graph endpoint). Inherits from [`GraphClient`](./src/lib/Soc.Api/Graph/GraphClient.cs) and defines the methods for calling the API endpoints exposed by the Enterprise graph endpoint's [`GraphController`](./src/enterprise/server/Enterprise.Api/Controllers/GraphController.cs).

* [`Program.cs`](./src/enterprise/server/Enterprise.Api/Program.cs#L40) - `builder.Services.AddGraphService()` (defined in [`GraphService`](./src/lib/Soc.Api/Graph/GraphService.cs)), registers a `GraphService` singleton.

## Staffing API

The following infrastructure illustrates defining functionality for consuming a publicly-exposed graph endpoint.

* [`appsettings.json`](./src/staffing/server/Staffing.Api/appsettings.json#L9) - The `"Graph"` object is used to populate the [`Graph`](./src/lib/Soc.Api/Graph/Graph.cs) details for a registered [`GraphService`](./src/lib/Soc.Api/Graph/GraphService.cs).

* [`Program.cs`](./src/staffing/server/Staffing.Api/Program.cs#L44) - `builder.Services.AddGraphService()` (defined in [`GraphService`](./src/lib/Soc.Api/Graph/GraphService.cs)), registers a `GraphService` singleton. `builder.Services.AddGraphClient<EnterpriseGraph>()` (defined in [`GraphClient`](./src/lib/Soc.Api/Graph/GraphClient.cs#L28)) registers a scoped instance of the [`EnterpriseGraph`](./src/lib/Soc.Enterprise/EnterpriseGraph.cs) client.

* [`EnterpriseController`](./src/staffing/server/Staffing.Api/Controllers/EnterpriseController.cs) - Exposes an API for interfacing with [`EnterpriseGraph`](./src/lib/Soc.Enterprise/EnterpriseGraph.cs).