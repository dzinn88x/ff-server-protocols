using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002128 RID: 8488
	[Token(Token = "0x2002128")]
	public class UIChampionshipAnimView : UIBaseView
	{
		// Token: 0x0600BD60 RID: 48480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD60")]
		[Address(RVA = "0x1C26E2C", Offset = "0x1C26E2C", VA = "0x7BBC426E2C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD61 RID: 48481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD61")]
		[Address(RVA = "0x1C27288", Offset = "0x1C27288", VA = "0x7BBC427288")]
		public UIChampionshipAnimView()
		{
		}

		// Token: 0x0400C308 RID: 49928
		[Token(Token = "0x400C308")]
		[FieldOffset(Offset = "0x20")]
		public Animator Animator;

		// Token: 0x0400C309 RID: 49929
		[Token(Token = "0x400C309")]
		[FieldOffset(Offset = "0x28")]
		public UILabel SeasonID;

		// Token: 0x0400C30A RID: 49930
		[Token(Token = "0x400C30A")]
		[FieldOffset(Offset = "0x30")]
		public UILabel SeasonName;

		// Token: 0x0400C30B RID: 49931
		[Token(Token = "0x400C30B")]
		[FieldOffset(Offset = "0x38")]
		public UILabel SeasonTime;

		// Token: 0x0400C30C RID: 49932
		[Token(Token = "0x400C30C")]
		[FieldOffset(Offset = "0x40")]
		public GameObject SeasonInfo;

		// Token: 0x0400C30D RID: 49933
		[Token(Token = "0x400C30D")]
		[FieldOffset(Offset = "0x48")]
		public GameObject DefaultIcon;

		// Token: 0x0400C30E RID: 49934
		[Token(Token = "0x400C30E")]
		[FieldOffset(Offset = "0x50")]
		public UINetworkTexture CDNIcon;

		// Token: 0x0400C30F RID: 49935
		[Token(Token = "0x400C30F")]
		[FieldOffset(Offset = "0x58")]
		public GameObject ExclusiveAwardEffect;

		// Token: 0x0400C310 RID: 49936
		[Token(Token = "0x400C310")]
		[FieldOffset(Offset = "0x60")]
		public UIButton ConfirmBtn;

		// Token: 0x0400C311 RID: 49937
		[Token(Token = "0x400C311")]
		[FieldOffset(Offset = "0x68")]
		public UIButton GotoMailBtn;

		// Token: 0x0400C312 RID: 49938
		[Token(Token = "0x400C312")]
		[FieldOffset(Offset = "0x70")]
		public GameObject ResultInfo;

		// Token: 0x0400C313 RID: 49939
		[Token(Token = "0x400C313")]
		[FieldOffset(Offset = "0x78")]
		public UILabel RankScore;

		// Token: 0x0400C314 RID: 49940
		[Token(Token = "0x400C314")]
		[FieldOffset(Offset = "0x80")]
		public UILabel rank;

		// Token: 0x0400C315 RID: 49941
		[Token(Token = "0x400C315")]
		[FieldOffset(Offset = "0x88")]
		public UISprite CupIcon;

		// Token: 0x0400C316 RID: 49942
		[Token(Token = "0x400C316")]
		[FieldOffset(Offset = "0x90")]
		public UILabel RankPos;

		// Token: 0x0400C317 RID: 49943
		[Token(Token = "0x400C317")]
		[FieldOffset(Offset = "0x98")]
		public UIGrid RewardList;

		// Token: 0x0400C318 RID: 49944
		[Token(Token = "0x400C318")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject Map;
	}
}
