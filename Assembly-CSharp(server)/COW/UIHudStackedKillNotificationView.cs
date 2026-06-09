using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200236E RID: 9070
	[Token(Token = "0x200236E")]
	public class UIHudStackedKillNotificationView : UIBaseView
	{
		// Token: 0x0600C1EC RID: 49644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1EC")]
		[Address(RVA = "0x16744B0", Offset = "0x16744B0", VA = "0x7BBBE744B0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C1ED RID: 49645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C1ED")]
		[Address(RVA = "0x16746C0", Offset = "0x16746C0", VA = "0x7BBBE746C0")]
		public UIHudStackedKillNotificationView()
		{
		}

		// Token: 0x0400DBED RID: 56301
		[Token(Token = "0x400DBED")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Team1Icon;

		// Token: 0x0400DBEE RID: 56302
		[Token(Token = "0x400DBEE")]
		[FieldOffset(Offset = "0x28")]
		public UISprite icon;

		// Token: 0x0400DBEF RID: 56303
		[Token(Token = "0x400DBEF")]
		[FieldOffset(Offset = "0x30")]
		public GameObject Team2Icon;

		// Token: 0x0400DBF0 RID: 56304
		[Token(Token = "0x400DBF0")]
		[FieldOffset(Offset = "0x38")]
		public UILabel killer;

		// Token: 0x0400DBF1 RID: 56305
		[Token(Token = "0x400DBF1")]
		[FieldOffset(Offset = "0x40")]
		public UILabel content;

		// Token: 0x0400DBF2 RID: 56306
		[Token(Token = "0x400DBF2")]
		[FieldOffset(Offset = "0x48")]
		public GameObject styleRed;

		// Token: 0x0400DBF3 RID: 56307
		[Token(Token = "0x400DBF3")]
		[FieldOffset(Offset = "0x50")]
		public GameObject styleBlue;
	}
}
