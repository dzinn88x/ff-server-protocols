using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A8E RID: 2702
	[Token(Token = "0x2000A8E")]
	[ProtoContract]
	public class GetEPCurrentEPAndEPDebrisRes
	{
		// Token: 0x06002798 RID: 10136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002798")]
		[Address(RVA = "0x21BAA60", Offset = "0x21BAA60", VA = "0x7BBC9BAA60")]
		public GetEPCurrentEPAndEPDebrisRes()
		{
		}

		// Token: 0x040031C2 RID: 12738
		[Token(Token = "0x40031C2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11235F0", Offset = "0x11235F0")]
		public EventSettingDesc ep_setting;

		// Token: 0x040031C3 RID: 12739
		[Token(Token = "0x40031C3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123604", Offset = "0x1123604")]
		public EPDebrisDropDesc ep_debris;
	}
}
