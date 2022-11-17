# Recipients

```php
$recipientsController = $client->getRecipientsController();
```

## Class Name

`RecipientsController`

## Methods

* [Update Recipient](../../doc/controllers/recipients.md#update-recipient)
* [Create Anticipation](../../doc/controllers/recipients.md#create-anticipation)
* [Get Anticipation Limits](../../doc/controllers/recipients.md#get-anticipation-limits)
* [Get Recipients](../../doc/controllers/recipients.md#get-recipients)
* [Get Withdraw by Id](../../doc/controllers/recipients.md#get-withdraw-by-id)
* [Update Recipient Default Bank Account](../../doc/controllers/recipients.md#update-recipient-default-bank-account)
* [Update Recipient Metadata](../../doc/controllers/recipients.md#update-recipient-metadata)
* [Get Transfers](../../doc/controllers/recipients.md#get-transfers)
* [Get Transfer](../../doc/controllers/recipients.md#get-transfer)
* [Create Withdraw](../../doc/controllers/recipients.md#create-withdraw)
* [Update Automatic Anticipation Settings](../../doc/controllers/recipients.md#update-automatic-anticipation-settings)
* [Get Anticipation](../../doc/controllers/recipients.md#get-anticipation)
* [Update Recipient Transfer Settings](../../doc/controllers/recipients.md#update-recipient-transfer-settings)
* [Get Anticipations](../../doc/controllers/recipients.md#get-anticipations)
* [Get Recipient](../../doc/controllers/recipients.md#get-recipient)
* [Get Balance](../../doc/controllers/recipients.md#get-balance)
* [Get Withdrawals](../../doc/controllers/recipients.md#get-withdrawals)
* [Create Transfer](../../doc/controllers/recipients.md#create-transfer)
* [Create Recipient](../../doc/controllers/recipients.md#create-recipient)
* [Get Recipient by Code](../../doc/controllers/recipients.md#get-recipient-by-code)
* [Get Default Recipient](../../doc/controllers/recipients.md#get-default-recipient)


# Update Recipient

Updates a recipient

```php
function updateRecipient(
    string $recipientId,
    UpdateRecipientRequest $request,
    ?string $idempotencyKey = null
): GetRecipientResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `request` | [`UpdateRecipientRequest`](../../doc/models/update-recipient-request.md) | Body, Required | Recipient data |
| `idempotencyKey` | `?string` | Header, Optional | - |

## Response Type

[`GetRecipientResponse`](../../doc/models/get-recipient-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';
$request_name = 'name6';
$request_email = 'email0';
$request_description = 'description6';
$request_type = 'type4';
$request_status = 'status8';
$request_metadata = ['key0' => 'metadata3'];
$request = new Models\UpdateRecipientRequest(
    $request_name,
    $request_email,
    $request_description,
    $request_type,
    $request_status,
    $request_metadata
);

$result = $recipientsController->updateRecipient($recipientId, $request);
```


# Create Anticipation

Creates an anticipation

```php
function createAnticipation(
    string $recipientId,
    CreateAnticipationRequest $request,
    ?string $idempotencyKey = null
): GetAnticipationResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `request` | [`CreateAnticipationRequest`](../../doc/models/create-anticipation-request.md) | Body, Required | Anticipation data |
| `idempotencyKey` | `?string` | Header, Optional | - |

## Response Type

[`GetAnticipationResponse`](../../doc/models/get-anticipation-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';
$request_amount = 242;
$request_timeframe = 'timeframe8';
$request_paymentDate = DateTimeHelper::fromRfc3339DateTime('2016-03-13T12:52:32.123Z');
$request = new Models\CreateAnticipationRequest(
    $request_amount,
    $request_timeframe,
    $request_paymentDate
);

$result = $recipientsController->createAnticipation($recipientId, $request);
```


# Get Anticipation Limits

Gets the anticipation limits for a recipient

```php
function getAnticipationLimits(
    string $recipientId,
    string $timeframe,
    \DateTime $paymentDate
): GetAnticipationLimitResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `timeframe` | `string` | Query, Required | Timeframe |
| `paymentDate` | `\DateTime` | Query, Required | Anticipation payment date |

## Response Type

[`GetAnticipationLimitResponse`](../../doc/models/get-anticipation-limit-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';
$timeframe = 'timeframe2';
$paymentDate = DateTimeHelper::fromRfc3339DateTime('2016-03-13T12:52:32.123Z');

$result = $recipientsController->getAnticipationLimits($recipientId, $timeframe, $paymentDate);
```


# Get Recipients

Retrieves paginated recipients information

```php
function getRecipients(?int $page = null, ?int $size = null): ListRecipientResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `?int` | Query, Optional | Page number |
| `size` | `?int` | Query, Optional | Page size |

## Response Type

[`ListRecipientResponse`](../../doc/models/list-recipient-response.md)

## Example Usage

```php
$result = $recipientsController->getRecipients();
```


# Get Withdraw by Id

```php
function getWithdrawById(string $recipientId, string $withdrawalId): GetWithdrawResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | - |
| `withdrawalId` | `string` | Template, Required | - |

## Response Type

[`GetWithdrawResponse`](../../doc/models/get-withdraw-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';
$withdrawalId = 'withdrawal_id2';

$result = $recipientsController->getWithdrawById($recipientId, $withdrawalId);
```


# Update Recipient Default Bank Account

Updates the default bank account from a recipient

```php
function updateRecipientDefaultBankAccount(
    string $recipientId,
    UpdateRecipientBankAccountRequest $request,
    ?string $idempotencyKey = null
): GetRecipientResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `request` | [`UpdateRecipientBankAccountRequest`](../../doc/models/update-recipient-bank-account-request.md) | Body, Required | Bank account data |
| `idempotencyKey` | `?string` | Header, Optional | - |

## Response Type

[`GetRecipientResponse`](../../doc/models/get-recipient-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';
$request_bankAccount_holderName = 'holder_name6';
$request_bankAccount_holderType = 'holder_type2';
$request_bankAccount_holderDocument = 'holder_document4';
$request_bankAccount_bank = 'bank8';
$request_bankAccount_branchNumber = 'branch_number6';
$request_bankAccount_branchCheckDigit = 'branch_check_digit6';
$request_bankAccount_accountNumber = 'account_number0';
$request_bankAccount_accountCheckDigit = 'account_check_digit6';
$request_bankAccount_type = 'type0';
$request_bankAccount_metadata = ['key0' => 'metadata9', 'key1' => 'metadata8'];
$request_bankAccount_pixKey = 'pix_key4';
$request_bankAccount = new Models\CreateBankAccountRequest(
    $request_bankAccount_holderName,
    $request_bankAccount_holderType,
    $request_bankAccount_holderDocument,
    $request_bankAccount_bank,
    $request_bankAccount_branchNumber,
    $request_bankAccount_branchCheckDigit,
    $request_bankAccount_accountNumber,
    $request_bankAccount_accountCheckDigit,
    $request_bankAccount_type,
    $request_bankAccount_metadata,
    $request_bankAccount_pixKey
);
$request_paymentMode = 'bank_transfer';
$request = new Models\UpdateRecipientBankAccountRequest(
    $request_bankAccount,
    $request_paymentMode
);

$result = $recipientsController->updateRecipientDefaultBankAccount($recipientId, $request);
```


# Update Recipient Metadata

Updates recipient metadata

```php
function updateRecipientMetadata(
    string $recipientId,
    UpdateMetadataRequest $request,
    ?string $idempotencyKey = null
): GetRecipientResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `request` | [`UpdateMetadataRequest`](../../doc/models/update-metadata-request.md) | Body, Required | Metadata |
| `idempotencyKey` | `?string` | Header, Optional | - |

## Response Type

[`GetRecipientResponse`](../../doc/models/get-recipient-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';
$request_metadata = ['key0' => 'metadata3'];
$request = new Models\UpdateMetadataRequest(
    $request_metadata
);

$result = $recipientsController->updateRecipientMetadata($recipientId, $request);
```


# Get Transfers

Gets a paginated list of transfers for the recipient

```php
function getTransfers(
    string $recipientId,
    ?int $page = null,
    ?int $size = null,
    ?string $status = null,
    ?\DateTime $createdSince = null,
    ?\DateTime $createdUntil = null
): ListTransferResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `page` | `?int` | Query, Optional | Page number |
| `size` | `?int` | Query, Optional | Page size |
| `status` | `?string` | Query, Optional | Filter for transfer status |
| `createdSince` | `?\DateTime` | Query, Optional | Filter for start range of transfer creation date |
| `createdUntil` | `?\DateTime` | Query, Optional | Filter for end range of transfer creation date |

## Response Type

[`ListTransferResponse`](../../doc/models/list-transfer-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';

$result = $recipientsController->getTransfers($recipientId);
```


# Get Transfer

Gets a transfer

```php
function getTransfer(string $recipientId, string $transferId): GetTransferResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `transferId` | `string` | Template, Required | Transfer id |

## Response Type

[`GetTransferResponse`](../../doc/models/get-transfer-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';
$transferId = 'transfer_id6';

$result = $recipientsController->getTransfer($recipientId, $transferId);
```


# Create Withdraw

```php
function createWithdraw(string $recipientId, CreateWithdrawRequest $request): GetWithdrawResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | - |
| `request` | [`CreateWithdrawRequest`](../../doc/models/create-withdraw-request.md) | Body, Required | - |

## Response Type

[`GetWithdrawResponse`](../../doc/models/get-withdraw-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';
$request_amount = 242;
$request = new Models\CreateWithdrawRequest(
    $request_amount
);

$result = $recipientsController->createWithdraw($recipientId, $request);
```


# Update Automatic Anticipation Settings

Updates recipient metadata

```php
function updateAutomaticAnticipationSettings(
    string $recipientId,
    UpdateAutomaticAnticipationSettingsRequest $request,
    ?string $idempotencyKey = null
): GetRecipientResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `request` | [`UpdateAutomaticAnticipationSettingsRequest`](../../doc/models/update-automatic-anticipation-settings-request.md) | Body, Required | Metadata |
| `idempotencyKey` | `?string` | Header, Optional | - |

## Response Type

[`GetRecipientResponse`](../../doc/models/get-recipient-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';
$request = new Models\UpdateAutomaticAnticipationSettingsRequest();

$result = $recipientsController->updateAutomaticAnticipationSettings($recipientId, $request);
```


# Get Anticipation

Gets an anticipation

```php
function getAnticipation(string $recipientId, string $anticipationId): GetAnticipationResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `anticipationId` | `string` | Template, Required | Anticipation id |

## Response Type

[`GetAnticipationResponse`](../../doc/models/get-anticipation-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';
$anticipationId = 'anticipation_id0';

$result = $recipientsController->getAnticipation($recipientId, $anticipationId);
```


# Update Recipient Transfer Settings

```php
function updateRecipientTransferSettings(
    string $recipientId,
    UpdateTransferSettingsRequest $request,
    ?string $idempotencyKey = null
): GetRecipientResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient Identificator |
| `request` | [`UpdateTransferSettingsRequest`](../../doc/models/update-transfer-settings-request.md) | Body, Required | - |
| `idempotencyKey` | `?string` | Header, Optional | - |

## Response Type

[`GetRecipientResponse`](../../doc/models/get-recipient-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';
$request_transferEnabled = 'transfer_enabled2';
$request_transferInterval = 'transfer_interval6';
$request_transferDay = 'transfer_day6';
$request = new Models\UpdateTransferSettingsRequest(
    $request_transferEnabled,
    $request_transferInterval,
    $request_transferDay
);

$result = $recipientsController->updateRecipientTransferSettings($recipientId, $request);
```


# Get Anticipations

Retrieves a paginated list of anticipations from a recipient

```php
function getAnticipations(
    string $recipientId,
    ?int $page = null,
    ?int $size = null,
    ?string $status = null,
    ?string $timeframe = null,
    ?\DateTime $paymentDateSince = null,
    ?\DateTime $paymentDateUntil = null,
    ?\DateTime $createdSince = null,
    ?\DateTime $createdUntil = null
): ListAnticipationResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |
| `page` | `?int` | Query, Optional | Page number |
| `size` | `?int` | Query, Optional | Page size |
| `status` | `?string` | Query, Optional | Filter for anticipation status |
| `timeframe` | `?string` | Query, Optional | Filter for anticipation timeframe |
| `paymentDateSince` | `?\DateTime` | Query, Optional | Filter for start range for anticipation payment date |
| `paymentDateUntil` | `?\DateTime` | Query, Optional | Filter for end range for anticipation payment date |
| `createdSince` | `?\DateTime` | Query, Optional | Filter for start range for anticipation creation date |
| `createdUntil` | `?\DateTime` | Query, Optional | Filter for end range for anticipation creation date |

## Response Type

[`ListAnticipationResponse`](../../doc/models/list-anticipation-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';

$result = $recipientsController->getAnticipations($recipientId);
```


# Get Recipient

Retrieves recipient information

```php
function getRecipient(string $recipientId): GetRecipientResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipiend id |

## Response Type

[`GetRecipientResponse`](../../doc/models/get-recipient-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';

$result = $recipientsController->getRecipient($recipientId);
```


# Get Balance

Get balance information for a recipient

```php
function getBalance(string $recipientId): GetBalanceResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient id |

## Response Type

[`GetBalanceResponse`](../../doc/models/get-balance-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';

$result = $recipientsController->getBalance($recipientId);
```


# Get Withdrawals

Gets a paginated list of transfers for the recipient

```php
function getWithdrawals(
    string $recipientId,
    ?int $page = null,
    ?int $size = null,
    ?string $status = null,
    ?\DateTime $createdSince = null,
    ?\DateTime $createdUntil = null
): ListWithdrawals
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | - |
| `page` | `?int` | Query, Optional | - |
| `size` | `?int` | Query, Optional | - |
| `status` | `?string` | Query, Optional | - |
| `createdSince` | `?\DateTime` | Query, Optional | - |
| `createdUntil` | `?\DateTime` | Query, Optional | - |

## Response Type

[`ListWithdrawals`](../../doc/models/list-withdrawals.md)

## Example Usage

```php
$recipientId = 'recipient_id0';

$result = $recipientsController->getWithdrawals($recipientId);
```


# Create Transfer

Creates a transfer for a recipient

```php
function createTransfer(
    string $recipientId,
    CreateTransferRequest $request,
    ?string $idempotencyKey = null
): GetTransferResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `recipientId` | `string` | Template, Required | Recipient Id |
| `request` | [`CreateTransferRequest`](../../doc/models/create-transfer-request.md) | Body, Required | Transfer data |
| `idempotencyKey` | `?string` | Header, Optional | - |

## Response Type

[`GetTransferResponse`](../../doc/models/get-transfer-response.md)

## Example Usage

```php
$recipientId = 'recipient_id0';
$request_amount = 242;
$request_metadata = ['key0' => 'metadata3'];
$request = new Models\CreateTransferRequest(
    $request_amount,
    $request_metadata
);

$result = $recipientsController->createTransfer($recipientId, $request);
```


# Create Recipient

Creates a new recipient

```php
function createRecipient(CreateRecipientRequest $request, ?string $idempotencyKey = null): GetRecipientResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `request` | [`CreateRecipientRequest`](../../doc/models/create-recipient-request.md) | Body, Required | Recipient data |
| `idempotencyKey` | `?string` | Header, Optional | - |

## Response Type

[`GetRecipientResponse`](../../doc/models/get-recipient-response.md)

## Example Usage

```php
$request_name = 'name6';
$request_email = 'email0';
$request_description = 'description6';
$request_document = 'document0';
$request_type = 'type4';
$request_defaultBankAccount_holderName = 'holder_name0';
$request_defaultBankAccount_holderType = 'holder_type6';
$request_defaultBankAccount_holderDocument = 'holder_document8';
$request_defaultBankAccount_bank = 'bank2';
$request_defaultBankAccount_branchNumber = 'branch_number0';
$request_defaultBankAccount_branchCheckDigit = 'branch_check_digit0';
$request_defaultBankAccount_accountNumber = 'account_number4';
$request_defaultBankAccount_accountCheckDigit = 'account_check_digit0';
$request_defaultBankAccount_type = 'type4';
$request_defaultBankAccount_metadata = ['key0' => 'metadata5'];
$request_defaultBankAccount_pixKey = 'pix_key8';
$request_defaultBankAccount = new Models\CreateBankAccountRequest(
    $request_defaultBankAccount_holderName,
    $request_defaultBankAccount_holderType,
    $request_defaultBankAccount_holderDocument,
    $request_defaultBankAccount_bank,
    $request_defaultBankAccount_branchNumber,
    $request_defaultBankAccount_branchCheckDigit,
    $request_defaultBankAccount_accountNumber,
    $request_defaultBankAccount_accountCheckDigit,
    $request_defaultBankAccount_type,
    $request_defaultBankAccount_metadata,
    $request_defaultBankAccount_pixKey
);
$request_metadata = ['key0' => 'metadata3'];
$request_code = 'code4';
$request_paymentMode = 'bank_transfer';
$request = new Models\CreateRecipientRequest(
    $request_name,
    $request_email,
    $request_description,
    $request_document,
    $request_type,
    $request_defaultBankAccount,
    $request_metadata,
    $request_code,
    $request_paymentMode
);

$result = $recipientsController->createRecipient($request);
```


# Get Recipient by Code

Retrieves recipient information

```php
function getRecipientByCode(string $code): GetRecipientResponse
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `code` | `string` | Template, Required | Recipient code |

## Response Type

[`GetRecipientResponse`](../../doc/models/get-recipient-response.md)

## Example Usage

```php
$code = 'code8';

$result = $recipientsController->getRecipientByCode($code);
```


# Get Default Recipient

```php
function getDefaultRecipient(): GetRecipientResponse
```

## Response Type

[`GetRecipientResponse`](../../doc/models/get-recipient-response.md)

## Example Usage

```php
$result = $recipientsController->getDefaultRecipient();
```

