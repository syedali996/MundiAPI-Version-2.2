
# Create Private Label Payment Request

The settings for creating a private label payment

## Structure

`CreatePrivateLabelPaymentRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Installments` | `Integer` | Optional | Number of installments<br>**Default**: `1` | Integer getInstallments() | setInstallments(Integer installments) |
| `StatementDescriptor` | `String` | Optional | The text that will be shown on the private label's statement | String getStatementDescriptor() | setStatementDescriptor(String statementDescriptor) |
| `Card` | [`CreateCardRequest`](../../doc/models/create-card-request.md) | Optional | Card data | CreateCardRequest getCard() | setCard(CreateCardRequest card) |
| `CardId` | `String` | Optional | The Card id | String getCardId() | setCardId(String cardId) |
| `CardToken` | `String` | Optional | - | String getCardToken() | setCardToken(String cardToken) |
| `Recurrence` | `Boolean` | Optional | Indicates a recurrence | Boolean getRecurrence() | setRecurrence(Boolean recurrence) |
| `Capture` | `Boolean` | Optional | Indicates if the operation should be only authorization or auth and capture.<br>**Default**: `true` | Boolean getCapture() | setCapture(Boolean capture) |
| `ExtendedLimitEnabled` | `Boolean` | Optional | Indicates whether the extended label (private label) is enabled | Boolean getExtendedLimitEnabled() | setExtendedLimitEnabled(Boolean extendedLimitEnabled) |
| `ExtendedLimitCode` | `String` | Optional | Extended Limit Code | String getExtendedLimitCode() | setExtendedLimitCode(String extendedLimitCode) |
| `RecurrencyCycle` | `String` | Optional | Defines whether the card has been used one or more times. | String getRecurrencyCycle() | setRecurrencyCycle(String recurrencyCycle) |

## Example (as JSON)

```json
{
  "installments": null,
  "statement_descriptor": null,
  "card": null,
  "card_id": null,
  "card_token": null,
  "recurrence": null,
  "capture": null,
  "extended_limit_enabled": null,
  "extended_limit_code": null,
  "recurrency_cycle": null
}
```

