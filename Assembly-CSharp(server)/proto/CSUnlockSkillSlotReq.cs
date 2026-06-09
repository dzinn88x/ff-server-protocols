using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000809 RID: 2057
	[Token(Token = "0x2000809")]
	[ProtoContract]
	public class CSUnlockSkillSlotReq
	{
		// Token: 0x06002518 RID: 9496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002518")]
		[Address(RVA = "0x21B7B58", Offset = "0x21B7B58", VA = "0x7BBC9B7B58")]
		public CSUnlockSkillSlotReq()
		{
		}

		// Token: 0x040026FA RID: 9978
		[Token(Token = "0x40026FA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110B08", Offset = "0x1110B08")]
		public uint avatar_id;

		// Token: 0x040026FB RID: 9979
		[Token(Token = "0x40026FB")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110B1C", Offset = "0x1110B1C")]
		public uint slot_id;

		// Token: 0x040026FC RID: 9980
		[Token(Token = "0x40026FC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110B30", Offset = "0x1110B30")]
		public uint currency_type;
	}
}
