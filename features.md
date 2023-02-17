# Features

Considerations for implementation from past projects.

- [ ] [Default value configurations](https://github.com/JaimeStill/data-conductor/blob/main/src/server/Conductor.Data/Config/ConnectorConfig.cs)
- [ ] Build out [`tasks.json`](https://github.com/JaimeStill/data-conductor/blob/main/.vscode/tasks.json)
- [ ] Look at how data is [streamed](https://github.com/JaimeStill/distributed-architecture/blob/main/src/App.Services/PhotoService.cs#L54) from an [`IStreamService<T>`](https://github.com/JaimeStill/distributed-architecture/blob/main/src/Picsum.Services/PicsumStreamService.cs)
    * Consider how this feature could be broken apart from the `ServiceBase` hierarchy and instead built through composition (i.e. a service has a `IStreamService` feature vs. extends the functionality into the base service). Not every class has to be a service. Classes can provide their own [specialized functionality](https://github.com/JaimeStill/distributed-architecture/blob/main/src/Picsum/PicsumPhoto.cs) and be part of the service composition.
- [ ] Consider how to expose [contracts](https://github.com/JaimeStill/distributed-architecture/tree/main/src/Platform.Contracts) between services.
- [ ] Re-engage the idea of using [`Sync`](https://github.com/JaimeStill/service-architecture/blob/main/server/Playground.Data/Models/Sync/Sync.cs) via a SignalR [`SyncHub`](https://github.com/JaimeStill/service-architecture/blob/main/server/Playground.Web/Hubs/SyncHub.cs) to synchronize API actions across distributed clients.
    * Client side infrastructure:
        * [`SyncNode`](https://github.com/JaimeStill/service-architecture/blob/main/client/core/models/sync/sync-node.ts)  - Model for isolating which synchronization endpoints are relevant to a particular route.
        * [`SyncSocket`](https://github.com/JaimeStill/service-architecture/blob/main/client/core/sockets/sync.socket.ts) service encapsulates socket interactions.
        * [`SyncRoute`](https://github.com/JaimeStill/service-architecture/blob/main/client/core/models/routes/sync.route.ts) - Abstract class that encapsulates common functionality of working with a synchronized route.
    * Should be optimized by incorporating the notion of node channels at the server hub group level. This way, broadcasts are only directed to the intended channel to begin with vs. relying on the `SyncRoute` to filter relevant requests.