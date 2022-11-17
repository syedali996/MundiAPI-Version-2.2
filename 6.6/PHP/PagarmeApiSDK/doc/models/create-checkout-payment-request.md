
# Create Checkout Payment Request

Checkout payment request

## Structure

`CreateCheckoutPaymentRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `acceptedPaymentMethods` | `string[]` | Required | Accepted Payment Methods | getAcceptedPaymentMethods(): array | setAcceptedPaymentMethods(array acceptedPaymentMethods): void |
| `acceptedMultiPaymentMethods` | `array[]` | Required | Accepted Multi Payment Methods | getAcceptedMultiPaymentMethods(): array | setAcceptedMultiPaymentMethods(array acceptedMultiPaymentMethods): void |
| `successUrl` | `string` | Required | Success url | getSuccessUrl(): string | setSuccessUrl(string successUrl): void |
| `defaultPaymentMethod` | `?string` | Optional | Default payment method | getDefaultPaymentMethod(): ?string | setDefaultPaymentMethod(?string defaultPaymentMethod): void |
| `gatewayAffiliationId` | `?string` | Optional | Gateway Affiliation Id | getGatewayAffiliationId(): ?string | setGatewayAffiliationId(?string gatewayAffiliationId): void |
| `creditCard` | [`?CreateCheckoutCreditCardPaymentRequest`](../../doc/models/create-checkout-credit-card-payment-request.md) | Optional | Credit Card payment request | getCreditCard(): ?CreateCheckoutCreditCardPaymentRequest | setCreditCard(?CreateCheckoutCreditCardPaymentRequest creditCard): void |
| `debitCard` | [`?CreateCheckoutDebitCardPaymentRequest`](../../doc/models/create-checkout-debit-card-payment-request.md) | Optional | Debit Card payment request | getDebitCard(): ?CreateCheckoutDebitCardPaymentRequest | setDebitCard(?CreateCheckoutDebitCardPaymentRequest debitCard): void |
| `boleto` | [`?CreateCheckoutBoletoPaymentRequest`](../../doc/models/create-checkout-boleto-payment-request.md) | Optional | Boleto payment request | getBoleto(): ?CreateCheckoutBoletoPaymentRequest | setBoleto(?CreateCheckoutBoletoPaymentRequest boleto): void |
| `customerEditable` | `?bool` | Optional | Customer is editable? | getCustomerEditable(): ?bool | setCustomerEditable(?bool customerEditable): void |
| `expiresIn` | `?int` | Optional | Time in minutes for expiration | getExpiresIn(): ?int | setExpiresIn(?int expiresIn): void |
| `skipCheckoutSuccessPage` | `bool` | Required | Skip postpay success screen? | getSkipCheckoutSuccessPage(): bool | setSkipCheckoutSuccessPage(bool skipCheckoutSuccessPage): void |
| `billingAddressEditable` | `bool` | Required | Billing Address is editable? | getBillingAddressEditable(): bool | setBillingAddressEditable(bool billingAddressEditable): void |
| `billingAddress` | [`CreateAddressRequest`](../../doc/models/create-address-request.md) | Required | Billing Address | getBillingAddress(): CreateAddressRequest | setBillingAddress(CreateAddressRequest billingAddress): void |
| `bankTransfer` | [`?CreateCheckoutBankTransferRequest`](../../doc/models/create-checkout-bank-transfer-request.md) | Optional | Bank Transfer payment request | getBankTransfer(): ?CreateCheckoutBankTransferRequest | setBankTransfer(?CreateCheckoutBankTransferRequest bankTransfer): void |
| `acceptedBrands` | `string[]` | Required | Accepted Brands | getAcceptedBrands(): array | setAcceptedBrands(array acceptedBrands): void |
| `pix` | [`?CreateCheckoutPixPaymentRequest`](../../doc/models/create-checkout-pix-payment-request.md) | Optional | Pix payment request | getPix(): ?CreateCheckoutPixPaymentRequest | setPix(?CreateCheckoutPixPaymentRequest pix): void |

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
  "bank_transfer": null,
  "accepted_brands": [
    "accepted_brands8",
    "accepted_brands9"
  ],
  "pix": null
}
```

