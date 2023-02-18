using MethodHooks;

// See https://aka.ms/new-console-template for more information
SquareService sqSvc = new();
StringService strSvc = new();

await sqSvc.ExecuteAction(42);
await strSvc.ExecuteAction("Testing");