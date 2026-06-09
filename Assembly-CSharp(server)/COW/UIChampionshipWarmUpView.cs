using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002146 RID: 8518
	[Token(Token = "0x2002146")]
	public class UIChampionshipWarmUpView : UIBaseView
	{
		// Token: 0x0600BD9C RID: 48540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD9C")]
		[Address(RVA = "0x1EDDEB8", Offset = "0x1EDDEB8", VA = "0x7BBC6DDEB8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD9D RID: 48541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD9D")]
		[Address(RVA = "0x1EDE0C0", Offset = "0x1EDE0C0", VA = "0x7BBC6DE0C0")]
		public UIChampionshipWarmUpView()
		{
		}

		// Token: 0x0400C480 RID: 50304
		[Token(Token = "0x400C480")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnRule;

		// Token: 0x0400C481 RID: 50305
		[Token(Token = "0x400C481")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Title;

		// Token: 0x0400C482 RID: 50306
		[Token(Token = "0x400C482")]
		[FieldOffset(Offset = "0x30")]
		public UILabel TitleDesc;

		// Token: 0x0400C483 RID: 50307
		[Token(Token = "0x400C483")]
		[FieldOffset(Offset = "0x38")]
		public GameObject CDNIcon;

		// Token: 0x0400C484 RID: 50308
		[Token(Token = "0x400C484")]
		[FieldOffset(Offset = "0x40")]
		public UINetworkTexture CDNTexture;

		// Token: 0x0400C485 RID: 50309
		[Token(Token = "0x400C485")]
		[FieldOffset(Offset = "0x48")]
		public GameObject DefaultIcon;

		// Token: 0x0400C486 RID: 50310
		[Token(Token = "0x400C486")]
		[FieldOffset(Offset = "0x50")]
		public UILabel OpenDateDesc;
	}
}
