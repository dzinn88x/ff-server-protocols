using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200232B RID: 9003
	[Token(Token = "0x200232B")]
	public class UIHudPlayerAndVehicleStatsView : UIBaseView
	{
		// Token: 0x0600C166 RID: 49510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C166")]
		[Address(RVA = "0x1D784F8", Offset = "0x1D784F8", VA = "0x7BBC5784F8", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C167 RID: 49511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C167")]
		[Address(RVA = "0x1D787E0", Offset = "0x1D787E0", VA = "0x7BBC5787E0")]
		public UIHudPlayerAndVehicleStatsView()
		{
		}

		// Token: 0x0400DA3B RID: 55867
		[Token(Token = "0x400DA3B")]
		[FieldOffset(Offset = "0x20")]
		public Transform ArmorStats;

		// Token: 0x0400DA3C RID: 55868
		[Token(Token = "0x400DA3C")]
		[FieldOffset(Offset = "0x28")]
		public UISprite Mark;

		// Token: 0x0400DA3D RID: 55869
		[Token(Token = "0x400DA3D")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid Skills;

		// Token: 0x0400DA3E RID: 55870
		[Token(Token = "0x400DA3E")]
		[FieldOffset(Offset = "0x38")]
		public UISprite SkillTemplate;

		// Token: 0x0400DA3F RID: 55871
		[Token(Token = "0x400DA3F")]
		[FieldOffset(Offset = "0x40")]
		public UISprite HPBar;

		// Token: 0x0400DA40 RID: 55872
		[Token(Token = "0x400DA40")]
		[FieldOffset(Offset = "0x48")]
		public UILabel LabelHP;

		// Token: 0x0400DA41 RID: 55873
		[Token(Token = "0x400DA41")]
		[FieldOffset(Offset = "0x50")]
		public UISprite VehicleHPBarThumb;

		// Token: 0x0400DA42 RID: 55874
		[Token(Token = "0x400DA42")]
		[FieldOffset(Offset = "0x58")]
		public UISprite VehicleHPBar;

		// Token: 0x0400DA43 RID: 55875
		[Token(Token = "0x400DA43")]
		[FieldOffset(Offset = "0x60")]
		public UILabel LabelVehicleHP;

		// Token: 0x0400DA44 RID: 55876
		[Token(Token = "0x400DA44")]
		[FieldOffset(Offset = "0x68")]
		public UIGrid BuffNode;

		// Token: 0x0400DA45 RID: 55877
		[Token(Token = "0x400DA45")]
		[FieldOffset(Offset = "0x70")]
		public UIGrid UseSkillNode;
	}
}
