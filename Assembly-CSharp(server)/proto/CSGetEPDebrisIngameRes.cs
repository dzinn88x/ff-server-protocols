using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000893 RID: 2195
	[Token(Token = "0x2000893")]
	[ProtoContract]
	public class CSGetEPDebrisIngameRes
	{
		// Token: 0x060025A1 RID: 9633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025A1")]
		[Address(RVA = "0x21B31E0", Offset = "0x21B31E0", VA = "0x7BBC9B31E0")]
		public CSGetEPDebrisIngameRes()
		{
		}

		// Token: 0x040028EF RID: 10479
		[Token(Token = "0x40028EF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113D44", Offset = "0x1113D44")]
		public uint ep_debris_id;

		// Token: 0x040028F0 RID: 10480
		[Token(Token = "0x40028F0")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113D58", Offset = "0x1113D58")]
		public uint gained_game_ep_debris;

		// Token: 0x040028F1 RID: 10481
		[Token(Token = "0x40028F1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1113D6C", Offset = "0x1113D6C")]
		public uint gained_daily_ep_debris;
	}
}
