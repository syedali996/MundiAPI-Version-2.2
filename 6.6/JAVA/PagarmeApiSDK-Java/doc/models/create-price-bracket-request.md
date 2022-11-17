
# Create Price Bracket Request

Request for creating a price bracket

## Structure

`CreatePriceBracketRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `StartQuantity` | `int` | Required | Start quantity | int getStartQuantity() | setStartQuantity(int startQuantity) |
| `Price` | `int` | Required | Price | int getPrice() | setPrice(int price) |
| `EndQuantity` | `Integer` | Optional | End quantity | Integer getEndQuantity() | setEndQuantity(Integer endQuantity) |
| `OveragePrice` | `Integer` | Optional | Overage price | Integer getOveragePrice() | setOveragePrice(Integer overagePrice) |

## Example (as JSON)

```json
{
  "start_quantity": 46,
  "price": 16,
  "end_quantity": null,
  "overage_price": null
}
```

