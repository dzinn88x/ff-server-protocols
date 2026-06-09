using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000609 RID: 1545
	[Token(Token = "0x2000609")]
	[ProtoContract]
	public class AccountPersonalShowInfo
	{
		// Token: 0x06002385 RID: 9093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002385")]
		[Address(RVA = "0x21AE690", Offset = "0x21AE690", VA = "0x7BBC9AE690")]
		public AccountPersonalShowInfo()
		{
		}

		// Token: 0x04001ECC RID: 7884
		[Token(Token = "0x4001ECC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11071AC", Offset = "0x11071AC")]
		public AccountInfoBasic basic_info;

		// Token: 0x04001ECD RID: 7885
		[Token(Token = "0x4001ECD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11071C0", Offset = "0x11071C0")]
		public AvatarProfile profile_info;

		// Token: 0x04001ECE RID: 7886
		[Token(Token = "0x4001ECE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11071D4", Offset = "0x11071D4")]
		public int ranking_leaderboard_pos;

		// Token: 0x04001ECF RID: 7887
		[Token(Token = "0x4001ECF")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11071E8", Offset = "0x11071E8")]
		public List<AccountNews> news;

		// Token: 0x04001ED0 RID: 7888
		[Token(Token = "0x4001ED0")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11071FC", Offset = "0x11071FC")]
		public List<BasicEPInfo> history_ep_info;

		// Token: 0x04001ED1 RID: 7889
		[Token(Token = "0x4001ED1")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107210", Offset = "0x1107210")]
		public ClanInfoBasic clan_basic_info;

		// Token: 0x04001ED2 RID: 7890
		[Token(Token = "0x4001ED2")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107224", Offset = "0x1107224")]
		public AccountInfoBasic captain_basic_info;

		// Token: 0x04001ED3 RID: 7891
		[Token(Token = "0x4001ED3")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1107238", Offset = "0x1107238")]
		public PetInfo pet_info;

		// Token: 0x04001ED4 RID: 7892
		[Token(Token = "0x4001ED4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110724C", Offset = "0x110724C")]
		public SocialBasicInfo social_info;
	}
}
