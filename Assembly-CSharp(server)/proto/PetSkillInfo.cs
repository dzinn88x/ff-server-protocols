using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000610 RID: 1552
	[Token(Token = "0x2000610")]
	[ProtoContract]
	public class PetSkillInfo
	{
		// Token: 0x0600238B RID: 9099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238B")]
		[Address(RVA = "0x249F2A0", Offset = "0x249F2A0", VA = "0x7BBCC9F2A0")]
		public PetSkillInfo()
		{
		}

		// Token: 0x04001EEA RID: 7914
		[Token(Token = "0x4001EEA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107418", Offset = "0x1107418")]
		public uint pet_id;

		// Token: 0x04001EEB RID: 7915
		[Token(Token = "0x4001EEB")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110742C", Offset = "0x110742C")]
		public uint skill_id;

		// Token: 0x04001EEC RID: 7916
		[Token(Token = "0x4001EEC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107440", Offset = "0x1107440")]
		public uint skill_level;
	}
}
