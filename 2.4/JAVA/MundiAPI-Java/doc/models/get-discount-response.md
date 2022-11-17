
# Get Discount Response

Response object for getting a discount

## Structure

`GetDiscountResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Id` | `String` | Required | - | String getId() | setId(String id) |
| `Value` | `double` | Required | - | double getValue() | setValue(double value) |
| `DiscountType` | `String` | Required | - | String getDiscountType() | setDiscountType(String discountType) |
| `Status` | `String` | Required | - | String getStatus() | setStatus(String status) |
| `CreatedAt` | `LocalDateTime` | Required | - | LocalDateTime getCreatedAt() | setCreatedAt(LocalDateTime createdAt) |
| `Cycles` | `Integer` | Optional | - | Integer getCycles() | setCycles(Integer cycles) |
| `DeletedAt` | `LocalDateTime` | Optional | - | LocalDateTime getDeletedAt() | setDeletedAt(LocalDateTime deletedAt) |
| `Description` | `String` | Optional | - | String getDescription() | setDescription(String description) |
| `Subscription` | [`GetSubscriptionResponse`](../../doc/models/get-subscription-response.md) | Optional | - | GetSubscriptionResponse getSubscription() | setSubscription(GetSubscriptionResponse subscription) |
| `SubscriptionItem` | [`GetSubscriptionItemResponse`](../../doc/models/get-subscription-item-response.md) | Optional | The subscription item | GetSubscriptionItemResponse getSubscriptionItem() | setSubscriptionItem(GetSubscriptionItemResponse subscriptionItem) |

## Example (as JSON)

```json
{
  "id": "id0",
  "value": 251.52,
  "discount_type": "discount_type8",
  "status": "status8",
  "created_at": "2016-03-13T12:52:32.123Z",
  "cycles": null,
  "deleted_at": null,
  "description": null,
  "subscription": null,
  "subscription_item": null
}
```

