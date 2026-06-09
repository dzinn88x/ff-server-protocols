using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000ADA RID: 2778
	[Token(Token = "0x2000ADA")]
	[ProtoContract]
	public class GoogleRewardsDesc
	{
		// Token: 0x060027E2 RID: 10210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E2")]
		[Address(RVA = "0x21BB0A0", Offset = "0x21BB0A0", VA = "0x7BBC9BB0A0")]
		public GoogleRewardsDesc()
		{
		}

		// Token: 0x0400342A RID: 13354
		[Token(Token = "0x400342A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127EE8", Offset = "0x1127EE8")]
		public uint id;

		// Token: 0x0400342B RID: 13355
		[Token(Token = "0x400342B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1127EFC", Offset = "0x1127EFC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127EFC", Offset = "0x1127EFC")]
		public string region;

		// Token: 0x0400342C RID: 13356
		[Token(Token = "0x400342C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127F4C", Offset = "0x1127F4C")]
		public uint is_paid;

		// Token: 0x0400342D RID: 13357
		[Token(Token = "0x400342D")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127F60", Offset = "0x1127F60")]
		public uint is_ep_unlock;

		// Token: 0x0400342E RID: 13358
		[Token(Token = "0x400342E")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127F74", Offset = "0x1127F74")]
		public uint action_type;

		// Token: 0x0400342F RID: 13359
		[Token(Token = "0x400342F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127F88", Offset = "0x1127F88")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1127F88", Offset = "0x1127F88")]
		public string task_desc;

		// Token: 0x04003430 RID: 13360
		[Token(Token = "0x4003430")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1127FD8", Offset = "0x1127FD8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1127FD8", Offset = "0x1127FD8")]
		public string reward_desc;
	}
}
