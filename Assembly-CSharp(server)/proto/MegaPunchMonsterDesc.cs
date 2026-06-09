using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B3A RID: 2874
	[Token(Token = "0x2000B3A")]
	[ProtoContract]
	public class MegaPunchMonsterDesc
	{
		// Token: 0x06002842 RID: 10306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002842")]
		[Address(RVA = "0x21BCA3C", Offset = "0x21BCA3C", VA = "0x7BBC9BCA3C")]
		public MegaPunchMonsterDesc()
		{
		}

		// Token: 0x04003693 RID: 13971
		[Token(Token = "0x4003693")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CEFC", Offset = "0x112CEFC")]
		public uint monster_id;

		// Token: 0x04003694 RID: 13972
		[Token(Token = "0x4003694")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CF10", Offset = "0x112CF10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112CF10", Offset = "0x112CF10")]
		public string icon;

		// Token: 0x04003695 RID: 13973
		[Token(Token = "0x4003695")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CF60", Offset = "0x112CF60")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112CF60", Offset = "0x112CF60")]
		public string dailogue_text;

		// Token: 0x04003696 RID: 13974
		[Token(Token = "0x4003696")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112CFB0", Offset = "0x112CFB0")]
		public uint rate;
	}
}
