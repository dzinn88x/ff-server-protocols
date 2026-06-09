using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200219F RID: 8607
	[Token(Token = "0x200219F")]
	public class UIDebugSettingView : UIBaseView
	{
		// Token: 0x0600BE4E RID: 48718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE4E")]
		[Address(RVA = "0x1BBC4EC", Offset = "0x1BBC4EC", VA = "0x7BBC3BC4EC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE4F RID: 48719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE4F")]
		[Address(RVA = "0x1BBC9AC", Offset = "0x1BBC9AC", VA = "0x7BBC3BC9AC")]
		public UIDebugSettingView()
		{
		}

		// Token: 0x0400C8CD RID: 51405
		[Token(Token = "0x400C8CD")]
		[FieldOffset(Offset = "0x20")]
		public UIToggle DebugInfoOn;

		// Token: 0x0400C8CE RID: 51406
		[Token(Token = "0x400C8CE")]
		[FieldOffset(Offset = "0x28")]
		public UIToggle DebugInfoOff;

		// Token: 0x0400C8CF RID: 51407
		[Token(Token = "0x400C8CF")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LogLevel;

		// Token: 0x0400C8D0 RID: 51408
		[Token(Token = "0x400C8D0")]
		[FieldOffset(Offset = "0x38")]
		public UIToggle LogLevelAll;

		// Token: 0x0400C8D1 RID: 51409
		[Token(Token = "0x400C8D1")]
		[FieldOffset(Offset = "0x40")]
		public UIToggle LogLevelError;

		// Token: 0x0400C8D2 RID: 51410
		[Token(Token = "0x400C8D2")]
		[FieldOffset(Offset = "0x48")]
		public UIToggle LogLevelNone;

		// Token: 0x0400C8D3 RID: 51411
		[Token(Token = "0x400C8D3")]
		[FieldOffset(Offset = "0x50")]
		public GameObject PCHideContainer;

		// Token: 0x0400C8D4 RID: 51412
		[Token(Token = "0x400C8D4")]
		[FieldOffset(Offset = "0x58")]
		public UICheckboxButton TestChangeClothCheckBox;

		// Token: 0x0400C8D5 RID: 51413
		[Token(Token = "0x400C8D5")]
		[FieldOffset(Offset = "0x60")]
		public UICheckboxButton TestAutoChangeClothCheckBox;

		// Token: 0x0400C8D6 RID: 51414
		[Token(Token = "0x400C8D6")]
		[FieldOffset(Offset = "0x68")]
		public UIToggle RemoteConsoleOn;

		// Token: 0x0400C8D7 RID: 51415
		[Token(Token = "0x400C8D7")]
		[FieldOffset(Offset = "0x70")]
		public GameObject RemoteConsoleInputContainer;

		// Token: 0x0400C8D8 RID: 51416
		[Token(Token = "0x400C8D8")]
		[FieldOffset(Offset = "0x78")]
		public UIInput RemoteConsoleInput;

		// Token: 0x0400C8D9 RID: 51417
		[Token(Token = "0x400C8D9")]
		[FieldOffset(Offset = "0x80")]
		public UIButton RemoteConsoleBtn;

		// Token: 0x0400C8DA RID: 51418
		[Token(Token = "0x400C8DA")]
		[FieldOffset(Offset = "0x88")]
		public UILabel RemoteConsoleBtnLabel;

		// Token: 0x0400C8DB RID: 51419
		[Token(Token = "0x400C8DB")]
		[FieldOffset(Offset = "0x90")]
		public UIButton DestroyCollider;

		// Token: 0x0400C8DC RID: 51420
		[Token(Token = "0x400C8DC")]
		[FieldOffset(Offset = "0x98")]
		public UIButton ShowTrigger;

		// Token: 0x0400C8DD RID: 51421
		[Token(Token = "0x400C8DD")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton ShowCollider;

		// Token: 0x0400C8DE RID: 51422
		[Token(Token = "0x400C8DE")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton RebuildCollider;
	}
}
