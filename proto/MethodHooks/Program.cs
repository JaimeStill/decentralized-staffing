using MethodHooks;

SquareService sqSvc = new();
StringService strSvc = new();

await sqSvc.ExecuteAction(42);
await strSvc.ExecuteAction("Testing");