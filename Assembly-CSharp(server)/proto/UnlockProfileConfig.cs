using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A5D RID: 2653
	[Token(Token = "0x2000A5D")]
	[ProtoContract]
	public class UnlockProfileConfig
	{
		// Token: 0x06002767 RID: 10087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002767")]
		[Address(RVA = "0x24A13BC", Offset = "0x24A13BC", VA = "0x7BBCCA13BC")]
		public UnlockProfileConfig()
		{
		}

		// Token: 0x04003082 RID: 12418
		[Token(Token = "0x4003082")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11212C8", Offset = "0x11212C8")]
		public uint avatar_id;

		// Token: 0x04003083 RID: 12419
		[Token(Token = "0x4003083")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11212DC", Offset = "0x11212DC")]
		public uint level;

		// Token: 0x04003084 RID: 12420
		[Token(Token = "0x4003084")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11212F0", Offset = "0x11212F0")]
		public uint debris_count;

		// Token: 0x04003085 RID: 12421
		[Token(Token = "0x4003085")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121304", Offset = "0x1121304")]
		public uint coins;

		// Token: 0x04003086 RID: 12422
		[Token(Token = "0x4003086")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121318", Offset = "0x1121318")]
		public uint gems;
	}
}
