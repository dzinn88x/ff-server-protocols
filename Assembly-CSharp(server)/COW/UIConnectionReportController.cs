using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001769 RID: 5993
	[Token(Token = "0x2001769")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F202C", Offset = "0x10F202C")]
	public class UIConnectionReportController : UIPopupWindowController, IUIModelDataChangeObserver
	{
		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x0600710A RID: 28938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000935")]
		private UIModelConnectionReport ConnectionModel
		{
			[Token(Token = "0x600710A")]
			[Address(RVA = "0x1816CE8", Offset = "0x1816CE8", VA = "0x7BBC016CE8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600710B RID: 28939 RVA: 0x0001F998 File Offset: 0x0001DB98
		[Token(Token = "0x600710B")]
		[Address(RVA = "0x1816D84", Offset = "0x1816D84", VA = "0x7BBC016D84")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600710C RID: 28940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600710C")]
		[Address(RVA = "0x1816DD4", Offset = "0x1816DD4", VA = "0x7BBC016DD4", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600710D RID: 28941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600710D")]
		[Address(RVA = "0x1816F24", Offset = "0x1816F24", VA = "0x7BBC016F24", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600710E RID: 28942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600710E")]
		[Address(RVA = "0x1816F68", Offset = "0x1816F68", VA = "0x7BBC016F68")]
		public void ShowInfo(string loc_key)
		{
		}

		// Token: 0x0600710F RID: 28943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600710F")]
		[Address(RVA = "0x18171A8", Offset = "0x18171A8", VA = "0x7BBC0171A8")]
		private void OnSendBtnClick()
		{
		}

		// Token: 0x06007110 RID: 28944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007110")]
		[Address(RVA = "0x18170A8", Offset = "0x18170A8", VA = "0x7BBC0170A8")]
		private void RefreshButtonState()
		{
		}

		// Token: 0x06007111 RID: 28945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007111")]
		[Address(RVA = "0x18171F4", Offset = "0x18171F4", VA = "0x7BBC0171F4", Slot = "40")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06007112 RID: 28946 RVA: 0x0001F9B0 File Offset: 0x0001DBB0
		[Token(Token = "0x6007112")]
		[Address(RVA = "0x181726C", Offset = "0x181726C", VA = "0x7BBC01726C", Slot = "41")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06007113 RID: 28947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007113")]
		[Address(RVA = "0x18172B0", Offset = "0x18172B0", VA = "0x7BBC0172B0")]
		public UIConnectionReportController()
		{
		}

		// Token: 0x04008AB7 RID: 35511
		[Token(Token = "0x4008AB7")]
		[FieldOffset(Offset = "0x98")]
		private UIConnectionReportView m_View;

		// Token: 0x04008AB8 RID: 35512
		[Token(Token = "0x4008AB8")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelConnectionReport m_Model;
	}
}
