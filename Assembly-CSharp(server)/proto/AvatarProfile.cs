using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005F9 RID: 1529
	[Token(Token = "0x20005F9")]
	[ProtoContract]
	public class AvatarProfile
	{
		// Token: 0x06002379 RID: 9081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002379")]
		[Address(RVA = "0x21AF52C", Offset = "0x21AF52C", VA = "0x7BBC9AF52C")]
		public AvatarProfile()
		{
		}

		// Token: 0x04001E83 RID: 7811
		[Token(Token = "0x4001E83")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106DC4", Offset = "0x1106DC4")]
		public uint avatar_id;

		// Token: 0x04001E84 RID: 7812
		[Token(Token = "0x4001E84")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106DD8", Offset = "0x1106DD8")]
		public uint unlocked_level;

		// Token: 0x04001E85 RID: 7813
		[Token(Token = "0x4001E85")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106DEC", Offset = "0x1106DEC")]
		public uint skin_color;

		// Token: 0x04001E86 RID: 7814
		[Token(Token = "0x4001E86")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106E00", Offset = "0x1106E00")]
		public uint[] clothes;

		// Token: 0x04001E87 RID: 7815
		[Token(Token = "0x4001E87")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106E3C", Offset = "0x1106E3C")]
		public List<AvatarSkillSlot> equiped_skills;

		// Token: 0x04001E88 RID: 7816
		[Token(Token = "0x4001E88")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106E50", Offset = "0x1106E50")]
		public bool is_selected;

		// Token: 0x04001E89 RID: 7817
		[Token(Token = "0x4001E89")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106E64", Offset = "0x1106E64")]
		public uint pve_primary_weapon;

		// Token: 0x04001E8A RID: 7818
		[Token(Token = "0x4001E8A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106E78", Offset = "0x1106E78")]
		public bool is_selected_awaken;

		// Token: 0x04001E8B RID: 7819
		[Token(Token = "0x4001E8B")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106E8C", Offset = "0x1106E8C")]
		public uint end_time;
	}
}
