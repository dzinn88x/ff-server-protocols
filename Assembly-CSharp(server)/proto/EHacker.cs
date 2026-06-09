using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006B7 RID: 1719
	[Token(Token = "0x20006B7")]
	[ProtoContract]
	public class EHacker
	{
		// Token: 0x060023DD RID: 9181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DD")]
		[Address(RVA = "0x21B9828", Offset = "0x21B9828", VA = "0x7BBC9B9828")]
		public EHacker()
		{
		}

		// Token: 0x020006B8 RID: 1720
		[Token(Token = "0x20006B8")]
		[ProtoContract]
		public enum HackerPoolCdt
		{
			// Token: 0x040021C2 RID: 8642
			[Token(Token = "0x40021C2")]
			HackerPoolCdt_NONE,
			// Token: 0x040021C3 RID: 8643
			[Token(Token = "0x40021C3")]
			HackerPoolCdt_SIGNATURE_LOGIN,
			// Token: 0x040021C4 RID: 8644
			[Token(Token = "0x40021C4")]
			HackerPoolCdt_MTP,
			// Token: 0x040021C5 RID: 8645
			[Token(Token = "0x40021C5")]
			HackerPoolCdt_START_TIME,
			// Token: 0x040021C6 RID: 8646
			[Token(Token = "0x40021C6")]
			HackerPoolCdt_MD5_FILE_EXCEPTION,
			// Token: 0x040021C7 RID: 8647
			[Token(Token = "0x40021C7")]
			HackerPoolCdt_MD5_SCAN_COUNT,
			// Token: 0x040021C8 RID: 8648
			[Token(Token = "0x40021C8")]
			HackerPoolCdt_MD5_COUNT,
			// Token: 0x040021C9 RID: 8649
			[Token(Token = "0x40021C9")]
			HackerPoolCdt_PMS_HOOK,
			// Token: 0x040021CA RID: 8650
			[Token(Token = "0x40021CA")]
			HackerPoolCdt_CLIENT_INFO_EMPTY,
			// Token: 0x040021CB RID: 8651
			[Token(Token = "0x40021CB")]
			HackerPoolCdt_NATIVE_RESULT
		}

		// Token: 0x020006B9 RID: 1721
		[Token(Token = "0x20006B9")]
		[ProtoContract]
		public enum HackerCdtManner
		{
			// Token: 0x040021CD RID: 8653
			[Token(Token = "0x40021CD")]
			HackerCdtManner_EQU,
			// Token: 0x040021CE RID: 8654
			[Token(Token = "0x40021CE")]
			HackerCdtManner_CVR,
			// Token: 0x040021CF RID: 8655
			[Token(Token = "0x40021CF")]
			HackerCdtManner_GTR,
			// Token: 0x040021D0 RID: 8656
			[Token(Token = "0x40021D0")]
			HackerCdtManner_LSS,
			// Token: 0x040021D1 RID: 8657
			[Token(Token = "0x40021D1")]
			HackerCdtManner_JSON_EQU,
			// Token: 0x040021D2 RID: 8658
			[Token(Token = "0x40021D2")]
			HackerCdtManner_JSON_NOT_EQU
		}

		// Token: 0x020006BA RID: 1722
		[Token(Token = "0x20006BA")]
		[ProtoContract]
		public enum HackerCdtID
		{
			// Token: 0x040021D4 RID: 8660
			[Token(Token = "0x40021D4")]
			HackerCdtID_NONE,
			// Token: 0x040021D5 RID: 8661
			[Token(Token = "0x40021D5")]
			HackerCdtID_FALSIFY_MEM_VALUE = 100
		}
	}
}
