
# Create Credit Card Payment Request

The settings for creating a credit card payment

## Structure

`CreateCreditCardPaymentRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `Installments` | `Integer` | Optional | Number of installments<br>**Default**: `1` | Integer getInstallments() | setInstallments(Integer installments) |
| `StatementDescriptor` | `String` | Optional | The text that will be shown on the credit card's statement | String getStatementDescriptor() | setStatementDescriptor(String statementDescriptor) |
| `Card` | [`CreateCardRequest`](../../doc/models/create-card-request.md) | Optional | Credit card data | CreateCardRequest getCard() | setCard(CreateCardRequest card) |
| `CardId` | `String` | Optional | The credit card id | String getCardId() | setCardId(String cardId) |
| `CardToken` | `String` | Optional | - | String getCardToken() | setCardToken(String cardToken) |
| `Recurrence` | `Boolean` | Optional | Indicates a recurrence | Boolean getRecurrence() | setRecurrence(Boolean recurrence) |
| `Capture` | `Boolean` | Optional | Indicates if the operation should be only authorization or auth and capture.<br>**Default**: `true` | Boolean getCapture() | setCapture(Boolean capture) |
| `ExtendedLimitEnabled` | `Boolean` | Optional | Indicates whether the extended label (private label) is enabled | Boolean getExtendedLimitEnabled() | setExtendedLimitEnabled(Boolean extendedLimitEnabled) |
| `ExtendedLimitCode` | `String` | Optional | Extended Limit Code | String getExtendedLimitCode() | setExtendedLimitCode(String extendedLimitCode) |
| `MerchantCategoryCode` | `Long` | Optional | Customer business segment code | Long getMerchantCategoryCode() | setMerchantCategoryCode(Long merchantCategoryCode) |
| `Authentication` | [`CreatePaymentAuthenticationRequest`](../../doc/models/create-payment-authentication-request.md) | Optional | The payment authentication request | CreatePaymentAuthenticationRequest getAuthentication() | setAuthentication(CreatePaymentAuthenticationRequest authentication) |
| `Contactless` | [`CreateCardPaymentContactlessRequest`](../../doc/models/create-card-payment-contactless-request.md) | Optional | The Credit card payment contactless request | CreateCardPaymentContactlessRequest getContactless() | setContactless(CreateCardPaymentContactlessRequest contactless) |
| `AutoRecovery` | `Boolean` | Optional | Indicates whether a particular payment will enter the offline retry flow | Boolean getAutoRecovery() | setAutoRecovery(Boolean autoRecovery) |
| `OperationType` | `String` | Optional | AuthOnly, AuthAndCapture, PreAuth | String getOperationType() | setOperationType(String operationType) |
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
  "merchant_category_code": null,
  "authentication": null,
  "contactless": null,
  "auto_recovery": null,
  "operation_type": null,
  "recurrency_cycle": null
}
```

