using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200213C RID: 8508
	[Token(Token = "0x200213C")]
	public class UIChampionshipTeamCreateFormView : UIBaseView
	{
		// Token: 0x0600BD88 RID: 48520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD88")]
		[Address(RVA = "0x1ECE6A4", Offset = "0x1ECE6A4", VA = "0x7BBC6CE6A4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD89 RID: 48521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD89")]
		[Address(RVA = "0x1ECEB64", Offset = "0x1ECEB64", VA = "0x7BBC6CEB64")]
		public UIChampionshipTeamCreateFormView()
		{
		}

		// Token: 0x0400C3CB RID: 50123
		[Token(Token = "0x400C3CB")]
		[FieldOffset(Offset = "0x20")]
		public UIButton Confirm;

		// Token: 0x0400C3CC RID: 50124
		[Token(Token = "0x400C3CC")]
		[FieldOffset(Offset = "0x28")]
		public UIButton Cancel;

		// Token: 0x0400C3CD RID: 50125
		[Token(Token = "0x400C3CD")]
		[FieldOffset(Offset = "0x30")]
		public UITable Content;

		// Token: 0x0400C3CE RID: 50126
		[Token(Token = "0x400C3CE")]
		[FieldOffset(Offset = "0x38")]
		public UILabel Name;

		// Token: 0x0400C3CF RID: 50127
		[Token(Token = "0x400C3CF")]
		[FieldOffset(Offset = "0x40")]
		public UIInput NameInput;

		// Token: 0x0400C3D0 RID: 50128
		[Token(Token = "0x400C3D0")]
		[FieldOffset(Offset = "0x48")]
		public UIInput ChannelNameValue;

		// Token: 0x0400C3D1 RID: 50129
		[Token(Token = "0x400C3D1")]
		[FieldOffset(Offset = "0x50")]
		public UISprite Channel;

		// Token: 0x0400C3D2 RID: 50130
		[Token(Token = "0x400C3D2")]
		[FieldOffset(Offset = "0x58")]
		public UIButton ChannelSelect;

		// Token: 0x0400C3D3 RID: 50131
		[Token(Token = "0x400C3D3")]
		[FieldOffset(Offset = "0x60")]
		public GameObject NationalFlag;

		// Token: 0x0400C3D4 RID: 50132
		[Token(Token = "0x400C3D4")]
		[FieldOffset(Offset = "0x68")]
		public UISprite Flag;

		// Token: 0x0400C3D5 RID: 50133
		[Token(Token = "0x400C3D5")]
		[FieldOffset(Offset = "0x70")]
		public UIButton FlagSelect;

		// Token: 0x0400C3D6 RID: 50134
		[Token(Token = "0x400C3D6")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ClanAvatar;

		// Token: 0x0400C3D7 RID: 50135
		[Token(Token = "0x400C3D7")]
		[FieldOffset(Offset = "0x80")]
		public UISprite Avatar;

		// Token: 0x0400C3D8 RID: 50136
		[Token(Token = "0x400C3D8")]
		[FieldOffset(Offset = "0x88")]
		public UIButton AvatarSelect;

		// Token: 0x0400C3D9 RID: 50137
		[Token(Token = "0x400C3D9")]
		[FieldOffset(Offset = "0x90")]
		public GameObject ClanBanner;

		// Token: 0x0400C3DA RID: 50138
		[Token(Token = "0x400C3DA")]
		[FieldOffset(Offset = "0x98")]
		public UIEffectSprite Banner;

		// Token: 0x0400C3DB RID: 50139
		[Token(Token = "0x400C3DB")]
		[FieldOffset(Offset = "0xA0")]
		public UISprite MiniBanner;

		// Token: 0x0400C3DC RID: 50140
		[Token(Token = "0x400C3DC")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton BannerSelect;
	}
}
