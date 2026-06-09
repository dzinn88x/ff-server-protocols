using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020013EC RID: 5100
	[Token(Token = "0x20013EC")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EC268", Offset = "0x10EC268")]
	public class UIActivityExchangeItemController : UIBaseController
	{
		// Token: 0x060053D9 RID: 21465 RVA: 0x00019098 File Offset: 0x00017298
		[Token(Token = "0x60053D9")]
		[Address(RVA = "0x194EAC0", Offset = "0x194EAC0", VA = "0x7BBC14EAC0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x000190B0 File Offset: 0x000172B0
		[Token(Token = "0x60053DA")]
		[Address(RVA = "0x194EB10", Offset = "0x194EB10", VA = "0x7BBC14EB10")]
		public static ResourceID GetVFXResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DB")]
		[Address(RVA = "0x194EB60", Offset = "0x194EB60", VA = "0x7BBC14EB60", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053DC")]
		[Address(RVA = "0x194ECD4", Offset = "0x194ECD4", VA = "0x7BBC14ECD4", Slot = "28")]
		protected virtual object CreateView()
		{
			return null;
		}

		// Token: 0x060053DD RID: 21469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DD")]
		[Address(RVA = "0x194ED24", Offset = "0x194ED24", VA = "0x7BBC14ED24")]
		public void SetData(ClientActivityDesc desc)
		{
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DE")]
		[Address(RVA = "0x194EE50", Offset = "0x194EE50", VA = "0x7BBC14EE50")]
		private void SetOperateButtonUI()
		{
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DF")]
		[Address(RVA = "0x19500B4", Offset = "0x19500B4", VA = "0x7BBC1500B4")]
		private void OnRedTipsOnOffClicked()
		{
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E0")]
		[Address(RVA = "0x194F8E8", Offset = "0x194F8E8", VA = "0x7BBC14F8E8")]
		private void CreateConsumeItems()
		{
		}

		// Token: 0x060053E1 RID: 21473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E1")]
		[Address(RVA = "0x194FD34", Offset = "0x194FD34", VA = "0x7BBC14FD34")]
		private void CreateAwardItems(List<AwardDesc> awards)
		{
		}

		// Token: 0x060053E2 RID: 21474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E2")]
		[Address(RVA = "0x195037C", Offset = "0x195037C", VA = "0x7BBC15037C")]
		private void OnOperate()
		{
		}

		// Token: 0x060053E3 RID: 21475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E3")]
		[Address(RVA = "0x195087C", Offset = "0x195087C", VA = "0x7BBC15087C")]
		public void Reload()
		{
		}

		// Token: 0x060053E4 RID: 21476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E4")]
		[Address(RVA = "0x1950228", Offset = "0x1950228", VA = "0x7BBC150228")]
		public string CalcCount(BaseItemInfo data)
		{
			return null;
		}

		// Token: 0x060053E5 RID: 21477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E5")]
		[Address(RVA = "0x1950A14", Offset = "0x1950A14", VA = "0x7BBC150A14")]
		public void SetItemWidgetWidth(int width)
		{
		}

		// Token: 0x060053E6 RID: 21478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E6")]
		[Address(RVA = "0x1950A5C", Offset = "0x1950A5C", VA = "0x7BBC150A5C")]
		public UIActivityExchangeItemController()
		{
		}

		// Token: 0x060053E7 RID: 21479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053E7")]
		[Address(RVA = "0x1950AE4", Offset = "0x1950AE4", VA = "0x7BBC150AE4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113E604", Offset = "0x113E604")]
		private void <OnOperate>b__17_0()
		{
		}

		// Token: 0x04007960 RID: 31072
		[Token(Token = "0x4007960")]
		[FieldOffset(Offset = "0x58")]
		private List<UIStandardItemMiniController> m_ConsumeItemUIs;

		// Token: 0x04007961 RID: 31073
		[Token(Token = "0x4007961")]
		[FieldOffset(Offset = "0x60")]
		private UIActivityExchangeItemView m_View;

		// Token: 0x04007962 RID: 31074
		[Token(Token = "0x4007962")]
		[FieldOffset(Offset = "0x68")]
		private string UNLIMITED_STRING;

		// Token: 0x04007963 RID: 31075
		[Token(Token = "0x4007963")]
		[FieldOffset(Offset = "0x70")]
		public int dragThresholdNum;

		// Token: 0x04007964 RID: 31076
		[Token(Token = "0x4007964")]
		[FieldOffset(Offset = "0x74")]
		private UIActivityExchangeItemController.OperateStatus m_OperateStatus;

		// Token: 0x04007965 RID: 31077
		[Token(Token = "0x4007965")]
		[FieldOffset(Offset = "0x78")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x04007966 RID: 31078
		[Token(Token = "0x4007966")]
		[FieldOffset(Offset = "0x80")]
		private ClientActivityDesc m_Desc;

		// Token: 0x020013ED RID: 5101
		[Token(Token = "0x20013ED")]
		private enum OperateStatus
		{
			// Token: 0x04007968 RID: 31080
			[Token(Token = "0x4007968")]
			None,
			// Token: 0x04007969 RID: 31081
			[Token(Token = "0x4007969")]
			Exchange,
			// Token: 0x0400796A RID: 31082
			[Token(Token = "0x400796A")]
			ExchangeNo,
			// Token: 0x0400796B RID: 31083
			[Token(Token = "0x400796B")]
			ExchangeFinished
		}
	}
}
