using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002138 RID: 8504
	[Token(Token = "0x2002138")]
	internal class UIChampionshipReviewRewardItemView : UIBaseView
	{
		// Token: 0x0600BD80 RID: 48512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD80")]
		[Address(RVA = "0x1ECA28C", Offset = "0x1ECA28C", VA = "0x7BBC6CA28C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD81 RID: 48513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD81")]
		[Address(RVA = "0x1ECA510", Offset = "0x1ECA510", VA = "0x7BBC6CA510")]
		public UIChampionshipReviewRewardItemView()
		{
		}

		// Token: 0x0400C3AE RID: 50094
		[Token(Token = "0x400C3AE")]
		[FieldOffset(Offset = "0x20")]
		public Transform LevelRewardContainer;

		// Token: 0x0400C3AF RID: 50095
		[Token(Token = "0x400C3AF")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid LevelRewardGrid;

		// Token: 0x0400C3B0 RID: 50096
		[Token(Token = "0x400C3B0")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SelectedBg;

		// Token: 0x0400C3B1 RID: 50097
		[Token(Token = "0x400C3B1")]
		[FieldOffset(Offset = "0x38")]
		public GameObject BG;

		// Token: 0x0400C3B2 RID: 50098
		[Token(Token = "0x400C3B2")]
		[FieldOffset(Offset = "0x40")]
		public GameObject BG1;

		// Token: 0x0400C3B3 RID: 50099
		[Token(Token = "0x400C3B3")]
		[FieldOffset(Offset = "0x48")]
		public GameObject BG2;

		// Token: 0x0400C3B4 RID: 50100
		[Token(Token = "0x400C3B4")]
		[FieldOffset(Offset = "0x50")]
		public GameObject BG3;

		// Token: 0x0400C3B5 RID: 50101
		[Token(Token = "0x400C3B5")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Level;

		// Token: 0x0400C3B6 RID: 50102
		[Token(Token = "0x400C3B6")]
		[FieldOffset(Offset = "0x60")]
		public UISprite LevelSprite;
	}
}
