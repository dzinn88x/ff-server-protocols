using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002143 RID: 8515
	[Token(Token = "0x2002143")]
	public class UIChampionshipTeamProfileView : UIBaseView
	{
		// Token: 0x0600BD96 RID: 48534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD96")]
		[Address(RVA = "0x1EDAF00", Offset = "0x1EDAF00", VA = "0x7BBC6DAF00", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD97 RID: 48535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD97")]
		[Address(RVA = "0x1EDB60C", Offset = "0x1EDB60C", VA = "0x7BBC6DB60C")]
		public UIChampionshipTeamProfileView()
		{
		}

		// Token: 0x0400C40A RID: 50186
		[Token(Token = "0x400C40A")]
		[FieldOffset(Offset = "0x20")]
		public GameObject TeamOverview;

		// Token: 0x0400C40B RID: 50187
		[Token(Token = "0x400C40B")]
		[FieldOffset(Offset = "0x28")]
		public UIGrid NewTeam;

		// Token: 0x0400C40C RID: 50188
		[Token(Token = "0x400C40C")]
		[FieldOffset(Offset = "0x30")]
		public UIButton CreateTeam;

		// Token: 0x0400C40D RID: 50189
		[Token(Token = "0x400C40D")]
		[FieldOffset(Offset = "0x38")]
		public UILabel CreateTeamLabel;

		// Token: 0x0400C40E RID: 50190
		[Token(Token = "0x400C40E")]
		[FieldOffset(Offset = "0x40")]
		public UIButton JoinTeam;

		// Token: 0x0400C40F RID: 50191
		[Token(Token = "0x400C40F")]
		[FieldOffset(Offset = "0x48")]
		public GameObject Left;

		// Token: 0x0400C410 RID: 50192
		[Token(Token = "0x400C410")]
		[FieldOffset(Offset = "0x50")]
		public UIMenu Menu;

		// Token: 0x0400C411 RID: 50193
		[Token(Token = "0x400C411")]
		[FieldOffset(Offset = "0x58")]
		public UILabel MenuLabelSelect;

		// Token: 0x0400C412 RID: 50194
		[Token(Token = "0x400C412")]
		[FieldOffset(Offset = "0x60")]
		public UILabel MenuLabelUnSelect;

		// Token: 0x0400C413 RID: 50195
		[Token(Token = "0x400C413")]
		[FieldOffset(Offset = "0x68")]
		public UITipsButton RedPoint;

		// Token: 0x0400C414 RID: 50196
		[Token(Token = "0x400C414")]
		[FieldOffset(Offset = "0x70")]
		public GameObject Info;

		// Token: 0x0400C415 RID: 50197
		[Token(Token = "0x400C415")]
		[FieldOffset(Offset = "0x78")]
		public UILabel TeammateCntText;

		// Token: 0x0400C416 RID: 50198
		[Token(Token = "0x400C416")]
		[FieldOffset(Offset = "0x80")]
		public UIEasyList InfoEasyList;

		// Token: 0x0400C417 RID: 50199
		[Token(Token = "0x400C417")]
		[FieldOffset(Offset = "0x88")]
		public UIButton Recruit;

		// Token: 0x0400C418 RID: 50200
		[Token(Token = "0x400C418")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnApplyAndInvite;

		// Token: 0x0400C419 RID: 50201
		[Token(Token = "0x400C419")]
		[FieldOffset(Offset = "0x98")]
		public UITipsButton ApplyAndInviteRedPoint;

		// Token: 0x0400C41A RID: 50202
		[Token(Token = "0x400C41A")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton BtnInvite;

		// Token: 0x0400C41B RID: 50203
		[Token(Token = "0x400C41B")]
		[FieldOffset(Offset = "0xA8")]
		public UITipsButton InviteRedPoint;

		// Token: 0x0400C41C RID: 50204
		[Token(Token = "0x400C41C")]
		[FieldOffset(Offset = "0xB0")]
		public UIButton BtnInviteNoTeam;

		// Token: 0x0400C41D RID: 50205
		[Token(Token = "0x400C41D")]
		[FieldOffset(Offset = "0xB8")]
		public UITipsButton InviteNoTeamRedPoint;

		// Token: 0x0400C41E RID: 50206
		[Token(Token = "0x400C41E")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject NoTeamTips;

		// Token: 0x0400C41F RID: 50207
		[Token(Token = "0x400C41F")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject Record;

		// Token: 0x0400C420 RID: 50208
		[Token(Token = "0x400C420")]
		[FieldOffset(Offset = "0xD0")]
		public UIEasyList RecoardEasyList;

		// Token: 0x0400C421 RID: 50209
		[Token(Token = "0x400C421")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton RecordDetail;

		// Token: 0x0400C422 RID: 50210
		[Token(Token = "0x400C422")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject RecordNoData;

		// Token: 0x0400C423 RID: 50211
		[Token(Token = "0x400C423")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject RecordNoTeam;

		// Token: 0x0400C424 RID: 50212
		[Token(Token = "0x400C424")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel RecordTips;

		// Token: 0x0400C425 RID: 50213
		[Token(Token = "0x400C425")]
		[FieldOffset(Offset = "0xF8")]
		public UIButton Exit;

		// Token: 0x0400C426 RID: 50214
		[Token(Token = "0x400C426")]
		[FieldOffset(Offset = "0x100")]
		public UIButton ChampionshipRecruitBtn;
	}
}
