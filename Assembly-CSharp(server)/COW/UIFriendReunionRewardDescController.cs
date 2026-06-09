using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020017D4 RID: 6100
	[Token(Token = "0x20017D4")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F2DC4", Offset = "0x10F2DC4")]
	public class UIFriendReunionRewardDescController : UIBaseController
	{
		// Token: 0x06007589 RID: 30089 RVA: 0x00020A18 File Offset: 0x0001EC18
		[Token(Token = "0x6007589")]
		[Address(RVA = "0x159DFE0", Offset = "0x159DFE0", VA = "0x7BBBD9DFE0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600758A RID: 30090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600758A")]
		[Address(RVA = "0x159E030", Offset = "0x159E030", VA = "0x7BBBD9E030", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600758B RID: 30091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600758B")]
		[Address(RVA = "0x159E16C", Offset = "0x159E16C", VA = "0x7BBBD9E16C")]
		public void SetWidth(int width, float alpha)
		{
		}

		// Token: 0x0600758C RID: 30092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600758C")]
		[Address(RVA = "0x159E1F0", Offset = "0x159E1F0", VA = "0x7BBBD9E1F0")]
		public void SetData(ClientActivityDesc desc, ActivityClientInfo info)
		{
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600758D")]
		[Address(RVA = "0x159F0AC", Offset = "0x159F0AC", VA = "0x7BBBD9F0AC")]
		private void OnGetRewardClick()
		{
		}

		// Token: 0x0600758E RID: 30094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600758E")]
		[Address(RVA = "0x159F1E4", Offset = "0x159F1E4", VA = "0x7BBBD9F1E4")]
		private void OnGoToClick()
		{
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600758F")]
		[Address(RVA = "0x159F220", Offset = "0x159F220", VA = "0x7BBBD9F220")]
		private void OnExchangeClick()
		{
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007590")]
		[Address(RVA = "0x159F3BC", Offset = "0x159F3BC", VA = "0x7BBBD9F3BC")]
		private void OnExchangeNoClick()
		{
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007591")]
		[Address(RVA = "0x159F6E4", Offset = "0x159F6E4", VA = "0x7BBBD9F6E4")]
		private void OnBtnOperate()
		{
		}

		// Token: 0x06007592 RID: 30098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007592")]
		[Address(RVA = "0x159E798", Offset = "0x159E798", VA = "0x7BBBD9E798")]
		private void UpdateBtnOperateStatus()
		{
		}

		// Token: 0x06007593 RID: 30099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007593")]
		[Address(RVA = "0x159F7F0", Offset = "0x159F7F0", VA = "0x7BBBD9F7F0")]
		public UIFriendReunionRewardDescController()
		{
		}

		// Token: 0x04008CE3 RID: 36067
		[Token(Token = "0x4008CE3")]
		[FieldOffset(Offset = "0x58")]
		private UIFriendReunionRewardDescView m_View;

		// Token: 0x04008CE4 RID: 36068
		[Token(Token = "0x4008CE4")]
		[FieldOffset(Offset = "0x60")]
		private List<UIStandardItemMiniController> m_List;

		// Token: 0x04008CE5 RID: 36069
		[Token(Token = "0x4008CE5")]
		[FieldOffset(Offset = "0x68")]
		private UIStandardItemMiniController m_ExchangeRewardItem;

		// Token: 0x04008CE6 RID: 36070
		[Token(Token = "0x4008CE6")]
		[FieldOffset(Offset = "0x70")]
		private ClientActivityDesc m_Desc;

		// Token: 0x04008CE7 RID: 36071
		[Token(Token = "0x4008CE7")]
		[FieldOffset(Offset = "0x78")]
		private UIFriendReunionRewardDescController.BtnOperateType m_curOperation;

		// Token: 0x04008CE8 RID: 36072
		[Token(Token = "0x4008CE8")]
		[FieldOffset(Offset = "0x80")]
		private UIModelActivity m_ModelActivity;

		// Token: 0x04008CE9 RID: 36073
		[Token(Token = "0x4008CE9")]
		[FieldOffset(Offset = "0x88")]
		private bool m_ExchangeFinished;

		// Token: 0x04008CEA RID: 36074
		[Token(Token = "0x4008CEA")]
		[FieldOffset(Offset = "0x89")]
		private bool m_ExchangeItemLack;

		// Token: 0x020017D5 RID: 6101
		[Token(Token = "0x20017D5")]
		private enum BtnOperateType
		{
			// Token: 0x04008CEC RID: 36076
			[Token(Token = "0x4008CEC")]
			GoTo,
			// Token: 0x04008CED RID: 36077
			[Token(Token = "0x4008CED")]
			GetReward,
			// Token: 0x04008CEE RID: 36078
			[Token(Token = "0x4008CEE")]
			RewardFinished,
			// Token: 0x04008CEF RID: 36079
			[Token(Token = "0x4008CEF")]
			RewardUnfinish,
			// Token: 0x04008CF0 RID: 36080
			[Token(Token = "0x4008CF0")]
			Exchange,
			// Token: 0x04008CF1 RID: 36081
			[Token(Token = "0x4008CF1")]
			ExchangeNo,
			// Token: 0x04008CF2 RID: 36082
			[Token(Token = "0x4008CF2")]
			ExchangeNoFinished,
			// Token: 0x04008CF3 RID: 36083
			[Token(Token = "0x4008CF3")]
			Forcast,
			// Token: 0x04008CF4 RID: 36084
			[Token(Token = "0x4008CF4")]
			Callback
		}
	}
}
