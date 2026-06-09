using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020014F9 RID: 5369
	[Token(Token = "0x20014F9")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EDE5C", Offset = "0x10EDE5C")]
	public class UIEPPreOrderAndSubscribedController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x06005C11 RID: 23569 RVA: 0x0001AD90 File Offset: 0x00018F90
		[Token(Token = "0x6005C11")]
		[Address(RVA = "0x1ACC3DC", Offset = "0x1ACC3DC", VA = "0x7BBC2CC3DC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005C12 RID: 23570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C12")]
		[Address(RVA = "0x1ACC42C", Offset = "0x1ACC42C", VA = "0x7BBC2CC42C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005C13 RID: 23571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C13")]
		[Address(RVA = "0x1ACC8F0", Offset = "0x1ACC8F0", VA = "0x7BBC2CC8F0", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005C14 RID: 23572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C14")]
		[Address(RVA = "0x1ACC70C", Offset = "0x1ACC70C", VA = "0x7BBC2CC70C")]
		private void InitUI()
		{
		}

		// Token: 0x06005C15 RID: 23573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C15")]
		[Address(RVA = "0x1ACCE68", Offset = "0x1ACCE68", VA = "0x7BBC2CCE68")]
		private void SetCDN(params object[] data)
		{
		}

		// Token: 0x06005C16 RID: 23574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C16")]
		[Address(RVA = "0x1ACD064", Offset = "0x1ACD064", VA = "0x7BBC2CD064")]
		private void OnClickSubscribeEPBtn()
		{
		}

		// Token: 0x06005C17 RID: 23575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C17")]
		[Address(RVA = "0x1ACD0E0", Offset = "0x1ACD0E0", VA = "0x7BBC2CD0E0")]
		private void OnClickPreorderBtn()
		{
		}

		// Token: 0x06005C18 RID: 23576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C18")]
		[Address(RVA = "0x1ACD15C", Offset = "0x1ACD15C", VA = "0x7BBC2CD15C")]
		private void OnPreorderSuccess(object[] data)
		{
		}

		// Token: 0x06005C19 RID: 23577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C19")]
		[Address(RVA = "0x1ACD160", Offset = "0x1ACD160", VA = "0x7BBC2CD160")]
		private void UpdateSubscriptionBonus()
		{
		}

		// Token: 0x06005C1A RID: 23578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1A")]
		[Address(RVA = "0x1ACCA30", Offset = "0x1ACCA30", VA = "0x7BBC2CCA30")]
		private void SetBtnState()
		{
		}

		// Token: 0x06005C1B RID: 23579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1B")]
		[Address(RVA = "0x1ACD2F4", Offset = "0x1ACD2F4", VA = "0x7BBC2CD2F4", Slot = "40")]
		private void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06005C1C RID: 23580 RVA: 0x0001ADA8 File Offset: 0x00018FA8
		[Token(Token = "0x6005C1C")]
		[Address(RVA = "0x1ACD384", Offset = "0x1ACD384", VA = "0x7BBC2CD384", Slot = "41")]
		private uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06005C1D RID: 23581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1D")]
		[Address(RVA = "0x1ACD3C8", Offset = "0x1ACD3C8", VA = "0x7BBC2CD3C8")]
		public UIEPPreOrderAndSubscribedController()
		{
		}

		// Token: 0x04007E5B RID: 32347
		[Token(Token = "0x4007E5B")]
		[FieldOffset(Offset = "0x98")]
		private UIEPPreOrderAndSubscribedView m_View;

		// Token: 0x04007E5C RID: 32348
		[Token(Token = "0x4007E5C")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelElitePass m_Model;

		// Token: 0x020014FA RID: 5370
		[Token(Token = "0x20014FA")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EDE94", Offset = "0x10EDE94")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06005C1F RID: 23583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005C1F")]
			[Address(RVA = "0x1ACD434", Offset = "0x1ACD434", VA = "0x7BBC2CD434")]
			public <>c()
			{
			}

			// Token: 0x06005C20 RID: 23584 RVA: 0x0001ADC0 File Offset: 0x00018FC0
			[Token(Token = "0x6005C20")]
			[Address(RVA = "0x1ACD43C", Offset = "0x1ACD43C", VA = "0x7BBC2CD43C")]
			internal bool <SetCDN>b__6_0(AdvertDesc x)
			{
				return default(bool);
			}

			// Token: 0x04007E5D RID: 32349
			[Token(Token = "0x4007E5D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIEPPreOrderAndSubscribedController.<>c <>9;

			// Token: 0x04007E5E RID: 32350
			[Token(Token = "0x4007E5E")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<AdvertDesc> <>9__6_0;
		}
	}
}
