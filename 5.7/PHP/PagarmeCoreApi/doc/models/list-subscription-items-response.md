
# List Subscription Items Response

Response model for listing subscription items

## Structure

`ListSubscriptionItemsResponse`

## Fields

| Name | Type | Tags | Description | Getter | Setter |
|  --- | --- | --- | --- | --- | --- |
| `data` | [`GetSubscriptionItemResponse[]`](../../doc/models/get-subscription-item-response.md) | Required | The subscription items | getData(): array | setData(array data): void |
| `paging` | [`PagingResponse`](../../doc/models/paging-response.md) | Required | Paging object | getPaging(): PagingResponse | setPaging(PagingResponse paging): void |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "id5",
      "description": "description5",
      "status": "status7",
      "created_at": "2016-03-13T12:52:32.123Z",
      "updated_at": "2016-03-13T12:52:32.123Z",
      "pricing_scheme": {
        "price": 31,
        "scheme_type": "scheme_type7",
        "price_brackets": [
          {
            "start_quantity": 178,
            "price": 116,
            "end_quantity": null,
            "overage_price": null
          },
          {
            "start_quantity": 179,
            "price": 117,
            "end_quantity": null,
            "overage_price": null
          },
          {
            "start_quantity": 180,
            "price": 118,
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
          "value": 160.38,
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
          "value": 160.39,
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
          "value": 160.4,
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
          "value": 15.66,
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
      "subscription": {
        "id": "id1",
        "code": "code9",
        "start_at": "2016-03-13T12:52:32.123Z",
        "interval": "interval9",
        "interval_count": 97,
        "billing_type": "billing_type5",
        "current_cycle": null,
        "payment_method": "payment_method9",
        "currency": "currency1",
        "installments": 9,
        "status": "status3",
        "created_at": "2016-03-13T12:52:32.123Z",
        "updated_at": "2016-03-13T12:52:32.123Z",
        "customer": null,
        "card": {
          "id": "id5",
          "last_four_digits": "last_four_digits1",
          "brand": "brand9",
          "holder_name": "holder_name1",
          "exp_month": 97,
          "exp_year": 199,
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
            "key0": "metadata8",
            "key1": "metadata9"
          },
          "type": "type5",
          "holder_document": "holder_document1",
          "deleted_at": null,
          "first_six_digits": "first_six_digits5",
          "label": "label5"
        },
        "items": [
          {
            "id": "id8",
            "description": "description8",
            "status": "status0",
            "created_at": "2016-03-13T12:52:32.123Z",
            "updated_at": "2016-03-13T12:52:32.123Z",
            "pricing_scheme": {
              "price": 124,
              "scheme_type": "scheme_type0",
              "price_brackets": [
                {
                  "start_quantity": 85,
                  "price": 233,
                  "end_quantity": null,
                  "overage_price": null
                },
                {
                  "start_quantity": 86,
                  "price": 232,
                  "end_quantity": null,
                  "overage_price": null
                },
                {
                  "start_quantity": 87,
                  "price": 231,
                  "end_quantity": null,
                  "overage_price": null
                }
              ],
              "minimum_price": null,
              "percentage": null
            },
            "discounts": [
              {
                "id": "id9",
                "value": 46.81,
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
                "value": 46.82,
                "discount_type": "discount_type8",
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
                "value": 46.83,
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
                "id": "id7",
                "value": 158.09,
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
              "id": "id6",
              "code": "code4",
              "start_at": "2016-03-13T12:52:32.123Z",
              "interval": "interval6",
              "interval_count": 160,
              "billing_type": "billing_type0",
              "current_cycle": null,
              "payment_method": "payment_method4",
              "currency": "currency4",
              "installments": 72,
              "status": "status2",
              "created_at": "2016-03-13T12:52:32.123Z",
              "updated_at": "2016-03-13T12:52:32.123Z",
              "customer": null,
              "card": {
                "id": "id0",
                "last_four_digits": "last_four_digits6",
                "brand": "brand4",
                "holder_name": "holder_name6",
                "exp_month": 50,
                "exp_year": 246,
                "status": "status8",
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
                    "price": 227,
                    "scheme_type": "scheme_type5",
                    "price_brackets": [
                      {
                        "start_quantity": 238,
                        "price": 80,
                        "end_quantity": null,
                        "overage_price": null
                      },
                      {
                        "start_quantity": 239,
                        "price": 79,
                        "end_quantity": null,
                        "overage_price": null
                      },
                      {
                        "start_quantity": 240,
                        "price": 78,
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
                      "value": 26.96,
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
                      "value": 26.97,
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
                      "value": 26.98,
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
                      "id": "id8",
                      "value": 108.8,
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
                    "price": 228,
                    "scheme_type": "scheme_type4",
                    "price_brackets": [
                      {
                        "start_quantity": 237,
                        "price": 81,
                        "end_quantity": null,
                        "overage_price": null
                      },
                      {
                        "start_quantity": 238,
                        "price": 80,
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
                      "value": 26.97,
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
                      "id": "id7",
                      "value": 108.79,
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
                      "id": "id6",
                      "value": 108.78,
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
                  "name": "name4",
                  "quantity": null,
                  "cycles": null,
                  "deleted_at": null
                }
              ],
              "statement_descriptor": "statement_descriptor6",
              "metadata": {
                "key0": "metadata7",
                "key1": "metadata8",
                "key2": "metadata9"
              },
              "setup": {
                "id": "id0",
                "description": "description0",
                "amount": 160,
                "status": "status8"
              },
              "gateway_affiliation_id": "gateway_affiliation_id2",
              "next_billing_at": null,
              "billing_day": null,
              "minimum_price": null,
              "canceled_at": null,
              "discounts": null,
              "increments": [
                {
                  "id": "id1",
                  "value": 77.33,
                  "increment_type": "increment_type3",
                  "status": "status7",
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
                    "type": "type6",
                    "amount": 68,
                    "recipient": null,
                    "gateway_id": "gateway_id6",
                    "options": null,
                    "id": "id4"
                  },
                  {
                    "type": "type7",
                    "amount": 69,
                    "recipient": null,
                    "gateway_id": "gateway_id7",
                    "options": null,
                    "id": "id3"
                  }
                ]
              }
            },
            "name": "name8",
            "quantity": null,
            "cycles": null,
            "deleted_at": null
          },
          {
            "id": "id9",
            "description": "description9",
            "status": "status1",
            "created_at": "2016-03-13T12:52:32.123Z",
            "updated_at": "2016-03-13T12:52:32.123Z",
            "pricing_scheme": {
              "price": 123,
              "scheme_type": "scheme_type1",
              "price_brackets": [
                {
                  "start_quantity": 86,
                  "price": 232,
                  "end_quantity": null,
                  "overage_price": null
                }
              ],
              "minimum_price": null,
              "percentage": null
            },
            "discounts": [
              {
                "id": "id0",
                "value": 46.82,
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
                "id": "id8",
                "value": 158.1,
                "increment_type": "increment_type0",
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
                "value": 158.11,
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
            "subscription": {
              "id": "id5",
              "code": "code3",
              "start_at": "2016-03-13T12:52:32.123Z",
              "interval": "interval7",
              "interval_count": 159,
              "billing_type": "billing_type1",
              "current_cycle": null,
              "payment_method": "payment_method5",
              "currency": "currency5",
              "installments": 71,
              "status": "status3",
              "created_at": "2016-03-13T12:52:32.123Z",
              "updated_at": "2016-03-13T12:52:32.123Z",
              "customer": null,
              "card": {
                "id": "id1",
                "last_four_digits": "last_four_digits7",
                "brand": "brand5",
                "holder_name": "holder_name7",
                "exp_month": 49,
                "exp_year": 247,
                "status": "status7",
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
                  "id": "id2",
                  "description": "description2",
                  "status": "status4",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "updated_at": "2016-03-13T12:52:32.123Z",
                  "pricing_scheme": {
                    "price": 226,
                    "scheme_type": "scheme_type6",
                    "price_brackets": [
                      {
                        "start_quantity": 239,
                        "price": 79,
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
                      "value": 26.95,
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
                      "value": 26.96,
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
                      "id": "id9",
                      "value": 108.81,
                      "increment_type": "increment_type1",
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
                      "value": 108.8,
                      "increment_type": "increment_type0",
                      "status": "status0",
                      "created_at": "2016-03-13T12:52:32.123Z",
                      "cycles": null,
                      "deleted_at": null,
                      "description": null,
                      "subscription": null,
                      "subscription_item": null
                    },
                    {
                      "id": "id7",
                      "value": 108.79,
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
                  "name": "name2",
                  "quantity": null,
                  "cycles": null,
                  "deleted_at": null
                }
              ],
              "statement_descriptor": "statement_descriptor5",
              "metadata": {
                "key0": "metadata8"
              },
              "setup": {
                "id": "id9",
                "description": "description1",
                "amount": 161,
                "status": "status9"
              },
              "gateway_affiliation_id": "gateway_affiliation_id1",
              "next_billing_at": null,
              "billing_day": null,
              "minimum_price": null,
              "canceled_at": null,
              "discounts": null,
              "increments": [
                {
                  "id": "id2",
                  "value": 77.34,
                  "increment_type": "increment_type4",
                  "status": "status6",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                },
                {
                  "id": "id3",
                  "value": 77.35,
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
                    "type": "type5",
                    "amount": 67,
                    "recipient": null,
                    "gateway_id": "gateway_id5",
                    "options": null,
                    "id": "id5"
                  }
                ]
              }
            },
            "name": "name9",
            "quantity": null,
            "cycles": null,
            "deleted_at": null
          }
        ],
        "statement_descriptor": "statement_descriptor1",
        "metadata": {
          "key0": "metadata2",
          "key1": "metadata3",
          "key2": "metadata4"
        },
        "setup": {
          "id": "id5",
          "description": "description5",
          "amount": 33,
          "status": "status7"
        },
        "gateway_affiliation_id": "gateway_affiliation_id7",
        "next_billing_at": null,
        "billing_day": null,
        "minimum_price": null,
        "canceled_at": null,
        "discounts": null,
        "increments": [
          {
            "id": "id0",
            "value": 58.82,
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
              "type": "type9",
              "amount": 169,
              "recipient": null,
              "gateway_id": "gateway_id9",
              "options": null,
              "id": "id1"
            },
            {
              "type": "type8",
              "amount": 170,
              "recipient": null,
              "gateway_id": "gateway_id8",
              "options": null,
              "id": "id2"
            }
          ]
        }
      },
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
        "price": 30,
        "scheme_type": "scheme_type8",
        "price_brackets": [
          {
            "start_quantity": 179,
            "price": 117,
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
          "value": 160.39,
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
          "value": 15.67,
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
          "value": 15.68,
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
      "subscription": {
        "id": "id2",
        "code": "code0",
        "start_at": "2016-03-13T12:52:32.123Z",
        "interval": "interval0",
        "interval_count": 98,
        "billing_type": "billing_type4",
        "current_cycle": null,
        "payment_method": "payment_method8",
        "currency": "currency2",
        "installments": 10,
        "status": "status4",
        "created_at": "2016-03-13T12:52:32.123Z",
        "updated_at": "2016-03-13T12:52:32.123Z",
        "customer": null,
        "card": {
          "id": "id6",
          "last_four_digits": "last_four_digits2",
          "brand": "brand0",
          "holder_name": "holder_name2",
          "exp_month": 96,
          "exp_year": 200,
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
            "key0": "metadata7"
          },
          "type": "type4",
          "holder_document": "holder_document0",
          "deleted_at": null,
          "first_six_digits": "first_six_digits6",
          "label": "label6"
        },
        "items": [
          {
            "id": "id9",
            "description": "description9",
            "status": "status1",
            "created_at": "2016-03-13T12:52:32.123Z",
            "updated_at": "2016-03-13T12:52:32.123Z",
            "pricing_scheme": {
              "price": 123,
              "scheme_type": "scheme_type1",
              "price_brackets": [
                {
                  "start_quantity": 86,
                  "price": 232,
                  "end_quantity": null,
                  "overage_price": null
                }
              ],
              "minimum_price": null,
              "percentage": null
            },
            "discounts": [
              {
                "id": "id0",
                "value": 46.82,
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
                "id": "id8",
                "value": 158.1,
                "increment_type": "increment_type0",
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
                "value": 158.11,
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
            "subscription": {
              "id": "id5",
              "code": "code3",
              "start_at": "2016-03-13T12:52:32.123Z",
              "interval": "interval7",
              "interval_count": 159,
              "billing_type": "billing_type1",
              "current_cycle": null,
              "payment_method": "payment_method5",
              "currency": "currency5",
              "installments": 71,
              "status": "status3",
              "created_at": "2016-03-13T12:52:32.123Z",
              "updated_at": "2016-03-13T12:52:32.123Z",
              "customer": null,
              "card": {
                "id": "id1",
                "last_four_digits": "last_four_digits7",
                "brand": "brand5",
                "holder_name": "holder_name7",
                "exp_month": 49,
                "exp_year": 247,
                "status": "status7",
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
                  "id": "id2",
                  "description": "description2",
                  "status": "status4",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "updated_at": "2016-03-13T12:52:32.123Z",
                  "pricing_scheme": {
                    "price": 226,
                    "scheme_type": "scheme_type6",
                    "price_brackets": [
                      {
                        "start_quantity": 239,
                        "price": 79,
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
                      "value": 26.95,
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
                      "value": 26.96,
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
                      "id": "id9",
                      "value": 108.81,
                      "increment_type": "increment_type1",
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
                      "value": 108.8,
                      "increment_type": "increment_type0",
                      "status": "status0",
                      "created_at": "2016-03-13T12:52:32.123Z",
                      "cycles": null,
                      "deleted_at": null,
                      "description": null,
                      "subscription": null,
                      "subscription_item": null
                    },
                    {
                      "id": "id7",
                      "value": 108.79,
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
                  "name": "name2",
                  "quantity": null,
                  "cycles": null,
                  "deleted_at": null
                }
              ],
              "statement_descriptor": "statement_descriptor5",
              "metadata": {
                "key0": "metadata8"
              },
              "setup": {
                "id": "id9",
                "description": "description1",
                "amount": 161,
                "status": "status9"
              },
              "gateway_affiliation_id": "gateway_affiliation_id1",
              "next_billing_at": null,
              "billing_day": null,
              "minimum_price": null,
              "canceled_at": null,
              "discounts": null,
              "increments": [
                {
                  "id": "id2",
                  "value": 77.34,
                  "increment_type": "increment_type4",
                  "status": "status6",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "cycles": null,
                  "deleted_at": null,
                  "description": null,
                  "subscription": null,
                  "subscription_item": null
                },
                {
                  "id": "id3",
                  "value": 77.35,
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
                    "type": "type5",
                    "amount": 67,
                    "recipient": null,
                    "gateway_id": "gateway_id5",
                    "options": null,
                    "id": "id5"
                  }
                ]
              }
            },
            "name": "name9",
            "quantity": null,
            "cycles": null,
            "deleted_at": null
          },
          {
            "id": "id0",
            "description": "description0",
            "status": "status2",
            "created_at": "2016-03-13T12:52:32.123Z",
            "updated_at": "2016-03-13T12:52:32.123Z",
            "pricing_scheme": {
              "price": 122,
              "scheme_type": "scheme_type2",
              "price_brackets": [
                {
                  "start_quantity": 87,
                  "price": 231,
                  "end_quantity": null,
                  "overage_price": null
                },
                {
                  "start_quantity": 88,
                  "price": 230,
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
                "value": 46.83,
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
                "value": 46.84,
                "discount_type": "discount_type0",
                "status": "status4",
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
                "value": 158.11,
                "increment_type": "increment_type1",
                "status": "status9",
                "created_at": "2016-03-13T12:52:32.123Z",
                "cycles": null,
                "deleted_at": null,
                "description": null,
                "subscription": null,
                "subscription_item": null
              },
              {
                "id": "id0",
                "value": 158.12,
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
                "id": "id1",
                "value": 158.13,
                "increment_type": "increment_type3",
                "status": "status7",
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
              "interval": "interval8",
              "interval_count": 158,
              "billing_type": "billing_type2",
              "current_cycle": null,
              "payment_method": "payment_method6",
              "currency": "currency6",
              "installments": 70,
              "status": "status4",
              "created_at": "2016-03-13T12:52:32.123Z",
              "updated_at": "2016-03-13T12:52:32.123Z",
              "customer": null,
              "card": {
                "id": "id2",
                "last_four_digits": "last_four_digits8",
                "brand": "brand6",
                "holder_name": "holder_name8",
                "exp_month": 48,
                "exp_year": 248,
                "status": "status6",
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
                  "id": "id1",
                  "description": "description1",
                  "status": "status3",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "updated_at": "2016-03-13T12:52:32.123Z",
                  "pricing_scheme": {
                    "price": 225,
                    "scheme_type": "scheme_type7",
                    "price_brackets": [
                      {
                        "start_quantity": 240,
                        "price": 78,
                        "end_quantity": null,
                        "overage_price": null
                      },
                      {
                        "start_quantity": 241,
                        "price": 77,
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
                      "value": 26.94,
                      "discount_type": "discount_type0",
                      "status": "status4",
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
                      "value": 108.82,
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
                      "value": 108.81,
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
                  "subscription": null,
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
                    "price": 226,
                    "scheme_type": "scheme_type6",
                    "price_brackets": [
                      {
                        "start_quantity": 239,
                        "price": 79,
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
                      "value": 26.95,
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
                      "value": 26.96,
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
                      "id": "id9",
                      "value": 108.81,
                      "increment_type": "increment_type1",
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
                      "value": 108.8,
                      "increment_type": "increment_type0",
                      "status": "status0",
                      "created_at": "2016-03-13T12:52:32.123Z",
                      "cycles": null,
                      "deleted_at": null,
                      "description": null,
                      "subscription": null,
                      "subscription_item": null
                    },
                    {
                      "id": "id7",
                      "value": 108.79,
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
                  "name": "name2",
                  "quantity": null,
                  "cycles": null,
                  "deleted_at": null
                },
                {
                  "id": "id3",
                  "description": "description3",
                  "status": "status5",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "updated_at": "2016-03-13T12:52:32.123Z",
                  "pricing_scheme": {
                    "price": 227,
                    "scheme_type": "scheme_type5",
                    "price_brackets": [
                      {
                        "start_quantity": 238,
                        "price": 80,
                        "end_quantity": null,
                        "overage_price": null
                      },
                      {
                        "start_quantity": 239,
                        "price": 79,
                        "end_quantity": null,
                        "overage_price": null
                      },
                      {
                        "start_quantity": 240,
                        "price": 78,
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
                      "value": 26.96,
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
                      "value": 26.97,
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
                      "value": 26.98,
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
                      "id": "id8",
                      "value": 108.8,
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
                  "subscription": null,
                  "name": "name3",
                  "quantity": null,
                  "cycles": null,
                  "deleted_at": null
                }
              ],
              "statement_descriptor": "statement_descriptor4",
              "metadata": {
                "key0": "metadata9",
                "key1": "metadata0"
              },
              "setup": {
                "id": "id8",
                "description": "description2",
                "amount": 162,
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
                  "value": 77.35,
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
                  "value": 77.36,
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
                  "value": 77.37,
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
              "boleto_due_days": null,
              "split": {
                "enabled": false,
                "rules": [
                  {
                    "type": "type4",
                    "amount": 66,
                    "recipient": null,
                    "gateway_id": "gateway_id4",
                    "options": null,
                    "id": "id6"
                  },
                  {
                    "type": "type5",
                    "amount": 67,
                    "recipient": null,
                    "gateway_id": "gateway_id5",
                    "options": null,
                    "id": "id5"
                  },
                  {
                    "type": "type6",
                    "amount": 68,
                    "recipient": null,
                    "gateway_id": "gateway_id6",
                    "options": null,
                    "id": "id4"
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
              "price": 121,
              "scheme_type": "scheme_type3",
              "price_brackets": [
                {
                  "start_quantity": 88,
                  "price": 230,
                  "end_quantity": null,
                  "overage_price": null
                },
                {
                  "start_quantity": 89,
                  "price": 229,
                  "end_quantity": null,
                  "overage_price": null
                },
                {
                  "start_quantity": 90,
                  "price": 228,
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
                "value": 46.84,
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
                "value": 46.85,
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
                "value": 46.86,
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
                "value": 158.12,
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
            "subscription": {
              "id": "id3",
              "code": "code1",
              "start_at": "2016-03-13T12:52:32.123Z",
              "interval": "interval9",
              "interval_count": 157,
              "billing_type": "billing_type3",
              "current_cycle": null,
              "payment_method": "payment_method7",
              "currency": "currency7",
              "installments": 69,
              "status": "status5",
              "created_at": "2016-03-13T12:52:32.123Z",
              "updated_at": "2016-03-13T12:52:32.123Z",
              "customer": null,
              "card": {
                "id": "id3",
                "last_four_digits": "last_four_digits9",
                "brand": "brand7",
                "holder_name": "holder_name9",
                "exp_month": 47,
                "exp_year": 249,
                "status": "status5",
                "created_at": "2016-03-13T12:52:32.123Z",
                "updated_at": "2016-03-13T12:52:32.123Z",
                "billing_address": {
                  "street": "street5",
                  "number": "number7",
                  "zip_code": "zip_code9",
                  "neighborhood": "neighborhood1",
                  "city": "city5",
                  "state": "state9",
                  "country": "country9",
                  "complement": "complement9",
                  "line_1": "line_11",
                  "line_2": "line_23"
                },
                "customer": null,
                "metadata": {
                  "key0": "metadata0"
                },
                "type": "type7",
                "holder_document": "holder_document3",
                "deleted_at": null,
                "first_six_digits": "first_six_digits3",
                "label": "label3"
              },
              "items": [
                {
                  "id": "id0",
                  "description": "description0",
                  "status": "status2",
                  "created_at": "2016-03-13T12:52:32.123Z",
                  "updated_at": "2016-03-13T12:52:32.123Z",
                  "pricing_scheme": {
                    "price": 224,
                    "scheme_type": "scheme_type8",
                    "price_brackets": [
                      {
                        "start_quantity": 241,
                        "price": 77,
                        "end_quantity": null,
                        "overage_price": null
                      },
                      {
                        "start_quantity": 242,
                        "price": 76,
                        "end_quantity": null,
                        "overage_price": null
                      },
                      {
                        "start_quantity": 243,
                        "price": 75,
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
                      "value": 26.93,
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
                      "value": 26.94,
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
                      "value": 26.95,
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
                      "value": 108.83,
                      "increment_type": "increment_type3",
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
                    "price": 225,
                    "scheme_type": "scheme_type7",
                    "price_brackets": [
                      {
                        "start_quantity": 240,
                        "price": 78,
                        "end_quantity": null,
                        "overage_price": null
                      },
                      {
                        "start_quantity": 241,
                        "price": 77,
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
                      "value": 26.94,
                      "discount_type": "discount_type0",
                      "status": "status4",
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
                      "value": 108.82,
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
                      "value": 108.81,
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
                  "subscription": null,
                  "name": "name1",
                  "quantity": null,
                  "cycles": null,
                  "deleted_at": null
                }
              ],
              "statement_descriptor": "statement_descriptor3",
              "metadata": {
                "key0": "metadata0",
                "key1": "metadata1",
                "key2": "metadata2"
              },
              "setup": {
                "id": "id7",
                "description": "description3",
                "amount": 163,
                "status": "status1"
              },
              "gateway_affiliation_id": "gateway_affiliation_id9",
              "next_billing_at": null,
              "billing_day": null,
              "minimum_price": null,
              "canceled_at": null,
              "discounts": null,
              "increments": [
                {
                  "id": "id4",
                  "value": 77.36,
                  "increment_type": "increment_type6",
                  "status": "status4",
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
                    "amount": 65,
                    "recipient": null,
                    "gateway_id": "gateway_id3",
                    "options": null,
                    "id": "id7"
                  },
                  {
                    "type": "type4",
                    "amount": 66,
                    "recipient": null,
                    "gateway_id": "gateway_id4",
                    "options": null,
                    "id": "id6"
                  }
                ]
              }
            },
            "name": "name1",
            "quantity": null,
            "cycles": null,
            "deleted_at": null
          }
        ],
        "statement_descriptor": "statement_descriptor2",
        "metadata": {
          "key0": "metadata1",
          "key1": "metadata2"
        },
        "setup": {
          "id": "id6",
          "description": "description6",
          "amount": 34,
          "status": "status8"
        },
        "gateway_affiliation_id": "gateway_affiliation_id8",
        "next_billing_at": null,
        "billing_day": null,
        "minimum_price": null,
        "canceled_at": null,
        "discounts": null,
        "increments": [
          {
            "id": "id9",
            "value": 58.81,
            "increment_type": "increment_type1",
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
            "value": 58.8,
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
          "enabled": false,
          "rules": [
            {
              "type": "type8",
              "amount": 170,
              "recipient": null,
              "gateway_id": "gateway_id8",
              "options": null,
              "id": "id2"
            },
            {
              "type": "type7",
              "amount": 171,
              "recipient": null,
              "gateway_id": "gateway_id7",
              "options": null,
              "id": "id3"
            },
            {
              "type": "type6",
              "amount": 172,
              "recipient": null,
              "gateway_id": "gateway_id6",
              "options": null,
              "id": "id4"
            }
          ]
        }
      },
      "name": "name6",
      "quantity": null,
      "cycles": null,
      "deleted_at": null
    }
  ],
  "paging": {
    "total": 6,
    "previous": "previous2",
    "next": "next8"
  }
}
```

