
# Create Sub Merchant Request

SubMerchant

## Structure

`CreateSubMerchantRequest`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `PaymentFacilitatorCode` | `String` | Required | Payment Facilitator Code | String getPaymentFacilitatorCode() | setPaymentFacilitatorCode(String paymentFacilitatorCode) |
| `Code` | `String` | Required | Code | String getCode() | setCode(String code) |
| `Name` | `String` | Required | Name | String getName() | setName(String name) |
| `MerchantCategoryCode` | `String` | Required | Merchant Category Code | String getMerchantCategoryCode() | setMerchantCategoryCode(String merchantCategoryCode) |
| `Document` | `String` | Required | Document number. Only numbers, no special characters. | String getDocument() | setDocument(String document) |
| `Type` | `String` | Required | Document type. Can be either 'individual' or 'company' | String getType() | setType(String type) |
| `Phone` | [`CreatePhoneRequest`](../../doc/models/create-phone-request.md) | Required | Phone | CreatePhoneRequest getPhone() | setPhone(CreatePhoneRequest phone) |
| `Address` | [`CreateAddressRequest`](../../doc/models/create-address-request.md) | Required | Address | CreateAddressRequest getAddress() | setAddress(CreateAddressRequest address) |

## Example (as JSON)

```json
{
  "payment_facilitator_code": "payment_facilitator_code6",
  "code": "code8",
  "name": "name0",
  "merchant_category_code": "merchant_category_code0",
  "document": "document6",
  "type": "type0",
  "phone": {
    "country_code": null,
    "number": null,
    "area_code": null
  },
  "address": {
    "street": "street6",
    "number": "number4",
    "zip_code": "zip_code0",
    "neighborhood": "neighborhood2",
    "city": "city6",
    "state": "state2",
    "country": "country0",
    "complement": "complement2",
    "metadata": {
      "key0": "metadata3",
      "key1": "metadata2",
      "key2": "metadata1"
    },
    "line_1": "line_10",
    "line_2": "line_24"
  }
}
```

