
# Create Transfer

## Structure

`CreateTransfer`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Amount` | `int` | Required | - | int getAmount() | setAmount(int amount) |
| `SourceId` | `String` | Required | - | String getSourceId() | setSourceId(String sourceId) |
| `TargetId` | `String` | Required | - | String getTargetId() | setTargetId(String targetId) |
| `Metadata` | `Map<String, String>` | Optional | - | Map<String, String> getMetadata() | setMetadata(Map<String, String> metadata) |

## Example (as JSON)

```json
{
  "amount": 46,
  "source_id": "source_id6",
  "target_id": "target_id0",
  "metadata": null
}
```

