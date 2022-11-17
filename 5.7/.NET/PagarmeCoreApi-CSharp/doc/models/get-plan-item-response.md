
# Get Plan Item Response

Response object for getting a plan item

## Structure

`GetPlanItemResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Name` | `string` | Required | - |
| `Status` | `string` | Required | - |
| `CreatedAt` | `DateTime` | Required | - |
| `UpdatedAt` | `DateTime` | Required | - |
| `PricingScheme` | [`Models.GetPricingSchemeResponse`](../../doc/models/get-pricing-scheme-response.md) | Required | - |
| `Description` | `string` | Required | - |
| `Plan` | [`Models.GetPlanResponse`](../../doc/models/get-plan-response.md) | Required | - |
| `Quantity` | `int?` | Optional | - |
| `Cycles` | `int?` | Optional | - |
| `DeletedAt` | `DateTime?` | Optional | - |

## Example (as JSON)

```json
{
  "id": "id0",
  "name": "name0",
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
  "description": "description0",
  "plan": {
    "id": "id4",
    "name": "name4",
    "description": "description4",
    "url": "url8",
    "statement_descriptor": "statement_descriptor4",
    "interval": "interval2",
    "interval_count": 148,
    "billing_type": "billing_type2",
    "payment_methods": [
      "payment_methods9",
      "payment_methods8"
    ],
    "installments": [
      185,
      186,
      187
    ],
    "status": "status6",
    "currency": "currency4",
    "created_at": "2016-03-13T12:52:32.123Z",
    "updated_at": "2016-03-13T12:52:32.123Z",
    "items": [
      {
        "id": "id1",
        "name": "name1",
        "status": "status3",
        "created_at": "2016-03-13T12:52:32.123Z",
        "updated_at": "2016-03-13T12:52:32.123Z",
        "pricing_scheme": {
          "price": 73,
          "scheme_type": "scheme_type3",
          "price_brackets": [
            {
              "start_quantity": 136,
              "price": 182,
              "end_quantity": null,
              "overage_price": null
            },
            {
              "start_quantity": 137,
              "price": 181,
              "end_quantity": null,
              "overage_price": null
            },
            {
              "start_quantity": 138,
              "price": 180,
              "end_quantity": null,
              "overage_price": null
            }
          ],
          "minimum_price": null,
          "percentage": null
        },
        "description": "description1",
        "plan": {
          "id": "id7",
          "name": "name7",
          "description": "description7",
          "url": "url1",
          "statement_descriptor": "statement_descriptor7",
          "interval": "interval5",
          "interval_count": 141,
          "billing_type": "billing_type9",
          "payment_methods": [
            "payment_methods8",
            "payment_methods9"
          ],
          "installments": [
            178,
            179,
            180
          ],
          "status": "status1",
          "currency": "currency7",
          "created_at": "2016-03-13T12:52:32.123Z",
          "updated_at": "2016-03-13T12:52:32.123Z",
          "items": [
            {
              "id": "id4",
              "name": "name4",
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
              "description": "description4",
              "plan": null,
              "quantity": null,
              "cycles": null,
              "deleted_at": null
            },
            {
              "id": "id5",
              "name": "name5",
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
              "description": "description5",
              "plan": null,
              "quantity": null,
              "cycles": null,
              "deleted_at": null
            }
          ],
          "billing_days": [
            114,
            113
          ],
          "shippable": true,
          "metadata": {
            "key0": "metadata6",
            "key1": "metadata7",
            "key2": "metadata8"
          },
          "trial_period_days": null,
          "minimum_price": null,
          "deleted_at": null
        },
        "quantity": null,
        "cycles": null,
        "deleted_at": null
      },
      {
        "id": "id2",
        "name": "name2",
        "status": "status4",
        "created_at": "2016-03-13T12:52:32.123Z",
        "updated_at": "2016-03-13T12:52:32.123Z",
        "pricing_scheme": {
          "price": 72,
          "scheme_type": "scheme_type4",
          "price_brackets": [
            {
              "start_quantity": 137,
              "price": 181,
              "end_quantity": null,
              "overage_price": null
            }
          ],
          "minimum_price": null,
          "percentage": null
        },
        "description": "description2",
        "plan": {
          "id": "id8",
          "name": "name8",
          "description": "description8",
          "url": "url2",
          "statement_descriptor": "statement_descriptor8",
          "interval": "interval6",
          "interval_count": 142,
          "billing_type": "billing_type8",
          "payment_methods": [
            "payment_methods7"
          ],
          "installments": [
            179
          ],
          "status": "status0",
          "currency": "currency8",
          "created_at": "2016-03-13T12:52:32.123Z",
          "updated_at": "2016-03-13T12:52:32.123Z",
          "items": [
            {
              "id": "id5",
              "name": "name5",
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
              "description": "description5",
              "plan": null,
              "quantity": null,
              "cycles": null,
              "deleted_at": null
            },
            {
              "id": "id6",
              "name": "name6",
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
              "description": "description6",
              "plan": null,
              "quantity": null,
              "cycles": null,
              "deleted_at": null
            },
            {
              "id": "id7",
              "name": "name7",
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
              "description": "description7",
              "plan": null,
              "quantity": null,
              "cycles": null,
              "deleted_at": null
            }
          ],
          "billing_days": [
            113,
            112,
            111
          ],
          "shippable": false,
          "metadata": {
            "key0": "metadata5",
            "key1": "metadata6"
          },
          "trial_period_days": null,
          "minimum_price": null,
          "deleted_at": null
        },
        "quantity": null,
        "cycles": null,
        "deleted_at": null
      }
    ],
    "billing_days": [
      149,
      150
    ],
    "shippable": false,
    "metadata": {
      "key0": "metadata9",
      "key1": "metadata0",
      "key2": "metadata1"
    },
    "trial_period_days": null,
    "minimum_price": null,
    "deleted_at": null
  },
  "quantity": null,
  "cycles": null,
  "deleted_at": null
}
```

