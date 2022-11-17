
# Get Subscription Item Response

## Structure

`GetSubscriptionItemResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Description` | `string` | Required | - |
| `Status` | `string` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |
| `UpdatedAt` | `DateTime` | Required | - |
| `PricingScheme` | [`Models.GetPricingSchemeResponse`](../../doc/models/get-pricing-scheme-response.md) | Required | - |
| `Discounts` | [`List<Models.GetDiscountResponse>`](../../doc/models/get-discount-response.md) | Required | - |
| `Increments` | [`List<Models.GetIncrementResponse>`](../../doc/models/get-increment-response.md) | Required | - |
| `Subscription` | [`Models.GetSubscriptionResponse`](../../doc/models/get-subscription-response.md) | Required | - |
| `Name` | `string` | Required | Item name |
| `Quantity` | `int?` | Optional | - |
| `Cycles` | `int?` | Optional | - |
| `DeletedAt` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "id": "id0",
  "description": "description0",
  "status": "status8",
  "created_at": "2016-03-13T12:52:32.123Z",
  "updated_at": "2016-03-13T12:52:32.123Z",
  "pricing_scheme": {
    "price": 166,
    "scheme_type": "scheme_type8",
    "price_brackets": [
      {
        "start_quantity": 119,
        "price": 57,
        "end_quantity": null,
        "overage_price": null
      },
      {
        "start_quantity": 120,
        "price": 58,
        "end_quantity": null,
        "overage_price": null
      },
      {
        "start_quantity": 121,
        "price": 59,
        "end_quantity": null,
        "overage_price": null
      }
    ],
    "minimum_price": null,
    "percentage": null
  },
  "discounts": [
    {
      "id": "id1",
      "value": 10.23,
      "discount_type": "discount_type9",
      "status": "status3",
      "created_at": "2016-03-13T12:52:32.123Z",
      "cycles": null,
      "deleted_at": null,
      "description": null,
      "subscription": null,
      "subscription_item": null
    },
    {
      "id": "id2",
      "value": 10.24,
      "discount_type": "discount_type0",
      "status": "status4",
      "created_at": "2016-03-13T12:52:32.123Z",
      "cycles": null,
      "deleted_at": null,
      "description": null,
      "subscription": null,
      "subscription_item": null
    },
    {
      "id": "id3",
      "value": 10.25,
      "discount_type": "discount_type1",
      "status": "status5",
      "created_at": "2016-03-13T12:52:32.123Z",
      "cycles": null,
      "deleted_at": null,
      "description": null,
      "subscription": null,
      "subscription_item": null
    }
  ],
  "increments": [
    {
      "id": "id7",
      "value": 124.19,
      "increment_type": "increment_type9",
      "status": "status1",
      "created_at": "2016-03-13T12:52:32.123Z",
      "cycles": null,
      "deleted_at": null,
      "description": null,
      "subscription": null,
      "subscription_item": null
    }
  ],
  "subscription": {
    "id": "id4",
    "code": "code2",
    "start_at": "2016-03-13T12:52:32.123Z",
    "interval": "interval2",
    "interval_count": 234,
    "billing_type": "billing_type8",
    "current_cycle": null,
    "payment_method": "payment_method4",
    "currency": "currency4",
    "installments": 146,
    "status": "status6",
    "created_at": "2016-03-13T12:52:32.123Z",
    "updated_at": "2016-03-13T12:52:32.123Z",
    "customer": null,
    "card": {
      "id": "id8",
      "last_four_digits": "last_four_digits4",
      "brand": "brand2",
      "holder_name": "holder_name4",
      "exp_month": 216,
      "exp_year": 80,
      "status": "status0",
      "created_at": "2016-03-13T12:52:32.123Z",
      "updated_at": "2016-03-13T12:52:32.123Z",
      "billing_address": {
        "street": "street0",
        "number": "number2",
        "zip_code": "zip_code4",
        "neighborhood": "neighborhood6",
        "city": "city0",
        "state": "state4",
        "country": "country4",
        "complement": "complement4",
        "line_1": "line_16",
        "line_2": "line_28"
      },
      "customer": null,
      "metadata": {
        "key0": "metadata5",
        "key1": "metadata4"
      },
      "type": "type2",
      "holder_document": "holder_document2",
      "deleted_at": null,
      "first_six_digits": "first_six_digits8",
      "label": "label8"
    },
    "items": [
      {
        "id": "id1",
        "description": "description1",
        "status": "status3",
        "created_at": "2016-03-13T12:52:32.123Z",
        "updated_at": "2016-03-13T12:52:32.123Z",
        "pricing_scheme": {
          "price": 243,
          "scheme_type": "scheme_type3",
          "price_brackets": [
            {
              "start_quantity": 222,
              "price": 96,
              "end_quantity": null,
              "overage_price": null
            },
            {
              "start_quantity": 223,
              "price": 95,
              "end_quantity": null,
              "overage_price": null
            },
            {
              "start_quantity": 224,
              "price": 94,
              "end_quantity": null,
              "overage_price": null
            }
          ],
          "minimum_price": null,
          "percentage": null
        },
        "discounts": [
          {
            "id": "id2",
            "value": 63.54,
            "discount_type": "discount_type0",
            "status": "status4",
            "created_at": "2016-03-13T12:52:32.123Z",
            "cycles": null,
            "deleted_at": null,
            "description": null,
            "subscription": null,
            "subscription_item": null
          },
          {
            "id": "id3",
            "value": 63.55,
            "discount_type": "discount_type1",
            "status": "status5",
            "created_at": "2016-03-13T12:52:32.123Z",
            "cycles": null,
            "deleted_at": null,
            "description": null,
            "subscription": null,
            "subscription_item": null
          },
          {
            "id": "id4",
            "value": 63.56,
            "discount_type": "discount_type2",
            "status": "status6",
            "created_at": "2016-03-13T12:52:32.123Z",
            "cycles": null,
            "deleted_at": null,
            "description": null,
            "subscription": null,
            "subscription_item": null
          }
        ],
        "increments": [
          {
            "id": "id0",
            "value": 174.82,
            "increment_type": "increment_type2",
            "status": "status2",
            "created_at": "2016-03-13T12:52:32.123Z",
            "cycles": null,
            "deleted_at": null,
            "description": null,
            "subscription": null,
            "subscription_item": null
          }
        ],
        "subscription": {
          "id": "id7",
          "code": "code5",
          "start_at": "2016-03-13T12:52:32.123Z",
          "interval": "interval5",
          "interval_count": 141,
          "billing_type": "billing_type9",
          "current_cycle": null,
          "payment_method": "payment_method3",
          "currency": "currency7",
          "installments": 53,
          "status": "status1",
          "created_at": "2016-03-13T12:52:32.123Z",
          "updated_at": "2016-03-13T12:52:32.123Z",
          "customer": null,
          "card": {
            "id": "id9",
            "last_four_digits": "last_four_digits5",
            "brand": "brand3",
            "holder_name": "holder_name5",
            "exp_month": 31,
            "exp_year": 9,
            "status": "status9",
            "created_at": "2016-03-13T12:52:32.123Z",
            "updated_at": "2016-03-13T12:52:32.123Z",
            "billing_address": {
              "street": "street9",
              "number": "number3",
              "zip_code": "zip_code3",
              "neighborhood": "neighborhood5",
              "city": "city1",
              "state": "state5",
              "country": "country3",
              "complement": "complement5",
              "line_1": "line_17",
              "line_2": "line_27"
            },
            "customer": null,
            "metadata": {
              "key0": "metadata4"
            },
            "type": "type1",
            "holder_document": "holder_document7",
            "deleted_at": null,
            "first_six_digits": "first_six_digits9",
            "label": "label9"
          },
          "items": [
            {
              "id": "id4",
              "description": "description4",
              "status": "status6",
              "created_at": "2016-03-13T12:52:32.123Z",
              "updated_at": "2016-03-13T12:52:32.123Z",
              "pricing_scheme": {
                "price": 208,
                "scheme_type": "scheme_type4",
                "price_brackets": [
                  {
                    "start_quantity": 1,
                    "price": 61,
                    "end_quantity": null,
                    "overage_price": null
                  },
                  {
                    "start_quantity": 2,
                    "price": 60,
                    "end_quantity": null,
                    "overage_price": null
                  },
                  {
                    "start_quantity": 3,
                    "price": 59,
                    "end_quantity": null,
                    "overage_price": null
                  }
                ],
                "minimum_price": null,
                "percentage": null
              },
              "discounts": [
                {
                  "id": "id5",
                  "value": 205.97,
                  "discount_type": "discount_type3",
                  "status": "status7",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                },
                {
                  "id": "id6",
                  "value": 205.98,
                  "discount_type": "discount_type4",
                  "status": "status8",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                },
                {
                  "id": "id7",
                  "value": 205.99,
                  "discount_type": "discount_type5",
                  "status": "status9",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                }
              ],
              "increments": [
                {
                  "id": "id3",
                  "value": 61.25,
                  "increment_type": "increment_type5",
                  "status": "status5",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                }
              ],
              "subscription": null,
              "name": "name4",
              "quantity": null,
              "cycles": null,
              "deleted_at": null
            },
            {
              "id": "id5",
              "description": "description5",
              "status": "status7",
              "created_at": "2016-03-13T12:52:32.123Z",
              "updated_at": "2016-03-13T12:52:32.123Z",
              "pricing_scheme": {
                "price": 209,
                "scheme_type": "scheme_type3",
                "price_brackets": [
                  {
                    "start_quantity": 0,
                    "price": 62,
                    "end_quantity": null,
                    "overage_price": null
                  },
                  {
                    "start_quantity": 1,
                    "price": 61,
                    "end_quantity": null,
                    "overage_price": null
                  }
                ],
                "minimum_price": null,
                "percentage": null
              },
              "discounts": [
                {
                  "id": "id6",
                  "value": 205.98,
                  "discount_type": "discount_type4",
                  "status": "status8",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                }
              ],
              "increments": [
                {
                  "id": "id4",
                  "value": 61.26,
                  "increment_type": "increment_type6",
                  "status": "status4",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                },
                {
                  "id": "id5",
                  "value": 61.27,
                  "increment_type": "increment_type7",
                  "status": "status3",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                }
              ],
              "subscription": null,
              "name": "name5",
              "quantity": null,
              "cycles": null,
              "deleted_at": null
            }
          ],
          "statement_descriptor": "statement_descriptor7",
          "metadata": {
            "key0": "metadata6",
            "key1": "metadata7",
            "key2": "metadata8"
          },
          "setup": {
            "id": "id1",
            "description": "description9",
            "amount": 77,
            "status": "status7"
          },
          "gateway_affiliation_id": "gateway_affiliation_id3",
          "next_billing_at": null,
          "billing_day": null,
          "minimum_price": null,
          "canceled_at": null,
          "discounts": null,
          "increments": [
            {
              "id": "id0",
              "value": 92.72,
              "increment_type": "increment_type2",
              "status": "status8",
              "created_at": "2016-03-13T12:52:32.123Z",
              "cycles": null,
              "deleted_at": null,
              "description": null,
              "subscription": null,
              "subscription_item": null
            }
          ],
          "boleto_due_days": null,
          "split": {
            "enabled": true,
            "rules": [
              {
                "type": "type3",
                "amount": 213,
                "recipient": null,
                "gateway_id": "gateway_id3",
                "options": null,
                "id": "id7"
              },
              {
                "type": "type2",
                "amount": 214,
                "recipient": null,
                "gateway_id": "gateway_id2",
                "options": null,
                "id": "id8"
              }
            ]
          }
        },
        "name": "name1",
        "quantity": null,
        "cycles": null,
        "deleted_at": null
      },
      {
        "id": "id2",
        "description": "description2",
        "status": "status4",
        "created_at": "2016-03-13T12:52:32.123Z",
        "updated_at": "2016-03-13T12:52:32.123Z",
        "pricing_scheme": {
          "price": 242,
          "scheme_type": "scheme_type4",
          "price_brackets": [
            {
              "start_quantity": 223,
              "price": 95,
              "end_quantity": null,
              "overage_price": null
            }
          ],
          "minimum_price": null,
          "percentage": null
        },
        "discounts": [
          {
            "id": "id3",
            "value": 63.55,
            "discount_type": "discount_type1",
            "status": "status5",
            "created_at": "2016-03-13T12:52:32.123Z",
            "cycles": null,
            "deleted_at": null,
            "description": null,
            "subscription": null,
            "subscription_item": null
          }
        ],
        "increments": [
          {
            "id": "id1",
            "value": 174.83,
            "increment_type": "increment_type3",
            "status": "status3",
            "created_at": "2016-03-13T12:52:32.123Z",
            "cycles": null,
            "deleted_at": null,
            "description": null,
            "subscription": null,
            "subscription_item": null
          },
          {
            "id": "id2",
            "value": 174.84,
            "increment_type": "increment_type4",
            "status": "status4",
            "created_at": "2016-03-13T12:52:32.123Z",
            "cycles": null,
            "deleted_at": null,
            "description": null,
            "subscription": null,
            "subscription_item": null
          }
        ],
        "subscription": {
          "id": "id8",
          "code": "code6",
          "start_at": "2016-03-13T12:52:32.123Z",
          "interval": "interval6",
          "interval_count": 142,
          "billing_type": "billing_type8",
          "current_cycle": null,
          "payment_method": "payment_method2",
          "currency": "currency8",
          "installments": 54,
          "status": "status0",
          "created_at": "2016-03-13T12:52:32.123Z",
          "updated_at": "2016-03-13T12:52:32.123Z",
          "customer": null,
          "card": {
            "id": "id8",
            "last_four_digits": "last_four_digits4",
            "brand": "brand2",
            "holder_name": "holder_name6",
            "exp_month": 32,
            "exp_year": 8,
            "status": "status0",
            "created_at": "2016-03-13T12:52:32.123Z",
            "updated_at": "2016-03-13T12:52:32.123Z",
            "billing_address": {
              "street": "street0",
              "number": "number2",
              "zip_code": "zip_code4",
              "neighborhood": "neighborhood6",
              "city": "city0",
              "state": "state4",
              "country": "country4",
              "complement": "complement4",
              "line_1": "line_16",
              "line_2": "line_28"
            },
            "customer": null,
            "metadata": {
              "key0": "metadata5",
              "key1": "metadata6"
            },
            "type": "type2",
            "holder_document": "holder_document8",
            "deleted_at": null,
            "first_six_digits": "first_six_digits8",
            "label": "label8"
          },
          "items": [
            {
              "id": "id5",
              "description": "description5",
              "status": "status7",
              "created_at": "2016-03-13T12:52:32.123Z",
              "updated_at": "2016-03-13T12:52:32.123Z",
              "pricing_scheme": {
                "price": 209,
                "scheme_type": "scheme_type3",
                "price_brackets": [
                  {
                    "start_quantity": 0,
                    "price": 62,
                    "end_quantity": null,
                    "overage_price": null
                  },
                  {
                    "start_quantity": 1,
                    "price": 61,
                    "end_quantity": null,
                    "overage_price": null
                  }
                ],
                "minimum_price": null,
                "percentage": null
              },
              "discounts": [
                {
                  "id": "id6",
                  "value": 205.98,
                  "discount_type": "discount_type4",
                  "status": "status8",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                }
              ],
              "increments": [
                {
                  "id": "id4",
                  "value": 61.26,
                  "increment_type": "increment_type6",
                  "status": "status4",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                },
                {
                  "id": "id5",
                  "value": 61.27,
                  "increment_type": "increment_type7",
                  "status": "status3",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                }
              ],
              "subscription": null,
              "name": "name5",
              "quantity": null,
              "cycles": null,
              "deleted_at": null
            },
            {
              "id": "id6",
              "description": "description6",
              "status": "status8",
              "created_at": "2016-03-13T12:52:32.123Z",
              "updated_at": "2016-03-13T12:52:32.123Z",
              "pricing_scheme": {
                "price": 210,
                "scheme_type": "scheme_type2",
                "price_brackets": [
                  {
                    "start_quantity": 255,
                    "price": 63,
                    "end_quantity": null,
                    "overage_price": null
                  }
                ],
                "minimum_price": null,
                "percentage": null
              },
              "discounts": [
                {
                  "id": "id7",
                  "value": 205.99,
                  "discount_type": "discount_type5",
                  "status": "status9",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                },
                {
                  "id": "id8",
                  "value": 206.0,
                  "discount_type": "discount_type6",
                  "status": "status0",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                }
              ],
              "increments": [
                {
                  "id": "id5",
                  "value": 61.27,
                  "increment_type": "increment_type7",
                  "status": "status3",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                },
                {
                  "id": "id6",
                  "value": 61.28,
                  "increment_type": "increment_type8",
                  "status": "status2",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                },
                {
                  "id": "id7",
                  "value": 61.29,
                  "increment_type": "increment_type9",
                  "status": "status1",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                }
              ],
              "subscription": null,
              "name": "name6",
              "quantity": null,
              "cycles": null,
              "deleted_at": null
            },
            {
              "id": "id7",
              "description": "description7",
              "status": "status9",
              "created_at": "2016-03-13T12:52:32.123Z",
              "updated_at": "2016-03-13T12:52:32.123Z",
              "pricing_scheme": {
                "price": 211,
                "scheme_type": "scheme_type1",
                "price_brackets": [
                  {
                    "start_quantity": 254,
                    "price": 64,
                    "end_quantity": null,
                    "overage_price": null
                  },
                  {
                    "start_quantity": 255,
                    "price": 63,
                    "end_quantity": null,
                    "overage_price": null
                  },
                  {
                    "start_quantity": 0,
                    "price": 62,
                    "end_quantity": null,
                    "overage_price": null
                  }
                ],
                "minimum_price": null,
                "percentage": null
              },
              "discounts": [
                {
                  "id": "id8",
                  "value": 206.0,
                  "discount_type": "discount_type6",
                  "status": "status0",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                },
                {
                  "id": "id9",
                  "value": 206.01,
                  "discount_type": "discount_type7",
                  "status": "status1",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                },
                {
                  "id": "id0",
                  "value": 206.02,
                  "discount_type": "discount_type8",
                  "status": "status2",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                }
              ],
              "increments": [
                {
                  "id": "id6",
                  "value": 61.28,
                  "increment_type": "increment_type8",
                  "status": "status2",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                }
              ],
              "subscription": null,
              "name": "name7",
              "quantity": null,
              "cycles": null,
              "deleted_at": null
            }
          ],
          "statement_descriptor": "statement_descriptor8",
          "metadata": {
            "key0": "metadata5",
            "key1": "metadata6"
          },
          "setup": {
            "id": "id2",
            "description": "description8",
            "amount": 78,
            "status": "status6"
          },
          "gateway_affiliation_id": "gateway_affiliation_id4",
          "next_billing_at": null,
          "billing_day": null,
          "minimum_price": null,
          "canceled_at": null,
          "discounts": null,
          "increments": [
            {
              "id": "id1",
              "value": 92.73,
              "increment_type": "increment_type3",
              "status": "status7",
              "created_at": "2016-03-13T12:52:32.123Z",
              "cycles": null,
              "deleted_at": null,
              "description": null,
              "subscription": null,
              "subscription_item": null
            },
            {
              "id": "id0",
              "value": 92.72,
              "increment_type": "increment_type2",
              "status": "status8",
              "created_at": "2016-03-13T12:52:32.123Z",
              "cycles": null,
              "deleted_at": null,
              "description": null,
              "subscription": null,
              "subscription_item": null
            },
            {
              "id": "id9",
              "value": 92.71,
              "increment_type": "increment_type1",
              "status": "status9",
              "created_at": "2016-03-13T12:52:32.123Z",
              "cycles": null,
              "deleted_at": null,
              "description": null,
              "subscription": null,
              "subscription_item": null
            }
          ],
          "boleto_due_days": null,
          "split": {
            "enabled": false,
            "rules": [
              {
                "type": "type2",
                "amount": 214,
                "recipient": null,
                "gateway_id": "gateway_id2",
                "options": null,
                "id": "id8"
              },
              {
                "type": "type1",
                "amount": 215,
                "recipient": null,
                "gateway_id": "gateway_id1",
                "options": null,
                "id": "id9"
              },
              {
                "type": "type0",
                "amount": 216,
                "recipient": null,
                "gateway_id": "gateway_id0",
                "options": null,
                "id": "id0"
              }
            ]
          }
        },
        "name": "name2",
        "quantity": null,
        "cycles": null,
        "deleted_at": null
      }
    ],
    "statement_descriptor": "statement_descriptor4",
    "metadata": {
      "key0": "metadata1",
      "key1": "metadata0",
      "key2": "metadata9"
    },
    "setup": {
      "id": "id8",
      "description": "description8",
      "amount": 170,
      "status": "status0"
    },
    "gateway_affiliation_id": "gateway_affiliation_id0",
    "next_billing_at": null,
    "billing_day": null,
    "minimum_price": null,
    "canceled_at": null,
    "discounts": null,
    "increments": [
      {
        "id": "id3",
        "value": 204.95,
        "increment_type": "increment_type5",
        "status": "status5",
        "created_at": "2016-03-13T12:52:32.123Z",
        "cycles": null,
        "deleted_at": null,
        "description": null,
        "subscription": null,
        "subscription_item": null
      }
    ],
    "boleto_due_days": null,
    "split": {
      "enabled": false,
      "rules": [
        {
          "type": "type4",
          "amount": 50,
          "recipient": null,
          "gateway_id": "gateway_id4",
          "options": null,
          "id": "id4"
        },
        {
          "type": "type5",
          "amount": 51,
          "recipient": null,
          "gateway_id": "gateway_id5",
          "options": null,
          "id": "id5"
        }
      ]
    }
  },
  "name": "name0",
  "quantity": null,
  "cycles": null,
  "deleted_at": null
}
```

