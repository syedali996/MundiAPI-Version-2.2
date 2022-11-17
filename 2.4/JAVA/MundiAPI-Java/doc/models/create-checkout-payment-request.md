
# Create Checkout Payment Request

Checkout payment request

## Structure

`CreateCheckoutPaymentRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `AcceptedPaymentMethods` | `List<String>` | Required | Accepted Payment Methods | List<String> getAcceptedPaymentMethods() | setAcceptedPaymentMethods(List<String> acceptedPaymentMethods) |
| `AcceptedMultiPaymentMethods` | `List<Object>` | Required | Accepted Multi Payment Methods | List<Object> getAcceptedMultiPaymentMethods() | setAcceptedMultiPaymentMethods(List<Object> acceptedMultiPaymentMethods) |
| `SuccessUrl` | `String` | Required | Success url | String getSuccessUrl() | setSuccessUrl(String successUrl) |
| `DefaultPaymentMethod` | `String` | Optional | Default payment method | String getDefaultPaymentMethod() | setDefaultPaymentMethod(String defaultPaymentMethod) |
| `GatewayAffiliationId` | `String` | Optional | Gateway Affiliation Id | String getGatewayAffiliationId() | setGatewayAffiliationId(String gatewayAffiliationId) |
| `CreditCard` | [`CreateCheckoutCreditCardPaymentRequest`](../../doc/models/create-checkout-credit-card-payment-request.md) | Optional | Credit Card payment request | CreateCheckoutCreditCardPaymentRequest getCreditCard() | setCreditCard(CreateCheckoutCreditCardPaymentRequest creditCard) |
| `DebitCard` | [`CreateCheckoutDebitCardPaymentRequest`](../../doc/models/create-checkout-debit-card-payment-request.md) | Optional | Debit Card payment request | CreateCheckoutDebitCardPaymentRequest getDebitCard() | setDebitCard(CreateCheckoutDebitCardPaymentRequest debitCard) |
| `Boleto` | [`CreateCheckoutBoletoPaymentRequest`](../../doc/models/create-checkout-boleto-payment-request.md) | Optional | Boleto payment request | CreateCheckoutBoletoPaymentRequest getBoleto() | setBoleto(CreateCheckoutBoletoPaymentRequest boleto) |
| `CustomerEditable` | `Boolean` | Optional | Customer is editable? | Boolean getCustomerEditable() | setCustomerEditable(Boolean customerEditable) |
| `ExpiresIn` | `Integer` | Optional | Time in minutes for expiration | Integer getExpiresIn() | setExpiresIn(Integer expiresIn) |
| `SkipCheckoutSuccessPage` | `boolean` | Required | Skip postpay success screen? | boolean getSkipCheckoutSuccessPage() | setSkipCheckoutSuccessPage(boolean skipCheckoutSuccessPage) |
| `BillingAddressEditable` | `boolean` | Required | Billing Address is editable? | boolean getBillingAddressEditable() | setBillingAddressEditable(boolean billingAddressEditable) |
| `BillingAddress` | [`CreateAddressRequest`](../../doc/models/create-address-request.md) | Required | Billing Address | CreateAddressRequest getBillingAddress() | setBillingAddress(CreateAddressRequest billingAddress) |
| `BankTransfer` | [`CreateCheckoutBankTransferRequest`](../../doc/models/create-checkout-bank-transfer-request.md) | Required | Bank Transfer payment request | CreateCheckoutBankTransferRequest getBankTransfer() | setBankTransfer(CreateCheckoutBankTransferRequest bankTransfer) |
| `AcceptedBrands` | `List<String>` | Required | Accepted Brands | List<String> getAcceptedBrands() | setAcceptedBrands(List<String> acceptedBrands) |

## Example (as JSON)

```json
{
  "accepted_payment_methods": [
    "accepted_payment_methods3",
    "accepted_payment_methods4",
    "accepted_payment_methods5"
  ],
  "accepted_multi_payment_methods": [
    {
      "key1": "val1",
      "key2": "val2"
    },
    {
      "key1": "val1",
      "key2": "val2"
    }
  ],
  "success_url": "success_url2",
  "default_payment_method": null,
  "gateway_affiliation_id": null,
  "credit_card": null,
  "debit_card": null,
  "boleto": null,
  "customer_editable": null,
  "expires_in": null,
  "skip_checkout_success_page": false,
  "billing_address_editable": false,
  "billing_address": {
    "street": "street8",
    "number": "number4",
    "zip_code": "zip_code2",
    "neighborhood": "neighborhood4",
    "city": "city2",
    "state": "state6",
    "country": "country2",
    "complement": "complement6",
    "metadata": {
      "key0": "metadata5",
      "key1": "metadata6"
    },
    "line_1": "line_18",
    "line_2": "line_26"
  },
  "bank_transfer": {
    "bank": [
      "bank9",
      "bank0"
    ],
    "retries": 236
  },
  "accepted_brands": [
    "accepted_brands8",
    "accepted_brands9"
  ]
}
```

