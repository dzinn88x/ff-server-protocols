using System;
using Il2CppDummyDll;

namespace GarenaMSDKUnity.GMSDK
{
	// Token: 0x02002BBE RID: 11198
	[Token(Token = "0x2002BBE")]
	public enum GGErrorCode
	{
		// Token: 0x04011B6B RID: 72555
		[Token(Token = "0x4011B6B")]
		SUCCESS,
		// Token: 0x04011B6C RID: 72556
		[Token(Token = "0x4011B6C")]
		APP_NOT_INSTALLED = 2000,
		// Token: 0x04011B6D RID: 72557
		[Token(Token = "0x4011B6D")]
		UNSUPPORTED_API,
		// Token: 0x04011B6E RID: 72558
		[Token(Token = "0x4011B6E")]
		USER_CANCELLED,
		// Token: 0x04011B6F RID: 72559
		[Token(Token = "0x4011B6F")]
		USER_DENIED_REQUEST,
		// Token: 0x04011B70 RID: 72560
		[Token(Token = "0x4011B70")]
		LOGIN_FAILED,
		// Token: 0x04011B71 RID: 72561
		[Token(Token = "0x4011B71")]
		REFRESH_TOKEN_SUCCESS,
		// Token: 0x04011B72 RID: 72562
		[Token(Token = "0x4011B72")]
		REFRESH_TOKEN_FAILED,
		// Token: 0x04011B73 RID: 72563
		[Token(Token = "0x4011B73")]
		ACCESS_TOKEN_EXPIRED,
		// Token: 0x04011B74 RID: 72564
		[Token(Token = "0x4011B74")]
		NETWORK_EXCEPTION,
		// Token: 0x04011B75 RID: 72565
		[Token(Token = "0x4011B75")]
		ACCESS_TOKEN_EXCHANGE_FAILED,
		// Token: 0x04011B76 RID: 72566
		[Token(Token = "0x4011B76")]
		NETWORK_CONNECTION_EXCEPTION,
		// Token: 0x04011B77 RID: 72567
		[Token(Token = "0x4011B77")]
		CANNOT_GET_RESULT,
		// Token: 0x04011B78 RID: 72568
		[Token(Token = "0x4011B78")]
		ERROR_IN_PARAMS,
		// Token: 0x04011B79 RID: 72569
		[Token(Token = "0x4011B79")]
		CANNOT_START_ACTIVITY,
		// Token: 0x04011B7A RID: 72570
		[Token(Token = "0x4011B7A")]
		REQUEST_ID_MISMATCH,
		// Token: 0x04011B7B RID: 72571
		[Token(Token = "0x4011B7B")]
		ACCESS_TOKEN_INSPECTION_FAILED,
		// Token: 0x04011B7C RID: 72572
		[Token(Token = "0x4011B7C")]
		SESSION_NOT_INITIALIZED,
		// Token: 0x04011B7D RID: 72573
		[Token(Token = "0x4011B7D")]
		BATCH_SIZE_EXCEEDED = 2102,
		// Token: 0x04011B7E RID: 72574
		[Token(Token = "0x4011B7E")]
		BIND_FAILED = 2201,
		// Token: 0x04011B7F RID: 72575
		[Token(Token = "0x4011B7F")]
		GUEST_ACCOUNT_INVALID,
		// Token: 0x04011B80 RID: 72576
		[Token(Token = "0x4011B80")]
		REDEEM_NOT_AVAILABLE = 2304,
		// Token: 0x04011B81 RID: 72577
		[Token(Token = "0x4011B81")]
		ALREADY_REDEEMED,
		// Token: 0x04011B82 RID: 72578
		[Token(Token = "0x4011B82")]
		REDEEM_LIMIT_REACHED,
		// Token: 0x04011B83 RID: 72579
		[Token(Token = "0x4011B83")]
		SERVER_ERROR_TOKEN_SESSION,
		// Token: 0x04011B84 RID: 72580
		[Token(Token = "0x4011B84")]
		NETWORK_RESPONSE_PARSE_FAIL,
		// Token: 0x04011B85 RID: 72581
		[Token(Token = "0x4011B85")]
		NETWORK_REQUEST_TIME_OUT,
		// Token: 0x04011B86 RID: 72582
		[Token(Token = "0x4011B86")]
		GOP_ERROR_SERVER = 2300,
		// Token: 0x04011B87 RID: 72583
		[Token(Token = "0x4011B87")]
		GOP_ERROR_TOKEN = 2302,
		// Token: 0x04011B88 RID: 72584
		[Token(Token = "0x4011B88")]
		GOP_ERROR_SCOPE,
		// Token: 0x04011B89 RID: 72585
		[Token(Token = "0x4011B89")]
		ERROR = 2999,
		// Token: 0x04011B8A RID: 72586
		[Token(Token = "0x4011B8A")]
		UNKNOWN_ERROR = -1,
		// Token: 0x04011B8B RID: 72587
		[Token(Token = "0x4011B8B")]
		ACCESS_TOKEN_INVALID_GRANT = 2017,
		// Token: 0x04011B8C RID: 72588
		[Token(Token = "0x4011B8C")]
		ERROR_USER_BANNED
	}
}
