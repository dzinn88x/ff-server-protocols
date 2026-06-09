using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002177 RID: 8567
	[Token(Token = "0x2002177")]
	public class UICollectionPopMeuItemView : UIBaseView
	{
		// Token: 0x0600BDFE RID: 48638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDFE")]
		[Address(RVA = "0x20AAB6C", Offset = "0x20AAB6C", VA = "0x7BBC8AAB6C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BDFF RID: 48639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDFF")]
		[Address(RVA = "0x20AAD8C", Offset = "0x20AAD8C", VA = "0x7BBC8AAD8C")]
		public UICollectionPopMeuItemView()
		{
		}

		// Token: 0x0400C70F RID: 50959
		[Token(Token = "0x400C70F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400C710 RID: 50960
		[Token(Token = "0x400C710")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ItemWidget;

		// Token: 0x0400C711 RID: 50961
		[Token(Token = "0x400C711")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Label;

		// Token: 0x0400C712 RID: 50962
		[Token(Token = "0x400C712")]
		[FieldOffset(Offset = "0x38")]
		public GameObject HighLight;

		// Token: 0x0400C713 RID: 50963
		[Token(Token = "0x400C713")]
		[FieldOffset(Offset = "0x40")]
		public UISprite bg;

		// Token: 0x0400C714 RID: 50964
		[Token(Token = "0x400C714")]
		[FieldOffset(Offset = "0x48")]
		public UISprite Sprite;

		// Token: 0x0400C715 RID: 50965
		[Token(Token = "0x400C715")]
		[FieldOffset(Offset = "0x50")]
		public GameObject tipsGo;
	}
}
