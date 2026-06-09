using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009F0 RID: 2544
	[Token(Token = "0x20009F0")]
	[ProtoContract]
	public class PetSkillLevelDesc
	{
		// Token: 0x060026FA RID: 9978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026FA")]
		[Address(RVA = "0x249F2B0", Offset = "0x249F2B0", VA = "0x7BBCC9F2B0")]
		public PetSkillLevelDesc()
		{
		}

		// Token: 0x04002DF0 RID: 11760
		[Token(Token = "0x4002DF0")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C1D8", Offset = "0x111C1D8")]
		public uint skill_id;

		// Token: 0x04002DF1 RID: 11761
		[Token(Token = "0x4002DF1")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C1EC", Offset = "0x111C1EC")]
		public uint skill_level;

		// Token: 0x04002DF2 RID: 11762
		[Token(Token = "0x4002DF2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C200", Offset = "0x111C200")]
		public uint pet_level;

		// Token: 0x04002DF3 RID: 11763
		[Token(Token = "0x4002DF3")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C214", Offset = "0x111C214")]
		public uint type;

		// Token: 0x04002DF4 RID: 11764
		[Token(Token = "0x4002DF4")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C228", Offset = "0x111C228")]
		public uint parameter1;

		// Token: 0x04002DF5 RID: 11765
		[Token(Token = "0x4002DF5")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C23C", Offset = "0x111C23C")]
		public uint parameter2;

		// Token: 0x04002DF6 RID: 11766
		[Token(Token = "0x4002DF6")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111C250", Offset = "0x111C250")]
		public uint parameter3;
	}
}
