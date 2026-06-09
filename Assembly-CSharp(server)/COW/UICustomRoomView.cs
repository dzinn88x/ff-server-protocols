using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02002192 RID: 8594
	[Token(Token = "0x2002192")]
	public class UICustomRoomView : UIBaseView
	{
		// Token: 0x0600BE34 RID: 48692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE34")]
		[Address(RVA = "0x1BAB13C", Offset = "0x1BAB13C", VA = "0x7BBC3AB13C", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE35 RID: 48693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE35")]
		[Address(RVA = "0x1BAC04C", Offset = "0x1BAC04C", VA = "0x7BBC3AC04C")]
		public UICustomRoomView()
		{
		}

		// Token: 0x0400C84D RID: 51277
		[Token(Token = "0x400C84D")]
		[FieldOffset(Offset = "0x20")]
		public UIWidget LeftContainer;

		// Token: 0x0400C84E RID: 51278
		[Token(Token = "0x400C84E")]
		[FieldOffset(Offset = "0x28")]
		public UILabel RoomId;

		// Token: 0x0400C84F RID: 51279
		[Token(Token = "0x400C84F")]
		[FieldOffset(Offset = "0x30")]
		public UIGrid Flags;

		// Token: 0x0400C850 RID: 51280
		[Token(Token = "0x400C850")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Lock;

		// Token: 0x0400C851 RID: 51281
		[Token(Token = "0x400C851")]
		[FieldOffset(Offset = "0x40")]
		public GameObject Emulator;

		// Token: 0x0400C852 RID: 51282
		[Token(Token = "0x400C852")]
		[FieldOffset(Offset = "0x48")]
		public UISprite Map;

		// Token: 0x0400C853 RID: 51283
		[Token(Token = "0x400C853")]
		[FieldOffset(Offset = "0x50")]
		public UISprite weatherBg;

		// Token: 0x0400C854 RID: 51284
		[Token(Token = "0x400C854")]
		[FieldOffset(Offset = "0x58")]
		public UISprite WeatherIcon;

		// Token: 0x0400C855 RID: 51285
		[Token(Token = "0x400C855")]
		[FieldOffset(Offset = "0x60")]
		public UILabel MapName;

		// Token: 0x0400C856 RID: 51286
		[Token(Token = "0x400C856")]
		[FieldOffset(Offset = "0x68")]
		public UILabel RoomMode;

		// Token: 0x0400C857 RID: 51287
		[Token(Token = "0x400C857")]
		[FieldOffset(Offset = "0x70")]
		public UILabel roomType;

		// Token: 0x0400C858 RID: 51288
		[Token(Token = "0x400C858")]
		[FieldOffset(Offset = "0x78")]
		public UILabel Mode;

		// Token: 0x0400C859 RID: 51289
		[Token(Token = "0x400C859")]
		[FieldOffset(Offset = "0x80")]
		public UIButton CustomizeBtn;

		// Token: 0x0400C85A RID: 51290
		[Token(Token = "0x400C85A")]
		[FieldOffset(Offset = "0x88")]
		public UILabel CustomizeTxt;

		// Token: 0x0400C85B RID: 51291
		[Token(Token = "0x400C85B")]
		[FieldOffset(Offset = "0x90")]
		public UIButton BtnShare;

		// Token: 0x0400C85C RID: 51292
		[Token(Token = "0x400C85C")]
		[FieldOffset(Offset = "0x98")]
		public UILabel DropTxt;

		// Token: 0x0400C85D RID: 51293
		[Token(Token = "0x400C85D")]
		[FieldOffset(Offset = "0xA0")]
		public UIScrollView roomSettingtScrollView;

		// Token: 0x0400C85E RID: 51294
		[Token(Token = "0x400C85E")]
		[FieldOffset(Offset = "0xA8")]
		public UIGrid SettingGrid;

		// Token: 0x0400C85F RID: 51295
		[Token(Token = "0x400C85F")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject roundnumlbl;

		// Token: 0x0400C860 RID: 51296
		[Token(Token = "0x400C860")]
		[FieldOffset(Offset = "0xB8")]
		public UILabel RoundNumTxt;

		// Token: 0x0400C861 RID: 51297
		[Token(Token = "0x400C861")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject initcoinlbl;

		// Token: 0x0400C862 RID: 51298
		[Token(Token = "0x400C862")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel InitCoinTxt;

		// Token: 0x0400C863 RID: 51299
		[Token(Token = "0x400C863")]
		[FieldOffset(Offset = "0xD0")]
		public UILabel HpTxt;

		// Token: 0x0400C864 RID: 51300
		[Token(Token = "0x400C864")]
		[FieldOffset(Offset = "0xD8")]
		public UILabel EpTxt;

		// Token: 0x0400C865 RID: 51301
		[Token(Token = "0x400C865")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel SkillTxt;

		// Token: 0x0400C866 RID: 51302
		[Token(Token = "0x400C866")]
		[FieldOffset(Offset = "0xE8")]
		public UILabel FallingDamageTxt;

		// Token: 0x0400C867 RID: 51303
		[Token(Token = "0x400C867")]
		[FieldOffset(Offset = "0xF0")]
		public UILabel NoloadoutTxt;

		// Token: 0x0400C868 RID: 51304
		[Token(Token = "0x400C868")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel UnlimitedAmmoTxt;

		// Token: 0x0400C869 RID: 51305
		[Token(Token = "0x400C869")]
		[FieldOffset(Offset = "0x100")]
		public UILabel NoAirdropTxt;

		// Token: 0x0400C86A RID: 51306
		[Token(Token = "0x400C86A")]
		[FieldOffset(Offset = "0x108")]
		public UILabel SpeedTxt;

		// Token: 0x0400C86B RID: 51307
		[Token(Token = "0x400C86B")]
		[FieldOffset(Offset = "0x110")]
		public UILabel JumpHeightTxt;

		// Token: 0x0400C86C RID: 51308
		[Token(Token = "0x400C86C")]
		[FieldOffset(Offset = "0x118")]
		public UILabel NoVehicleTxt;

		// Token: 0x0400C86D RID: 51309
		[Token(Token = "0x400C86D")]
		[FieldOffset(Offset = "0x120")]
		public UILabel NoUAVTxt;

		// Token: 0x0400C86E RID: 51310
		[Token(Token = "0x400C86E")]
		[FieldOffset(Offset = "0x128")]
		public UILabel NoBombTxt;

		// Token: 0x0400C86F RID: 51311
		[Token(Token = "0x400C86F")]
		[FieldOffset(Offset = "0x130")]
		public GameObject InvitationGO;

		// Token: 0x0400C870 RID: 51312
		[Token(Token = "0x400C870")]
		[FieldOffset(Offset = "0x138")]
		public UIWidget RightContainer;

		// Token: 0x0400C871 RID: 51313
		[Token(Token = "0x400C871")]
		[FieldOffset(Offset = "0x140")]
		public UILabel RoomName;

		// Token: 0x0400C872 RID: 51314
		[Token(Token = "0x400C872")]
		[FieldOffset(Offset = "0x148")]
		public GameObject Effect_Glow;

		// Token: 0x0400C873 RID: 51315
		[Token(Token = "0x400C873")]
		[FieldOffset(Offset = "0x150")]
		public UILabel RoomStatus;

		// Token: 0x0400C874 RID: 51316
		[Token(Token = "0x400C874")]
		[FieldOffset(Offset = "0x158")]
		public UIButton ToggleDisplayTypeBtn;

		// Token: 0x0400C875 RID: 51317
		[Token(Token = "0x400C875")]
		[FieldOffset(Offset = "0x160")]
		public UILabel DisplayTypeLabel;

		// Token: 0x0400C876 RID: 51318
		[Token(Token = "0x400C876")]
		[FieldOffset(Offset = "0x168")]
		public UIButton InviteBtn;

		// Token: 0x0400C877 RID: 51319
		[Token(Token = "0x400C877")]
		[FieldOffset(Offset = "0x170")]
		public UIButton ClearBtn;

		// Token: 0x0400C878 RID: 51320
		[Token(Token = "0x400C878")]
		[FieldOffset(Offset = "0x178")]
		public UIButton SearchBtn;

		// Token: 0x0400C879 RID: 51321
		[Token(Token = "0x400C879")]
		[FieldOffset(Offset = "0x180")]
		public UISprite SearchBtnSprite;

		// Token: 0x0400C87A RID: 51322
		[Token(Token = "0x400C87A")]
		[FieldOffset(Offset = "0x188")]
		public UIInput SearchInput;

		// Token: 0x0400C87B RID: 51323
		[Token(Token = "0x400C87B")]
		[FieldOffset(Offset = "0x190")]
		public UIButton Start;

		// Token: 0x0400C87C RID: 51324
		[Token(Token = "0x400C87C")]
		[FieldOffset(Offset = "0x198")]
		public UICountDownLabel CountDownTxt;

		// Token: 0x0400C87D RID: 51325
		[Token(Token = "0x400C87D")]
		[FieldOffset(Offset = "0x1A0")]
		public UIButton Ready;

		// Token: 0x0400C87E RID: 51326
		[Token(Token = "0x400C87E")]
		[FieldOffset(Offset = "0x1A8")]
		public UILabel ReadyLabel;

		// Token: 0x0400C87F RID: 51327
		[Token(Token = "0x400C87F")]
		[FieldOffset(Offset = "0x1B0")]
		public GameObject Waiting;

		// Token: 0x0400C880 RID: 51328
		[Token(Token = "0x400C880")]
		[FieldOffset(Offset = "0x1B8")]
		public UILabel WatingLabel;

		// Token: 0x0400C881 RID: 51329
		[Token(Token = "0x400C881")]
		[FieldOffset(Offset = "0x1C0")]
		public GameObject RoomCardTips;

		// Token: 0x0400C882 RID: 51330
		[Token(Token = "0x400C882")]
		[FieldOffset(Offset = "0x1C8")]
		public GameObject RoomCardGo;

		// Token: 0x0400C883 RID: 51331
		[Token(Token = "0x400C883")]
		[FieldOffset(Offset = "0x1D0")]
		public UIButton RoomCardBtn;

		// Token: 0x0400C884 RID: 51332
		[Token(Token = "0x400C884")]
		[FieldOffset(Offset = "0x1D8")]
		public GameObject LoadoutGo;

		// Token: 0x0400C885 RID: 51333
		[Token(Token = "0x400C885")]
		[FieldOffset(Offset = "0x1E0")]
		public GameObject ObserverListGo;

		// Token: 0x0400C886 RID: 51334
		[Token(Token = "0x400C886")]
		[FieldOffset(Offset = "0x1E8")]
		public UIScrollView ObserverListScrollView;

		// Token: 0x0400C887 RID: 51335
		[Token(Token = "0x400C887")]
		[FieldOffset(Offset = "0x1F0")]
		public UIGrid ObserverListGrid;

		// Token: 0x0400C888 RID: 51336
		[Token(Token = "0x400C888")]
		[FieldOffset(Offset = "0x1F8")]
		public UIButton OBHideBtn;

		// Token: 0x0400C889 RID: 51337
		[Token(Token = "0x400C889")]
		[FieldOffset(Offset = "0x200")]
		public UIButton OBShowBtn;

		// Token: 0x0400C88A RID: 51338
		[Token(Token = "0x400C88A")]
		[FieldOffset(Offset = "0x208")]
		public UILabel OBTitle;

		// Token: 0x0400C88B RID: 51339
		[Token(Token = "0x400C88B")]
		[FieldOffset(Offset = "0x210")]
		public UILabel OBCount;

		// Token: 0x0400C88C RID: 51340
		[Token(Token = "0x400C88C")]
		[FieldOffset(Offset = "0x218")]
		public UIScrollView PlayerListScrollView;

		// Token: 0x0400C88D RID: 51341
		[Token(Token = "0x400C88D")]
		[FieldOffset(Offset = "0x220")]
		public UIEasyList PlayerListGrid;

		// Token: 0x0400C88E RID: 51342
		[Token(Token = "0x400C88E")]
		[FieldOffset(Offset = "0x228")]
		public UIButton BackBtn;
	}
}
