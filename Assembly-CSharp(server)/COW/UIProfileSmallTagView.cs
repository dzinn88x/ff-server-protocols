using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024AD RID: 9389
	[Token(Token = "0x20024AD")]
	public class UIProfileSmallTagView : UIBaseView
	{
		// Token: 0x0600C46A RID: 50282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C46A")]
		[Address(RVA = "0x1FEFE68", Offset = "0x1FEFE68", VA = "0x7BBC7EFE68", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C46B RID: 50283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C46B")]
		[Address(RVA = "0x1FF00BC", Offset = "0x1FF00BC", VA = "0x7BBC7F00BC")]
		public UIProfileSmallTagView()
		{
		}

		// Token: 0x0400ED9F RID: 60831
		[Token(Token = "0x400ED9F")]
		[FieldOffset(Offset = "0x20")]
		public UIButton UIProfileSmallTag;

		// Token: 0x0400EDA0 RID: 60832
		[Token(Token = "0x400EDA0")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Tag;

		// Token: 0x0400EDA1 RID: 60833
		[Token(Token = "0x400EDA1")]
		[FieldOffset(Offset = "0x30")]
		public UISprite LevelBg;

		// Token: 0x0400EDA2 RID: 60834
		[Token(Token = "0x400EDA2")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Lock;

		// Token: 0x0400EDA3 RID: 60835
		[Token(Token = "0x400EDA3")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Selected;

		// Token: 0x0400EDA4 RID: 60836
		[Token(Token = "0x400EDA4")]
		[FieldOffset(Offset = "0x48")]
		public UILabel ConditionNum;

		// Token: 0x0400EDA5 RID: 60837
		[Token(Token = "0x400EDA5")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Equiped;

		// Token: 0x0400EDA6 RID: 60838
		[Token(Token = "0x400EDA6")]
		[FieldOffset(Offset = "0x58")]
		public UICustomHoverButton CustomBtn;
	}
}
