using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002142 RID: 8514
	[Token(Token = "0x2002142")]
	public class UIChampionshipTeamOverviewView : UIBaseView
	{
		// Token: 0x0600BD94 RID: 48532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD94")]
		[Address(RVA = "0x1ED61E0", Offset = "0x1ED61E0", VA = "0x7BBC6D61E0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD95 RID: 48533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD95")]
		[Address(RVA = "0x1ED6724", Offset = "0x1ED6724", VA = "0x7BBC6D6724")]
		public UIChampionshipTeamOverviewView()
		{
		}

		// Token: 0x0400C3F5 RID: 50165
		[Token(Token = "0x400C3F5")]
		[FieldOffset(Offset = "0x20")]
		public GameObject Content;

		// Token: 0x0400C3F6 RID: 50166
		[Token(Token = "0x400C3F6")]
		[FieldOffset(Offset = "0x28")]
		public UISprite TeamIcon;

		// Token: 0x0400C3F7 RID: 50167
		[Token(Token = "0x400C3F7")]
		[FieldOffset(Offset = "0x30")]
		public UIButton TeamIconBtn;

		// Token: 0x0400C3F8 RID: 50168
		[Token(Token = "0x400C3F8")]
		[FieldOffset(Offset = "0x38")]
		public UILabel TeamName;

		// Token: 0x0400C3F9 RID: 50169
		[Token(Token = "0x400C3F9")]
		[FieldOffset(Offset = "0x40")]
		public GameObject FlagBg;

		// Token: 0x0400C3FA RID: 50170
		[Token(Token = "0x400C3FA")]
		[FieldOffset(Offset = "0x48")]
		public UISprite NationFlag;

		// Token: 0x0400C3FB RID: 50171
		[Token(Token = "0x400C3FB")]
		[FieldOffset(Offset = "0x50")]
		public UIButton InfoEdit;

		// Token: 0x0400C3FC RID: 50172
		[Token(Token = "0x400C3FC")]
		[FieldOffset(Offset = "0x58")]
		public UIButton InfoEdit_bg;

		// Token: 0x0400C3FD RID: 50173
		[Token(Token = "0x400C3FD")]
		[FieldOffset(Offset = "0x60")]
		public GameObject RankNomal;

		// Token: 0x0400C3FE RID: 50174
		[Token(Token = "0x400C3FE")]
		[FieldOffset(Offset = "0x68")]
		public UILabel RankValue;

		// Token: 0x0400C3FF RID: 50175
		[Token(Token = "0x400C3FF")]
		[FieldOffset(Offset = "0x70")]
		public UISprite RankTop3;

		// Token: 0x0400C400 RID: 50176
		[Token(Token = "0x400C400")]
		[FieldOffset(Offset = "0x78")]
		public UITable TeamInfoTable;

		// Token: 0x0400C401 RID: 50177
		[Token(Token = "0x400C401")]
		[FieldOffset(Offset = "0x80")]
		public UILabel TeamID;

		// Token: 0x0400C402 RID: 50178
		[Token(Token = "0x400C402")]
		[FieldOffset(Offset = "0x88")]
		public GameObject MemberCount;

		// Token: 0x0400C403 RID: 50179
		[Token(Token = "0x400C403")]
		[FieldOffset(Offset = "0x90")]
		public UILabel TeamMemberCount;

		// Token: 0x0400C404 RID: 50180
		[Token(Token = "0x400C404")]
		[FieldOffset(Offset = "0x98")]
		public GameObject TopCup;

		// Token: 0x0400C405 RID: 50181
		[Token(Token = "0x400C405")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject NoTeamIcon;

		// Token: 0x0400C406 RID: 50182
		[Token(Token = "0x400C406")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject Solo;

		// Token: 0x0400C407 RID: 50183
		[Token(Token = "0x400C407")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject Double;

		// Token: 0x0400C408 RID: 50184
		[Token(Token = "0x400C408")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject Four;

		// Token: 0x0400C409 RID: 50185
		[Token(Token = "0x400C409")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject TopThreeEffect;
	}
}
