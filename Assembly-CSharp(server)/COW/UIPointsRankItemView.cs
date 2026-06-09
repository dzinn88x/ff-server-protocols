using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002494 RID: 9364
	[Token(Token = "0x2002494")]
	internal class UIPointsRankItemView : UIBaseView
	{
		// Token: 0x0600C438 RID: 50232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C438")]
		[Address(RVA = "0x20E7E24", Offset = "0x20E7E24", VA = "0x7BBC8E7E24", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C439 RID: 50233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C439")]
		[Address(RVA = "0x20E800C", Offset = "0x20E800C", VA = "0x7BBC8E800C")]
		public UIPointsRankItemView()
		{
		}

		// Token: 0x0400EBA7 RID: 60327
		[Token(Token = "0x400EBA7")]
		[FieldOffset(Offset = "0x20")]
		public UIButton itembtn;

		// Token: 0x0400EBA8 RID: 60328
		[Token(Token = "0x400EBA8")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Rank;

		// Token: 0x0400EBA9 RID: 60329
		[Token(Token = "0x400EBA9")]
		[FieldOffset(Offset = "0x30")]
		public UISprite CupIcon;

		// Token: 0x0400EBAA RID: 60330
		[Token(Token = "0x400EBAA")]
		[FieldOffset(Offset = "0x38")]
		public UILabel GuildName;

		// Token: 0x0400EBAB RID: 60331
		[Token(Token = "0x400EBAB")]
		[FieldOffset(Offset = "0x40")]
		public UISprite Level;

		// Token: 0x0400EBAC RID: 60332
		[Token(Token = "0x400EBAC")]
		[FieldOffset(Offset = "0x48")]
		public UILabel Points;
	}
}
