using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200243C RID: 9276
	[Token(Token = "0x200243C")]
	internal class UIMatchResultScreenshotView : UIBaseView
	{
		// Token: 0x0600C388 RID: 50056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C388")]
		[Address(RVA = "0x147E864", Offset = "0x147E864", VA = "0x7BBBC7E864", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C389 RID: 50057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C389")]
		[Address(RVA = "0x147F1C8", Offset = "0x147F1C8", VA = "0x7BBBC7F1C8")]
		public UIMatchResultScreenshotView()
		{
		}

		// Token: 0x0400E70B RID: 59147
		[Token(Token = "0x400E70B")]
		[FieldOffset(Offset = "0x20")]
		public ShareCamera ShareCameraObject;

		// Token: 0x0400E70C RID: 59148
		[Token(Token = "0x400E70C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ShareUI;

		// Token: 0x0400E70D RID: 59149
		[Token(Token = "0x400E70D")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTexture HeadshotRemote;

		// Token: 0x0400E70E RID: 59150
		[Token(Token = "0x400E70E")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HeadshotDefault;

		// Token: 0x0400E70F RID: 59151
		[Token(Token = "0x400E70F")]
		[FieldOffset(Offset = "0x40")]
		public UIEffectSprite HeadshotLocal;

		// Token: 0x0400E710 RID: 59152
		[Token(Token = "0x400E710")]
		[FieldOffset(Offset = "0x48")]
		public UISprite callsign;

		// Token: 0x0400E711 RID: 59153
		[Token(Token = "0x400E711")]
		[FieldOffset(Offset = "0x50")]
		public UILabel PlayerID;

		// Token: 0x0400E712 RID: 59154
		[Token(Token = "0x400E712")]
		[FieldOffset(Offset = "0x58")]
		public UILabel PlayerNickname;

		// Token: 0x0400E713 RID: 59155
		[Token(Token = "0x400E713")]
		[FieldOffset(Offset = "0x60")]
		public UILabel EndgameDescription;

		// Token: 0x0400E714 RID: 59156
		[Token(Token = "0x400E714")]
		[FieldOffset(Offset = "0x68")]
		public UILabel Defeater;

		// Token: 0x0400E715 RID: 59157
		[Token(Token = "0x400E715")]
		[FieldOffset(Offset = "0x70")]
		public UILabel WeaponDefeatedWith;

		// Token: 0x0400E716 RID: 59158
		[Token(Token = "0x400E716")]
		[FieldOffset(Offset = "0x78")]
		public UILabel GameMode;

		// Token: 0x0400E717 RID: 59159
		[Token(Token = "0x400E717")]
		[FieldOffset(Offset = "0x80")]
		public UILabel Map;

		// Token: 0x0400E718 RID: 59160
		[Token(Token = "0x400E718")]
		[FieldOffset(Offset = "0x88")]
		public UILabel PlayerRank;

		// Token: 0x0400E719 RID: 59161
		[Token(Token = "0x400E719")]
		[FieldOffset(Offset = "0x90")]
		public UILabel TotalPlayersCount;

		// Token: 0x0400E71A RID: 59162
		[Token(Token = "0x400E71A")]
		[FieldOffset(Offset = "0x98")]
		public UISprite SeasonRankIcon;

		// Token: 0x0400E71B RID: 59163
		[Token(Token = "0x400E71B")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel SeasonRank;

		// Token: 0x0400E71C RID: 59164
		[Token(Token = "0x400E71C")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject rankcolor;

		// Token: 0x0400E71D RID: 59165
		[Token(Token = "0x400E71D")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject bronze;

		// Token: 0x0400E71E RID: 59166
		[Token(Token = "0x400E71E")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject silver;

		// Token: 0x0400E71F RID: 59167
		[Token(Token = "0x400E71F")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject gold;

		// Token: 0x0400E720 RID: 59168
		[Token(Token = "0x400E720")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject platinum;

		// Token: 0x0400E721 RID: 59169
		[Token(Token = "0x400E721")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject diamon;

		// Token: 0x0400E722 RID: 59170
		[Token(Token = "0x400E722")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject king;

		// Token: 0x0400E723 RID: 59171
		[Token(Token = "0x400E723")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject peek;

		// Token: 0x0400E724 RID: 59172
		[Token(Token = "0x400E724")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel playerKill;

		// Token: 0x0400E725 RID: 59173
		[Token(Token = "0x400E725")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel playerDamage;

		// Token: 0x0400E726 RID: 59174
		[Token(Token = "0x400E726")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel playerSurviveTime;

		// Token: 0x0400E727 RID: 59175
		[Token(Token = "0x400E727")]
		[FieldOffset(Offset = "0x100")]
		public UITable Team;

		// Token: 0x0400E728 RID: 59176
		[Token(Token = "0x400E728")]
		[FieldOffset(Offset = "0x108")]
		public GameObject Teammate1;

		// Token: 0x0400E729 RID: 59177
		[Token(Token = "0x400E729")]
		[FieldOffset(Offset = "0x110")]
		public UILabel teammate1Kill;

		// Token: 0x0400E72A RID: 59178
		[Token(Token = "0x400E72A")]
		[FieldOffset(Offset = "0x118")]
		public UILabel teammate1Name;

		// Token: 0x0400E72B RID: 59179
		[Token(Token = "0x400E72B")]
		[FieldOffset(Offset = "0x120")]
		public GameObject Teammate2;

		// Token: 0x0400E72C RID: 59180
		[Token(Token = "0x400E72C")]
		[FieldOffset(Offset = "0x128")]
		public UILabel teammate2Kill;

		// Token: 0x0400E72D RID: 59181
		[Token(Token = "0x400E72D")]
		[FieldOffset(Offset = "0x130")]
		public UILabel teammate2Name;

		// Token: 0x0400E72E RID: 59182
		[Token(Token = "0x400E72E")]
		[FieldOffset(Offset = "0x138")]
		public GameObject Teammate3;

		// Token: 0x0400E72F RID: 59183
		[Token(Token = "0x400E72F")]
		[FieldOffset(Offset = "0x140")]
		public UILabel teammate3Kill;

		// Token: 0x0400E730 RID: 59184
		[Token(Token = "0x400E730")]
		[FieldOffset(Offset = "0x148")]
		public UILabel teammate3Name;

		// Token: 0x0400E731 RID: 59185
		[Token(Token = "0x400E731")]
		[FieldOffset(Offset = "0x150")]
		public UITexture PlayerAvatar;

		// Token: 0x0400E732 RID: 59186
		[Token(Token = "0x400E732")]
		[FieldOffset(Offset = "0x158")]
		public UITexture BG_Shared;
	}
}
