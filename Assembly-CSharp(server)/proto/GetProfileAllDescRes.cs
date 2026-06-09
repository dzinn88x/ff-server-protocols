using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007FE RID: 2046
	[Token(Token = "0x20007FE")]
	[ProtoContract]
	public class GetProfileAllDescRes
	{
		// Token: 0x0600250D RID: 9485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600250D")]
		[Address(RVA = "0x21BAAEC", Offset = "0x21BAAEC", VA = "0x7BBC9BAAEC")]
		public GetProfileAllDescRes()
		{
		}

		// Token: 0x040026E0 RID: 9952
		[Token(Token = "0x40026E0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11108B0", Offset = "0x11108B0")]
		public CSGetUnlockProfileInfoRes profile;

		// Token: 0x040026E1 RID: 9953
		[Token(Token = "0x40026E1")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11108C4", Offset = "0x11108C4")]
		public CSGetHideAvatarRes hide;

		// Token: 0x040026E2 RID: 9954
		[Token(Token = "0x40026E2")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11108D8", Offset = "0x11108D8")]
		public CSGetAvatarAwakenRes avatar_awaken;

		// Token: 0x040026E3 RID: 9955
		[Token(Token = "0x40026E3")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11108EC", Offset = "0x11108EC")]
		public CSGetGoPosRes go_pos;
	}
}
