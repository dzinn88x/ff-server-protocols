using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A65 RID: 2661
	[Token(Token = "0x2000A65")]
	[ProtoContract]
	public class AvatarSkillSlotUnlockInfo
	{
		// Token: 0x0600276F RID: 10095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276F")]
		[Address(RVA = "0x21AF5B0", Offset = "0x21AF5B0", VA = "0x7BBC9AF5B0")]
		public AvatarSkillSlotUnlockInfo()
		{
		}

		// Token: 0x040030A7 RID: 12455
		[Token(Token = "0x40030A7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11217C8", Offset = "0x11217C8")]
		public uint avatar_id;

		// Token: 0x040030A8 RID: 12456
		[Token(Token = "0x40030A8")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11217DC", Offset = "0x11217DC")]
		public uint slot_id;

		// Token: 0x040030A9 RID: 12457
		[Token(Token = "0x40030A9")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11217F0", Offset = "0x11217F0")]
		public uint gems;

		// Token: 0x040030AA RID: 12458
		[Token(Token = "0x40030AA")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121804", Offset = "0x1121804")]
		public uint coins;
	}
}
