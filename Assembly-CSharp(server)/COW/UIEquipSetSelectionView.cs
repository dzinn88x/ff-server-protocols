using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020021D9 RID: 8665
	[Token(Token = "0x20021D9")]
	public class UIEquipSetSelectionView : UIBaseView
	{
		// Token: 0x0600BEC3 RID: 48835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEC3")]
		[Address(RVA = "0x1E7B728", Offset = "0x1E7B728", VA = "0x7BBC67B728", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BEC4 RID: 48836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEC4")]
		[Address(RVA = "0x1E7B9B4", Offset = "0x1E7B9B4", VA = "0x7BBC67B9B4")]
		public UIEquipSetSelectionView()
		{
		}

		// Token: 0x0400CBAB RID: 52139
		[Token(Token = "0x400CBAB")]
		[FieldOffset(Offset = "0x20")]
		public UILabel LastTime;

		// Token: 0x0400CBAC RID: 52140
		[Token(Token = "0x400CBAC")]
		[FieldOffset(Offset = "0x28")]
		public GameObject InGameContainer;

		// Token: 0x0400CBAD RID: 52141
		[Token(Token = "0x400CBAD")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LeftTimeShow;

		// Token: 0x0400CBAE RID: 52142
		[Token(Token = "0x400CBAE")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LeftTime;

		// Token: 0x0400CBAF RID: 52143
		[Token(Token = "0x400CBAF")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnConfirm;

		// Token: 0x0400CBB0 RID: 52144
		[Token(Token = "0x400CBB0")]
		[FieldOffset(Offset = "0x48")]
		public GameObject LobbyContainer;

		// Token: 0x0400CBB1 RID: 52145
		[Token(Token = "0x400CBB1")]
		[FieldOffset(Offset = "0x50")]
		public UIButton BtnClose;

		// Token: 0x0400CBB2 RID: 52146
		[Token(Token = "0x400CBB2")]
		[FieldOffset(Offset = "0x58")]
		public UIGrid Grid;

		// Token: 0x0400CBB3 RID: 52147
		[Token(Token = "0x400CBB3")]
		[FieldOffset(Offset = "0x60")]
		public GameObject LabelNumShow;
	}
}
