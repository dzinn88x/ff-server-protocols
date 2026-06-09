using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002131 RID: 8497
	[Token(Token = "0x2002131")]
	public class UIChampionshipLeaderBoardItemView : UIBaseView
	{
		// Token: 0x0600BD72 RID: 48498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD72")]
		[Address(RVA = "0x1EC4E3C", Offset = "0x1EC4E3C", VA = "0x7BBC6C4E3C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD73 RID: 48499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD73")]
		[Address(RVA = "0x1EC51D4", Offset = "0x1EC51D4", VA = "0x7BBC6C51D4")]
		public UIChampionshipLeaderBoardItemView()
		{
		}

		// Token: 0x0400C381 RID: 50049
		[Token(Token = "0x400C381")]
		[FieldOffset(Offset = "0x20")]
		public UIButton ItemBtn;

		// Token: 0x0400C382 RID: 50050
		[Token(Token = "0x400C382")]
		[FieldOffset(Offset = "0x28")]
		public UILabel Score;

		// Token: 0x0400C383 RID: 50051
		[Token(Token = "0x400C383")]
		[FieldOffset(Offset = "0x30")]
		public UILabel Kills;

		// Token: 0x0400C384 RID: 50052
		[Token(Token = "0x400C384")]
		[FieldOffset(Offset = "0x38")]
		public UISprite BG;

		// Token: 0x0400C385 RID: 50053
		[Token(Token = "0x400C385")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Profile;

		// Token: 0x0400C386 RID: 50054
		[Token(Token = "0x400C386")]
		[FieldOffset(Offset = "0x48")]
		public GameObject FirstCupIcon;

		// Token: 0x0400C387 RID: 50055
		[Token(Token = "0x400C387")]
		[FieldOffset(Offset = "0x50")]
		public GameObject FirstBg;

		// Token: 0x0400C388 RID: 50056
		[Token(Token = "0x400C388")]
		[FieldOffset(Offset = "0x58")]
		public GameObject SecondCupIcon;

		// Token: 0x0400C389 RID: 50057
		[Token(Token = "0x400C389")]
		[FieldOffset(Offset = "0x60")]
		public GameObject SecondBg;

		// Token: 0x0400C38A RID: 50058
		[Token(Token = "0x400C38A")]
		[FieldOffset(Offset = "0x68")]
		public GameObject ThirdCupIcon;

		// Token: 0x0400C38B RID: 50059
		[Token(Token = "0x400C38B")]
		[FieldOffset(Offset = "0x70")]
		public GameObject ThirdBg;

		// Token: 0x0400C38C RID: 50060
		[Token(Token = "0x400C38C")]
		[FieldOffset(Offset = "0x78")]
		public GameObject SelfBg;

		// Token: 0x0400C38D RID: 50061
		[Token(Token = "0x400C38D")]
		[FieldOffset(Offset = "0x80")]
		public GameObject OtherRank;

		// Token: 0x0400C38E RID: 50062
		[Token(Token = "0x400C38E")]
		[FieldOffset(Offset = "0x88")]
		public UILabel rank;
	}
}
