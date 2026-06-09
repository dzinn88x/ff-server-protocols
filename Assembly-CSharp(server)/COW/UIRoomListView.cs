using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x020024E1 RID: 9441
	[Token(Token = "0x20024E1")]
	public class UIRoomListView : UIBaseView
	{
		// Token: 0x0600C4D2 RID: 50386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4D2")]
		[Address(RVA = "0x1A1AD88", Offset = "0x1A1AD88", VA = "0x7BBC21AD88", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600C4D3 RID: 50387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4D3")]
		[Address(RVA = "0x1A1B430", Offset = "0x1A1B430", VA = "0x7BBC21B430")]
		public UIRoomListView()
		{
		}

		// Token: 0x0400F012 RID: 61458
		[Token(Token = "0x400F012")]
		[FieldOffset(Offset = "0x20")]
		public UILabel MemberNum;

		// Token: 0x0400F013 RID: 61459
		[Token(Token = "0x400F013")]
		[FieldOffset(Offset = "0x28")]
		public UIButton SelectModeBtn;

		// Token: 0x0400F014 RID: 61460
		[Token(Token = "0x400F014")]
		[FieldOffset(Offset = "0x30")]
		public UIButton TipIcon;

		// Token: 0x0400F015 RID: 61461
		[Token(Token = "0x400F015")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Content;

		// Token: 0x0400F016 RID: 61462
		[Token(Token = "0x400F016")]
		[FieldOffset(Offset = "0x40")]
		public UIScrollView ListScrollView;

		// Token: 0x0400F017 RID: 61463
		[Token(Token = "0x400F017")]
		[FieldOffset(Offset = "0x48")]
		public UIEasyList ListGrid;

		// Token: 0x0400F018 RID: 61464
		[Token(Token = "0x400F018")]
		[FieldOffset(Offset = "0x50")]
		public UILabel Result;

		// Token: 0x0400F019 RID: 61465
		[Token(Token = "0x400F019")]
		[FieldOffset(Offset = "0x58")]
		public GameObject Arrow;

		// Token: 0x0400F01A RID: 61466
		[Token(Token = "0x400F01A")]
		[FieldOffset(Offset = "0x60")]
		public GameObject SearchBarContainer;

		// Token: 0x0400F01B RID: 61467
		[Token(Token = "0x400F01B")]
		[FieldOffset(Offset = "0x68")]
		public UIButton RefreshBtn;

		// Token: 0x0400F01C RID: 61468
		[Token(Token = "0x400F01C")]
		[FieldOffset(Offset = "0x70")]
		public GameObject SpriteRefresh;

		// Token: 0x0400F01D RID: 61469
		[Token(Token = "0x400F01D")]
		[FieldOffset(Offset = "0x78")]
		public UILabel RefreshTxt;

		// Token: 0x0400F01E RID: 61470
		[Token(Token = "0x400F01E")]
		[FieldOffset(Offset = "0x80")]
		public UICountDownLabel CountDownTxt;

		// Token: 0x0400F01F RID: 61471
		[Token(Token = "0x400F01F")]
		[FieldOffset(Offset = "0x88")]
		public UIInput SearchInput;

		// Token: 0x0400F020 RID: 61472
		[Token(Token = "0x400F020")]
		[FieldOffset(Offset = "0x90")]
		public UIButton SearchBtn;

		// Token: 0x0400F021 RID: 61473
		[Token(Token = "0x400F021")]
		[FieldOffset(Offset = "0x98")]
		public UISprite SearchBtnSprite;

		// Token: 0x0400F022 RID: 61474
		[Token(Token = "0x400F022")]
		[FieldOffset(Offset = "0xA0")]
		public UIButton ClearBtn;

		// Token: 0x0400F023 RID: 61475
		[Token(Token = "0x400F023")]
		[FieldOffset(Offset = "0xA8")]
		public UIButton RoomCreate;

		// Token: 0x0400F024 RID: 61476
		[Token(Token = "0x400F024")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject RoomCardGo;

		// Token: 0x0400F025 RID: 61477
		[Token(Token = "0x400F025")]
		[FieldOffset(Offset = "0xB8")]
		public UITable RoomTypeTabTable;

		// Token: 0x0400F026 RID: 61478
		[Token(Token = "0x400F026")]
		[FieldOffset(Offset = "0xC0")]
		public UIToggleButton BtnCasualRoom;

		// Token: 0x0400F027 RID: 61479
		[Token(Token = "0x400F027")]
		[FieldOffset(Offset = "0xC8")]
		public UIToggleButton BtnLeagueRoom;

		// Token: 0x0400F028 RID: 61480
		[Token(Token = "0x400F028")]
		[FieldOffset(Offset = "0xD0")]
		public UIToggleButton BtnMyRoom;

		// Token: 0x0400F029 RID: 61481
		[Token(Token = "0x400F029")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel MyRoomCnt;

		// Token: 0x0400F02A RID: 61482
		[Token(Token = "0x400F02A")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel MyRoomUnselectLbl;

		// Token: 0x0400F02B RID: 61483
		[Token(Token = "0x400F02B")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel MyRoomSelectLbl;

		// Token: 0x0400F02C RID: 61484
		[Token(Token = "0x400F02C")]
		[FieldOffset(Offset = "0xF0")]
		public UIToggleButton BtnWereWolvesRoom;
	}
}
