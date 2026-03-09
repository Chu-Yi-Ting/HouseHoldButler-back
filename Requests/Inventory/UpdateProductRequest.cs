namespace BackendApi.Requests.Inventory;

public record UpdateProductRequest(
    string Name,
    Guid? CategoryId,
    string? Barcode,
    decimal AvgConsumptionRate,
    decimal LowStockThreshold);
