using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002122 RID: 8482
	[Token(Token = "0x2002122")]
	public class UIBooyahSignInView : UIBaseView
	{
		// Token: 0x0600BD54 RID: 48468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD54")]
		[Address(RVA = "0x1433110", Offset = "0x1433110", VA = "0x7BBBC33110", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD55 RID: 48469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD55")]
		[Address(RVA = "0x1433920", Offset = "0x1433920", VA = "0x7BBBC33920")]
		public UIBooyahSignInView()
		{
		}

		// Token: 0x0400C27B RID: 49787
		[Token(Token = "0x400C27B")]
		[FieldOffset(Offset = "0x20")]
		public UINetworkTextureExt CdnBgTexture;

		// Token: 0x0400C27C RID: 49788
		[Token(Token = "0x400C27C")]
		[FieldOffset(Offset = "0x28")]
		public UILabel LabelPlayTip2;

		// Token: 0x0400C27D RID: 49789
		[Token(Token = "0x400C27D")]
		[FieldOffset(Offset = "0x30")]
		public UILabel LabelPlayTip1;

		// Token: 0x0400C27E RID: 49790
		[Token(Token = "0x400C27E")]
		[FieldOffset(Offset = "0x38")]
		public UILabel LabelRemainNum;

		// Token: 0x0400C27F RID: 49791
		[Token(Token = "0x400C27F")]
		[FieldOffset(Offset = "0x40")]
		public UIButton BtnClose;

		// Token: 0x0400C280 RID: 49792
		[Token(Token = "0x400C280")]
		[FieldOffset(Offset = "0x48")]
		public UISprite IconTokin;

		// Token: 0x0400C281 RID: 49793
		[Token(Token = "0x400C281")]
		[FieldOffset(Offset = "0x50")]
		public UIButton IconTokinBtn;

		// Token: 0x0400C282 RID: 49794
		[Token(Token = "0x400C282")]
		[FieldOffset(Offset = "0x58")]
		public UILabel LableTokinNum;

		// Token: 0x0400C283 RID: 49795
		[Token(Token = "0x400C283")]
		[FieldOffset(Offset = "0x60")]
		public UISprite VFXTokin;

		// Token: 0x0400C284 RID: 49796
		[Token(Token = "0x400C284")]
		[FieldOffset(Offset = "0x68")]
		public UIButton BtnRule;

		// Token: 0x0400C285 RID: 49797
		[Token(Token = "0x400C285")]
		[FieldOffset(Offset = "0x70")]
		public UILabel LabelDate;

		// Token: 0x0400C286 RID: 49798
		[Token(Token = "0x400C286")]
		[FieldOffset(Offset = "0x78")]
		public UINetworkTexture CdnTitle;

		// Token: 0x0400C287 RID: 49799
		[Token(Token = "0x400C287")]
		[FieldOffset(Offset = "0x80")]
		public UIButton BtnConfirm;

		// Token: 0x0400C288 RID: 49800
		[Token(Token = "0x400C288")]
		[FieldOffset(Offset = "0x88")]
		public GameObject Chosen;

		// Token: 0x0400C289 RID: 49801
		[Token(Token = "0x400C289")]
		[FieldOffset(Offset = "0x90")]
		public GameObject Locked;

		// Token: 0x0400C28A RID: 49802
		[Token(Token = "0x400C28A")]
		[FieldOffset(Offset = "0x98")]
		public UILabel LabelBooyahNum;

		// Token: 0x0400C28B RID: 49803
		[Token(Token = "0x400C28B")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel LabelRewardNum;

		// Token: 0x0400C28C RID: 49804
		[Token(Token = "0x400C28C")]
		[FieldOffset(Offset = "0xA8")]
		public UISprite SpriteReward;

		// Token: 0x0400C28D RID: 49805
		[Token(Token = "0x400C28D")]
		[FieldOffset(Offset = "0xB0")]
		public UILabel LabelBooyahNum1;

		// Token: 0x0400C28E RID: 49806
		[Token(Token = "0x400C28E")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel LabelRewardNum1;

		// Token: 0x0400C28F RID: 49807
		[Token(Token = "0x400C28F")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite SpriteReward1;

		// Token: 0x0400C290 RID: 49808
		[Token(Token = "0x400C290")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel LabelBooyahNum2;

		// Token: 0x0400C291 RID: 49809
		[Token(Token = "0x400C291")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel LabelRewardNum2;

		// Token: 0x0400C292 RID: 49810
		[Token(Token = "0x400C292")]
		[FieldOffset(Offset = "0xD8")]
		public UISprite SpriteReward2;

		// Token: 0x0400C293 RID: 49811
		[Token(Token = "0x400C293")]
		[FieldOffset(Offset = "0xE0")]
		public Transform SignInItemGrid;

		// Token: 0x0400C294 RID: 49812
		[Token(Token = "0x400C294")]
		[FieldOffset(Offset = "0xE8")]
		public Transform SpriteChosen;

		// Token: 0x0400C295 RID: 49813
		[Token(Token = "0x400C295")]
		[FieldOffset(Offset = "0xF0")]
		public UIButton BtnBullet0;

		// Token: 0x0400C296 RID: 49814
		[Token(Token = "0x400C296")]
		[FieldOffset(Offset = "0xF8")]
		public UIButton BtnBullet1;

		// Token: 0x0400C297 RID: 49815
		[Token(Token = "0x400C297")]
		[FieldOffset(Offset = "0x100")]
		public UIButton BtnBullet2;

		// Token: 0x0400C298 RID: 49816
		[Token(Token = "0x400C298")]
		[FieldOffset(Offset = "0x108")]
		public UIButton BtnBullet3;

		// Token: 0x0400C299 RID: 49817
		[Token(Token = "0x400C299")]
		[FieldOffset(Offset = "0x110")]
		public UIButton BtnBullet4;

		// Token: 0x0400C29A RID: 49818
		[Token(Token = "0x400C29A")]
		[FieldOffset(Offset = "0x118")]
		public UIButton BtnBullet5;

		// Token: 0x0400C29B RID: 49819
		[Token(Token = "0x400C29B")]
		[FieldOffset(Offset = "0x120")]
		public UIButton BtnBullet6;

		// Token: 0x0400C29C RID: 49820
		[Token(Token = "0x400C29C")]
		[FieldOffset(Offset = "0x128")]
		public UIButton BtnBullet7;
	}
}
