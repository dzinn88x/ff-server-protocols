using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005A1 RID: 1441
	[Token(Token = "0x20005A1")]
	[ProtoContract]
	public class Activeness
	{
		// Token: 0x0600234B RID: 9035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234B")]
		[Address(RVA = "0x21AE91C", Offset = "0x21AE91C", VA = "0x7BBC9AE91C")]
		public Activeness()
		{
		}

		// Token: 0x020005A2 RID: 1442
		[Token(Token = "0x20005A2")]
		[ProtoContract]
		public enum ActivenessBoxType
		{
			// Token: 0x04001C95 RID: 7317
			[Token(Token = "0x4001C95")]
			ActivenessBoxType_NONE,
			// Token: 0x04001C96 RID: 7318
			[Token(Token = "0x4001C96")]
			ActivenessBoxType_REWARDED
		}

		// Token: 0x020005A3 RID: 1443
		[Token(Token = "0x20005A3")]
		[ProtoContract]
		public enum ActivenessBoxRefreshType
		{
			// Token: 0x04001C98 RID: 7320
			[Token(Token = "0x4001C98")]
			ActivenessBoxRefreshType_DAILY,
			// Token: 0x04001C99 RID: 7321
			[Token(Token = "0x4001C99")]
			ActivenessBoxRefreshType_WEEKLY
		}
	}
}
