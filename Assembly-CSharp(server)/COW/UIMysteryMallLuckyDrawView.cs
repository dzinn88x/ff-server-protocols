using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002455 RID: 9301
	[Token(Token = "0x2002455")]
	public class UIMysteryMallLuckyDrawView : UIBaseView
	{
		// Token: 0x0600C3BA RID: 50106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3BA")]
		[Address(RVA = "0x14D5BDC", Offset = "0x14D5BDC", VA = "0x7BBBCD5BDC", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C3BB RID: 50107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C3BB")]
		[Address(RVA = "0x14D6020", Offset = "0x14D6020", VA = "0x7BBBCD6020")]
		public UIMysteryMallLuckyDrawView()
		{
		}

		// Token: 0x0400E874 RID: 59508
		[Token(Token = "0x400E874")]
		[FieldOffset(Offset = "0x20")]
		public UIButton BtnClose;

		// Token: 0x0400E875 RID: 59509
		[Token(Token = "0x400E875")]
		[FieldOffset(Offset = "0x28")]
		public GameObject GetLuckContainer;

		// Token: 0x0400E876 RID: 59510
		[Token(Token = "0x400E876")]
		[FieldOffset(Offset = "0x30")]
		public UIButton BtnGetLuck;

		// Token: 0x0400E877 RID: 59511
		[Token(Token = "0x400E877")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelGetLuckTip;

		// Token: 0x0400E878 RID: 59512
		[Token(Token = "0x400E878")]
		[FieldOffset(Offset = "0x40")]
		public GameObject FinishLuckContainer;

		// Token: 0x0400E879 RID: 59513
		[Token(Token = "0x400E879")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LabelCongratulation;

		// Token: 0x0400E87A RID: 59514
		[Token(Token = "0x400E87A")]
		[FieldOffset(Offset = "0x50")]
		public GameObject LabelSuperLuckTip;

		// Token: 0x0400E87B RID: 59515
		[Token(Token = "0x400E87B")]
		[FieldOffset(Offset = "0x58")]
		public GameObject VFXDrawingContainer;

		// Token: 0x0400E87C RID: 59516
		[Token(Token = "0x400E87C")]
		[FieldOffset(Offset = "0x60")]
		public GameObject VFXStopDrawContainer;

		// Token: 0x0400E87D RID: 59517
		[Token(Token = "0x400E87D")]
		[FieldOffset(Offset = "0x68")]
		public UILabel LabelLuckNumLBit;

		// Token: 0x0400E87E RID: 59518
		[Token(Token = "0x400E87E")]
		[FieldOffset(Offset = "0x70")]
		public UILabel LabelLuckNumRBit;

		// Token: 0x0400E87F RID: 59519
		[Token(Token = "0x400E87F")]
		[FieldOffset(Offset = "0x78")]
		public MeshRenderer VFXLuckNum;

		// Token: 0x0400E880 RID: 59520
		[Token(Token = "0x400E880")]
		[FieldOffset(Offset = "0x80")]
		public UILabel LabelLuckBitTip;

		// Token: 0x0400E881 RID: 59521
		[Token(Token = "0x400E881")]
		[FieldOffset(Offset = "0x88")]
		public UILabel LabelLuckBitTip1;

		// Token: 0x0400E882 RID: 59522
		[Token(Token = "0x400E882")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnGoMystery;

		// Token: 0x0400E883 RID: 59523
		[Token(Token = "0x400E883")]
		[FieldOffset(Offset = "0x98")]
		public UILabel LabelBtnGoMystery;

		// Token: 0x0400E884 RID: 59524
		[Token(Token = "0x400E884")]
		[FieldOffset(Offset = "0xA0")]
		public UINetworkTextureExt CdnBgTexture;
	}
}
