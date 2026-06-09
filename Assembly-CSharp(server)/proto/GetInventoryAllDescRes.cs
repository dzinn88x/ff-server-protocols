using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200078F RID: 1935
	[Token(Token = "0x200078F")]
	[ProtoContract]
	public class GetInventoryAllDescRes
	{
		// Token: 0x0600249E RID: 9374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249E")]
		[Address(RVA = "0x21BAA68", Offset = "0x21BAA68", VA = "0x7BBC9BAA68")]
		public GetInventoryAllDescRes()
		{
		}

		// Token: 0x04002595 RID: 9621
		[Token(Token = "0x4002595")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E2CC", Offset = "0x110E2CC")]
		public CSGetBundleRes bundle;

		// Token: 0x04002596 RID: 9622
		[Token(Token = "0x4002596")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E2E0", Offset = "0x110E2E0")]
		public GetRankingItemRankConfigRes ranking_item_rank_config;

		// Token: 0x04002597 RID: 9623
		[Token(Token = "0x4002597")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E2F4", Offset = "0x110E2F4")]
		public CSGetFullscreenItemRes full_screen_item;

		// Token: 0x04002598 RID: 9624
		[Token(Token = "0x4002598")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E308", Offset = "0x110E308")]
		public CSGetRoleDebrisDescRes role_debris;

		// Token: 0x04002599 RID: 9625
		[Token(Token = "0x4002599")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E31C", Offset = "0x110E31C")]
		public long weapon_skin_system_time;

		// Token: 0x0400259A RID: 9626
		[Token(Token = "0x400259A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E330", Offset = "0x110E330")]
		public CSGetOptionalBundleRes optional_bundle;
	}
}
