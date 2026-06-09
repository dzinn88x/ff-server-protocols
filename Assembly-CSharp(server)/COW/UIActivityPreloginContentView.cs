using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020E5 RID: 8421
	[Token(Token = "0x20020E5")]
	public class UIActivityPreloginContentView : UIBaseView
	{
		// Token: 0x0600BCDB RID: 48347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCDB")]
		[Address(RVA = "0x1959E18", Offset = "0x1959E18", VA = "0x7BBC159E18", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BCDC RID: 48348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BCDC")]
		[Address(RVA = "0x195A010", Offset = "0x195A010", VA = "0x7BBC15A010")]
		public UIActivityPreloginContentView()
		{
		}

		// Token: 0x0400BF2B RID: 48939
		[Token(Token = "0x400BF2B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject ScrollView_NoTabs;

		// Token: 0x0400BF2C RID: 48940
		[Token(Token = "0x400BF2C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject ScrollView;

		// Token: 0x0400BF2D RID: 48941
		[Token(Token = "0x400BF2D")]
		[FieldOffset(Offset = "0x30")]
		public UITable ContentTable;

		// Token: 0x0400BF2E RID: 48942
		[Token(Token = "0x400BF2E")]
		[FieldOffset(Offset = "0x38")]
		public UIGrid DetailList;

		// Token: 0x0400BF2F RID: 48943
		[Token(Token = "0x400BF2F")]
		[FieldOffset(Offset = "0x40")]
		public ActivityPreloginDescription AwardDescTemplate;

		// Token: 0x0400BF30 RID: 48944
		[Token(Token = "0x400BF30")]
		[FieldOffset(Offset = "0x48")]
		public UIDragScrollView DragArea;
	}
}
