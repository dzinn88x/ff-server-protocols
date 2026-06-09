using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200060D RID: 1549
	[Token(Token = "0x200060D")]
	[ProtoContract]
	public class PetInfo
	{
		// Token: 0x06002388 RID: 9096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002388")]
		[Address(RVA = "0x249F1B8", Offset = "0x249F1B8", VA = "0x7BBCC9F1B8")]
		public PetInfo()
		{
		}

		// Token: 0x04001EDC RID: 7900
		[Token(Token = "0x4001EDC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110729C", Offset = "0x110729C")]
		public uint id;

		// Token: 0x04001EDD RID: 7901
		[Token(Token = "0x4001EDD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11072B0", Offset = "0x11072B0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11072B0", Offset = "0x11072B0")]
		public string name;

		// Token: 0x04001EDE RID: 7902
		[Token(Token = "0x4001EDE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107300", Offset = "0x1107300")]
		public uint level;

		// Token: 0x04001EDF RID: 7903
		[Token(Token = "0x4001EDF")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107314", Offset = "0x1107314")]
		public uint exp;

		// Token: 0x04001EE0 RID: 7904
		[Token(Token = "0x4001EE0")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107328", Offset = "0x1107328")]
		public bool is_selected;

		// Token: 0x04001EE1 RID: 7905
		[Token(Token = "0x4001EE1")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110733C", Offset = "0x110733C")]
		public uint skin_id;

		// Token: 0x04001EE2 RID: 7906
		[Token(Token = "0x4001EE2")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107350", Offset = "0x1107350")]
		public uint[] actions;

		// Token: 0x04001EE3 RID: 7907
		[Token(Token = "0x4001EE3")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110738C", Offset = "0x110738C")]
		public List<PetSkillInfo> skills;

		// Token: 0x04001EE4 RID: 7908
		[Token(Token = "0x4001EE4")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11073A0", Offset = "0x11073A0")]
		public uint selected_skill_id;
	}
}
