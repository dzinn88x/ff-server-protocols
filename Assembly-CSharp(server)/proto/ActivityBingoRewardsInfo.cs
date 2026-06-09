using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020007CD RID: 1997
	[Token(Token = "0x20007CD")]
	[ProtoContract]
	public class ActivityBingoRewardsInfo
	{
		// Token: 0x060024DC RID: 9436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024DC")]
		[Address(RVA = "0x21AEB54", Offset = "0x21AEB54", VA = "0x7BBC9AEB54")]
		public ActivityBingoRewardsInfo()
		{
		}

		// Token: 0x04002624 RID: 9764
		[Token(Token = "0x4002624")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F280", Offset = "0x110F280")]
		public uint rewards_id;

		// Token: 0x04002625 RID: 9765
		[Token(Token = "0x4002625")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110F294", Offset = "0x110F294")]
		public bool awarded;
	}
}
