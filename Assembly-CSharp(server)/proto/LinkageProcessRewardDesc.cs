using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AFA RID: 2810
	[Token(Token = "0x2000AFA")]
	[ProtoContract]
	public class LinkageProcessRewardDesc
	{
		// Token: 0x06002802 RID: 10242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002802")]
		[Address(RVA = "0x21BBC30", Offset = "0x21BBC30", VA = "0x7BBC9BBC30")]
		public LinkageProcessRewardDesc()
		{
		}

		// Token: 0x040034F9 RID: 13561
		[Token(Token = "0x40034F9")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112998C", Offset = "0x112998C")]
		public uint rewards_process_id;

		// Token: 0x040034FA RID: 13562
		[Token(Token = "0x40034FA")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11299A0", Offset = "0x11299A0")]
		public ulong target_value;

		// Token: 0x040034FB RID: 13563
		[Token(Token = "0x40034FB")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11299B4", Offset = "0x11299B4")]
		public uint rewards_id;
	}
}
