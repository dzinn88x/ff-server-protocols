using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000468 RID: 1128
	[Token(Token = "0x2000468")]
	[ProtoContract]
	public class EChat
	{
		// Token: 0x06001C9D RID: 7325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9D")]
		[Address(RVA = "0x24A2D08", Offset = "0x24A2D08", VA = "0x7BBCCA2D08")]
		public EChat()
		{
		}

		// Token: 0x02000469 RID: 1129
		[Token(Token = "0x2000469")]
		[ProtoContract]
		public enum Proto
		{
			// Token: 0x040014E6 RID: 5350
			[Token(Token = "0x40014E6")]
			Proto_NONE,
			// Token: 0x040014E7 RID: 5351
			[Token(Token = "0x40014E7")]
			Proto_REPORT_CHAT
		}

		// Token: 0x0200046A RID: 1130
		[Token(Token = "0x200046A")]
		[ProtoContract]
		public enum ErrCode
		{
			// Token: 0x040014E9 RID: 5353
			[Token(Token = "0x40014E9")]
			ErrCode_NONE,
			// Token: 0x040014EA RID: 5354
			[Token(Token = "0x40014EA")]
			ErrCode_ALREADY_MUTED
		}
	}
}
