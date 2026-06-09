using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008A0 RID: 2208
	[Token(Token = "0x20008A0")]
	[ProtoContract]
	public class BlacklistInfoRes
	{
		// Token: 0x060025AE RID: 9646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025AE")]
		[Address(RVA = "0x21AFA64", Offset = "0x21AFA64", VA = "0x7BBC9AFA64")]
		public BlacklistInfoRes()
		{
		}

		// Token: 0x0400297D RID: 10621
		[Token(Token = "0x400297D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11155F4", Offset = "0x11155F4")]
		public EAccount.BanReason ban_reason;

		// Token: 0x0400297E RID: 10622
		[Token(Token = "0x400297E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115608", Offset = "0x1115608")]
		public uint expire_duration;
	}
}
