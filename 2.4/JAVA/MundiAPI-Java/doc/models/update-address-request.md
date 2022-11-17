
# Update Address Request

Request for updating an address

## Structure

`UpdateAddressRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Number` | `String` | Required | Number | String getNumber() | setNumber(String number) |
| `Complement` | `String` | Required | Complement | String getComplement() | setComplement(String complement) |
| `Metadata` | `Map<String, String>` | Required | Metadata | Map<String, String> getMetadata() | setMetadata(Map<String, String> metadata) |
| `Line2` | `String` | Required | Line 2 for address | String getLine2() | setLine2(String line2) |

## Example (as JSON)

```json
{
  "number": "number2",
  "complement": "complement4",
  "metadata": {
    "key0": "metadata3",
    "key1": "metadata4",
    "key2": "metadata5"
  },
  "line_2": "line_28"
}
```

