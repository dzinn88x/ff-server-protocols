using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022EC RID: 8940
	[Token(Token = "0x20022EC")]
	public class UIHudInventoryEntryView : UIBaseView
	{
		// Token: 0x0600C0E8 RID: 49384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0E8")]
		[Address(RVA = "0x1C435C4", Offset = "0x1C435C4", VA = "0x7BBC4435C4", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0E9 RID: 49385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0E9")]
		[Address(RVA = "0x1C437BC", Offset = "0x1C437BC", VA = "0x7BBC4437BC")]
		public UIHudInventoryEntryView()
		{
		}

		// Token: 0x0400D760 RID: 55136
		[Token(Token = "0x400D760")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnInventory;

		// Token: 0x0400D761 RID: 55137
		[Token(Token = "0x400D761")]
		[FieldOffset(Offset = "0x28")]
		public ParticleSystem FlashEffect;

		// Token: 0x0400D762 RID: 55138
		[Token(Token = "0x400D762")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Capratio;

		// Token: 0x0400D763 RID: 55139
		[Token(Token = "0x400D763")]
		[FieldOffset(Offset = "0x38")]
		public UILabel CapacityRatio;

		// Token: 0x0400D764 RID: 55140
		[Token(Token = "0x400D764")]
		[FieldOffset(Offset = "0x40")]
		public GameObject MaxCap;

		// Token: 0x0400D765 RID: 55141
		[Token(Token = "0x400D765")]
		[FieldOffset(Offset = "0x48")]
		public UISprite ItemLevelInfo;
	}
}
