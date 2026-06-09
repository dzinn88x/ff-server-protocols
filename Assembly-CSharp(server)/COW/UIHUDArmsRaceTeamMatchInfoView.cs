using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200226C RID: 8812
	[Token(Token = "0x200226C")]
	public class UIHUDArmsRaceTeamMatchInfoView : UIBaseView
	{
		// Token: 0x0600BFE9 RID: 49129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFE9")]
		[Address(RVA = "0x16B4D50", Offset = "0x16B4D50", VA = "0x7BBBEB4D50", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFEA RID: 49130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFEA")]
		[Address(RVA = "0x16B50E8", Offset = "0x16B50E8", VA = "0x7BBBEB50E8")]
		public UIHUDArmsRaceTeamMatchInfoView()
		{
		}

		// Token: 0x0400D39A RID: 54170
		[Token(Token = "0x400D39A")]
		[FieldOffset(Offset = "0x20")]
		public UIGrid MaxLevelGrid;

		// Token: 0x0400D39B RID: 54171
		[Token(Token = "0x400D39B")]
		[FieldOffset(Offset = "0x28")]
		public UISprite MaxTenSprite;

		// Token: 0x0400D39C RID: 54172
		[Token(Token = "0x400D39C")]
		[FieldOffset(Offset = "0x30")]
		public UISprite MaxUnitSprite;

		// Token: 0x0400D39D RID: 54173
		[Token(Token = "0x400D39D")]
		[FieldOffset(Offset = "0x38")]
		public UILabel BattleTimeLabel;

		// Token: 0x0400D39E RID: 54174
		[Token(Token = "0x400D39E")]
		[FieldOffset(Offset = "0x40")]
		public UISprite SelfWeaponIcon;

		// Token: 0x0400D39F RID: 54175
		[Token(Token = "0x400D39F")]
		[FieldOffset(Offset = "0x48")]
		public UIGrid SelfLevelGrid;

		// Token: 0x0400D3A0 RID: 54176
		[Token(Token = "0x400D3A0")]
		[FieldOffset(Offset = "0x50")]
		public UISprite SelfTenSprite;

		// Token: 0x0400D3A1 RID: 54177
		[Token(Token = "0x400D3A1")]
		[FieldOffset(Offset = "0x58")]
		public UISprite SelfUnitSprite;

		// Token: 0x0400D3A2 RID: 54178
		[Token(Token = "0x400D3A2")]
		[FieldOffset(Offset = "0x60")]
		public UISprite OpponenWeaponIcon;

		// Token: 0x0400D3A3 RID: 54179
		[Token(Token = "0x400D3A3")]
		[FieldOffset(Offset = "0x68")]
		public UILabel OpponenArmLevel;

		// Token: 0x0400D3A4 RID: 54180
		[Token(Token = "0x400D3A4")]
		[FieldOffset(Offset = "0x70")]
		public UIGrid OpponenLevelGrid;

		// Token: 0x0400D3A5 RID: 54181
		[Token(Token = "0x400D3A5")]
		[FieldOffset(Offset = "0x78")]
		public UISprite OpponenTenSprite;

		// Token: 0x0400D3A6 RID: 54182
		[Token(Token = "0x400D3A6")]
		[FieldOffset(Offset = "0x80")]
		public UISprite OpponenUintSprite;

		// Token: 0x0400D3A7 RID: 54183
		[Token(Token = "0x400D3A7")]
		[FieldOffset(Offset = "0x88")]
		public UIButton OpenScoreBoardBtn;
	}
}
