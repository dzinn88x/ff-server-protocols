using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ABC RID: 2748
	[Token(Token = "0x2000ABC")]
	[ProtoContract]
	public class IntimacyRankInfoDesc
	{
		// Token: 0x060027C6 RID: 10182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C6")]
		[Address(RVA = "0x21BB5C0", Offset = "0x21BB5C0", VA = "0x7BBC9BB5C0")]
		public IntimacyRankInfoDesc()
		{
		}

		// Token: 0x040033AA RID: 13226
		[Token(Token = "0x40033AA")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112722C", Offset = "0x112722C")]
		public uint idx;

		// Token: 0x040033AB RID: 13227
		[Token(Token = "0x40033AB")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127240", Offset = "0x1127240")]
		public EFriend.RelationType relation_type;

		// Token: 0x040033AC RID: 13228
		[Token(Token = "0x40033AC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127254", Offset = "0x1127254")]
		public uint intimacy_rank;

		// Token: 0x040033AD RID: 13229
		[Token(Token = "0x40033AD")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127268", Offset = "0x1127268")]
		public uint lower_bound;

		// Token: 0x040033AE RID: 13230
		[Token(Token = "0x40033AE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112727C", Offset = "0x112727C")]
		public uint upper_bound;

		// Token: 0x040033AF RID: 13231
		[Token(Token = "0x40033AF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127290", Offset = "0x1127290")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1127290", Offset = "0x1127290")]
		public string relation_badge_icon;
	}
}
