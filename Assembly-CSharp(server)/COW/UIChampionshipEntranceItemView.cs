using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200212E RID: 8494
	[Token(Token = "0x200212E")]
	public class UIChampionshipEntranceItemView : UIBaseView
	{
		// Token: 0x0600BD6C RID: 48492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD6C")]
		[Address(RVA = "0x1C347F0", Offset = "0x1C347F0", VA = "0x7BBC4347F0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BD6D RID: 48493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD6D")]
		[Address(RVA = "0x1C35448", Offset = "0x1C35448", VA = "0x7BBC435448")]
		public UIChampionshipEntranceItemView()
		{
		}

		// Token: 0x0400C329 RID: 49961
		[Token(Token = "0x400C329")]
		[FieldOffset(Offset = "0x20")]
		public Animation ShowDetailedInfoAnim;

		// Token: 0x0400C32A RID: 49962
		[Token(Token = "0x400C32A")]
		[FieldOffset(Offset = "0x28")]
		public Animation Animation;

		// Token: 0x0400C32B RID: 49963
		[Token(Token = "0x400C32B")]
		[FieldOffset(Offset = "0x30")]
		public UIButton EntranceBtn;

		// Token: 0x0400C32C RID: 49964
		[Token(Token = "0x400C32C")]
		[FieldOffset(Offset = "0x38")]
		public GameObject OpenEffect;

		// Token: 0x0400C32D RID: 49965
		[Token(Token = "0x400C32D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ClickEffect;

		// Token: 0x0400C32E RID: 49966
		[Token(Token = "0x400C32E")]
		[FieldOffset(Offset = "0x48")]
		public GameObject OpenInfo;

		// Token: 0x0400C32F RID: 49967
		[Token(Token = "0x400C32F")]
		[FieldOffset(Offset = "0x50")]
		public GameObject SubscriptInfo;

		// Token: 0x0400C330 RID: 49968
		[Token(Token = "0x400C330")]
		[FieldOffset(Offset = "0x58")]
		public UILabel Subscript;

		// Token: 0x0400C331 RID: 49969
		[Token(Token = "0x400C331")]
		[FieldOffset(Offset = "0x60")]
		public UILabel OpenTimeDesc;

		// Token: 0x0400C332 RID: 49970
		[Token(Token = "0x400C332")]
		[FieldOffset(Offset = "0x68")]
		public UILabel OpenTimeInDay;

		// Token: 0x0400C333 RID: 49971
		[Token(Token = "0x400C333")]
		[FieldOffset(Offset = "0x70")]
		public UILabel OpenTimeInWeek;

		// Token: 0x0400C334 RID: 49972
		[Token(Token = "0x400C334")]
		[FieldOffset(Offset = "0x78")]
		public UILabel StartTime;

		// Token: 0x0400C335 RID: 49973
		[Token(Token = "0x400C335")]
		[FieldOffset(Offset = "0x80")]
		public UILabel SettleTime;

		// Token: 0x0400C336 RID: 49974
		[Token(Token = "0x400C336")]
		[FieldOffset(Offset = "0x88")]
		public UILabel MatchFinished;

		// Token: 0x0400C337 RID: 49975
		[Token(Token = "0x400C337")]
		[FieldOffset(Offset = "0x90")]
		public UIButton Ticket;

		// Token: 0x0400C338 RID: 49976
		[Token(Token = "0x400C338")]
		[FieldOffset(Offset = "0x98")]
		public UILabel RemainSessionLabel;

		// Token: 0x0400C339 RID: 49977
		[Token(Token = "0x400C339")]
		[FieldOffset(Offset = "0xA0")]
		public UILabel SeasonTime;

		// Token: 0x0400C33A RID: 49978
		[Token(Token = "0x400C33A")]
		[FieldOffset(Offset = "0xA8")]
		public UILabel SeasonName;

		// Token: 0x0400C33B RID: 49979
		[Token(Token = "0x400C33B")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject ComingSoon;

		// Token: 0x0400C33C RID: 49980
		[Token(Token = "0x400C33C")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject CupDefault;

		// Token: 0x0400C33D RID: 49981
		[Token(Token = "0x400C33D")]
		[FieldOffset(Offset = "0xC0")]
		public UINetworkTexture CupCDN;

		// Token: 0x0400C33E RID: 49982
		[Token(Token = "0x400C33E")]
		[FieldOffset(Offset = "0xC8")]
		public UITipsButton ApplyRedPoint;

		// Token: 0x0400C33F RID: 49983
		[Token(Token = "0x400C33F")]
		[FieldOffset(Offset = "0xD0")]
		public UITipsButton TrialOpenRedPoint;

		// Token: 0x0400C340 RID: 49984
		[Token(Token = "0x400C340")]
		[FieldOffset(Offset = "0xD8")]
		public UIButton DetailedInfoBtn;

		// Token: 0x0400C341 RID: 49985
		[Token(Token = "0x400C341")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject LockNode;

		// Token: 0x0400C342 RID: 49986
		[Token(Token = "0x400C342")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject LevelCondition;

		// Token: 0x0400C343 RID: 49987
		[Token(Token = "0x400C343")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel LevelConditionContent;

		// Token: 0x0400C344 RID: 49988
		[Token(Token = "0x400C344")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject ScoreCondition;

		// Token: 0x0400C345 RID: 49989
		[Token(Token = "0x400C345")]
		[FieldOffset(Offset = "0x100")]
		public UILabel ScoreConditionContent;

		// Token: 0x0400C346 RID: 49990
		[Token(Token = "0x400C346")]
		[FieldOffset(Offset = "0x108")]
		public UIButton DetailedInfoBackBtn;

		// Token: 0x0400C347 RID: 49991
		[Token(Token = "0x400C347")]
		[FieldOffset(Offset = "0x110")]
		public UILabel DetailedTitle;

		// Token: 0x0400C348 RID: 49992
		[Token(Token = "0x400C348")]
		[FieldOffset(Offset = "0x118")]
		public UILabel CurState;

		// Token: 0x0400C349 RID: 49993
		[Token(Token = "0x400C349")]
		[FieldOffset(Offset = "0x120")]
		public UIToggleButton PrepareBtn;

		// Token: 0x0400C34A RID: 49994
		[Token(Token = "0x400C34A")]
		[FieldOffset(Offset = "0x128")]
		public UIToggleButton OpenBtn;

		// Token: 0x0400C34B RID: 49995
		[Token(Token = "0x400C34B")]
		[FieldOffset(Offset = "0x130")]
		public UIToggleButton CheckBtn;

		// Token: 0x0400C34C RID: 49996
		[Token(Token = "0x400C34C")]
		[FieldOffset(Offset = "0x138")]
		public UIToggleButton SettleBtn;

		// Token: 0x0400C34D RID: 49997
		[Token(Token = "0x400C34D")]
		[FieldOffset(Offset = "0x140")]
		public UILabel ModeName;

		// Token: 0x0400C34E RID: 49998
		[Token(Token = "0x400C34E")]
		[FieldOffset(Offset = "0x148")]
		public UILabel PlayerCount;

		// Token: 0x0400C34F RID: 49999
		[Token(Token = "0x400C34F")]
		[FieldOffset(Offset = "0x150")]
		public UILabel MinMatchNum;

		// Token: 0x0400C350 RID: 50000
		[Token(Token = "0x400C350")]
		[FieldOffset(Offset = "0x158")]
		public UILabel NoWeaponSkinBonus;

		// Token: 0x0400C351 RID: 50001
		[Token(Token = "0x400C351")]
		[FieldOffset(Offset = "0x160")]
		public GameObject MonSelect;

		// Token: 0x0400C352 RID: 50002
		[Token(Token = "0x400C352")]
		[FieldOffset(Offset = "0x168")]
		public GameObject MonUnSelect;

		// Token: 0x0400C353 RID: 50003
		[Token(Token = "0x400C353")]
		[FieldOffset(Offset = "0x170")]
		public GameObject TueSelect;

		// Token: 0x0400C354 RID: 50004
		[Token(Token = "0x400C354")]
		[FieldOffset(Offset = "0x178")]
		public GameObject TueUnSelect;

		// Token: 0x0400C355 RID: 50005
		[Token(Token = "0x400C355")]
		[FieldOffset(Offset = "0x180")]
		public GameObject WedSelect;

		// Token: 0x0400C356 RID: 50006
		[Token(Token = "0x400C356")]
		[FieldOffset(Offset = "0x188")]
		public GameObject WedUnSelect;

		// Token: 0x0400C357 RID: 50007
		[Token(Token = "0x400C357")]
		[FieldOffset(Offset = "0x190")]
		public GameObject ThuSelect;

		// Token: 0x0400C358 RID: 50008
		[Token(Token = "0x400C358")]
		[FieldOffset(Offset = "0x198")]
		public GameObject ThuUnSelect;

		// Token: 0x0400C359 RID: 50009
		[Token(Token = "0x400C359")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject FriSelect;

		// Token: 0x0400C35A RID: 50010
		[Token(Token = "0x400C35A")]
		[FieldOffset(Offset = "0x1A8")]
		public GameObject FriUnSelect;

		// Token: 0x0400C35B RID: 50011
		[Token(Token = "0x400C35B")]
		[FieldOffset(Offset = "0x1B0")]
		public GameObject SatSelect;

		// Token: 0x0400C35C RID: 50012
		[Token(Token = "0x400C35C")]
		[FieldOffset(Offset = "0x1B8")]
		public GameObject SatUnSelect;

		// Token: 0x0400C35D RID: 50013
		[Token(Token = "0x400C35D")]
		[FieldOffset(Offset = "0x1C0")]
		public GameObject SunSelect;

		// Token: 0x0400C35E RID: 50014
		[Token(Token = "0x400C35E")]
		[FieldOffset(Offset = "0x1C8")]
		public GameObject SunUnSelect;
	}
}
