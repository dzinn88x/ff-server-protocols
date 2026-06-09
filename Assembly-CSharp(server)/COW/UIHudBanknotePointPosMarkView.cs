using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002275 RID: 8821
	[Token(Token = "0x2002275")]
	public class UIHudBanknotePointPosMarkView : UIBaseView
	{
		// Token: 0x0600BFFB RID: 49147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFFB")]
		[Address(RVA = "0x18915A8", Offset = "0x18915A8", VA = "0x7BBC0915A8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BFFC RID: 49148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BFFC")]
		[Address(RVA = "0x1891880", Offset = "0x1891880", VA = "0x7BBC091880")]
		public UIHudBanknotePointPosMarkView()
		{
		}

		// Token: 0x0400D3D2 RID: 54226
		[Token(Token = "0x400D3D2")]
		[FieldOffset(Offset = "0x20")]
		public UISprite NormalState;

		// Token: 0x0400D3D3 RID: 54227
		[Token(Token = "0x400D3D3")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ScrambleState;

		// Token: 0x0400D3D4 RID: 54228
		[Token(Token = "0x400D3D4")]
		[FieldOffset(Offset = "0x30")]
		public UILabel ControlPointName;

		// Token: 0x0400D3D5 RID: 54229
		[Token(Token = "0x400D3D5")]
		[FieldOffset(Offset = "0x38")]
		public UILabel RestAmount;

		// Token: 0x0400D3D6 RID: 54230
		[Token(Token = "0x400D3D6")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ArrowLeft;

		// Token: 0x0400D3D7 RID: 54231
		[Token(Token = "0x400D3D7")]
		[FieldOffset(Offset = "0x48")]
		public GameObject ArrowUp;

		// Token: 0x0400D3D8 RID: 54232
		[Token(Token = "0x400D3D8")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ArrowDown;

		// Token: 0x0400D3D9 RID: 54233
		[Token(Token = "0x400D3D9")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ArrowRight;

		// Token: 0x0400D3DA RID: 54234
		[Token(Token = "0x400D3DA")]
		[FieldOffset(Offset = "0x60")]
		public UILabel DistanceLabel;

		// Token: 0x0400D3DB RID: 54235
		[Token(Token = "0x400D3DB")]
		[FieldOffset(Offset = "0x68")]
		public UIWidget Container;
	}
}
