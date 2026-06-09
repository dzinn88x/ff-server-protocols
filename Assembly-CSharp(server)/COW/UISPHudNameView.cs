using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200251D RID: 9501
	[Token(Token = "0x200251D")]
	public class UISPHudNameView : UIBaseView
	{
		// Token: 0x0600C54A RID: 50506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C54A")]
		[Address(RVA = "0x1EEAD0C", Offset = "0x1EEAD0C", VA = "0x7BBC6EAD0C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C54B RID: 50507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C54B")]
		[Address(RVA = "0x1EEB6A0", Offset = "0x1EEB6A0", VA = "0x7BBC6EB6A0")]
		public UISPHudNameView()
		{
		}

		// Token: 0x0400F2A8 RID: 62120
		[Token(Token = "0x400F2A8")]
		[FieldOffset(Offset = "0x20")]
		public Animator Animator;

		// Token: 0x0400F2A9 RID: 62121
		[Token(Token = "0x400F2A9")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget AlphaCtrlWidget;

		// Token: 0x0400F2AA RID: 62122
		[Token(Token = "0x400F2AA")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Container;

		// Token: 0x0400F2AB RID: 62123
		[Token(Token = "0x400F2AB")]
		[FieldOffset(Offset = "0x38")]
		public GameObject WeaponInfo;

		// Token: 0x0400F2AC RID: 62124
		[Token(Token = "0x400F2AC")]
		[FieldOffset(Offset = "0x40")]
		public UISprite WeaponIcon;

		// Token: 0x0400F2AD RID: 62125
		[Token(Token = "0x400F2AD")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Ammo;

		// Token: 0x0400F2AE RID: 62126
		[Token(Token = "0x400F2AE")]
		[FieldOffset(Offset = "0x50")]
		public UILabel CurrentAmmoCount;

		// Token: 0x0400F2AF RID: 62127
		[Token(Token = "0x400F2AF")]
		[FieldOffset(Offset = "0x58")]
		public UILabel MaxAmmoCount;

		// Token: 0x0400F2B0 RID: 62128
		[Token(Token = "0x400F2B0")]
		[FieldOffset(Offset = "0x60")]
		public GameObject InfiniteSprite;

		// Token: 0x0400F2B1 RID: 62129
		[Token(Token = "0x400F2B1")]
		[FieldOffset(Offset = "0x68")]
		public GameObject PlayerInfo;

		// Token: 0x0400F2B2 RID: 62130
		[Token(Token = "0x400F2B2")]
		[FieldOffset(Offset = "0x70")]
		public GameObject FlashIcon;

		// Token: 0x0400F2B3 RID: 62131
		[Token(Token = "0x400F2B3")]
		[FieldOffset(Offset = "0x78")]
		public UIWidget HurtWave;

		// Token: 0x0400F2B4 RID: 62132
		[Token(Token = "0x400F2B4")]
		[FieldOffset(Offset = "0x80")]
		public UIButton QuickGoto;

		// Token: 0x0400F2B5 RID: 62133
		[Token(Token = "0x400F2B5")]
		[FieldOffset(Offset = "0x88")]
		public UILabel TeamId;

		// Token: 0x0400F2B6 RID: 62134
		[Token(Token = "0x400F2B6")]
		[FieldOffset(Offset = "0x90")]
		public UISprite TeamBg;

		// Token: 0x0400F2B7 RID: 62135
		[Token(Token = "0x400F2B7")]
		[FieldOffset(Offset = "0x98")]
		public UISprite TeamBorder;

		// Token: 0x0400F2B8 RID: 62136
		[Token(Token = "0x400F2B8")]
		[FieldOffset(Offset = "0xA0")]
		public UIWidget TeamIconGo;

		// Token: 0x0400F2B9 RID: 62137
		[Token(Token = "0x400F2B9")]
		[FieldOffset(Offset = "0xA8")]
		public UIEffectSprite TeamIcon;

		// Token: 0x0400F2BA RID: 62138
		[Token(Token = "0x400F2BA")]
		[FieldOffset(Offset = "0xB0")]
		public UISprite TeamFakeIcon;

		// Token: 0x0400F2BB RID: 62139
		[Token(Token = "0x400F2BB")]
		[FieldOffset(Offset = "0xB8")]
		public UISprite TeamIconBG;

		// Token: 0x0400F2BC RID: 62140
		[Token(Token = "0x400F2BC")]
		[FieldOffset(Offset = "0xC0")]
		public UILabel Name;

		// Token: 0x0400F2BD RID: 62141
		[Token(Token = "0x400F2BD")]
		[FieldOffset(Offset = "0xC8")]
		public UISprite Knockdown;

		// Token: 0x0400F2BE RID: 62142
		[Token(Token = "0x400F2BE")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject Hp;

		// Token: 0x0400F2BF RID: 62143
		[Token(Token = "0x400F2BF")]
		[FieldOffset(Offset = "0xD8")]
		public UISprite Hpbarfg;

		// Token: 0x0400F2C0 RID: 62144
		[Token(Token = "0x400F2C0")]
		[FieldOffset(Offset = "0xE0")]
		public UISprite Hpbarbg;

		// Token: 0x0400F2C1 RID: 62145
		[Token(Token = "0x400F2C1")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject TeamMateIcon;

		// Token: 0x0400F2C2 RID: 62146
		[Token(Token = "0x400F2C2")]
		[FieldOffset(Offset = "0xF0")]
		public UISprite Bg;

		// Token: 0x0400F2C3 RID: 62147
		[Token(Token = "0x400F2C3")]
		[FieldOffset(Offset = "0xF8")]
		public UIWidget KokGo;

		// Token: 0x0400F2C4 RID: 62148
		[Token(Token = "0x400F2C4")]
		[FieldOffset(Offset = "0x100")]
		public UIEffectWidget KokVFX;

		// Token: 0x0400F2C5 RID: 62149
		[Token(Token = "0x400F2C5")]
		[FieldOffset(Offset = "0x108")]
		public GameObject MiniContainer;

		// Token: 0x0400F2C6 RID: 62150
		[Token(Token = "0x400F2C6")]
		[FieldOffset(Offset = "0x110")]
		public GameObject MiniPlayerInfo;

		// Token: 0x0400F2C7 RID: 62151
		[Token(Token = "0x400F2C7")]
		[FieldOffset(Offset = "0x118")]
		public UIButton MiniQuickGoto;

		// Token: 0x0400F2C8 RID: 62152
		[Token(Token = "0x400F2C8")]
		[FieldOffset(Offset = "0x120")]
		public UILabel MiniTeamId;

		// Token: 0x0400F2C9 RID: 62153
		[Token(Token = "0x400F2C9")]
		[FieldOffset(Offset = "0x128")]
		public UISprite MiniTeamBg;

		// Token: 0x0400F2CA RID: 62154
		[Token(Token = "0x400F2CA")]
		[FieldOffset(Offset = "0x130")]
		public UISprite MiniTeamBorder;

		// Token: 0x0400F2CB RID: 62155
		[Token(Token = "0x400F2CB")]
		[FieldOffset(Offset = "0x138")]
		public UIWidget MiniTeamIconGo;

		// Token: 0x0400F2CC RID: 62156
		[Token(Token = "0x400F2CC")]
		[FieldOffset(Offset = "0x140")]
		public UIEffectSprite MiniTeamIcon;

		// Token: 0x0400F2CD RID: 62157
		[Token(Token = "0x400F2CD")]
		[FieldOffset(Offset = "0x148")]
		public UISprite MiniTeamFakeIcon;

		// Token: 0x0400F2CE RID: 62158
		[Token(Token = "0x400F2CE")]
		[FieldOffset(Offset = "0x150")]
		public UIWidget KokMinGo;

		// Token: 0x0400F2CF RID: 62159
		[Token(Token = "0x400F2CF")]
		[FieldOffset(Offset = "0x158")]
		public UIEffectWidget MiniKokVFX;
	}
}
