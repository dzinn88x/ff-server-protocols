using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200218F RID: 8591
	[Token(Token = "0x200218F")]
	public class UICRMapModePopMenuItemView : UIBaseView
	{
		// Token: 0x0600BE2E RID: 48686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE2E")]
		[Address(RVA = "0x1C21E88", Offset = "0x1C21E88", VA = "0x7BBC421E88", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE2F RID: 48687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE2F")]
		[Address(RVA = "0x1C22068", Offset = "0x1C22068", VA = "0x7BBC422068")]
		public UICRMapModePopMenuItemView()
		{
		}

		// Token: 0x0400C842 RID: 51266
		[Token(Token = "0x400C842")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400C843 RID: 51267
		[Token(Token = "0x400C843")]
		[FieldOffset(Offset = "0x28")]
		public UIWidget ItemWidget;

		// Token: 0x0400C844 RID: 51268
		[Token(Token = "0x400C844")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Label;

		// Token: 0x0400C845 RID: 51269
		[Token(Token = "0x400C845")]
		[FieldOffset(Offset = "0x38")]
		public GameObject RLabel;

		// Token: 0x0400C846 RID: 51270
		[Token(Token = "0x400C846")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Icon;

		// Token: 0x0400C847 RID: 51271
		[Token(Token = "0x400C847")]
		[FieldOffset(Offset = "0x48")]
		public GameObject HighLight;
	}
}
