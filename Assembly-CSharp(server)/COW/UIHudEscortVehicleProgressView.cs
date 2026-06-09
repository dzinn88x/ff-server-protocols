using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020022CD RID: 8909
	[Token(Token = "0x20022CD")]
	public class UIHudEscortVehicleProgressView : UIBaseView
	{
		// Token: 0x0600C0AA RID: 49322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0AA")]
		[Address(RVA = "0x1C0A86C", Offset = "0x1C0A86C", VA = "0x7BBC40A86C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C0AB RID: 49323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C0AB")]
		[Address(RVA = "0x1C0AC2C", Offset = "0x1C0AC2C", VA = "0x7BBC40AC2C")]
		public UIHudEscortVehicleProgressView()
		{
		}

		// Token: 0x0400D68A RID: 54922
		[Token(Token = "0x400D68A")]
		[FieldOffset(Offset = "0x20")]
		public Transform PlayerStatus;

		// Token: 0x0400D68B RID: 54923
		[Token(Token = "0x400D68B")]
		[FieldOffset(Offset = "0x28")]
		public UILabel DefenderLabel;

		// Token: 0x0400D68C RID: 54924
		[Token(Token = "0x400D68C")]
		[FieldOffset(Offset = "0x30")]
		public UILabel AttackerLabel;

		// Token: 0x0400D68D RID: 54925
		[Token(Token = "0x400D68D")]
		[FieldOffset(Offset = "0x38")]
		public UISprite ProgBar1;

		// Token: 0x0400D68E RID: 54926
		[Token(Token = "0x400D68E")]
		[FieldOffset(Offset = "0x40")]
		public UISprite Flag1;

		// Token: 0x0400D68F RID: 54927
		[Token(Token = "0x400D68F")]
		[FieldOffset(Offset = "0x48")]
		public UISprite ProgBar2;

		// Token: 0x0400D690 RID: 54928
		[Token(Token = "0x400D690")]
		[FieldOffset(Offset = "0x50")]
		public UISprite Flag2;

		// Token: 0x0400D691 RID: 54929
		[Token(Token = "0x400D691")]
		[FieldOffset(Offset = "0x58")]
		public UISprite ProgBar3;

		// Token: 0x0400D692 RID: 54930
		[Token(Token = "0x400D692")]
		[FieldOffset(Offset = "0x60")]
		public UISprite Flag3;

		// Token: 0x0400D693 RID: 54931
		[Token(Token = "0x400D693")]
		[FieldOffset(Offset = "0x68")]
		public UISprite ProgBar4;

		// Token: 0x0400D694 RID: 54932
		[Token(Token = "0x400D694")]
		[FieldOffset(Offset = "0x70")]
		public UISprite Flag4;

		// Token: 0x0400D695 RID: 54933
		[Token(Token = "0x400D695")]
		[FieldOffset(Offset = "0x78")]
		public Transform VehicleIcon;

		// Token: 0x0400D696 RID: 54934
		[Token(Token = "0x400D696")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Hint;

		// Token: 0x0400D697 RID: 54935
		[Token(Token = "0x400D697")]
		[FieldOffset(Offset = "0x88")]
		public UILabel HintText;

		// Token: 0x0400D698 RID: 54936
		[Token(Token = "0x400D698")]
		[FieldOffset(Offset = "0x90")]
		public UISprite DescriptionBG;
	}
}
