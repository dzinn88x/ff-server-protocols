using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020EB RID: 8427
	[Token(Token = "0x20020EB")]
	public class UIActivityStandardContentView : UIBaseView
	{
		// Token: 0x0600BCE7 RID: 48359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE7")]
		[Address(RVA = "0x195EB0C", Offset = "0x195EB0C", VA = "0x7BBC15EB0C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCE8 RID: 48360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCE8")]
		[Address(RVA = "0x195ED68", Offset = "0x195ED68", VA = "0x7BBC15ED68")]
		public UIActivityStandardContentView()
		{
		}

		// Token: 0x0400BF5B RID: 48987
		[Token(Token = "0x400BF5B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ScrollView_NoTabs;

		// Token: 0x0400BF5C RID: 48988
		[Token(Token = "0x400BF5C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ScrollView;

		// Token: 0x0400BF5D RID: 48989
		[Token(Token = "0x400BF5D")]
		[FieldOffset(Offset = "0x30")]
		public UITable ContentTable;

		// Token: 0x0400BF5E RID: 48990
		[Token(Token = "0x400BF5E")]
		[FieldOffset(Offset = "0x38")]
		public ActivityAwardDescription AwardDescTemplate;

		// Token: 0x0400BF5F RID: 48991
		[Token(Token = "0x400BF5F")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Gained;

		// Token: 0x0400BF60 RID: 48992
		[Token(Token = "0x400BF60")]
		[FieldOffset(Offset = "0x48")]
		public UILabel GainedLabel;

		// Token: 0x0400BF61 RID: 48993
		[Token(Token = "0x400BF61")]
		[FieldOffset(Offset = "0x50")]
		public GameObject Title;

		// Token: 0x0400BF62 RID: 48994
		[Token(Token = "0x400BF62")]
		[FieldOffset(Offset = "0x58")]
		public UIDragScrollView DragArea;
	}
}
