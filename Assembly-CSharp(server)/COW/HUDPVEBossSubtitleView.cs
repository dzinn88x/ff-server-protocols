using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020020BC RID: 8380
	[Token(Token = "0x20020BC")]
	public class HUDPVEBossSubtitleView : UIBaseView
	{
		// Token: 0x0600BC89 RID: 48265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC89")]
		[Address(RVA = "0x1857D60", Offset = "0x1857D60", VA = "0x7BBC057D60", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BC8A RID: 48266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BC8A")]
		[Address(RVA = "0x1857ED4", Offset = "0x1857ED4", VA = "0x7BBC057ED4")]
		public HUDPVEBossSubtitleView()
		{
		}

		// Token: 0x0400BD31 RID: 48433
		[Token(Token = "0x400BD31")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Container;

		// Token: 0x0400BD32 RID: 48434
		[Token(Token = "0x400BD32")]
		[FieldOffset(Offset = "0x28")]
		public UILabel ContentLabel;

		// Token: 0x0400BD33 RID: 48435
		[Token(Token = "0x400BD33")]
		[FieldOffset(Offset = "0x30")]
		public UISprite Bg_01;

		// Token: 0x0400BD34 RID: 48436
		[Token(Token = "0x400BD34")]
		[FieldOffset(Offset = "0x38")]
		public UISprite Bg_02;
	}
}
