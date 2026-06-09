using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002357 RID: 9047
	[Token(Token = "0x2002357")]
	public class UIHudRevivePointPosMarkView : UIBaseView
	{
		// Token: 0x0600C1BE RID: 49598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1BE")]
		[Address(RVA = "0x17FA9DC", Offset = "0x17FA9DC", VA = "0x7BBBFFA9DC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1BF RID: 49599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1BF")]
		[Address(RVA = "0x17FABE4", Offset = "0x17FABE4", VA = "0x7BBBFFABE4")]
		public UIHudRevivePointPosMarkView()
		{
		}

		// Token: 0x0400DB19 RID: 56089
		[Token(Token = "0x400DB19")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400DB1A RID: 56090
		[Token(Token = "0x400DB1A")]
		[FieldOffset(Offset = "0x28")]
		public UISprite ProgressBg;

		// Token: 0x0400DB1B RID: 56091
		[Token(Token = "0x400DB1B")]
		[FieldOffset(Offset = "0x30")]
		public UILabel PointStatusLabel;

		// Token: 0x0400DB1C RID: 56092
		[Token(Token = "0x400DB1C")]
		[FieldOffset(Offset = "0x38")]
		public UISprite StateIcon;

		// Token: 0x0400DB1D RID: 56093
		[Token(Token = "0x400DB1D")]
		[FieldOffset(Offset = "0x40")]
		public UISprite StateBg;

		// Token: 0x0400DB1E RID: 56094
		[Token(Token = "0x400DB1E")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Timer;

		// Token: 0x0400DB1F RID: 56095
		[Token(Token = "0x400DB1F")]
		[FieldOffset(Offset = "0x50")]
		public UILabel DistanceLabel;
	}
}
