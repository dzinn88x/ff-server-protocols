using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200218E RID: 8590
	[Token(Token = "0x200218E")]
	public class UICreateRoomView : UIBaseView
	{
		// Token: 0x0600BE2C RID: 48684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE2C")]
		[Address(RVA = "0x1BA35B0", Offset = "0x1BA35B0", VA = "0x7BBC3A35B0", Slot = "4")]
		protected override void OnInit(Transform holder)
		{
		}

		// Token: 0x0600BE2D RID: 48685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BE2D")]
		[Address(RVA = "0x1BA4554", Offset = "0x1BA4554", VA = "0x7BBC3A4554")]
		public UICreateRoomView()
		{
		}

		// Token: 0x0400C7FD RID: 51197
		[Token(Token = "0x400C7FD")]
		[FieldOffset(Offset = "0x20")]
		public UILabel Title;

		// Token: 0x0400C7FE RID: 51198
		[Token(Token = "0x400C7FE")]
		[FieldOffset(Offset = "0x28")]
		public GameObject RoomTypeBtns;

		// Token: 0x0400C7FF RID: 51199
		[Token(Token = "0x400C7FF")]
		[FieldOffset(Offset = "0x30")]
		public GameObject LeagueNormalRoomTab;

		// Token: 0x0400C800 RID: 51200
		[Token(Token = "0x400C800")]
		[FieldOffset(Offset = "0x38")]
		public UIToggleButton LeagueNormalToggleBtn;

		// Token: 0x0400C801 RID: 51201
		[Token(Token = "0x400C801")]
		[FieldOffset(Offset = "0x40")]
		public GameObject CasualRoomTab;

		// Token: 0x0400C802 RID: 51202
		[Token(Token = "0x400C802")]
		[FieldOffset(Offset = "0x48")]
		public UIToggleButton CasualToggleBtn;

		// Token: 0x0400C803 RID: 51203
		[Token(Token = "0x400C803")]
		[FieldOffset(Offset = "0x50")]
		public GameObject BatchRoomTab;

		// Token: 0x0400C804 RID: 51204
		[Token(Token = "0x400C804")]
		[FieldOffset(Offset = "0x58")]
		public UIToggleButton BatchToggleBtn;

		// Token: 0x0400C805 RID: 51205
		[Token(Token = "0x400C805")]
		[FieldOffset(Offset = "0x60")]
		public GameObject TabBg;

		// Token: 0x0400C806 RID: 51206
		[Token(Token = "0x400C806")]
		[FieldOffset(Offset = "0x68")]
		public GameObject RoomGameSettingBtnGo;

		// Token: 0x0400C807 RID: 51207
		[Token(Token = "0x400C807")]
		[FieldOffset(Offset = "0x70")]
		public UIButton close;

		// Token: 0x0400C808 RID: 51208
		[Token(Token = "0x400C808")]
		[FieldOffset(Offset = "0x78")]
		public GameObject InfoPanel;

		// Token: 0x0400C809 RID: 51209
		[Token(Token = "0x400C809")]
		[FieldOffset(Offset = "0x80")]
		public GameObject RoomSettingPanel;

		// Token: 0x0400C80A RID: 51210
		[Token(Token = "0x400C80A")]
		[FieldOffset(Offset = "0x88")]
		public UIGrid MapGrid;

		// Token: 0x0400C80B RID: 51211
		[Token(Token = "0x400C80B")]
		[FieldOffset(Offset = "0x90")]
		public UIToggleButtonGroup MapToggleGroup;

		// Token: 0x0400C80C RID: 51212
		[Token(Token = "0x400C80C")]
		[FieldOffset(Offset = "0x98")]
		public UICreateRoomMapItem MapItemObj;

		// Token: 0x0400C80D RID: 51213
		[Token(Token = "0x400C80D")]
		[FieldOffset(Offset = "0xA0")]
		public UIWidget GameModePopMenu;

		// Token: 0x0400C80E RID: 51214
		[Token(Token = "0x400C80E")]
		[FieldOffset(Offset = "0xA8")]
		public UIInput NameInput;

		// Token: 0x0400C80F RID: 51215
		[Token(Token = "0x400C80F")]
		[FieldOffset(Offset = "0xB0")]
		public UIInput CodeInput;

		// Token: 0x0400C810 RID: 51216
		[Token(Token = "0x400C810")]
		[FieldOffset(Offset = "0xB8")]
		public UIToggleButton SoloToggle;

		// Token: 0x0400C811 RID: 51217
		[Token(Token = "0x400C811")]
		[FieldOffset(Offset = "0xC0")]
		public UISprite SoloLabelCheckmark;

		// Token: 0x0400C812 RID: 51218
		[Token(Token = "0x400C812")]
		[FieldOffset(Offset = "0xC8")]
		public UILabel SoloLabel;

		// Token: 0x0400C813 RID: 51219
		[Token(Token = "0x400C813")]
		[FieldOffset(Offset = "0xD0")]
		public UIToggleButton DuoToggle;

		// Token: 0x0400C814 RID: 51220
		[Token(Token = "0x400C814")]
		[FieldOffset(Offset = "0xD8")]
		public UISprite DuoCheckmark;

		// Token: 0x0400C815 RID: 51221
		[Token(Token = "0x400C815")]
		[FieldOffset(Offset = "0xE0")]
		public UILabel DuoLabel;

		// Token: 0x0400C816 RID: 51222
		[Token(Token = "0x400C816")]
		[FieldOffset(Offset = "0xE8")]
		public UIToggleButton QuadToggle;

		// Token: 0x0400C817 RID: 51223
		[Token(Token = "0x400C817")]
		[FieldOffset(Offset = "0xF0")]
		public UISprite QuadCheckmark;

		// Token: 0x0400C818 RID: 51224
		[Token(Token = "0x400C818")]
		[FieldOffset(Offset = "0xF8")]
		public UILabel QuadLabel;

		// Token: 0x0400C819 RID: 51225
		[Token(Token = "0x400C819")]
		[FieldOffset(Offset = "0x100")]
		public UIWidget DropModePopMenu;

		// Token: 0x0400C81A RID: 51226
		[Token(Token = "0x400C81A")]
		[FieldOffset(Offset = "0x108")]
		public UIGrid RoomSettingDropListGrid;

		// Token: 0x0400C81B RID: 51227
		[Token(Token = "0x400C81B")]
		[FieldOffset(Offset = "0x110")]
		public GameObject MembersGo;

		// Token: 0x0400C81C RID: 51228
		[Token(Token = "0x400C81C")]
		[FieldOffset(Offset = "0x118")]
		public GameObject SpectatorsGo;

		// Token: 0x0400C81D RID: 51229
		[Token(Token = "0x400C81D")]
		[FieldOffset(Offset = "0x120")]
		public GameObject GameSettingPanel;

		// Token: 0x0400C81E RID: 51230
		[Token(Token = "0x400C81E")]
		[FieldOffset(Offset = "0x128")]
		public UITable InfoTable;

		// Token: 0x0400C81F RID: 51231
		[Token(Token = "0x400C81F")]
		[FieldOffset(Offset = "0x130")]
		public GameObject GameSettingCSModeGo;

		// Token: 0x0400C820 RID: 51232
		[Token(Token = "0x400C820")]
		[FieldOffset(Offset = "0x138")]
		public GameObject CSTotalRoundGo;

		// Token: 0x0400C821 RID: 51233
		[Token(Token = "0x400C821")]
		[FieldOffset(Offset = "0x140")]
		public GameObject CSInitCoinGo;

		// Token: 0x0400C822 RID: 51234
		[Token(Token = "0x400C822")]
		[FieldOffset(Offset = "0x148")]
		public UIGrid GameSettingDropListGrid;

		// Token: 0x0400C823 RID: 51235
		[Token(Token = "0x400C823")]
		[FieldOffset(Offset = "0x150")]
		public GameObject HPGo;

		// Token: 0x0400C824 RID: 51236
		[Token(Token = "0x400C824")]
		[FieldOffset(Offset = "0x158")]
		public GameObject EPGo;

		// Token: 0x0400C825 RID: 51237
		[Token(Token = "0x400C825")]
		[FieldOffset(Offset = "0x160")]
		public GameObject SpeedGo;

		// Token: 0x0400C826 RID: 51238
		[Token(Token = "0x400C826")]
		[FieldOffset(Offset = "0x168")]
		public GameObject JumpHeightGo;

		// Token: 0x0400C827 RID: 51239
		[Token(Token = "0x400C827")]
		[FieldOffset(Offset = "0x170")]
		public UIGrid GameSettingToggleGrid;

		// Token: 0x0400C828 RID: 51240
		[Token(Token = "0x400C828")]
		[FieldOffset(Offset = "0x178")]
		public GameObject WeatherTypeGo;

		// Token: 0x0400C829 RID: 51241
		[Token(Token = "0x400C829")]
		[FieldOffset(Offset = "0x180")]
		public GameObject UnlimitedAmmoGo;

		// Token: 0x0400C82A RID: 51242
		[Token(Token = "0x400C82A")]
		[FieldOffset(Offset = "0x188")]
		public GameObject NoFallingDamageGo;

		// Token: 0x0400C82B RID: 51243
		[Token(Token = "0x400C82B")]
		[FieldOffset(Offset = "0x190")]
		public GameObject NoLoadoutGo;

		// Token: 0x0400C82C RID: 51244
		[Token(Token = "0x400C82C")]
		[FieldOffset(Offset = "0x198")]
		public GameObject NoAirdropGo;

		// Token: 0x0400C82D RID: 51245
		[Token(Token = "0x400C82D")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject NoSkillGo;

		// Token: 0x0400C82E RID: 51246
		[Token(Token = "0x400C82E")]
		[FieldOffset(Offset = "0x1A8")]
		public GameObject NoVehicleGo;

		// Token: 0x0400C82F RID: 51247
		[Token(Token = "0x400C82F")]
		[FieldOffset(Offset = "0x1B0")]
		public GameObject PowerGunGo;

		// Token: 0x0400C830 RID: 51248
		[Token(Token = "0x400C830")]
		[FieldOffset(Offset = "0x1B8")]
		public GameObject NoUAVGo;

		// Token: 0x0400C831 RID: 51249
		[Token(Token = "0x400C831")]
		[FieldOffset(Offset = "0x1C0")]
		public GameObject NoBombGo;

		// Token: 0x0400C832 RID: 51250
		[Token(Token = "0x400C832")]
		[FieldOffset(Offset = "0x1C8")]
		public GameObject NoZeppelinGo;

		// Token: 0x0400C833 RID: 51251
		[Token(Token = "0x400C833")]
		[FieldOffset(Offset = "0x1D0")]
		public GameObject HideEnemyClothGo;

		// Token: 0x0400C834 RID: 51252
		[Token(Token = "0x400C834")]
		[FieldOffset(Offset = "0x1D8")]
		public GameObject OBSettingPanel;

		// Token: 0x0400C835 RID: 51253
		[Token(Token = "0x400C835")]
		[FieldOffset(Offset = "0x1E0")]
		public UIGrid OBSettingToggleGrid;

		// Token: 0x0400C836 RID: 51254
		[Token(Token = "0x400C836")]
		[FieldOffset(Offset = "0x1E8")]
		public GameObject OBEnabledGo;

		// Token: 0x0400C837 RID: 51255
		[Token(Token = "0x400C837")]
		[FieldOffset(Offset = "0x1F0")]
		public GameObject AccDataGo;

		// Token: 0x0400C838 RID: 51256
		[Token(Token = "0x400C838")]
		[FieldOffset(Offset = "0x1F8")]
		public GameObject HideKillInfoGo;

		// Token: 0x0400C839 RID: 51257
		[Token(Token = "0x400C839")]
		[FieldOffset(Offset = "0x200")]
		public GameObject ReplayEnabledGo;

		// Token: 0x0400C83A RID: 51258
		[Token(Token = "0x400C83A")]
		[FieldOffset(Offset = "0x208")]
		public GameObject Emulator;

		// Token: 0x0400C83B RID: 51259
		[Token(Token = "0x400C83B")]
		[FieldOffset(Offset = "0x210")]
		public GameObject EnableRoleCheck;

		// Token: 0x0400C83C RID: 51260
		[Token(Token = "0x400C83C")]
		[FieldOffset(Offset = "0x218")]
		public GameObject CSAdSettingPanel;

		// Token: 0x0400C83D RID: 51261
		[Token(Token = "0x400C83D")]
		[FieldOffset(Offset = "0x220")]
		public UIGrid BtnGrid;

		// Token: 0x0400C83E RID: 51262
		[Token(Token = "0x400C83E")]
		[FieldOffset(Offset = "0x228")]
		public UIButton CancelBtn;

		// Token: 0x0400C83F RID: 51263
		[Token(Token = "0x400C83F")]
		[FieldOffset(Offset = "0x230")]
		public UIButton ConfirmBtn;

		// Token: 0x0400C840 RID: 51264
		[Token(Token = "0x400C840")]
		[FieldOffset(Offset = "0x238")]
		public UIButton ReOpenBtn;

		// Token: 0x0400C841 RID: 51265
		[Token(Token = "0x400C841")]
		[FieldOffset(Offset = "0x240")]
		public GameObject RoomCardGo;
	}
}
