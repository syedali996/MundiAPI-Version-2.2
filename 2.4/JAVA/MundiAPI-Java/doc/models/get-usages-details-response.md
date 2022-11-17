
# Get Usages Details Response

## Structure

`GetUsagesDetailsResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `SubscriptionId` | `String` | Required | Subscription Identifier | String getSubscriptionId() | setSubscriptionId(String subscriptionId) |
| `TotalAmount` | `int` | Required | Current Invoice Amount | int getTotalAmount() | setTotalAmount(int totalAmount) |
| `Period` | [`GetPeriodResponse`](../../doc/models/get-period-response.md) | Optional | Period Details | GetPeriodResponse getPeriod() | setPeriod(GetPeriodResponse period) |
| `Usages` | [`ListUsagesDetailsResponse`](../../doc/models/list-usages-details-response.md) | Required | Usages Details | ListUsagesDetailsResponse getUsages() | setUsages(ListUsagesDetailsResponse usages) |
| `TotalDiscount` | `Integer` | Optional | Total discounted value | Integer getTotalDiscount() | setTotalDiscount(Integer totalDiscount) |
| `TotalIncrement` | `Integer` | Optional | Total inremented value | Integer getTotalIncrement() | setTotalIncrement(Integer totalIncrement) |

## Example (as JSON)

```json
{
  "subscription_id": "subscription_id0",
  "total_amount": 112,
  "Period": null,
  "Usages": {
    "data": [
      {
        "id": "id1",
        "quantity": 25,
        "description": "description1",
        "used_at": "2016-03-13T12:52:32.123Z",
        "created_at": "2016-03-13T12:52:32.123Z",
        "status": "status3",
        "deleted_at": null,
        "subscription_item": {
          "id": "id7",
          "description": "description7",
          "status": "status9",
          "created_at": "2016-03-13T12:52:32.123Z",
          "updated_at": "2016-03-13T12:52:32.123Z",
          "pricing_scheme": {
            "price": 3,
            "scheme_type": "scheme_type9",
            "price_brackets": [
              {
                "start_quantity": 212,
                "price": 150,
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
              "value": 232.4,
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
              "id": "id6",
              "value": 87.68,
              "increment_type": "increment_type8",
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
              "value": 87.69,
              "increment_type": "increment_type9",
              "status": "status9",
              "created_at": "2016-03-13T12:52:32.123Z",
              "cycles": null,
              "deleted_at": null,
              "description": null,
              "subscription": null,
              "subscription_item": null
            }
          ],
          "subscription": {
            "id": "id3",
            "code": "code1",
            "start_at": "2016-03-13T12:52:32.123Z",
            "interval": "interval1",
            "interval_count": 131,
            "billing_type": "billing_type7",
            "current_cycle": null,
            "payment_method": "payment_method3",
            "currency": "currency3",
            "installments": 43,
            "status": "status5",
            "created_at": "2016-03-13T12:52:32.123Z",
            "updated_at": "2016-03-13T12:52:32.123Z",
            "customer": null,
            "card": {
              "id": "id7",
              "last_four_digits": "last_four_digits3",
              "brand": "brand1",
              "holder_name": "holder_name3",
              "exp_month": 193,
              "exp_year": 233,
              "status": "status9",
              "created_at": "2016-03-13T12:52:32.123Z",
              "updated_at": "2016-03-13T12:52:32.123Z",
              "billing_address": {
                "street": "street9",
                "number": "number7",
                "zip_code": "zip_code3",
                "neighborhood": "neighborhood5",
                "city": "city9",
                "state": "state5",
                "country": "country3",
                "complement": "complement5",
                "line_1": "line_13",
                "line_2": "line_27"
              },
              "customer": null,
              "metadata": {
                "key0": "metadata2"
              },
              "type": "type7",
              "holder_document": "holder_document1",
              "deleted_at": null,
              "first_six_digits": "first_six_digits7",
              "label": "label7"
            },
            "items": [
              {
                "id": "id0",
                "description": "description0",
                "status": "status2",
                "created_at": "2016-03-13T12:52:32.123Z",
                "updated_at": "2016-03-13T12:52:32.123Z",
                "pricing_scheme": {
                  "price": 166,
                  "scheme_type": "scheme_type2",
                  "price_brackets": [
                    {
                      "start_quantity": 119,
                      "price": 57,
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
                    "value": 118.83,
                    "discount_type": "discount_type9",
                    "status": "status3",
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
                    "id": "id9",
                    "value": 230.11,
                    "increment_type": "increment_type1",
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
                    "value": 230.12,
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
                  "id": "id6",
                  "code": "code4",
                  "start_at": "2016-03-13T12:52:32.123Z",
                  "interval": "interval4",
                  "interval_count": 38,
                  "billing_type": "billing_type0",
                  "current_cycle": null,
                  "payment_method": "payment_method6",
                  "currency": "currency6",
                  "installments": 206,
                  "status": "status8",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "updated_at": "2016-03-13T12:52:32.123Z",
                  "customer": null,
                  "card": {
                    "id": "id0",
                    "last_four_digits": "last_four_digits6",
                    "brand": "brand4",
                    "holder_name": "holder_name6",
                    "exp_month": 156,
                    "exp_year": 140,
                    "status": "status2",
                    "created_at": "2016-03-13T12:52:32.123Z",
                    "updated_at": "2016-03-13T12:52:32.123Z",
                    "billing_address": {
                      "street": "street2",
                      "number": "number0",
                      "zip_code": "zip_code6",
                      "neighborhood": "neighborhood8",
                      "city": "city8",
                      "state": "state2",
                      "country": "country6",
                      "complement": "complement2",
                      "line_1": "line_14",
                      "line_2": "line_20"
                    },
                    "customer": null,
                    "metadata": {
                      "key0": "metadata3"
                    },
                    "type": "type0",
                    "holder_document": "holder_document6",
                    "deleted_at": null,
                    "first_six_digits": "first_six_digits0",
                    "label": "label0"
                  },
                  "items": [
                    {
                      "id": "id3",
                      "description": "description3",
                      "status": "status5",
                      "created_at": "2016-03-13T12:52:32.123Z",
                      "updated_at": "2016-03-13T12:52:32.123Z",
                      "pricing_scheme": {
                        "price": 183,
                        "scheme_type": "scheme_type5",
                        "price_brackets": [
                          {
                            "start_quantity": 26,
                            "price": 36,
                            "end_quantity": null,
                            "overage_price": null
                          }
                        ],
                        "minimum_price": null,
                        "percentage": null
                      },
                      "discounts": [
                        {
                          "id": "id4",
                          "value": 5.26,
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
                          "id": "id2",
                          "value": 116.54,
                          "increment_type": "increment_type4",
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
                          "value": 116.55,
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
                      "name": "name3",
                      "quantity": null,
                      "cycles": null,
                      "deleted_at": null
                    },
                    {
                      "id": "id4",
                      "description": "description4",
                      "status": "status6",
                      "created_at": "2016-03-13T12:52:32.123Z",
                      "updated_at": "2016-03-13T12:52:32.123Z",
                      "pricing_scheme": {
                        "price": 182,
                        "scheme_type": "scheme_type6",
                        "price_brackets": [
                          {
                            "start_quantity": 27,
                            "price": 35,
                            "end_quantity": null,
                            "overage_price": null
                          },
                          {
                            "start_quantity": 28,
                            "price": 34,
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
                          "value": 5.27,
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
                          "value": 5.28,
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
                          "id": "id3",
                          "value": 116.55,
                          "increment_type": "increment_type5",
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
                          "value": 116.56,
                          "increment_type": "increment_type6",
                          "status": "status6",
                          "created_at": "2016-03-13T12:52:32.123Z",
                          "cycles": null,
                          "deleted_at": null,
                          "description": null,
                          "subscription": null,
                          "subscription_item": null
                        },
                        {
                          "id": "id5",
                          "value": 116.57,
                          "increment_type": "increment_type7",
                          "status": "status7",
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
                        "price": 181,
                        "scheme_type": "scheme_type7",
                        "price_brackets": [
                          {
                            "start_quantity": 28,
                            "price": 34,
                            "end_quantity": null,
                            "overage_price": null
                          },
                          {
                            "start_quantity": 29,
                            "price": 33,
                            "end_quantity": null,
                            "overage_price": null
                          },
                          {
                            "start_quantity": 30,
                            "price": 32,
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
                          "value": 5.28,
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
                          "value": 5.29,
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
                          "value": 5.3,
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
                          "id": "id4",
                          "value": 116.56,
                          "increment_type": "increment_type6",
                          "status": "status6",
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
                  "statement_descriptor": "statement_descriptor6",
                  "metadata": {
                    "key0": "metadata3",
                    "key1": "metadata2"
                  },
                  "setup": {
                    "id": "id0",
                    "description": "description0",
                    "amount": 230,
                    "status": "status2"
                  },
                  "gateway_affiliation_id": "gateway_affiliation_id2",
                  "next_billing_at": null,
                  "billing_day": null,
                  "minimum_price": null,
                  "canceled_at": null,
                  "discounts": null,
                  "increments": [
                    {
                      "id": "id5",
                      "value": 146.67,
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
                      "value": 146.68,
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
                  "boleto_due_days": null,
                  "split": {
                    "enabled": false,
                    "rules": [
                      {
                        "type": "type4",
                        "amount": 110,
                        "recipient": null,
                        "gateway_id": "gateway_id4",
                        "options": null,
                        "id": "id6"
                      },
                      {
                        "type": "type3",
                        "amount": 111,
                        "recipient": null,
                        "gateway_id": "gateway_id3",
                        "options": null,
                        "id": "id7"
                      },
                      {
                        "type": "type2",
                        "amount": 112,
                        "recipient": null,
                        "gateway_id": "gateway_id2",
                        "options": null,
                        "id": "id8"
                      }
                    ]
                  }
                },
                "name": "name0",
                "quantity": null,
                "cycles": null,
                "deleted_at": null
              },
              {
                "id": "id1",
                "description": "description1",
                "status": "status3",
                "created_at": "2016-03-13T12:52:32.123Z",
                "updated_at": "2016-03-13T12:52:32.123Z",
                "pricing_scheme": {
                  "price": 167,
                  "scheme_type": "scheme_type3",
                  "price_brackets": [
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
                    "id": "id2",
                    "value": 118.84,
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
                    "value": 118.85,
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
                    "id": "id0",
                    "value": 230.12,
                    "increment_type": "increment_type2",
                    "status": "status2",
                    "created_at": "2016-03-13T12:52:32.123Z",
                    "cycles": null,
                    "deleted_at": null,
                    "description": null,
                    "subscription": null,
                    "subscription_item": null
                  },
                  {
                    "id": "id1",
                    "value": 230.13,
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
                    "value": 230.14,
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
                  "id": "id7",
                  "code": "code5",
                  "start_at": "2016-03-13T12:52:32.123Z",
                  "interval": "interval5",
                  "interval_count": 39,
                  "billing_type": "billing_type1",
                  "current_cycle": null,
                  "payment_method": "payment_method7",
                  "currency": "currency7",
                  "installments": 207,
                  "status": "status9",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "updated_at": "2016-03-13T12:52:32.123Z",
                  "customer": null,
                  "card": {
                    "id": "id1",
                    "last_four_digits": "last_four_digits7",
                    "brand": "brand5",
                    "holder_name": "holder_name7",
                    "exp_month": 155,
                    "exp_year": 141,
                    "status": "status3",
                    "created_at": "2016-03-13T12:52:32.123Z",
                    "updated_at": "2016-03-13T12:52:32.123Z",
                    "billing_address": {
                      "street": "street3",
                      "number": "number9",
                      "zip_code": "zip_code7",
                      "neighborhood": "neighborhood9",
                      "city": "city7",
                      "state": "state1",
                      "country": "country7",
                      "complement": "complement1",
                      "line_1": "line_13",
                      "line_2": "line_21"
                    },
                    "customer": null,
                    "metadata": {
                      "key0": "metadata2",
                      "key1": "metadata3",
                      "key2": "metadata4"
                    },
                    "type": "type9",
                    "holder_document": "holder_document5",
                    "deleted_at": null,
                    "first_six_digits": "first_six_digits1",
                    "label": "label1"
                  },
                  "items": [
                    {
                      "id": "id4",
                      "description": "description4",
                      "status": "status6",
                      "created_at": "2016-03-13T12:52:32.123Z",
                      "updated_at": "2016-03-13T12:52:32.123Z",
                      "pricing_scheme": {
                        "price": 182,
                        "scheme_type": "scheme_type6",
                        "price_brackets": [
                          {
                            "start_quantity": 27,
                            "price": 35,
                            "end_quantity": null,
                            "overage_price": null
                          },
                          {
                            "start_quantity": 28,
                            "price": 34,
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
                          "value": 5.27,
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
                          "value": 5.28,
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
                          "id": "id3",
                          "value": 116.55,
                          "increment_type": "increment_type5",
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
                          "value": 116.56,
                          "increment_type": "increment_type6",
                          "status": "status6",
                          "created_at": "2016-03-13T12:52:32.123Z",
                          "cycles": null,
                          "deleted_at": null,
                          "description": null,
                          "subscription": null,
                          "subscription_item": null
                        },
                        {
                          "id": "id5",
                          "value": 116.57,
                          "increment_type": "increment_type7",
                          "status": "status7",
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
                    }
                  ],
                  "statement_descriptor": "statement_descriptor7",
                  "metadata": {
                    "key0": "metadata4"
                  },
                  "setup": {
                    "id": "id1",
                    "description": "description1",
                    "amount": 231,
                    "status": "status3"
                  },
                  "gateway_affiliation_id": "gateway_affiliation_id3",
                  "next_billing_at": null,
                  "billing_day": null,
                  "minimum_price": null,
                  "canceled_at": null,
                  "discounts": null,
                  "increments": [
                    {
                      "id": "id6",
                      "value": 146.68,
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
                      "value": 146.69,
                      "increment_type": "increment_type9",
                      "status": "status1",
                      "created_at": "2016-03-13T12:52:32.123Z",
                      "cycles": null,
                      "deleted_at": null,
                      "description": null,
                      "subscription": null,
                      "subscription_item": null
                    },
                    {
                      "id": "id8",
                      "value": 146.7,
                      "increment_type": "increment_type0",
                      "status": "status0",
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
                        "amount": 111,
                        "recipient": null,
                        "gateway_id": "gateway_id3",
                        "options": null,
                        "id": "id7"
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
                  "price": 168,
                  "scheme_type": "scheme_type4",
                  "price_brackets": [
                    {
                      "start_quantity": 121,
                      "price": 59,
                      "end_quantity": null,
                      "overage_price": null
                    },
                    {
                      "start_quantity": 122,
                      "price": 60,
                      "end_quantity": null,
                      "overage_price": null
                    },
                    {
                      "start_quantity": 123,
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
                    "id": "id3",
                    "value": 118.85,
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
                    "value": 118.86,
                    "discount_type": "discount_type2",
                    "status": "status6",
                    "created_at": "2016-03-13T12:52:32.123Z",
                    "cycles": null,
                    "deleted_at": null,
                    "description": null,
                    "subscription": null,
                    "subscription_item": null
                  },
                  {
                    "id": "id5",
                    "value": 118.87,
                    "discount_type": "discount_type3",
                    "status": "status7",
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
                    "value": 230.13,
                    "increment_type": "increment_type3",
                    "status": "status3",
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
                  "interval_count": 40,
                  "billing_type": "billing_type2",
                  "current_cycle": null,
                  "payment_method": "payment_method8",
                  "currency": "currency8",
                  "installments": 208,
                  "status": "status0",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "updated_at": "2016-03-13T12:52:32.123Z",
                  "customer": null,
                  "card": {
                    "id": "id2",
                    "last_four_digits": "last_four_digits8",
                    "brand": "brand6",
                    "holder_name": "holder_name8",
                    "exp_month": 154,
                    "exp_year": 142,
                    "status": "status4",
                    "created_at": "2016-03-13T12:52:32.123Z",
                    "updated_at": "2016-03-13T12:52:32.123Z",
                    "billing_address": {
                      "street": "street4",
                      "number": "number8",
                      "zip_code": "zip_code8",
                      "neighborhood": "neighborhood0",
                      "city": "city6",
                      "state": "state0",
                      "country": "country8",
                      "complement": "complement0",
                      "line_1": "line_12",
                      "line_2": "line_22"
                    },
                    "customer": null,
                    "metadata": {
                      "key0": "metadata1",
                      "key1": "metadata2"
                    },
                    "type": "type8",
                    "holder_document": "holder_document4",
                    "deleted_at": null,
                    "first_six_digits": "first_six_digits2",
                    "label": "label2"
                  },
                  "items": [
                    {
                      "id": "id5",
                      "description": "description5",
                      "status": "status7",
                      "created_at": "2016-03-13T12:52:32.123Z",
                      "updated_at": "2016-03-13T12:52:32.123Z",
                      "pricing_scheme": {
                        "price": 181,
                        "scheme_type": "scheme_type7",
                        "price_brackets": [
                          {
                            "start_quantity": 28,
                            "price": 34,
                            "end_quantity": null,
                            "overage_price": null
                          },
                          {
                            "start_quantity": 29,
                            "price": 33,
                            "end_quantity": null,
                            "overage_price": null
                          },
                          {
                            "start_quantity": 30,
                            "price": 32,
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
                          "value": 5.28,
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
                          "value": 5.29,
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
                          "value": 5.3,
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
                          "id": "id4",
                          "value": 116.56,
                          "increment_type": "increment_type6",
                          "status": "status6",
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
                        "price": 180,
                        "scheme_type": "scheme_type8",
                        "price_brackets": [
                          {
                            "start_quantity": 29,
                            "price": 33,
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
                          "value": 5.29,
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
                          "id": "id5",
                          "value": 116.57,
                          "increment_type": "increment_type7",
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
                          "value": 116.58,
                          "increment_type": "increment_type8",
                          "status": "status8",
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
                    }
                  ],
                  "statement_descriptor": "statement_descriptor8",
                  "metadata": {
                    "key0": "metadata5",
                    "key1": "metadata4",
                    "key2": "metadata3"
                  },
                  "setup": {
                    "id": "id2",
                    "description": "description2",
                    "amount": 232,
                    "status": "status4"
                  },
                  "gateway_affiliation_id": "gateway_affiliation_id4",
                  "next_billing_at": null,
                  "billing_day": null,
                  "minimum_price": null,
                  "canceled_at": null,
                  "discounts": null,
                  "increments": [
                    {
                      "id": "id7",
                      "value": 146.69,
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
                  "boleto_due_days": null,
                  "split": {
                    "enabled": false,
                    "rules": [
                      {
                        "type": "type2",
                        "amount": 112,
                        "recipient": null,
                        "gateway_id": "gateway_id2",
                        "options": null,
                        "id": "id8"
                      },
                      {
                        "type": "type1",
                        "amount": 113,
                        "recipient": null,
                        "gateway_id": "gateway_id1",
                        "options": null,
                        "id": "id9"
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
            "statement_descriptor": "statement_descriptor3",
            "metadata": {
              "key0": "metadata6",
              "key1": "metadata5",
              "key2": "metadata4"
            },
            "setup": {
              "id": "id7",
              "description": "description7",
              "amount": 67,
              "status": "status9"
            },
            "gateway_affiliation_id": "gateway_affiliation_id9",
            "next_billing_at": null,
            "billing_day": null,
            "minimum_price": null,
            "canceled_at": null,
            "discounts": null,
            "increments": [
              {
                "id": "id2",
                "value": 4.24,
                "increment_type": "increment_type4",
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
                "value": 4.25,
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
              "enabled": true,
              "rules": [
                {
                  "type": "type3",
                  "amount": 203,
                  "recipient": null,
                  "gateway_id": "gateway_id3",
                  "options": null,
                  "id": "id3"
                },
                {
                  "type": "type4",
                  "amount": 204,
                  "recipient": null,
                  "gateway_id": "gateway_id4",
                  "options": null,
                  "id": "id4"
                },
                {
                  "type": "type5",
                  "amount": 205,
                  "recipient": null,
                  "gateway_id": "gateway_id5",
                  "options": null,
                  "id": "id5"
                }
              ]
            }
          },
          "name": "name7",
          "quantity": null,
          "cycles": null,
          "deleted_at": null
        },
        "code": null,
        "group": null,
        "amount": null
      }
    ],
    "paging": {
      "total": 32,
      "previous": "previous0",
      "next": "next0"
    }
  },
  "total_discount": null,
  "total_increment": null
}
```

