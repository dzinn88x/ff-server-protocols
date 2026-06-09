using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001546 RID: 5446
	[Token(Token = "0x2001546")]
	public class UILinkActivityEntryController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06005E1E RID: 24094 RVA: 0x0001B498 File Offset: 0x00019698
		[Token(Token = "0x6005E1E")]
		[Address(RVA = "0x1CBB5E8", Offset = "0x1CBB5E8", VA = "0x7BBC4BB5E8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005E1F RID: 24095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E1F")]
		[Address(RVA = "0x1CBB638", Offset = "0x1CBB638", VA = "0x7BBC4BB638", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005E20 RID: 24096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E20")]
		[Address(RVA = "0x1CBBB50", Offset = "0x1CBBB50", VA = "0x7BBC4BBB50", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x0001B4B0 File Offset: 0x000196B0
		[Token(Token = "0x6005E21")]
		[Address(RVA = "0x1CBBC3C", Offset = "0x1CBBC3C", VA = "0x7BBC4BBC3C", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005E22 RID: 24098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E22")]
		[Address(RVA = "0x1CBBC44", Offset = "0x1CBBC44", VA = "0x7BBC4BBC44", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005E23 RID: 24099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E23")]
		[Address(RVA = "0x1CBBA1C", Offset = "0x1CBBA1C", VA = "0x7BBC4BBA1C")]
		private void UpdateBtnState()
		{
		}

		// Token: 0x06005E24 RID: 24100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E24")]
		[Address(RVA = "0x1CBBC54", Offset = "0x1CBBC54", VA = "0x7BBC4BBC54")]
		private void OnClick()
		{
		}

		// Token: 0x06005E25 RID: 24101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E25")]
		[Address(RVA = "0x1CBC044", Offset = "0x1CBC044", VA = "0x7BBC4BC044")]
		private void OnGameModeViewShowHide(params object[] data)
		{
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E26")]
		[Address(RVA = "0x1CBBDFC", Offset = "0x1CBBDFC", VA = "0x7BBC4BBDFC")]
		private void OnClickPVELink()
		{
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E27")]
		[Address(RVA = "0x1CBC134", Offset = "0x1CBC134", VA = "0x7BBC4BC134")]
		private void OnPVELinkPageSwitch()
		{
		}

		// Token: 0x06005E28 RID: 24104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E28")]
		[Address(RVA = "0x1CBC1D8", Offset = "0x1CBC1D8", VA = "0x7BBC4BC1D8")]
		public UILinkActivityEntryController()
		{
		}

		// Token: 0x04007F8E RID: 32654
		[Token(Token = "0x4007F8E")]
		[FieldOffset(Offset = "0x58")]
		private UILinkActivityEntryView m_View;

		// Token: 0x04007F8F RID: 32655
		[Token(Token = "0x4007F8F")]
		[FieldOffset(Offset = "0x60")]
		private UIModelLinkActivity m_Model;

		// Token: 0x04007F90 RID: 32656
		[Token(Token = "0x4007F90")]
		[FieldOffset(Offset = "0x68")]
		private UILinkActivityDetailController m_Window;
	}
}
