using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002178 RID: 8568
	[Token(Token = "0x2002178")]
	internal class UICollectionPortraitItemView : UIBaseView
	{
		// Token: 0x0600BE00 RID: 48640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE00")]
		[Address(RVA = "0x20AB9C8", Offset = "0x20AB9C8", VA = "0x7BBC8AB9C8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE01 RID: 48641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE01")]
		[Address(RVA = "0x20ABCB8", Offset = "0x20ABCB8", VA = "0x7BBC8ABCB8")]
		public UICollectionPortraitItemView()
		{
		}

		// Token: 0x0400C716 RID: 50966
		[Token(Token = "0x400C716")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400C717 RID: 50967
		[Token(Token = "0x400C717")]
		[FieldOffset(Offset = "0x28")]
		public GameObject gray;

		// Token: 0x0400C718 RID: 50968
		[Token(Token = "0x400C718")]
		[FieldOffset(Offset = "0x30")]
		public UISprite validSprite;

		// Token: 0x0400C719 RID: 50969
		[Token(Token = "0x400C719")]
		[FieldOffset(Offset = "0x38")]
		public UILabel valid;

		// Token: 0x0400C71A RID: 50970
		[Token(Token = "0x400C71A")]
		[FieldOffset(Offset = "0x40")]
		public GameObject TipsGO;

		// Token: 0x0400C71B RID: 50971
		[Token(Token = "0x400C71B")]
		[FieldOffset(Offset = "0x48")]
		public UILabel TagLabel;

		// Token: 0x0400C71C RID: 50972
		[Token(Token = "0x400C71C")]
		[FieldOffset(Offset = "0x50")]
		public GameObject HL;

		// Token: 0x0400C71D RID: 50973
		[Token(Token = "0x400C71D")]
		[FieldOffset(Offset = "0x58")]
		public GameObject WL;

		// Token: 0x0400C71E RID: 50974
		[Token(Token = "0x400C71E")]
		[FieldOffset(Offset = "0x60")]
		public GameObject FakeSprite;

		// Token: 0x0400C71F RID: 50975
		[Token(Token = "0x400C71F")]
		[FieldOffset(Offset = "0x68")]
		public UIEffectSprite iconSprite;

		// Token: 0x0400C720 RID: 50976
		[Token(Token = "0x400C720")]
		[FieldOffset(Offset = "0x70")]
		public UISprite RankIcon;
	}
}
