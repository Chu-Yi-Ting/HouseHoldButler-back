namespace BackendApi.Requests.Inventory;

public record CreateProductRequest(
    string Name,
    Guid? CategoryId,
    string? Barcode,
    decimal AvgConsumptionRate,
    decimal LowStockThreshold);
