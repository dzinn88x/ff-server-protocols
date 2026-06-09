using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002174 RID: 8564
	[Token(Token = "0x2002174")]
	internal class UICollectionBgItemView : UIBaseView
	{
		// Token: 0x0600BDF8 RID: 48632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDF8")]
		[Address(RVA = "0x2097C04", Offset = "0x2097C04", VA = "0x7BBC897C04", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDF9 RID: 48633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDF9")]
		[Address(RVA = "0x2098050", Offset = "0x2098050", VA = "0x7BBC898050")]
		public UICollectionBgItemView()
		{
		}

		// Token: 0x0400C6D1 RID: 50897
		[Token(Token = "0x400C6D1")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400C6D2 RID: 50898
		[Token(Token = "0x400C6D2")]
		[FieldOffset(Offset = "0x28")]
		public GameObject gray;

		// Token: 0x0400C6D3 RID: 50899
		[Token(Token = "0x400C6D3")]
		[FieldOffset(Offset = "0x30")]
		public UIEffectSprite bgSprite;

		// Token: 0x0400C6D4 RID: 50900
		[Token(Token = "0x400C6D4")]
		[FieldOffset(Offset = "0x38")]
		public GameObject TipsGO;

		// Token: 0x0400C6D5 RID: 50901
		[Token(Token = "0x400C6D5")]
		[FieldOffset(Offset = "0x40")]
		public UILabel TagLabel;

		// Token: 0x0400C6D6 RID: 50902
		[Token(Token = "0x400C6D6")]
		[FieldOffset(Offset = "0x48")]
		public GameObject fakeBgSprite;

		// Token: 0x0400C6D7 RID: 50903
		[Token(Token = "0x400C6D7")]
		[FieldOffset(Offset = "0x50")]
		public UISprite minibgSprite;

		// Token: 0x0400C6D8 RID: 50904
		[Token(Token = "0x400C6D8")]
		[FieldOffset(Offset = "0x58")]
		public GameObject HL;

		// Token: 0x0400C6D9 RID: 50905
		[Token(Token = "0x400C6D9")]
		[FieldOffset(Offset = "0x60")]
		public GameObject WL;

		// Token: 0x0400C6DA RID: 50906
		[Token(Token = "0x400C6DA")]
		[FieldOffset(Offset = "0x68")]
		public UISprite stateSprite;

		// Token: 0x0400C6DB RID: 50907
		[Token(Token = "0x400C6DB")]
		[FieldOffset(Offset = "0x70")]
		public UILabel state;

		// Token: 0x0400C6DC RID: 50908
		[Token(Token = "0x400C6DC")]
		[FieldOffset(Offset = "0x78")]
		public UISprite validSprite;

		// Token: 0x0400C6DD RID: 50909
		[Token(Token = "0x400C6DD")]
		[FieldOffset(Offset = "0x80")]
		public UILabel valid;

		// Token: 0x0400C6DE RID: 50910
		[Token(Token = "0x400C6DE")]
		[FieldOffset(Offset = "0x88")]
		public UISprite descSprite;

		// Token: 0x0400C6DF RID: 50911
		[Token(Token = "0x400C6DF")]
		[FieldOffset(Offset = "0x90")]
		public UILabel description;

		// Token: 0x0400C6E0 RID: 50912
		[Token(Token = "0x400C6E0")]
		[FieldOffset(Offset = "0x98")]
		public UISprite RankIcon;
	}
}
