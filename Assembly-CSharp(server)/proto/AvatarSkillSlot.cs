using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005F3 RID: 1523
	[Token(Token = "0x20005F3")]
	[ProtoContract]
	public class AvatarSkillSlot
	{
		// Token: 0x06002373 RID: 9075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002373")]
		[Address(RVA = "0x21AF5A8", Offset = "0x21AF5A8", VA = "0x7BBC9AF5A8")]
		public AvatarSkillSlot()
		{
		}

		// Token: 0x04001E79 RID: 7801
		[Token(Token = "0x4001E79")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106C48", Offset = "0x1106C48")]
		public uint slot_id;

		// Token: 0x04001E7A RID: 7802
		[Token(Token = "0x4001E7A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106C5C", Offset = "0x1106C5C")]
		public uint skill_id;
	}
}
