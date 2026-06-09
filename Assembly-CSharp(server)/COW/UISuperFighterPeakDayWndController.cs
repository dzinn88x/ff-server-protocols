using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020013D4 RID: 5076
	[Token(Token = "0x20013D4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC000", Offset = "0x10EC000")]
	public class UISuperFighterPeakDayWndController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x0600532E RID: 21294 RVA: 0x00018DE0 File Offset: 0x00016FE0
		[Token(Token = "0x600532E")]
		[Address(RVA = "0x1F4E030", Offset = "0x1F4E030", VA = "0x7BBC74E030")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600532F RID: 21295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600532F")]
		[Address(RVA = "0x1F4E080", Offset = "0x1F4E080", VA = "0x7BBC74E080", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005330")]
		[Address(RVA = "0x1F4E908", Offset = "0x1F4E908", VA = "0x7BBC74E908", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005331 RID: 21297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005331")]
		[Address(RVA = "0x1F4E210", Offset = "0x1F4E210", VA = "0x7BBC74E210")]
		private void SetView(bool claimed = false)
		{
		}

		// Token: 0x06005332 RID: 21298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005332")]
		[Address(RVA = "0x1F4E948", Offset = "0x1F4E948", VA = "0x7BBC74E948")]
		private void SetErrorView()
		{
		}

		// Token: 0x06005333 RID: 21299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005333")]
		[Address(RVA = "0x1F4EA78", Offset = "0x1F4EA78", VA = "0x7BBC74EA78")]
		private void OnBtnClaimClick()
		{
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x00018DF8 File Offset: 0x00016FF8
		[Token(Token = "0x6005334")]
		[Address(RVA = "0x1F4EB2C", Offset = "0x1F4EB2C", VA = "0x7BBC74EB2C", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005335")]
		[Address(RVA = "0x1F4EB70", Offset = "0x1F4EB70", VA = "0x7BBC74EB70", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005336")]
		[Address(RVA = "0x1F4EBEC", Offset = "0x1F4EBEC", VA = "0x7BBC74EBEC")]
		public UISuperFighterPeakDayWndController()
		{
		}

		// Token: 0x040078EA RID: 30954
		[Token(Token = "0x40078EA")]
		[FieldOffset(Offset = "0x98")]
		private UISuperFighterPeakDayWndView m_View;

		// Token: 0x040078EB RID: 30955
		[Token(Token = "0x40078EB")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelBigEvent m_ModelBigEvent;

		// Token: 0x040078EC RID: 30956
		[Token(Token = "0x40078EC")]
		[FieldOffset(Offset = "0xA8")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x040078ED RID: 30957
		[Token(Token = "0x40078ED")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_ActivityId;
	}
}
