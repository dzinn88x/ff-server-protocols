using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200243F RID: 9279
	[Token(Token = "0x200243F")]
	internal class UIMatchResultZombieScreenshotView : UIBaseView
	{
		// Token: 0x0600C38E RID: 50062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C38E")]
		[Address(RVA = "0x1482534", Offset = "0x1482534", VA = "0x7BBBC82534", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C38F RID: 50063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C38F")]
		[Address(RVA = "0x14829EC", Offset = "0x14829EC", VA = "0x7BBBC829EC")]
		public UIMatchResultZombieScreenshotView()
		{
		}

		// Token: 0x0400E740 RID: 59200
		[Token(Token = "0x400E740")]
		[FieldOffset(Offset = "0x20")]
		public ShareCamera ShareCameraObject;

		// Token: 0x0400E741 RID: 59201
		[Token(Token = "0x400E741")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ShareUI;

		// Token: 0x0400E742 RID: 59202
		[Token(Token = "0x400E742")]
		[FieldOffset(Offset = "0x30")]
		public UINetworkTexture HeadshotRemote;

		// Token: 0x0400E743 RID: 59203
		[Token(Token = "0x400E743")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HeadshotDefault;

		// Token: 0x0400E744 RID: 59204
		[Token(Token = "0x400E744")]
		[FieldOffset(Offset = "0x40")]
		public UIEffectSprite HeadshotLocal;

		// Token: 0x0400E745 RID: 59205
		[Token(Token = "0x400E745")]
		[FieldOffset(Offset = "0x48")]
		public UILabel PlayerID;

		// Token: 0x0400E746 RID: 59206
		[Token(Token = "0x400E746")]
		[FieldOffset(Offset = "0x50")]
		public UILabel PlayerNickname;

		// Token: 0x0400E747 RID: 59207
		[Token(Token = "0x400E747")]
		[FieldOffset(Offset = "0x58")]
		public UILabel EndgameDescription;

		// Token: 0x0400E748 RID: 59208
		[Token(Token = "0x400E748")]
		[FieldOffset(Offset = "0x60")]
		public UILabel Defeater;

		// Token: 0x0400E749 RID: 59209
		[Token(Token = "0x400E749")]
		[FieldOffset(Offset = "0x68")]
		public UILabel PlayerRank;

		// Token: 0x0400E74A RID: 59210
		[Token(Token = "0x400E74A")]
		[FieldOffset(Offset = "0x70")]
		public UILabel TotalPlayersCount;

		// Token: 0x0400E74B RID: 59211
		[Token(Token = "0x400E74B")]
		[FieldOffset(Offset = "0x78")]
		public UISprite PlayerRankTop;

		// Token: 0x0400E74C RID: 59212
		[Token(Token = "0x400E74C")]
		[FieldOffset(Offset = "0x80")]
		public UISprite PlayerCharacter;

		// Token: 0x0400E74D RID: 59213
		[Token(Token = "0x400E74D")]
		[FieldOffset(Offset = "0x88")]
		public UITexture BG_Shared;

		// Token: 0x0400E74E RID: 59214
		[Token(Token = "0x400E74E")]
		[FieldOffset(Offset = "0x90")]
		public UITexture GameTexture;

		// Token: 0x0400E74F RID: 59215
		[Token(Token = "0x400E74F")]
		[FieldOffset(Offset = "0x98")]
		public UIGrid Teammates;

		// Token: 0x0400E750 RID: 59216
		[Token(Token = "0x400E750")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel MatchMode;

		// Token: 0x0400E751 RID: 59217
		[Token(Token = "0x400E751")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel GameMode;

		// Token: 0x0400E752 RID: 59218
		[Token(Token = "0x400E752")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel Map;
	}
}
