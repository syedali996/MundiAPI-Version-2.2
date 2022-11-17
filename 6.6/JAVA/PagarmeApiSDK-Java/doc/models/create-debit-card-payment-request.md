
# Create Debit Card Payment Request

The settings for creating a debit card payment

## Structure

`CreateDebitCardPaymentRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `StatementDescriptor` | `String` | Optional | The text that will be shown on the debit card's statement | String getStatementDescriptor() | setStatementDescriptor(String statementDescriptor) |
| `Card` | [`CreateCardRequest`](../../doc/models/create-card-request.md) | Optional | Debit card data | CreateCardRequest getCard() | setCard(CreateCardRequest card) |
| `CardId` | `String` | Optional | The debit card id | String getCardId() | setCardId(String cardId) |
| `CardToken` | `String` | Optional | The debit card token | String getCardToken() | setCardToken(String cardToken) |
| `Recurrence` | `Boolean` | Optional | Indicates a recurrence | Boolean getRecurrence() | setRecurrence(Boolean recurrence) |
| `Authentication` | [`CreatePaymentAuthenticationRequest`](../../doc/models/create-payment-authentication-request.md) | Optional | The payment authentication request | CreatePaymentAuthenticationRequest getAuthentication() | setAuthentication(CreatePaymentAuthenticationRequest authentication) |
| `Token` | [`CreateCardPaymentContactlessRequest`](../../doc/models/create-card-payment-contactless-request.md) | Optional | The Debit card payment token request | CreateCardPaymentContactlessRequest getToken() | setToken(CreateCardPaymentContactlessRequest token) |

## Example (as JSON)

```json
{
  "statement_descriptor": null,
  "card": null,
  "card_id": null,
  "card_token": null,
  "recurrence": null,
  "authentication": null,
  "token": null
}
```

