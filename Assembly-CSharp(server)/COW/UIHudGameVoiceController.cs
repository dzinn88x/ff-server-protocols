using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020018CC RID: 6348
	[Token(Token = "0x20018CC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F4DDC", Offset = "0x10F4DDC")]
	public class UIHudGameVoiceController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06007E6B RID: 32363 RVA: 0x00022908 File Offset: 0x00020B08
		[Token(Token = "0x6007E6B")]
		[Address(RVA = "0x1C1491C", Offset = "0x1C1491C", VA = "0x7BBC41491C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007E6C RID: 32364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E6C")]
		[Address(RVA = "0x1C1496C", Offset = "0x1C1496C", VA = "0x7BBC41496C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007E6D RID: 32365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E6D")]
		[Address(RVA = "0x1C1521C", Offset = "0x1C1521C", VA = "0x7BBC41521C", Slot = "17")]
		protected override void OnUIDestroy()
		{
		}

		// Token: 0x06007E6E RID: 32366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E6E")]
		[Address(RVA = "0x1C153FC", Offset = "0x1C153FC", VA = "0x7BBC4153FC")]
		private void OnVoicePanelMaskClick()
		{
		}

		// Token: 0x06007E6F RID: 32367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E6F")]
		[Address(RVA = "0x1C1547C", Offset = "0x1C1547C", VA = "0x7BBC41547C")]
		private void ShowTurnOnMicTutorial(params object[] data)
		{
		}

		// Token: 0x06007E70 RID: 32368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E70")]
		[Address(RVA = "0x1C1553C", Offset = "0x1C1553C", VA = "0x7BBC41553C")]
		private void OnSpeakerMuteToggleClicked()
		{
		}

		// Token: 0x06007E71 RID: 32369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E71")]
		[Address(RVA = "0x1C1568C", Offset = "0x1C1568C", VA = "0x7BBC41568C")]
		private void OnSpeakerMuteAllBtnClicked()
		{
		}

		// Token: 0x06007E72 RID: 32370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E72")]
		[Address(RVA = "0x1C15874", Offset = "0x1C15874", VA = "0x7BBC415874")]
		private void OnMicroPhoneMuteToggleChange()
		{
		}

		// Token: 0x06007E73 RID: 32371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E73")]
		[Address(RVA = "0x1C14EE4", Offset = "0x1C14EE4", VA = "0x7BBC414EE4")]
		private void RefreshToggleView()
		{
		}

		// Token: 0x06007E74 RID: 32372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E74")]
		[Address(RVA = "0x1C15C90", Offset = "0x1C15C90", VA = "0x7BBC415C90")]
		private void OnJoinedRoom(params object[] data)
		{
		}

		// Token: 0x06007E75 RID: 32373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E75")]
		[Address(RVA = "0x1C15D08", Offset = "0x1C15D08", VA = "0x7BBC415D08")]
		private void OnLeavedRoom(params object[] data)
		{
		}

		// Token: 0x06007E76 RID: 32374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E76")]
		[Address(RVA = "0x1C15E8C", Offset = "0x1C15E8C", VA = "0x7BBC415E8C")]
		private void RefreshVoiceViewPanel()
		{
		}

		// Token: 0x06007E77 RID: 32375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E77")]
		[Address(RVA = "0x1C16628", Offset = "0x1C16628", VA = "0x7BBC416628", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007E78 RID: 32376 RVA: 0x00022920 File Offset: 0x00020B20
		[Token(Token = "0x6007E78")]
		[Address(RVA = "0x1C16898", Offset = "0x1C16898", VA = "0x7BBC416898", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007E79 RID: 32377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007E79")]
		[Address(RVA = "0x1C168DC", Offset = "0x1C168DC", VA = "0x7BBC4168DC")]
		public UIHudGameVoiceController()
		{
		}

		// Token: 0x040091C7 RID: 37319
		[Token(Token = "0x40091C7")]
		[FieldOffset(Offset = "0x58")]
		private UIHudGameVoiceView m_View;

		// Token: 0x040091C8 RID: 37320
		[Token(Token = "0x40091C8")]
		[FieldOffset(Offset = "0x60")]
		private HashSet<{QAb\u0082~u> m_TeammateIDList;

		// Token: 0x040091C9 RID: 37321
		[Token(Token = "0x40091C9")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<int, TeammateVoiceView> m_TeammatesVoiceViewMap;
	}
}
